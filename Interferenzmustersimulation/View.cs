using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
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
        private List<Thread> myWorkerList = new List<Thread>();

        public View(Model model)
        {
            myModel = model;
            myBild = new Bitmap(myModel.Width, myModel.Height);
            myForm = Form.ActiveForm;

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                myWorkerList.Add(null);
            }
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
                Color IntensityColor = Color.FromArgb(Convert.ToInt32(255 * intensity), 0, 0);
                Brush IntensityBrush = new SolidBrush(IntensityColor);
                double size = 2 * -i;
                g.FillEllipse(IntensityBrush, i + myModel.Width / 2, myModel.Height / 2 + i, (float)size, (float)size);
            }

            g.Dispose();
            myForm.Invalidate();
        }

        public void DrawInterferencePatternWithThreading()
        {
            int i = -myModel.Width / 2;

            Brush[] myIntensityBrushesArray = new Brush[-i + 1];

            while(i <= 0)
            {
                for (int q = 0; q < myWorkerList.Count; q++)
                {
                    if ((myWorkerList[q] == null || !myWorkerList[q].IsAlive) && i <= 0)
                    {
                        myWorkerList[q] = new Thread(ThreadWorker);

                        myWorkerList[q].Start(i);
                        i++;
                    }
                }
            }

            void ThreadWorker(object input)
            {
                int myi = (int)input;

                double x = myi * myModel.relativePerPixel;
                double intensity = myModel.InterferenzFunktionLaserGrösse(x);
                Color IntensityColor = Color.FromArgb(Convert.ToInt32(255 * intensity), 0, 0);
                myIntensityBrushesArray[-myi] = new SolidBrush(IntensityColor);

                return;
            }

            bool allThreadsfinished;
            do
            {
                allThreadsfinished = true;
                for (int q = 0; q < myWorkerList.Count; q++)
                {
                    if (myWorkerList[q] != null && myWorkerList[q].IsAlive)
                    {
                        allThreadsfinished = false;
                    }
                }
            }
            while (!allThreadsfinished);

            Graphics g = Graphics.FromImage(myBild);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.Black);


            for (int a = myIntensityBrushesArray.Length - 1; a >= 0; a--)
            {
                double size = 2 * -a;
                g.FillEllipse(myIntensityBrushesArray[a], a + myModel.Width / 2, myModel.Height / 2 + a, (float)size, (float)size);
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
