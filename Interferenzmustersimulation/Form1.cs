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
     * Es wird nun nur noch die quadrierte Amplitude zur Berechnung des Interfernezmusters verwendet.
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
            double length = (double)numericUpDown2.Value;
            int BitmapHeight = ClientSize.Height;
             InterferencePatternModel = new Model((double)Länge1UpDown.Value, (double)Länge2RelativUpDown.Value, 
                 length, BitmapHeight, BitmapHeight, (double)numericUpDown3.Value);
            InterferencePatternModel.ModelView = new View(InterferencePatternModel);
            RLVeränderung.Text = Länge2RelativUpDown.Increment.ToString();
        }

        private void Länge1UpDown_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.d1 = (double)Länge1UpDown.Value;
        }

        private void Länge2RelativUpDown_ValueChanged(object sender, EventArgs e)
        { 
            InterferencePatternModel.d2 = (double)Länge2RelativUpDown.Value;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(InterferencePatternModel.ModelView.ModelViewImage, new Point(350, 0));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.xmax = (double)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            InterferencePatternModel.LaserRadius = (double)numericUpDown3.Value;
        }

        private void toWavelengthButton_Click(object sender, EventArgs e)
        {
            Länge2RelativUpDown.Increment = Model.Wellenlänge * 1E6m;
            RLVeränderung.Text = Convert.ToString(Länge2RelativUpDown.Increment);
        }

        private void RLVeränderung_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textBoxText = RLVeränderung.Text;
                int lastChar = Convert.ToInt32(textBoxText[textBoxText.Length - 1]);
                if (48 <= lastChar && lastChar <= 57)
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    decimal result = (decimal)table.Compute(textBoxText, "");
                    Länge2RelativUpDown.Increment = result;
                    RLVeränderung.Text = Convert.ToString(result);
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterferencePatternModel.notifyView();
        }
    }
}
