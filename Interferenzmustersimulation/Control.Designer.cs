
namespace InterferenzmusterSimulation
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
            this.ControlPanelCollapseButton = new System.Windows.Forms.Button();
            this.RenderButton = new System.Windows.Forms.Button();
            this.ControlSubPanel = new System.Windows.Forms.Panel();
            this.Länge1Label = new System.Windows.Forms.Label();
            this.RendergenauigkeitUpDown = new System.Windows.Forms.NumericUpDown();
            this.Länge2RelativLabel = new System.Windows.Forms.Label();
            this.RendergenauigkeitLabel = new System.Windows.Forms.Label();
            this.Länge1UpDown = new System.Windows.Forms.NumericUpDown();
            this.Länge2RelativUpDown = new System.Windows.Forms.NumericUpDown();
            this.toWavelengthButton = new System.Windows.Forms.Button();
            this.InterferenzmustergrösseLabel = new System.Windows.Forms.Label();
            this.RLVeränderungTextBox = new System.Windows.Forms.TextBox();
            this.InterferenzmustergrösseUpDown = new System.Windows.Forms.NumericUpDown();
            this.RLVeränderungLabel = new System.Windows.Forms.Label();
            this.LaserDurchmesserLabel = new System.Windows.Forms.Label();
            this.LaserDurchmesserUpDown = new System.Windows.Forms.NumericUpDown();
            this.ControlBarPanel = new System.Windows.Forms.Panel();
            this.FormHelpLabel = new System.Windows.Forms.Label();
            this.FormMinimizeLabel = new System.Windows.Forms.Label();
            this.FormCloseLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ControlPanel.SuspendLayout();
            this.ControlSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RendergenauigkeitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Länge2RelativUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterferenzmustergrösseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaserDurchmesserUpDown)).BeginInit();
            this.ControlBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.ControlPanel.Controls.Add(this.ControlPanelCollapseButton);
            this.ControlPanel.Controls.Add(this.RenderButton);
            this.ControlPanel.Controls.Add(this.ControlSubPanel);
            this.ControlPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ControlPanel.Location = new System.Drawing.Point(12, 12);
            this.ControlPanel.MaximumSize = new System.Drawing.Size(463, 211);
            this.ControlPanel.MinimumSize = new System.Drawing.Size(165, 44);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(463, 211);
            this.ControlPanel.TabIndex = 34;
            this.ControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlPanel_Paint);
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // ControlPanelCollapseButton
            // 
            this.ControlPanelCollapseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ControlPanelCollapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ControlPanelCollapseButton.Location = new System.Drawing.Point(438, 186);
            this.ControlPanelCollapseButton.Name = "ControlPanelCollapseButton";
            this.ControlPanelCollapseButton.Size = new System.Drawing.Size(25, 25);
            this.ControlPanelCollapseButton.TabIndex = 48;
            this.ControlPanelCollapseButton.Text = "^";
            this.ControlPanelCollapseButton.UseVisualStyleBackColor = true;
            this.ControlPanelCollapseButton.Click += new System.EventHandler(this.ControlPanelCollapseButton_Click);
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
            this.ControlSubPanel.Controls.Add(this.Länge1Label);
            this.ControlSubPanel.Controls.Add(this.RendergenauigkeitUpDown);
            this.ControlSubPanel.Controls.Add(this.Länge2RelativLabel);
            this.ControlSubPanel.Controls.Add(this.RendergenauigkeitLabel);
            this.ControlSubPanel.Controls.Add(this.Länge1UpDown);
            this.ControlSubPanel.Controls.Add(this.Länge2RelativUpDown);
            this.ControlSubPanel.Controls.Add(this.toWavelengthButton);
            this.ControlSubPanel.Controls.Add(this.InterferenzmustergrösseLabel);
            this.ControlSubPanel.Controls.Add(this.RLVeränderungTextBox);
            this.ControlSubPanel.Controls.Add(this.InterferenzmustergrösseUpDown);
            this.ControlSubPanel.Controls.Add(this.RLVeränderungLabel);
            this.ControlSubPanel.Controls.Add(this.LaserDurchmesserLabel);
            this.ControlSubPanel.Controls.Add(this.LaserDurchmesserUpDown);
            this.ControlSubPanel.Location = new System.Drawing.Point(3, 3);
            this.ControlSubPanel.MaximumSize = new System.Drawing.Size(457, 160);
            this.ControlSubPanel.Name = "ControlSubPanel";
            this.ControlSubPanel.Size = new System.Drawing.Size(457, 160);
            this.ControlSubPanel.TabIndex = 36;
            this.ControlSubPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlSubPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlSubPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // Länge1Label
            // 
            this.Länge1Label.AutoSize = true;
            this.Länge1Label.ForeColor = System.Drawing.Color.White;
            this.Länge1Label.Location = new System.Drawing.Point(0, 0);
            this.Länge1Label.Name = "Länge1Label";
            this.Länge1Label.Size = new System.Drawing.Size(82, 17);
            this.Länge1Label.TabIndex = 34;
            this.Länge1Label.Text = "Länge [mm]";
            // 
            // RendergenauigkeitUpDown
            // 
            this.RendergenauigkeitUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RendergenauigkeitUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RendergenauigkeitUpDown.DecimalPlaces = 1;
            this.RendergenauigkeitUpDown.Location = new System.Drawing.Point(258, 132);
            this.RendergenauigkeitUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.RendergenauigkeitUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RendergenauigkeitUpDown.Name = "RendergenauigkeitUpDown";
            this.RendergenauigkeitUpDown.Size = new System.Drawing.Size(123, 22);
            this.RendergenauigkeitUpDown.TabIndex = 47;
            this.toolTip.SetToolTip(this.RendergenauigkeitUpDown, resources.GetString("RendergenauigkeitUpDown.ToolTip"));
            this.RendergenauigkeitUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RendergenauigkeitUpDown.ValueChanged += new System.EventHandler(this.RendergenauigkeitUpDown_ValueChanged);
            // 
            // Länge2RelativLabel
            // 
            this.Länge2RelativLabel.ForeColor = System.Drawing.Color.White;
            this.Länge2RelativLabel.Location = new System.Drawing.Point(0, 54);
            this.Länge2RelativLabel.Name = "Länge2RelativLabel";
            this.Länge2RelativLabel.Size = new System.Drawing.Size(194, 17);
            this.Länge2RelativLabel.TabIndex = 35;
            this.Länge2RelativLabel.Text = "Relativer L.-Unterschied [μm]";
            // 
            // RendergenauigkeitLabel
            // 
            this.RendergenauigkeitLabel.AutoSize = true;
            this.RendergenauigkeitLabel.ForeColor = System.Drawing.Color.White;
            this.RendergenauigkeitLabel.Location = new System.Drawing.Point(255, 112);
            this.RendergenauigkeitLabel.Name = "RendergenauigkeitLabel";
            this.RendergenauigkeitLabel.Size = new System.Drawing.Size(128, 17);
            this.RendergenauigkeitLabel.TabIndex = 46;
            this.RendergenauigkeitLabel.Text = "Rendergenauigkeit";
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
            this.toolTip.SetToolTip(this.Länge1UpDown, "Die Länge des arretierten Armes vom Laser bis zur Bildebene");
            this.Länge1UpDown.Value = new decimal(new int[] {
            800,
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
            this.toolTip.SetToolTip(this.Länge2RelativUpDown, "Die relative Längendifferenz des längenverstellbaren Armes zum arretierten Arm");
            this.Länge2RelativUpDown.Value = new decimal(new int[] {
            30000,
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
            // InterferenzmustergrösseLabel
            // 
            this.InterferenzmustergrösseLabel.ForeColor = System.Drawing.Color.White;
            this.InterferenzmustergrösseLabel.Location = new System.Drawing.Point(255, 0);
            this.InterferenzmustergrösseLabel.Name = "InterferenzmustergrösseLabel";
            this.InterferenzmustergrösseLabel.Size = new System.Drawing.Size(199, 17);
            this.InterferenzmustergrösseLabel.TabIndex = 38;
            this.InterferenzmustergrösseLabel.Text = "Interferenzmustergrösse [mm]";
            // 
            // RLVeränderungTextBox
            // 
            this.RLVeränderungTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RLVeränderungTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RLVeränderungTextBox.Location = new System.Drawing.Point(3, 132);
            this.RLVeränderungTextBox.MinimumSize = new System.Drawing.Size(5, 18);
            this.RLVeränderungTextBox.Multiline = true;
            this.RLVeränderungTextBox.Name = "RLVeränderungTextBox";
            this.RLVeränderungTextBox.Size = new System.Drawing.Size(124, 22);
            this.RLVeränderungTextBox.TabIndex = 43;
            this.RLVeränderungTextBox.Text = "1.0";
            this.toolTip.SetToolTip(this.RLVeränderungTextBox, resources.GetString("RLVeränderungTextBox.ToolTip"));
            this.RLVeränderungTextBox.WordWrap = false;
            this.RLVeränderungTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RLVeränderung_KeyDown);
            // 
            // InterferenzmustergrösseUpDown
            // 
            this.InterferenzmustergrösseUpDown.AccessibleDescription = "";
            this.InterferenzmustergrösseUpDown.AccessibleName = "";
            this.InterferenzmustergrösseUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InterferenzmustergrösseUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InterferenzmustergrösseUpDown.DecimalPlaces = 1;
            this.InterferenzmustergrösseUpDown.Location = new System.Drawing.Point(258, 20);
            this.InterferenzmustergrösseUpDown.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.InterferenzmustergrösseUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.InterferenzmustergrösseUpDown.Name = "InterferenzmustergrösseUpDown";
            this.InterferenzmustergrösseUpDown.Size = new System.Drawing.Size(124, 22);
            this.InterferenzmustergrösseUpDown.TabIndex = 39;
            this.toolTip.SetToolTip(this.InterferenzmustergrösseUpDown, "Der Durchmesser des Interferenzmusters, das auf der Bildebene entsteht.");
            this.InterferenzmustergrösseUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.InterferenzmustergrösseUpDown.ValueChanged += new System.EventHandler(this.InterferenzmusterGrösseUpDown_ValueChanged);
            // 
            // RLVeränderungLabel
            // 
            this.RLVeränderungLabel.ForeColor = System.Drawing.Color.White;
            this.RLVeränderungLabel.Location = new System.Drawing.Point(0, 112);
            this.RLVeränderungLabel.Name = "RLVeränderungLabel";
            this.RLVeränderungLabel.Size = new System.Drawing.Size(166, 17);
            this.RLVeränderungLabel.TabIndex = 42;
            this.RLVeränderungLabel.Text = "R.-L.-Veränderung [μm]";
            // 
            // LaserDurchmesserLabel
            // 
            this.LaserDurchmesserLabel.AutoSize = true;
            this.LaserDurchmesserLabel.ForeColor = System.Drawing.Color.White;
            this.LaserDurchmesserLabel.Location = new System.Drawing.Point(255, 58);
            this.LaserDurchmesserLabel.Name = "LaserDurchmesserLabel";
            this.LaserDurchmesserLabel.Size = new System.Drawing.Size(167, 17);
            this.LaserDurchmesserLabel.TabIndex = 40;
            this.LaserDurchmesserLabel.Text = "Laser-Durchmesser [mm]";
            // 
            // LaserDurchmesserUpDown
            // 
            this.LaserDurchmesserUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaserDurchmesserUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LaserDurchmesserUpDown.DecimalPlaces = 9;
            this.LaserDurchmesserUpDown.Location = new System.Drawing.Point(258, 78);
            this.LaserDurchmesserUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LaserDurchmesserUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.LaserDurchmesserUpDown.Name = "LaserDurchmesserUpDown";
            this.LaserDurchmesserUpDown.Size = new System.Drawing.Size(123, 22);
            this.LaserDurchmesserUpDown.TabIndex = 41;
            this.toolTip.SetToolTip(this.LaserDurchmesserUpDown, "Der Durchmesser der Laserdiode. Zur Bestimmung des Interferenzmusters werden für " +
        "jeden Punkt auf der Bildebene\r\nLichtwellen von verschiedenen Emissionspunkten im" +
        " Laser überlagert.");
            this.LaserDurchmesserUpDown.Value = new decimal(new int[] {
            750000,
            0,
            0,
            589824});
            this.LaserDurchmesserUpDown.ValueChanged += new System.EventHandler(this.LaserDurchmesserUpDown_ValueChanged);
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
            // toolTip
            // 
            this.toolTip.Active = false;
            this.toolTip.AutoPopDelay = 30000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // Interferenzmustersimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1039, 439);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.ControlBarPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.InterferenzmustergrösseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaserDurchmesserUpDown)).EndInit();
            this.ControlBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.Button toWavelengthButton;
        private System.Windows.Forms.TextBox RLVeränderungTextBox;
        private System.Windows.Forms.Label RLVeränderungLabel;
        private System.Windows.Forms.NumericUpDown LaserDurchmesserUpDown;
        private System.Windows.Forms.Label LaserDurchmesserLabel;
        private System.Windows.Forms.NumericUpDown InterferenzmustergrösseUpDown;
        private System.Windows.Forms.Label InterferenzmustergrösseLabel;
        private System.Windows.Forms.NumericUpDown Länge2RelativUpDown;
        private System.Windows.Forms.NumericUpDown Länge1UpDown;
        private System.Windows.Forms.Label Länge1Label;
        private System.Windows.Forms.Label Länge2RelativLabel;
        private System.Windows.Forms.Panel ControlBarPanel;
        private System.Windows.Forms.Label FormMinimizeLabel;
        private System.Windows.Forms.Label FormCloseLabel;
        private System.Windows.Forms.NumericUpDown RendergenauigkeitUpDown;
        private System.Windows.Forms.Label RendergenauigkeitLabel;
        private System.Windows.Forms.Button ControlPanelCollapseButton;
        private System.Windows.Forms.Panel ControlSubPanel;
        private System.Windows.Forms.Label FormHelpLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

