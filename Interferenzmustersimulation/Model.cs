using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MatrixTest
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
        /// Relative Längenänderung auf dem "Fotowiderstand" pro Pixel in der Bitmap
        /// </summary>
        private double myRelativePerPixel;
        /// <summary>
        /// In der Mitte des Fotowiderstandes befindet sich die Funktionskoordinate O(0/0).
        /// Die Variable bezeichnet die x-Koordinate am linken Rand des Fotowiderstandes
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
        private double myRenderGenauigkeit; //Genauigkeit

        const decimal myWellenlänge = 632.8E-9m;
        const double k = 2 * Math.PI / (double)myWellenlänge; //Wellenvektor
        public Model(double d1, double d2, double xmax, int width, int height, double LaserDurchmesser, double RenderGenauigkeit)
        {
            myD1 = d1 * 1E-3;
            myD2 = d2 * 1E-6;
            myXmax = xmax * 1E-3;
            myXmin = -myXmax;
            myYmax = myXmax;
            myYmin = -myXmax;
            myBitmapWidth = width;
            myBitmapHeight = height;
            myLaserDurchmesser = LaserDurchmesser;
            myRenderGenauigkeit = RenderGenauigkeit;

            newRelativePerPixel();


        }

        public void notifyView()
        {
            if (myView != null)
            {
                if (myRenderGenauigkeit < 320)
                {
                    myView.DrawInterferencePattern();
                }
                else
                {
                    myView.DrawInterferencePatternWithThreading();
                }
            }
        }

        private void newRelativePerPixel()
        {
            //Transform to map the graph bounds to the Bitmap.
            RectangleF rect = new RectangleF(
                (float)myXmin, (float)myXmax, (float)(myXmax - myXmin), (float)(myYmax - myYmin));

            //upper-left, upper-right, and lower-left corners
            PointF[] pts =
            {
                new PointF(0, myBitmapHeight),
                new PointF(myBitmapWidth, myBitmapHeight),
                new PointF(0, 0),
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
            myRelativePerPixel /= 2;

            inverse.Dispose();
        }

        /// <summary>
        /// Funktion, die Zeit wird als globale Variable verwendet
        /// </summary>
        /// <param name="r">Die Variable bezeichnet den Abstand zum Mittelpunkt des Interferenzmusters auf der Bildebene in Z-Richtung</param>
        /// <param name="hz">Die Variable bezeichnet den Abstand zum Mittelpunkt des Lasers in Z-Richtung</param>
        /// <param name="hx">Die Variable bezeichnet den Abstand zum Mittelpunkt des Lasers in X-Richtung</param>
        /// <returns>Normierte Superposition zwischen 0 und 1</returns>
        public double InterferenzFunktion(double r, double hz = 0, double hx = 0)
        {
            double l1 = Math.Sqrt(Math.Pow(myD1, 2) + Math.Pow(r - hz, 2) + Math.Pow(hx, 2)); //Distanz, welche die erste Welle zurücklegt
            double l2 = Math.Sqrt(Math.Pow(myD1 + myD2, 2) + Math.Pow(r - hz, 2) + Math.Pow(hx, 2)); //Distanz, welche die zweite Welle zurücklegt

            double Intensität = 2 * Math.Cos((l1 - l2) * k) + 2;

            return Intensität / 4; //Teilen durch Maximalwert, um Gradient zwischen 0 und 1 zu erhalten
        }

        /// <summary>
        /// Durchschnittsberechnung unter Berücksichtigung der Lasergrösse
        /// </summary>
        /// <param name="x"></param>
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
            set { myView = value; }
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

        public double LaserRadius
        {
            set { myLaserDurchmesser = value; }
        }

        public double xmax
        {
            set
            {
                myXmax = value * 1E-3; //Millimeter zu Meter
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
