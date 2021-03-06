/*MIT License

Copyright (c) 2021 Silvan Zünd

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace InterferenzmusterSimulation
{
    class Model
    {
        /// <summary>
        /// Weglänge der Welle 1 in X-Y Fläche
        /// </summary>
        private double myD1;
        /// <summary>
        /// Relativer Wegunterschied zu d1 in X-Y Fläche
        /// </summary>
        private double myD2;
        /// <summary>
        /// Relative Längenänderung auf der Bildebene pro Pixel in der Bitmap
        /// </summary>
        private double myRelativePerPixel;
        /// <summary>
        /// In der Mitte der Bildebene befindet sich die Funktionskoordinate O(0/0).
        /// Die Variable bezeichnet die x-Koordinate am linken Rand der Bildebene
        /// </summary>
        private double myXmin;
        private double myXmax;
        private double myYmin;
        private double myYmax;
        /// <summary>
        /// Breite der Zeichenfläche in Pixel
        /// </summary>
        private int myBitmapWidth;
        /// <summary>
        /// Höhe der Zeichenfläche in Pixel
        /// </summary>
        private int myBitmapHeight;
        /// <summary>
        /// Radius des Lasers in Metern
        /// </summary>
        private double myLaserDurchmesser;
        private View myView;
        private double myRenderGenauigkeit; // Genauigkeit

        const decimal myWellenlänge = 632.8E-9m;
        const double k = 2 * Math.PI / (double)myWellenlänge; // Wellenvektor
        public Model(double d1, double d2, double xmax, int width, int height, double LaserDurchmesser, double RenderGenauigkeit, Button RenderButton)
        {
            myD1 = d1 * 1E-3;
            myD2 = d2 * 1E-6;
            myXmax = xmax * 1E-3;
            myXmin = -myXmax;
            myYmax = myXmax;
            myYmin = -myXmax;
            myBitmapWidth = width;
            myBitmapHeight = height;
            myLaserDurchmesser = LaserDurchmesser * 1E-3;
            myRenderGenauigkeit = RenderGenauigkeit;

            myView = new View(this, RenderButton);

            newRelativePerPixel();
        }

        public void notifyView()
        {
            if (myView != null)
            {
                new Thread(myView.DrawInterferencePatternWithThreading).Start();
            }
        }

        private void newRelativePerPixel()
        {
            //Transform to map the graph bounds to the Bitmap.
            RectangleF rect = new RectangleF(
                (float)myXmin, (float)myYmin, (float)(myXmax - myXmin), (float)(myYmax - myYmin));

            //upper-left, upper-right, and lower-left corners
            PointF[] pts =
            {
                new PointF(0, 0),
                new PointF(myBitmapWidth, 0),
                new PointF(0, myBitmapHeight),
            };

            Matrix inverse = new Matrix(rect, pts);
            inverse.Invert();
            PointF[] pixel_pts =
            {
                    new PointF(0, 0),
                    new PointF(1, 0)
            };
            inverse.TransformPoints(pixel_pts);
            myRelativePerPixel = pixel_pts[1].X - pixel_pts[0].X;

            inverse.Dispose();
        }

        /// <summary>
        /// Berechnung des Interferenzmusters an einem Punkt
        /// </summary>
        /// <param name="Rx">Abstand zum Mittelpunkt des Interferenzmusters auf der Bildebene in X-Richtung</param>
        /// <param name="Hx">Abstand zum Laser-Mittelpunktin X-Richtung</param>
        /// <param name="Hz">Abstand zum Laser-Mittelpunktin in Z-Richtung</param>
        /// <returns>Normierte Superposition zwischen 0 und 1</returns>
        public double InterferenzFunktion(double Rx, double Hx = 0, double Hz = 0)
        {
            double l1 = Math.Sqrt(Math.Pow(myD1, 2) + Math.Pow(Rx - Hx, 2) + Math.Pow(Hz, 2)); // Distanz, welche die erste Welle zurücklegt
            double l2 = Math.Sqrt(Math.Pow(myD1 + myD2, 2) + Math.Pow(Rx - Hx, 2) + Math.Pow(Hz, 2)); // Distanz, welche die zweite Welle zurücklegt

            double Intensität = Math.Cos((l1 - l2) * k) + 1;

            return Intensität / 2; // Teilen durch Maximalwert, um Gradienten zwischen 0 und 1 zu erhalten
        }

        /// <summary>
        /// Durchschnittsberechnung unter Berücksichtigung der Lasergrösse
        /// </summary>
        /// <param name="x">Position auf der Bildeben in X-Richtung</param>
        /// <returns></returns>
        public double InterferenzFunktionLaserGrösse(double x)
        {
            double sum = 0;
            double p = 0;
            double LaserRadius = myLaserDurchmesser / 2;
            double LaserDistancePerCount = myLaserDurchmesser / myRenderGenauigkeit;

            for (double i = -LaserRadius; i <= LaserRadius; i += LaserDistancePerCount)
            {
                for (double j = -LaserRadius; j <= LaserRadius; j += LaserDistancePerCount)
                {
                    if (Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2)) <= LaserRadius)
                    {
                        sum += InterferenzFunktion(x, j, i);
                        p++;
                    }
                }
            }
            sum /= p;
            return sum;
        }

        #region Accessor-Properties
        public View ModelView
        {
            get { return myView; }
        }
        public int Height
        {
            get { return myBitmapHeight; }
        }

        public int Width
        {
            get { return myBitmapWidth; }
        }

        public double relativePerPixel
        {
            get { return myRelativePerPixel; }
        }

        public double d1
        {
            get { return myD1; }
            set { myD1 = value * 1E-3; } // Millimeter zu Meter
        }

        public double d2
        {
            get { return myD2; }
            set { myD2 = value * 1E-6; } // Mikrometer zu Meter
        }

        public double LaserDurchmesser
        {
            set { myLaserDurchmesser = value * 1E-3; } // Millimeter zu Meter
        }

        public double xmax
        {
            set
            {
                myXmax = value * 1E-3; // Millimeter zu Meter
                myXmin = -myXmax;
                myYmax = myXmax;
                myYmin = -myXmax;
                newRelativePerPixel();
            }
        }
        public static decimal Wellenlänge
        {
            get { return myWellenlänge; }
        }

        public double RenderGenauigkeit
        {
            get { return myRenderGenauigkeit; }
            set { myRenderGenauigkeit = value; }
        }
        #endregion
    }
}
