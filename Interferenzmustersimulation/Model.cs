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
        double myRenderGenauigkeit; //Genauigkeit

        static decimal myWellenlänge = 632.8E-9m;
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
                myView.DrawInterferencePattern();
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
        public double InterferenzFunktion(double x, double hx = 0, double hy = 0)
        {
            double k = 2 * Math.PI / (double)myWellenlänge; //Wellenvektor
            double phi1 = 0; //Phasenverschiebung Welle 1
            double phi2 = 0; //Phasenverschiebund Welle 2
            double l1 = Math.Sqrt(Math.Pow(myD1, 2) + Math.Pow(x - hx, 2) + Math.Pow(hy, 2)); //Distanz, welche die erste Welle zurücklegt
            double l2 = Math.Sqrt(Math.Pow(myD1 + myD2, 2) + Math.Pow(x - hx, 2) + Math.Pow(hy, 2)); //Distanz, welche die zweite Welle zurücklegt

            double psi1 = k * l1 + phi1;
            double psi2 = k * l2 + phi2;
            double Xc = Math.Cos(psi1) + Math.Cos(psi2);
            double Xs = Math.Sin(psi1) + Math.Sin(psi2);

            double Intensität = Math.Max(Math.Pow(Xc, 2) + Math.Pow(Xs, 2), 0);

            return Intensität / 4;
        }

        /// <summary>
        /// Durchschnittsberechnung unter Berücksichtigung der Lasergrösse
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double InterferenzFunktionLaserGrösse(double x)
        {
            double count = 100.0; //Genauigkeit
            double sum = 0;
            double p = 0;
            double LaserRadiusPerCount = myLaserDurchmesser * 2 / count;

            for (double i = -myLaserDurchmesser; i <= myLaserDurchmesser; i += LaserRadiusPerCount)
            {
                for (double j = -myLaserDurchmesser; j <= myLaserDurchmesser; j += LaserRadiusPerCount)
                {
                    if (Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2)) <= myLaserDurchmesser)
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
            set { myD1 = value * 1E-3; } // Millimeter zu Meter
        }

        public double d2
        {
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
