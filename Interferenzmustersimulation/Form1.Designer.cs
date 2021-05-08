
namespace MatrixTest
{
    partial class Interferenzmustersimulation
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interferenzmustersimulation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toWavelengthButton = new System.Windows.Forms.Button();
            this.RLVeränderung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Länge2RelativUpDown = new System.Windows.Forms.NumericUpDown();
            this.Länge1UpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge2RelativUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge1UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.toWavelengthButton);
            this.groupBox1.Controls.Add(this.RLVeränderung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Länge2RelativUpDown);
            this.groupBox1.Controls.Add(this.Länge1UpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 287);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toWavelengthButton
            // 
            this.toWavelengthButton.Location = new System.Drawing.Point(126, 133);
            this.toWavelengthButton.Name = "toWavelengthButton";
            this.toWavelengthButton.Size = new System.Drawing.Size(120, 48);
            this.toWavelengthButton.TabIndex = 20;
            this.toWavelengthButton.Text = "Auf Wellenlänge setzen";
            this.toWavelengthButton.UseVisualStyleBackColor = true;
            this.toWavelengthButton.Click += new System.EventHandler(this.toWavelengthButton_Click);
            // 
            // RLVeränderung
            // 
            this.RLVeränderung.Location = new System.Drawing.Point(126, 105);
            this.RLVeränderung.Name = "RLVeränderung";
            this.RLVeränderung.Size = new System.Drawing.Size(120, 22);
            this.RLVeränderung.TabIndex = 19;
            this.RLVeränderung.TextChanged += new System.EventHandler(this.RLVeränderung_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 53);
            this.label6.TabIndex = 17;
            this.label6.Text = "R.-L.-Veränderung [μm]:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 6;
            this.numericUpDown3.Location = new System.Drawing.Point(126, 224);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "LaserRadius [mm]:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 6;
            this.numericUpDown2.Location = new System.Drawing.Point(126, 190);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 53);
            this.label5.TabIndex = 13;
            this.label5.Text = "Interferenzmustergrösse [mm]";
            // 
            // Länge2RelativUpDown
            // 
            this.Länge2RelativUpDown.DecimalPlaces = 6;
            this.Länge2RelativUpDown.Location = new System.Drawing.Point(126, 52);
            this.Länge2RelativUpDown.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.Länge2RelativUpDown.Minimum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            -2147483648});
            this.Länge2RelativUpDown.Name = "Länge2RelativUpDown";
            this.Länge2RelativUpDown.Size = new System.Drawing.Size(120, 22);
            this.Länge2RelativUpDown.TabIndex = 8;
            this.Länge2RelativUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Länge2RelativUpDown.ValueChanged += new System.EventHandler(this.Länge2RelativUpDown_ValueChanged);
            // 
            // Länge1UpDown
            // 
            this.Länge1UpDown.DecimalPlaces = 6;
            this.Länge1UpDown.Location = new System.Drawing.Point(126, 16);
            this.Länge1UpDown.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.Länge1UpDown.Name = "Länge1UpDown";
            this.Länge1UpDown.Size = new System.Drawing.Size(120, 22);
            this.Länge1UpDown.TabIndex = 7;
            this.Länge1UpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Länge1UpDown.ValueChanged += new System.EventHandler(this.Länge1UpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Länge [mm]: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "Relativer Längenunterschied [μm]:";
            // 
            // Interferenzmustersimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 439);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interferenzmustersimulation";
            this.Text = "Interferenzmustersimulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge2RelativUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge1UpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Länge2RelativUpDown;
        private System.Windows.Forms.NumericUpDown Länge1UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button toWavelengthButton;
        private System.Windows.Forms.TextBox RLVeränderung;
        private System.Windows.Forms.Button button1;
    }
}

