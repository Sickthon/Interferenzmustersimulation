﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace InterferenzmusterSimulation
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
        private bool myRenderingFinished = true;

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

        public void DrawInterferencePatternWithThreading()
        {
            myRenderingFinished = false;
            int i = -myModel.Width / 2;

            Brush[] myIntensityBrushesArray = new Brush[-i + 1];

            int range = myModel.Width / 2 / myWorkerList.Count;

            int FinishCalls = 0;
            int ThreadCalls = 0;

            while (i <= 0)
            {
                for (int q = 0; q < myWorkerList.Count; q++)
                {
                    if ((myWorkerList[q] == null || !myWorkerList[q].IsAlive) && i <= 0)
                    {
                        myWorkerList[q] = new Thread(ThreadWorker);

                        myWorkerList[q].Start(i);
                        i += range;
                        ThreadCalls++;
                    }
                }
            }

            void ThreadWorker(object input)
            {
                int myi = (int)input;
                int limit = myi + range;

                for (int myj = myi; myj < limit && myj <= 0; myj++)
                {
                    double x = myj * myModel.relativePerPixel;
                    double intensity = myModel.InterferenzFunktionLaserGrösse(x);
                    Color IntensityColor = Color.FromArgb(Convert.ToInt32(255 * intensity), 0, 0);
                    myIntensityBrushesArray[-myj] = new SolidBrush(IntensityColor);
                }
                Finish();
                return;
            }

            void Finish()
            {
                FinishCalls++;

                if (FinishCalls == ThreadCalls)
                {
                    Graphics g = Graphics.FromImage(myBild);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.Clear(Color.Black);


                    for (int a = myIntensityBrushesArray.Length - 1; a >= 0; a--)
                    {
                        double size = 2 * -a;
                        g.FillEllipse(myIntensityBrushesArray[a], a + myModel.Width / 2, myModel.Height / 2 + a, (float)size, (float)size);
                    }

                    g.Dispose();
                    myRenderingFinished = true;
                    myForm.Invalidate();
                }
            }
        }

        public Bitmap ModelViewImage
        {
            get { return myBild; }
        }

        public bool RenderingFinished
        {
            get { return myRenderingFinished; }
        }
    }
}
