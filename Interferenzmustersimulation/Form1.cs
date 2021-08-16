using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MatrixTest
{
    /* Erläuterung Stand 31.03.2021:
     * Das Programm ist in das Hauptprogramm und in zwei Klassen aufgeteilt. 
     * Das Hauptprogramm steht in direktem Kontakt zum Fenster und gibt die Daten an die Model-Klasse weiter.
     * Die Model-Klasse benachrichtigt die View-Klasse, welche das Interferenzmuster mithilfe der Funktion der Model-Klasse rendert und einer Bitmap abspeichert.
     * Aufgrund der Symmetrie des Interferenzmusters wird nur eine Gerade von xmin zum Ursprung gerendert und die erhaltenen Farben als Kreise dargestellt.
     * Mit einem Aufruf des Paint-Ereignisses des Fensters im Hauptprogramm wird diese Bitmap im Fenster gezeichnet.
     * 
     * 26.04.2021:
     * Es wird nun nur noch die quadrierte Amplitude zur Berechnung des Interferenzmusters verwendet.
     * Des Weiteren lässt sich nun die Grösse des Laserstrahls miteinberechnen. Um alle Punkte im Laserstrahl gleich zu gewichten, 
     * wird über den kreisförmigen Laserquerschnitt ein kartesisches Koordinatensystem gelegt und diejenigen Punkte verwendet, die sich innerhalb des Kreises befinden.
     * Neu hinzugekommen ist das Eingabefeld "R.-L.-Veränderung", mit welchem sich steuern lässt, wie stark sich der relative Längenunterschied be einem Klick verändert.
     * In diesem Feld lassen sich einfache arithmetische Operationen durchführen. Der Bequemlichkeit halber wird eine Operation sofort ausgeführt, wenn dies möglich ist.
     * Dies bedeutet, dass bei einer versuchten Divison durch 15 direkt durch 1 dividiert wird. Die dürfte wenig stören, da die Idee dahinter ist, bequem auf beispielsweise die halbe Wellenlänge zu kommen.
     */
    public partial class Interferenzmustersimulation : Form
    {
        Model InterferencePatternModel;
        public Interferenzmustersimulation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBarPanel.Left = ClientSize.Width - ControlBarPanel.Width;
            double length = (double)InterferenzmustergrösseUpDown2.Value / 2.0;
            int BitmapHeight = ClientSize.Height;
            InterferencePatternModel = new Model((double)Länge1UpDown.Value, (double)Länge2RelativUpDown.Value,
                length, BitmapHeight, BitmapHeight, (double)LaserDurchmesserUpDown3.Value / 2.0, (double)RendergenauigkeitUpDown.Value);
            InterferencePatternModel.ModelView = new View(InterferencePatternModel);
            RLVeränderung.Text = Länge2RelativUpDown.Increment.ToString();
        }
        private void RenderButton_Click(object sender, EventArgs e)
        {
            InterferencePatternModel.notifyView();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (InterferencePatternModel != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Bitmap ImageOutput = InterferencePatternModel.ModelView.ModelViewImage;
                g.DrawImage(ImageOutput, new Point((ClientSize.Width - ImageOutput.Width) / 2, 0));
            }
        }

        #region UpDowns
        private void Länge1UpDown_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.d1 = (double)Länge1UpDown.Value;
        }

        private void Länge2RelativUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (InterferencePatternModel.d1 + (double)Länge2RelativUpDown.Value * 1E-6 >= 0)
            {
                InterferencePatternModel.d2 = (double)Länge2RelativUpDown.Value;
            }
            else
            {
                Länge2RelativUpDown.Value = (decimal)(InterferencePatternModel.d2 * 1E6);
                MessageBox.Show("Der zweite Arm kann keine negative Länge besitzen, da dies einerseits keinen Sinn ergibt " +
                    "und andererseits erhielte man ein falsches Interferenzmuster, schliesslich werden die Zahlen für die Berechnung quadriert. " +
                    "Diese Erkenntnis kostete mich übrigens den letzten Nachmittag meiner Sommerferien.");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.xmax = (double)InterferenzmustergrösseUpDown2.Value / 2.0;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.LaserRadius = (double)LaserDurchmesserUpDown3.Value / 2.0;
        }

        private void toWavelengthButton_Click(object sender, EventArgs e)
        {
            Länge2RelativUpDown.Increment = Model.Wellenlänge * 1E6m;
            RLVeränderung.Text = Convert.ToString(Länge2RelativUpDown.Increment);
        }

        private void RendergenauigkeitUpDown_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.RenderGenauigkeit = (double)RendergenauigkeitUpDown.Value;
        }
        private void RLVeränderung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void RLVeränderung_TextChanged(object sender, EventArgs e)
        {
            decimal result;
            string textBoxText = RLVeränderung.Text;
            try
            {
                int lastChar = Convert.ToInt32(textBoxText[textBoxText.Length - 1]);
                if (48 <= lastChar && lastChar <= 57)
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    result = (decimal)table.Compute(textBoxText, "");
                    Länge2RelativUpDown.Increment = result;
                    RLVeränderung.Text = Convert.ToString(result);
                }
            }
            catch 
            {
                decimal.TryParse(textBoxText, out result);
                Länge2RelativUpDown.Increment = result;
                RLVeränderung.Text = Convert.ToString(result);
            }
        }
        #endregion

        #region ControlBar
        private void FormCloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormCloseLabel_MouseDown(object sender, MouseEventArgs e)
        {
            FormCloseLabel.ForeColor = Color.White;
            FormCloseLabel.BackColor = Color.Red;
        }
        private void FormCloseLabel_MouseEnter(object sender, EventArgs e)
        {
            FormCloseLabel.ForeColor = Color.Red;
            FormCloseLabel.BackColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void FormCloseLabel_MouseLeave(object sender, EventArgs e)
        {
            FormCloseLabel.ForeColor = Color.White;
            FormCloseLabel.BackColor = Color.Transparent;
        }
        private void FormMinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FormMinimizeLabel_MouseDown(object sender, MouseEventArgs e)
        {
            FormMinimizeLabel.BackColor = Color.DodgerBlue;
        }

        private void FormMinimizeLabel_MouseEnter(object sender, EventArgs e)
        {
            FormMinimizeLabel.BackColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void FormMinimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            FormMinimizeLabel.BackColor = Color.Transparent;
        }
        private void FormHelpLabel_Click(object sender, EventArgs e)
        {
            toolTip1.Active = !toolTip1.Active;
            if (toolTip1.Active)
            {
                Font LabelFont = FormHelpLabel.Font;
                FormHelpLabel.Font = new Font(LabelFont.Name, LabelFont.Size, FontStyle.Strikeout);
            }
            else
            {
                Font LabelFont = FormHelpLabel.Font;
                FormHelpLabel.Font = new Font(LabelFont.Name, LabelFont.Size, FontStyle.Regular);
            }
        }
        private void FormHelpLabel_MouseDown(object sender, MouseEventArgs e)
        {
            FormHelpLabel.BackColor = Color.DarkOliveGreen;
        }

        private void FormHelpLabel_MouseEnter(object sender, EventArgs e)
        {
            FormHelpLabel.BackColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void FormHelpLabel_MouseLeave(object sender, EventArgs e)
        {
            FormHelpLabel.BackColor = Color.Transparent;
        }
        #endregion

        #region ControlPanel
        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ControlPanel.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        bool MoveControlmouseDown;
        int ControlMouseDownX;
        int ControlMouseDownY;
        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveControlmouseDown = true;
            ControlMouseDownX = e.X;
            ControlMouseDownY = e.Y;
        }

        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveControlmouseDown)
            {
                int newX = ControlPanel.Left + (e.X - ControlMouseDownX);
                int newY = ControlPanel.Top + (e.Y - ControlMouseDownY);

                if(newX < 0)
                { 
                    newX = 0;
                }
                else if (newX + ControlPanel.Width > ClientSize.Width)
                {
                    newX = ClientSize.Width - ControlPanel.Width;
                }
                if (newY < 0)
                {
                    newY = 0;
                }
                else if(newY + ControlPanel.Height > ClientSize.Height )
                {
                    newY = ClientSize.Height - ControlPanel.Height;
                }
                if (ControlPanel.ClientRectangle.IntersectsWith(ControlBarPanel.ClientRectangle))
                {
                    ControlPanel.Update();
                }
                ControlPanel.Left = newX;
                ControlPanel.Top = newY;
            }
        }

        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveControlmouseDown = false;
        }

        bool ControlPanelCollapsed = false;
        private void ControlPanelCollapsButton_Click(object sender, EventArgs e)
        {
            int DistanceY = ControlPanel.MaximumSize.Height - ControlPanel.MinimumSize.Height;
            int DistanceX = ControlPanel.MaximumSize.Width - ControlPanel.MinimumSize.Width;
            if (ControlPanelCollapsed)
            {
                ControlPanel.Size = ControlPanel.MaximumSize;
                RenderButton.Top += DistanceY;
                ControlPanelCollapsButton.Top += DistanceY;
                ControlPanelCollapsButton.Left += DistanceX;
            }
            else
            {
                ControlPanel.Size = ControlPanel.MinimumSize;
                RenderButton.Top -= DistanceY;
                ControlPanelCollapsButton.Top -= DistanceY;
                ControlPanelCollapsButton.Left -= DistanceX;
            }
            ControlSubPanel.Visible = !ControlSubPanel.Visible;
            ControlPanelCollapsed = !ControlPanelCollapsed;
            ControlPanel.Update();
            ControlPanel.Invalidate();
        }
        #endregion
    }
}
