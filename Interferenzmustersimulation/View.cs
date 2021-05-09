using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MatrixTest
{
    class View
    {
        /// <summary>
        /// Bitmap-Objekt, in welches das Interferenzmuster gezeichnet wird.
        /// </summary>
        private Bitmap myBild;
        private Model myModel;
        private Form myForm;

        public View(Model model)
        {
            myModel = model;
            myBild = new Bitmap(myModel.Width, myModel.Height);
            myForm = Form.ActiveForm;
        }

        public void DrawInterferencePattern()
        {
            Graphics g = Graphics.FromImage(myBild);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.Black);

            for (int i = -myModel.Width / 2; i <= 0; i++)
            {
                double x = i * myModel.relativePerPixel;
                double intensity = myModel.InterferenzFunktionLaserGrösse(x);
                double size = 2 * -i;
                Color IntensityColor = Color.FromArgb((int)Math.Round(255 * intensity, 0), 0, 0);
                Brush IntensityBrush = new SolidBrush(IntensityColor);
                g.FillEllipse(IntensityBrush, i + myModel.Width / 2, myModel.Height / 2 + i, (float)size, (float)size);
            }
            g.Dispose();
            myForm.Invalidate();
        }

        public Bitmap ModelViewImage
        {
            get { return myBild; }
        }
    }
}
