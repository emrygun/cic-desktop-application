namespace ColourInvestigatorCar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DangerBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Colour2_Button = new System.Windows.Forms.Button();
            this.Colour1_Button = new System.Windows.Forms.Button();
            this.Colour0_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LightsPanel = new System.Windows.Forms.Panel();
            this.LightsLabel = new System.Windows.Forms.Label();
            this.NoisePanel = new System.Windows.Forms.Panel();
            this.NoiseLabel = new System.Windows.Forms.Label();
            this.SpeedPanel = new System.Windows.Forms.Panel();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.SerialPorts = new System.Windows.Forms.ComboBox();
            this.COMPortsText = new System.Windows.Forms.Label();
            this.ReScan_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.UART_Tx_Label = new System.Windows.Forms.Label();
            this.UART_Rx_Label = new System.Windows.Forms.Label();
            this.Colour2_TrackBar = new System.Windows.Forms.TrackBar();
            this.Colour1_TrackBar = new System.Windows.Forms.TrackBar();
            this.Colour0_TrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.UART_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.LightsPanel.SuspendLayout();
            this.NoisePanel.SuspendLayout();
            this.SpeedPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colour2_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colour1_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colour0_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DangerBar
            // 
            this.DangerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DangerBar.Location = new System.Drawing.Point(3, 100);
            this.DangerBar.Name = "DangerBar";
            this.DangerBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DangerBar.Size = new System.Drawing.Size(377, 20);
            this.DangerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DangerBar.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Colour2_Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Colour1_Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Colour0_Button, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 44);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Colour2_Button
            // 
            this.Colour2_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Colour2_Button.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour2_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Colour2_Button.Location = new System.Drawing.Point(2, 2);
            this.Colour2_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Colour2_Button.Name = "Colour2_Button";
            this.Colour2_Button.Size = new System.Drawing.Size(196, 120);
            this.Colour2_Button.TabIndex = 0;
            this.Colour2_Button.UseVisualStyleBackColor = false;
            this.Colour2_Button.Click += new System.EventHandler(this.Colour2_Button_Click);
            // 
            // Colour1_Button
            // 
            this.Colour1_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Colour1_Button.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour1_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Colour1_Button.Location = new System.Drawing.Point(2, 124);
            this.Colour1_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Colour1_Button.Name = "Colour1_Button";
            this.Colour1_Button.Size = new System.Drawing.Size(196, 120);
            this.Colour1_Button.TabIndex = 1;
            this.Colour1_Button.UseVisualStyleBackColor = false;
            this.Colour1_Button.Click += new System.EventHandler(this.Colour1_Button_Click);
            // 
            // Colour0_Button
            // 
            this.Colour0_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Colour0_Button.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colour0_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Colour0_Button.Location = new System.Drawing.Point(2, 246);
            this.Colour0_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Colour0_Button.Name = "Colour0_Button";
            this.Colour0_Button.Size = new System.Drawing.Size(196, 121);
            this.Colour0_Button.TabIndex = 2;
            this.Colour0_Button.UseVisualStyleBackColor = false;
            this.Colour0_Button.Click += new System.EventHandler(this.Colour0_Button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Colour2_TrackBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Colour1_TrackBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Colour0_TrackBar, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(393, 369);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DangerBar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.StatusLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 98);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 266);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.LightsPanel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.NoisePanel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.SpeedPanel, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(383, 74);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // LightsPanel
            // 
            this.LightsPanel.BackColor = System.Drawing.Color.White;
            this.LightsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LightsPanel.Controls.Add(this.LightsLabel);
            this.LightsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightsPanel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightsPanel.Location = new System.Drawing.Point(0, 0);
            this.LightsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LightsPanel.Name = "LightsPanel";
            this.LightsPanel.Size = new System.Drawing.Size(127, 74);
            this.LightsPanel.TabIndex = 0;
            // 
            // LightsLabel
            // 
            this.LightsLabel.AutoSize = true;
            this.LightsLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightsLabel.Location = new System.Drawing.Point(27, 13);
            this.LightsLabel.Name = "LightsLabel";
            this.LightsLabel.Size = new System.Drawing.Size(73, 48);
            this.LightsLabel.TabIndex = 0;
            this.LightsLabel.Text = "Lights\r\n-";
            this.LightsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoisePanel
            // 
            this.NoisePanel.BackColor = System.Drawing.Color.White;
            this.NoisePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NoisePanel.Controls.Add(this.NoiseLabel);
            this.NoisePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoisePanel.Location = new System.Drawing.Point(127, 0);
            this.NoisePanel.Margin = new System.Windows.Forms.Padding(0);
            this.NoisePanel.Name = "NoisePanel";
            this.NoisePanel.Size = new System.Drawing.Size(127, 74);
            this.NoisePanel.TabIndex = 1;
            // 
            // NoiseLabel
            // 
            this.NoiseLabel.AutoSize = true;
            this.NoiseLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiseLabel.Location = new System.Drawing.Point(30, 13);
            this.NoiseLabel.Name = "NoiseLabel";
            this.NoiseLabel.Size = new System.Drawing.Size(66, 48);
            this.NoiseLabel.TabIndex = 1;
            this.NoiseLabel.Text = "Noise\r\n-";
            this.NoiseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedPanel
            // 
            this.SpeedPanel.BackColor = System.Drawing.Color.White;
            this.SpeedPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpeedPanel.Controls.Add(this.SpeedLabel);
            this.SpeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedPanel.Location = new System.Drawing.Point(254, 0);
            this.SpeedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SpeedPanel.Name = "SpeedPanel";
            this.SpeedPanel.Size = new System.Drawing.Size(129, 74);
            this.SpeedPanel.TabIndex = 2;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.Location = new System.Drawing.Point(27, 13);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(74, 48);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "Speed\r\n-";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danger Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(0, 123);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.StatusLabel.Size = new System.Drawing.Size(383, 61);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status\r\nWaiting For Connection\r\n";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68421F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.21053F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36842F));
            this.tableLayoutPanel5.Controls.Add(this.SerialPorts, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.COMPortsText, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ReScan_Button, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 237);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(383, 29);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // SerialPorts
            // 
            this.SerialPorts.Cursor = System.Windows.Forms.Cursors.Default;
            this.SerialPorts.Dock = System.Windows.Forms.DockStyle.Top;
            this.SerialPorts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPorts.FormattingEnabled = true;
            this.SerialPorts.IntegralHeight = false;
            this.SerialPorts.Location = new System.Drawing.Point(130, 3);
            this.SerialPorts.Margin = new System.Windows.Forms.Padding(0);
            this.SerialPorts.Name = "SerialPorts";
            this.SerialPorts.Size = new System.Drawing.Size(145, 24);
            this.SerialPorts.TabIndex = 6;
            this.SerialPorts.Text = "Select COM Port";
            this.SerialPorts.SelectedIndexChanged += new System.EventHandler(this.SerialPorts_SelectedIndexChanged);
            // 
            // COMPortsText
            // 
            this.COMPortsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMPortsText.AutoSize = true;
            this.COMPortsText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortsText.Location = new System.Drawing.Point(6, 3);
            this.COMPortsText.Name = "COMPortsText";
            this.COMPortsText.Size = new System.Drawing.Size(118, 23);
            this.COMPortsText.TabIndex = 7;
            this.COMPortsText.Text = "Robot COM Port: ";
            this.COMPortsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReScan_Button
            // 
            this.ReScan_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReScan_Button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReScan_Button.Location = new System.Drawing.Point(278, 3);
            this.ReScan_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ReScan_Button.Name = "ReScan_Button";
            this.ReScan_Button.Size = new System.Drawing.Size(102, 23);
            this.ReScan_Button.TabIndex = 8;
            this.ReScan_Button.Text = "ReScan Ports";
            this.ReScan_Button.UseVisualStyleBackColor = true;
            this.ReScan_Button.Click += new System.EventHandler(this.ReScan_Button_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.UART_Tx_Label, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.UART_Rx_Label, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 184);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(383, 53);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // UART_Tx_Label
            // 
            this.UART_Tx_Label.AutoSize = true;
            this.UART_Tx_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UART_Tx_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UART_Tx_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UART_Tx_Label.Location = new System.Drawing.Point(191, 0);
            this.UART_Tx_Label.Margin = new System.Windows.Forms.Padding(0);
            this.UART_Tx_Label.Name = "UART_Tx_Label";
            this.UART_Tx_Label.Size = new System.Drawing.Size(192, 53);
            this.UART_Tx_Label.TabIndex = 3;
            this.UART_Tx_Label.Text = "UART Tx\r\n-";
            this.UART_Tx_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UART_Rx_Label
            // 
            this.UART_Rx_Label.AutoSize = true;
            this.UART_Rx_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UART_Rx_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UART_Rx_Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UART_Rx_Label.Location = new System.Drawing.Point(0, 0);
            this.UART_Rx_Label.Margin = new System.Windows.Forms.Padding(0);
            this.UART_Rx_Label.Name = "UART_Rx_Label";
            this.UART_Rx_Label.Size = new System.Drawing.Size(191, 53);
            this.UART_Rx_Label.TabIndex = 2;
            this.UART_Rx_Label.Text = "UART Rx\r\n-";
            this.UART_Rx_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Colour2_TrackBar
            // 
            this.Colour2_TrackBar.Location = new System.Drawing.Point(5, 5);
            this.Colour2_TrackBar.Maximum = 5;
            this.Colour2_TrackBar.Name = "Colour2_TrackBar";
            this.Colour2_TrackBar.Size = new System.Drawing.Size(383, 23);
            this.Colour2_TrackBar.TabIndex = 1;
            this.Colour2_TrackBar.Scroll += new System.EventHandler(this.Colour2_TrackBar_Scroll);
            // 
            // Colour1_TrackBar
            // 
            this.Colour1_TrackBar.Location = new System.Drawing.Point(5, 36);
            this.Colour1_TrackBar.Maximum = 5;
            this.Colour1_TrackBar.Name = "Colour1_TrackBar";
            this.Colour1_TrackBar.Size = new System.Drawing.Size(383, 23);
            this.Colour1_TrackBar.TabIndex = 2;
            this.Colour1_TrackBar.Scroll += new System.EventHandler(this.Colour1_TrackBar_Scroll);
            // 
            // Colour0_TrackBar
            // 
            this.Colour0_TrackBar.Location = new System.Drawing.Point(5, 67);
            this.Colour0_TrackBar.Maximum = 5;
            this.Colour0_TrackBar.Name = "Colour0_TrackBar";
            this.Colour0_TrackBar.Size = new System.Drawing.Size(383, 23);
            this.Colour0_TrackBar.TabIndex = 3;
            this.Colour0_TrackBar.Scroll += new System.EventHandler(this.Colour0_TrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Robot Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Velocity";
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // UART_Timer
            // 
            this.UART_Timer.Interval = 185;
            this.UART_Timer.Tick += new System.EventHandler(this.UART_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Colour Investigator Robot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.LightsPanel.ResumeLayout(false);
            this.LightsPanel.PerformLayout();
            this.NoisePanel.ResumeLayout(false);
            this.NoisePanel.PerformLayout();
            this.SpeedPanel.ResumeLayout(false);
            this.SpeedPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colour2_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colour1_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colour0_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel LightsPanel;
        private System.Windows.Forms.Panel NoisePanel;
        private System.Windows.Forms.Panel SpeedPanel;
        public System.Windows.Forms.Label LightsLabel;
        public System.Windows.Forms.Label NoiseLabel;
        public System.Windows.Forms.Label SpeedLabel;
        public System.Windows.Forms.Label StatusLabel;
        public System.Windows.Forms.Button Colour2_Button;
        public System.Windows.Forms.Button Colour1_Button;
        public System.Windows.Forms.Button Colour0_Button;
        public System.Windows.Forms.TrackBar Colour0_TrackBar;
        public System.Windows.Forms.TrackBar Colour2_TrackBar;
        public System.Windows.Forms.TrackBar Colour1_TrackBar;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer UART_Timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.ComboBox SerialPorts;
        private System.Windows.Forms.Label COMPortsText;
        public System.Windows.Forms.ProgressBar DangerBar;
        private System.Windows.Forms.Button ReScan_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.Windows.Forms.Label UART_Rx_Label;
        public System.Windows.Forms.Label UART_Tx_Label;
    }
}

