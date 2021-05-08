using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
        private double myLaserRadius;
        private View myView;

        static decimal myWellenlänge = 632.8E-9m;
        public Model(double d1, double d2, double xmax, int width, int height, double LaserRadius)
        {
            myD1 = d1 * 1E-3;
            myD2 = d2 * 1E-6;         
            myXmax = xmax * 1E-3;
            myXmin = -myXmax;
            myYmax = myXmax;
            myYmin = -myXmax;
            myBitmapWidth = width;
            myBitmapHeight = height;
            myLaserRadius = LaserRadius;

            newRelativePerPixel();
        }

        public void notifyView()
        {
            if (myView != null)
            {
                myView.DrawInterferencePattern();
            }
        }

        public View ModelView
        {
            get { return myView; }
            set { myView = value; /*this.notifyView();*/ }
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
            //this.notifyView();
            inverse.Dispose();
        }

        /// <summary>
        /// Funktion, die Zeit wird als globale Variable verwendet
        /// </summary>
        /// <param name="x">Die Variable bezeichnet den Abstand zum Mittelpunkt des Interferenzmusters auf dem optischen Schirm</param>
        /// <param name="hx">Die Variable bezeichnet den Abstand zum Mittelpunkt des Lasers in X-Richtung</param>
        /// <param name="hy">Die Variable bezeichnet den Abstand zum Mittelpunkt des Lasers in Y-Richtung</param>
        /// <returns>Normierte Superposition zwischen 0 und 1</returns>
        public double InterferenzFunktion(double x, double hx=0, double hy=0)
        {
            //Debug.WriteLine(String.Format("{0}, {1}, {2}", x, hx, hy));
            double k = 2 * Math.PI / (double)myWellenlänge; //Wellenvektor
            /*double omega = k * 299792458; //Winkelgeschwidigket*/
            double yHat1 = 1; //Amplitude Welle 1
            double yHat2 = 1; //Amplitude Welle 2
            double phi1 = 0; //Phasenverschiebung Welle 1
            double phi2 = 0; //Phasenverschiebund Welle 2
            double l1 = Math.Sqrt(Math.Pow(myD1, 2) + Math.Pow(x-hx, 2) + Math.Pow(hy, 2)); //Distanz, welche die erste Welle zurücklegt
            double l2 = Math.Sqrt(Math.Pow(myD1 + myD2, 2) + Math.Pow(x-hx, 2) + Math.Pow(hy, 2)); //Distanz, welche die zweite Welle zurücklegt

            double psi1 = k * l1 + phi1;
            double psi2 = k * l2 + phi2;

            double Intensität = Math.Max(yHat1 * yHat2 * (Math.Pow(Math.Cos(psi1), 2) + 2 * Math.Cos(psi1) * Math.Cos(psi2) + Math.Pow(Math.Cos(psi2), 2) +
                Math.Pow(Math.Sin(psi1), 2) + 2 * Math.Sin(psi1) * Math.Sin(psi2) + Math.Pow(Math.Sin(psi2), 2)), 0);

            return Intensität / 4;
        }

        /// <summary>
        /// Durchschnittsberechnung unter Berücksichtigung der Lasergrösse, momentan noch nicht verwendet
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double InterferenzFunktionLaserGrösse(double x)
        {
            double count = 100.0; //Genauigkeit
            double sum = 0;
            double p = 0;
            double LaserRadiusPerCount = myLaserRadius / count;
            double RadPerCount = 2 * Math.PI / count;
            double previousX = double.NaN;
            double previousY = double.NaN;

            for (double i = 0; i < count; i++)
            {
                double AbsLength = LaserRadiusPerCount * i;
                for (double j = 0; j <= count; j++)
                {
                    double hx = AbsLength * Math.Cos(RadPerCount * j);
                    double hy = AbsLength * Math.Sin(RadPerCount * j);
                    if (previousX != hx && previousY != hy)
                    {
                        previousX = hx;
                        previousY = hy;
                        sum += InterferenzFunktion(x, hx, hy);
                        p++;
                    }
                }
            }
            sum /= p;
            return sum;
        }

        public double InterferenzFunktionLaserGrösse2(double x)
        {
            double count = 1000.0; //Genauigkeit
            double sum = 0;
            double p = 0;
            double LaserRadiusPerCount = myLaserRadius * 2 / count;

            for (double i = -myLaserRadius; i <= myLaserRadius; i+= LaserRadiusPerCount)
            {
                for (double j = -myLaserRadius; j <= myLaserRadius; j += LaserRadiusPerCount)
                {
                    if (Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2)) <= myLaserRadius)
                    {
                        sum += InterferenzFunktion(x, j, i);
                        p++;
                    }
                }
            }
            sum /= p;
            return sum;
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
            set { myD1 = value * 1E-3; /*this.notifyView();*/ } // Millimeter zu Meter
        }

        public double d2
        {
            set { myD2 = value * 1E-6; /*this.notifyView();*/ } // Mikrometer zu Meter
        }

        public double LaserRadius
        {
            set { myLaserRadius = value; /*this.notifyView();*/ }
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
        static public decimal Wellenlänge
        {
            get
            {
                return myWellenlänge;
            }
        }
    }
}
