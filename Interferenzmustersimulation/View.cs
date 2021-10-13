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
        private Button myFormRenderButton;

        public View(Model model, Button RenderButton)
        {
            myModel = model;
            myBild = new Bitmap(myModel.Width, myModel.Height);
            myForm = Form.ActiveForm;
            myFormRenderButton = RenderButton;

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                myWorkerList.Add(null);
            }
        }

        public void DrawInterferencePatternWithThreading()
        {
            myFormRenderButton.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                myFormRenderButton.Visible = false;
            });

            int Position = -myModel.Width / 2;

            Brush[] myIntensityBrushesArray = new Brush[-Position + 1];

            int range = myModel.Width / 2 / myWorkerList.Count;

            while (Position <= 0)
            {
                for (int q = 0; q < myWorkerList.Count; q++)
                {
                    if ((myWorkerList[q] == null || !myWorkerList[q].IsAlive) && Position <= 0)
                    {
                        myWorkerList[q] = new Thread(ThreadWorker);

                        myWorkerList[q].Start(Position);
                        Position += range;
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

                CheckForFinish();
                return;
            }

            void CheckForFinish()
            {
                int ActiveThreadsCount = 0;
                for (int q = 0; q < myWorkerList.Count; q++)
                {
                    if (myWorkerList[q].IsAlive) { ActiveThreadsCount++; }
                }

                if(ActiveThreadsCount == 1 && Position > 0)
                { Finish(); }
            }

            void Finish()
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
                
                myFormRenderButton.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    myFormRenderButton.Visible = true;
                    (myForm as Interferenzmustersimulation).ChacheNewRendering();
                });

                myForm.Invalidate();
            }
        }

        public Bitmap ModelViewImage
        {
            get { return myBild; }
        }
    }
}
