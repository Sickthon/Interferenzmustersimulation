
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interferenzmustersimulation));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ControlPanelCollapsButton = new System.Windows.Forms.Button();
            this.RenderButton = new System.Windows.Forms.Button();
            this.ControlSubPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RendergenauigkeitUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Länge1UpDown = new System.Windows.Forms.NumericUpDown();
            this.Länge2RelativUpDown = new System.Windows.Forms.NumericUpDown();
            this.toWavelengthButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RLVeränderung = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.ControlBarPanel = new System.Windows.Forms.Panel();
            this.FormHelpLabel = new System.Windows.Forms.Label();
            this.FormMinimizeLabel = new System.Windows.Forms.Label();
            this.FormCloseLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ControlPanel.SuspendLayout();
            this.ControlSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RendergenauigkeitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge2RelativUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.ControlBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.ControlPanel.Controls.Add(this.ControlPanelCollapsButton);
            this.ControlPanel.Controls.Add(this.RenderButton);
            this.ControlPanel.Controls.Add(this.ControlSubPanel);
            this.ControlPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ControlPanel.Location = new System.Drawing.Point(12, 12);
            this.ControlPanel.MaximumSize = new System.Drawing.Size(463, 211);
            this.ControlPanel.MinimumSize = new System.Drawing.Size(463, 44);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(463, 211);
            this.ControlPanel.TabIndex = 34;
            this.ControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlPanel_Paint);
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // ControlPanelCollapsButton
            // 
            this.ControlPanelCollapsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ControlPanelCollapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ControlPanelCollapsButton.Location = new System.Drawing.Point(438, 186);
            this.ControlPanelCollapsButton.Name = "ControlPanelCollapsButton";
            this.ControlPanelCollapsButton.Size = new System.Drawing.Size(25, 25);
            this.ControlPanelCollapsButton.TabIndex = 48;
            this.ControlPanelCollapsButton.Text = "^";
            this.ControlPanelCollapsButton.UseVisualStyleBackColor = true;
            this.ControlPanelCollapsButton.Click += new System.EventHandler(this.ControlPanelCollapsButton_Click);
            // 
            // RenderButton
            // 
            this.RenderButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RenderButton.Location = new System.Drawing.Point(6, 173);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(124, 23);
            this.RenderButton.TabIndex = 45;
            this.RenderButton.Text = "Berechnen";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // ControlSubPanel
            // 
            this.ControlSubPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlSubPanel.Controls.Add(this.label1);
            this.ControlSubPanel.Controls.Add(this.RendergenauigkeitUpDown);
            this.ControlSubPanel.Controls.Add(this.label2);
            this.ControlSubPanel.Controls.Add(this.label3);
            this.ControlSubPanel.Controls.Add(this.Länge1UpDown);
            this.ControlSubPanel.Controls.Add(this.Länge2RelativUpDown);
            this.ControlSubPanel.Controls.Add(this.toWavelengthButton);
            this.ControlSubPanel.Controls.Add(this.label5);
            this.ControlSubPanel.Controls.Add(this.RLVeränderung);
            this.ControlSubPanel.Controls.Add(this.numericUpDown2);
            this.ControlSubPanel.Controls.Add(this.label6);
            this.ControlSubPanel.Controls.Add(this.label4);
            this.ControlSubPanel.Controls.Add(this.numericUpDown3);
            this.ControlSubPanel.Location = new System.Drawing.Point(3, 3);
            this.ControlSubPanel.MaximumSize = new System.Drawing.Size(457, 160);
            this.ControlSubPanel.Name = "ControlSubPanel";
            this.ControlSubPanel.Size = new System.Drawing.Size(457, 160);
            this.ControlSubPanel.TabIndex = 36;
            this.ControlSubPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlSubPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlSubPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Länge [mm]";
            // 
            // RendergenauigkeitUpDown
            // 
            this.RendergenauigkeitUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RendergenauigkeitUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RendergenauigkeitUpDown.Location = new System.Drawing.Point(258, 132);
            this.RendergenauigkeitUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.RendergenauigkeitUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RendergenauigkeitUpDown.Name = "RendergenauigkeitUpDown";
            this.RendergenauigkeitUpDown.Size = new System.Drawing.Size(123, 22);
            this.RendergenauigkeitUpDown.TabIndex = 47;
            this.toolTip1.SetToolTip(this.RendergenauigkeitUpDown, resources.GetString("RendergenauigkeitUpDown.ToolTip"));
            this.RendergenauigkeitUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RendergenauigkeitUpDown.ValueChanged += new System.EventHandler(this.RendergenauigkeitUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Relativer L.-Unterschied [μm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Rendergenauigkeit";
            // 
            // Länge1UpDown
            // 
            this.Länge1UpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Länge1UpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Länge1UpDown.DecimalPlaces = 9;
            this.Länge1UpDown.Location = new System.Drawing.Point(3, 20);
            this.Länge1UpDown.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.Länge1UpDown.Name = "Länge1UpDown";
            this.Länge1UpDown.Size = new System.Drawing.Size(124, 22);
            this.Länge1UpDown.TabIndex = 36;
            this.toolTip1.SetToolTip(this.Länge1UpDown, "Die Länge des arretierten Armes vom Laser bis zum Fotowiderstand");
            this.Länge1UpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Länge1UpDown.ValueChanged += new System.EventHandler(this.Länge1UpDown_ValueChanged);
            // 
            // Länge2RelativUpDown
            // 
            this.Länge2RelativUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Länge2RelativUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Länge2RelativUpDown.DecimalPlaces = 9;
            this.Länge2RelativUpDown.Location = new System.Drawing.Point(3, 74);
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
            this.Länge2RelativUpDown.Size = new System.Drawing.Size(123, 22);
            this.Länge2RelativUpDown.TabIndex = 37;
            this.toolTip1.SetToolTip(this.Länge2RelativUpDown, "Die relative Längendifferenz des längenverstellbaren Armes zum arretierten Arm");
            this.Länge2RelativUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Länge2RelativUpDown.ValueChanged += new System.EventHandler(this.Länge2RelativUpDown_ValueChanged);
            // 
            // toWavelengthButton
            // 
            this.toWavelengthButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toWavelengthButton.Location = new System.Drawing.Point(133, 131);
            this.toWavelengthButton.Name = "toWavelengthButton";
            this.toWavelengthButton.Size = new System.Drawing.Size(22, 24);
            this.toWavelengthButton.TabIndex = 44;
            this.toWavelengthButton.Text = "λ";
            this.toWavelengthButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toWavelengthButton.UseVisualStyleBackColor = true;
            this.toWavelengthButton.Click += new System.EventHandler(this.toWavelengthButton_Click);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Interferenzmustergrösse [mm]";
            // 
            // RLVeränderung
            // 
            this.RLVeränderung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RLVeränderung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RLVeränderung.Location = new System.Drawing.Point(3, 132);
            this.RLVeränderung.MinimumSize = new System.Drawing.Size(5, 18);
            this.RLVeränderung.Multiline = true;
            this.RLVeränderung.Name = "RLVeränderung";
            this.RLVeränderung.Size = new System.Drawing.Size(124, 22);
            this.RLVeränderung.TabIndex = 43;
            this.toolTip1.SetToolTip(this.RLVeränderung, "Die Änderung bei einem Klick auf das Control \"Relativer L.-Unterschied [μm]\"\r\nDad" +
        "urch lässt sich die relative Längendifferenz um ein Vielfaches der Wellenlänge λ" +
        " verändern.\r\n\r\n");
            this.RLVeränderung.WordWrap = false;
            this.RLVeränderung.TextChanged += new System.EventHandler(this.RLVeränderung_TextChanged);
            this.RLVeränderung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RLVeränderung_KeyDown);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AccessibleDescription = "";
            this.numericUpDown2.AccessibleName = "";
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown2.DecimalPlaces = 9;
            this.numericUpDown2.Location = new System.Drawing.Point(258, 20);
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
            this.numericUpDown2.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown2.TabIndex = 39;
            this.toolTip1.SetToolTip(this.numericUpDown2, "Der Durchmesser des Interferenzmusters, das auf dem Fotowiderstand entsteht.");
            this.numericUpDown2.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "R.-L.-Veränderung [μm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(255, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Laser-Durchmesser [mm]";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown3.DecimalPlaces = 9;
            this.numericUpDown3.Location = new System.Drawing.Point(258, 78);
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
            this.numericUpDown3.Size = new System.Drawing.Size(123, 22);
            this.numericUpDown3.TabIndex = 41;
            this.toolTip1.SetToolTip(this.numericUpDown3, "Der Durchmesser der Laserdiode. Zur Bestimmung des Interferenzmusters werden für " +
        "jeden Punkt auf dem Fotowiderstand \r\nLichtwellen von verschiedenen Emissionspunk" +
        "ten im Laser überlagert.");
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // ControlBarPanel
            // 
            this.ControlBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlBarPanel.Controls.Add(this.FormHelpLabel);
            this.ControlBarPanel.Controls.Add(this.FormMinimizeLabel);
            this.ControlBarPanel.Controls.Add(this.FormCloseLabel);
            this.ControlBarPanel.Location = new System.Drawing.Point(645, 0);
            this.ControlBarPanel.Name = "ControlBarPanel";
            this.ControlBarPanel.Size = new System.Drawing.Size(200, 41);
            this.ControlBarPanel.TabIndex = 35;
            // 
            // FormHelpLabel
            // 
            this.FormHelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormHelpLabel.ForeColor = System.Drawing.Color.White;
            this.FormHelpLabel.Location = new System.Drawing.Point(17, 0);
            this.FormHelpLabel.Name = "FormHelpLabel";
            this.FormHelpLabel.Size = new System.Drawing.Size(60, 39);
            this.FormHelpLabel.TabIndex = 2;
            this.FormHelpLabel.Text = "?";
            this.FormHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormHelpLabel.Click += new System.EventHandler(this.FormHelpLabel_Click);
            this.FormHelpLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHelpLabel_MouseDown);
            this.FormHelpLabel.MouseEnter += new System.EventHandler(this.FormHelpLabel_MouseEnter);
            this.FormHelpLabel.MouseLeave += new System.EventHandler(this.FormHelpLabel_MouseLeave);
            this.FormHelpLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHelpLabel_MouseEnter);
            // 
            // FormMinimizeLabel
            // 
            this.FormMinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormMinimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormMinimizeLabel.ForeColor = System.Drawing.Color.White;
            this.FormMinimizeLabel.Location = new System.Drawing.Point(77, 0);
            this.FormMinimizeLabel.Name = "FormMinimizeLabel";
            this.FormMinimizeLabel.Size = new System.Drawing.Size(60, 39);
            this.FormMinimizeLabel.TabIndex = 1;
            this.FormMinimizeLabel.Text = "—";
            this.FormMinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormMinimizeLabel.Click += new System.EventHandler(this.FormMinimizeLabel_Click);
            this.FormMinimizeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMinimizeLabel_MouseDown);
            this.FormMinimizeLabel.MouseEnter += new System.EventHandler(this.FormMinimizeLabel_MouseEnter);
            this.FormMinimizeLabel.MouseLeave += new System.EventHandler(this.FormMinimizeLabel_MouseLeave);
            this.FormMinimizeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMinimizeLabel_MouseEnter);
            // 
            // FormCloseLabel
            // 
            this.FormCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCloseLabel.ForeColor = System.Drawing.Color.White;
            this.FormCloseLabel.Location = new System.Drawing.Point(137, 0);
            this.FormCloseLabel.Name = "FormCloseLabel";
            this.FormCloseLabel.Size = new System.Drawing.Size(60, 39);
            this.FormCloseLabel.TabIndex = 0;
            this.FormCloseLabel.Text = "✖";
            this.FormCloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormCloseLabel.Click += new System.EventHandler(this.FormCloseLabel_Click);
            this.FormCloseLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCloseLabel_MouseDown);
            this.FormCloseLabel.MouseEnter += new System.EventHandler(this.FormCloseLabel_MouseEnter);
            this.FormCloseLabel.MouseLeave += new System.EventHandler(this.FormCloseLabel_MouseLeave);
            this.FormCloseLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormCloseLabel_MouseEnter);
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.AutoPopDelay = 30000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Interferenzmustersimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1039, 439);
            this.Controls.Add(this.ControlBarPanel);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interferenzmustersimulation";
            this.Text = "Interferenzmustersimulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ControlPanel.ResumeLayout(false);
            this.ControlSubPanel.ResumeLayout(false);
            this.ControlSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RendergenauigkeitUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge2RelativUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ControlBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.Button toWavelengthButton;
        private System.Windows.Forms.TextBox RLVeränderung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Länge2RelativUpDown;
        private System.Windows.Forms.NumericUpDown Länge1UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ControlBarPanel;
        private System.Windows.Forms.Label FormMinimizeLabel;
        private System.Windows.Forms.Label FormCloseLabel;
        private System.Windows.Forms.NumericUpDown RendergenauigkeitUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ControlPanelCollapsButton;
        private System.Windows.Forms.Panel ControlSubPanel;
        private System.Windows.Forms.Label FormHelpLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

