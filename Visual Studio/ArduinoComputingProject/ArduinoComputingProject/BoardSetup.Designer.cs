namespace ArduinoComputingProject
{
    partial class BoardSetupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numOfBoards = new System.Windows.Forms.NumericUpDown();
            this.lblBoard1 = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBoard2 = new System.Windows.Forms.Label();
            this.lblBoard3 = new System.Windows.Forms.Label();
            this.lblBoard4 = new System.Windows.Forms.Label();
            this.lblBoard5 = new System.Windows.Forms.Label();
            this.comboBoard1Port = new System.Windows.Forms.ComboBox();
            this.comboBoard2Port = new System.Windows.Forms.ComboBox();
            this.comboBoard3Port = new System.Windows.Forms.ComboBox();
            this.comboBoard4Port = new System.Windows.Forms.ComboBox();
            this.comboBoard5Port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfLayers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoard5MotorX = new System.Windows.Forms.ComboBox();
            this.comboBoard4MotorX = new System.Windows.Forms.ComboBox();
            this.comboBoard3MotorX = new System.Windows.Forms.ComboBox();
            this.comboBoard2MotorX = new System.Windows.Forms.ComboBox();
            this.comboBoard1MotorX = new System.Windows.Forms.ComboBox();
            this.comboBoard5MotorY = new System.Windows.Forms.ComboBox();
            this.comboBoard4MotorY = new System.Windows.Forms.ComboBox();
            this.comboBoard3MotorY = new System.Windows.Forms.ComboBox();
            this.comboBoard2MotorY = new System.Windows.Forms.ComboBox();
            this.comboBoard1MotorY = new System.Windows.Forms.ComboBox();
            this.comboBoard5MotorZ = new System.Windows.Forms.ComboBox();
            this.comboBoard4MotorZ = new System.Windows.Forms.ComboBox();
            this.comboBoard3MotorZ = new System.Windows.Forms.ComboBox();
            this.comboBoard2MotorZ = new System.Windows.Forms.ComboBox();
            this.comboBoard1MotorZ = new System.Windows.Forms.ComboBox();
            this.comboBoard5MotorE1 = new System.Windows.Forms.ComboBox();
            this.comboBoard4MotorE1 = new System.Windows.Forms.ComboBox();
            this.comboBoard3MotorE1 = new System.Windows.Forms.ComboBox();
            this.comboBoard2MotorE1 = new System.Windows.Forms.ComboBox();
            this.comboBoard1MotorE1 = new System.Windows.Forms.ComboBox();
            this.lblLayerNotice = new System.Windows.Forms.Label();
            this.lstDeleteSetupFile = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResetLayers = new System.Windows.Forms.Button();
            this.btnResetPorts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOfBoards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Boards:";
            // 
            // numOfBoards
            // 
            this.numOfBoards.Location = new System.Drawing.Point(145, 9);
            this.numOfBoards.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOfBoards.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfBoards.Name = "numOfBoards";
            this.numOfBoards.Size = new System.Drawing.Size(38, 20);
            this.numOfBoards.TabIndex = 1;
            this.numOfBoards.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfBoards.ValueChanged += new System.EventHandler(this.numOfBoards_ValueChanged);
            // 
            // lblBoard1
            // 
            this.lblBoard1.AutoSize = true;
            this.lblBoard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard1.Location = new System.Drawing.Point(15, 62);
            this.lblBoard1.Name = "lblBoard1";
            this.lblBoard1.Size = new System.Drawing.Size(61, 15);
            this.lblBoard1.TabIndex = 4;
            this.lblBoard1.Text = "Board 1:";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(455, 223);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(173, 23);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Save Setup File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port:";
            // 
            // lblBoard2
            // 
            this.lblBoard2.AutoSize = true;
            this.lblBoard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard2.Location = new System.Drawing.Point(15, 88);
            this.lblBoard2.Name = "lblBoard2";
            this.lblBoard2.Size = new System.Drawing.Size(61, 15);
            this.lblBoard2.TabIndex = 9;
            this.lblBoard2.Text = "Board 2:";
            this.lblBoard2.Visible = false;
            // 
            // lblBoard3
            // 
            this.lblBoard3.AutoSize = true;
            this.lblBoard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard3.Location = new System.Drawing.Point(15, 114);
            this.lblBoard3.Name = "lblBoard3";
            this.lblBoard3.Size = new System.Drawing.Size(61, 15);
            this.lblBoard3.TabIndex = 11;
            this.lblBoard3.Text = "Board 3:";
            this.lblBoard3.Visible = false;
            // 
            // lblBoard4
            // 
            this.lblBoard4.AutoSize = true;
            this.lblBoard4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard4.Location = new System.Drawing.Point(15, 140);
            this.lblBoard4.Name = "lblBoard4";
            this.lblBoard4.Size = new System.Drawing.Size(61, 15);
            this.lblBoard4.TabIndex = 13;
            this.lblBoard4.Text = "Board 4:";
            this.lblBoard4.Visible = false;
            // 
            // lblBoard5
            // 
            this.lblBoard5.AutoSize = true;
            this.lblBoard5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard5.Location = new System.Drawing.Point(16, 166);
            this.lblBoard5.Name = "lblBoard5";
            this.lblBoard5.Size = new System.Drawing.Size(61, 15);
            this.lblBoard5.TabIndex = 15;
            this.lblBoard5.Text = "Board 5:";
            this.lblBoard5.Visible = false;
            // 
            // comboBoard1Port
            // 
            this.comboBoard1Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard1Port.FormattingEnabled = true;
            this.comboBoard1Port.Items.AddRange(new object[] {
            "COM0"});
            this.comboBoard1Port.Location = new System.Drawing.Point(82, 59);
            this.comboBoard1Port.Name = "comboBoard1Port";
            this.comboBoard1Port.Size = new System.Drawing.Size(57, 21);
            this.comboBoard1Port.TabIndex = 16;
            this.comboBoard1Port.SelectedIndexChanged += new System.EventHandler(this.comboBoard1Port_SelectedIndexChanged);
            // 
            // comboBoard2Port
            // 
            this.comboBoard2Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard2Port.FormattingEnabled = true;
            this.comboBoard2Port.Items.AddRange(new object[] {
            "COM0"});
            this.comboBoard2Port.Location = new System.Drawing.Point(82, 85);
            this.comboBoard2Port.Name = "comboBoard2Port";
            this.comboBoard2Port.Size = new System.Drawing.Size(57, 21);
            this.comboBoard2Port.TabIndex = 17;
            this.comboBoard2Port.Visible = false;
            this.comboBoard2Port.SelectedIndexChanged += new System.EventHandler(this.comboBoard2Port_SelectedIndexChanged);
            // 
            // comboBoard3Port
            // 
            this.comboBoard3Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard3Port.FormattingEnabled = true;
            this.comboBoard3Port.Items.AddRange(new object[] {
            "COM0"});
            this.comboBoard3Port.Location = new System.Drawing.Point(82, 111);
            this.comboBoard3Port.Name = "comboBoard3Port";
            this.comboBoard3Port.Size = new System.Drawing.Size(57, 21);
            this.comboBoard3Port.TabIndex = 18;
            this.comboBoard3Port.Visible = false;
            this.comboBoard3Port.SelectedIndexChanged += new System.EventHandler(this.comboBoard3Port_SelectedIndexChanged);
            // 
            // comboBoard4Port
            // 
            this.comboBoard4Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard4Port.FormattingEnabled = true;
            this.comboBoard4Port.Items.AddRange(new object[] {
            "COM0"});
            this.comboBoard4Port.Location = new System.Drawing.Point(82, 137);
            this.comboBoard4Port.Name = "comboBoard4Port";
            this.comboBoard4Port.Size = new System.Drawing.Size(57, 21);
            this.comboBoard4Port.TabIndex = 19;
            this.comboBoard4Port.Visible = false;
            this.comboBoard4Port.SelectedIndexChanged += new System.EventHandler(this.comboBoard4Port_SelectedIndexChanged);
            // 
            // comboBoard5Port
            // 
            this.comboBoard5Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard5Port.FormattingEnabled = true;
            this.comboBoard5Port.Items.AddRange(new object[] {
            "COM0"});
            this.comboBoard5Port.Location = new System.Drawing.Point(82, 162);
            this.comboBoard5Port.Name = "comboBoard5Port";
            this.comboBoard5Port.Size = new System.Drawing.Size(57, 21);
            this.comboBoard5Port.TabIndex = 20;
            this.comboBoard5Port.Visible = false;
            this.comboBoard5Port.SelectedIndexChanged += new System.EventHandler(this.comboBoard5Port_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Number of Layers:";
            // 
            // numOfLayers
            // 
            this.numOfLayers.Location = new System.Drawing.Point(364, 9);
            this.numOfLayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numOfLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfLayers.Name = "numOfLayers";
            this.numOfLayers.Size = new System.Drawing.Size(38, 20);
            this.numOfLayers.TabIndex = 24;
            this.numOfLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfLayers.ValueChanged += new System.EventHandler(this.numOfLayers_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Motor X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Motor Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Motor Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Motor E1:";
            // 
            // comboBoard5MotorX
            // 
            this.comboBoard5MotorX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard5MotorX.FormattingEnabled = true;
            this.comboBoard5MotorX.Location = new System.Drawing.Point(145, 162);
            this.comboBoard5MotorX.Name = "comboBoard5MotorX";
            this.comboBoard5MotorX.Size = new System.Drawing.Size(66, 21);
            this.comboBoard5MotorX.TabIndex = 33;
            this.comboBoard5MotorX.Visible = false;
            this.comboBoard5MotorX.SelectedIndexChanged += new System.EventHandler(this.comboBoard5MotorX_SelectedIndexChanged);
            // 
            // comboBoard4MotorX
            // 
            this.comboBoard4MotorX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard4MotorX.FormattingEnabled = true;
            this.comboBoard4MotorX.Location = new System.Drawing.Point(145, 137);
            this.comboBoard4MotorX.Name = "comboBoard4MotorX";
            this.comboBoard4MotorX.Size = new System.Drawing.Size(66, 21);
            this.comboBoard4MotorX.TabIndex = 32;
            this.comboBoard4MotorX.Visible = false;
            this.comboBoard4MotorX.SelectedIndexChanged += new System.EventHandler(this.comboBoard4MotorX_SelectedIndexChanged);
            // 
            // comboBoard3MotorX
            // 
            this.comboBoard3MotorX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard3MotorX.FormattingEnabled = true;
            this.comboBoard3MotorX.Location = new System.Drawing.Point(145, 111);
            this.comboBoard3MotorX.Name = "comboBoard3MotorX";
            this.comboBoard3MotorX.Size = new System.Drawing.Size(66, 21);
            this.comboBoard3MotorX.TabIndex = 31;
            this.comboBoard3MotorX.Visible = false;
            this.comboBoard3MotorX.SelectedIndexChanged += new System.EventHandler(this.comboBoard3MotorX_SelectedIndexChanged);
            // 
            // comboBoard2MotorX
            // 
            this.comboBoard2MotorX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard2MotorX.FormattingEnabled = true;
            this.comboBoard2MotorX.Location = new System.Drawing.Point(145, 85);
            this.comboBoard2MotorX.Name = "comboBoard2MotorX";
            this.comboBoard2MotorX.Size = new System.Drawing.Size(66, 21);
            this.comboBoard2MotorX.TabIndex = 30;
            this.comboBoard2MotorX.Visible = false;
            this.comboBoard2MotorX.SelectedIndexChanged += new System.EventHandler(this.comboBoard2MotorX_SelectedIndexChanged);
            // 
            // comboBoard1MotorX
            // 
            this.comboBoard1MotorX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard1MotorX.FormattingEnabled = true;
            this.comboBoard1MotorX.Location = new System.Drawing.Point(145, 59);
            this.comboBoard1MotorX.Name = "comboBoard1MotorX";
            this.comboBoard1MotorX.Size = new System.Drawing.Size(66, 21);
            this.comboBoard1MotorX.TabIndex = 29;
            this.comboBoard1MotorX.SelectedIndexChanged += new System.EventHandler(this.comboBoard1MotorX_SelectedIndexChanged);
            // 
            // comboBoard5MotorY
            // 
            this.comboBoard5MotorY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard5MotorY.FormattingEnabled = true;
            this.comboBoard5MotorY.Location = new System.Drawing.Point(217, 162);
            this.comboBoard5MotorY.Name = "comboBoard5MotorY";
            this.comboBoard5MotorY.Size = new System.Drawing.Size(66, 21);
            this.comboBoard5MotorY.TabIndex = 38;
            this.comboBoard5MotorY.Visible = false;
            this.comboBoard5MotorY.SelectedIndexChanged += new System.EventHandler(this.comboBoard5MotorY_SelectedIndexChanged);
            // 
            // comboBoard4MotorY
            // 
            this.comboBoard4MotorY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard4MotorY.FormattingEnabled = true;
            this.comboBoard4MotorY.Location = new System.Drawing.Point(217, 137);
            this.comboBoard4MotorY.Name = "comboBoard4MotorY";
            this.comboBoard4MotorY.Size = new System.Drawing.Size(66, 21);
            this.comboBoard4MotorY.TabIndex = 37;
            this.comboBoard4MotorY.Visible = false;
            this.comboBoard4MotorY.SelectedIndexChanged += new System.EventHandler(this.comboBoard4MotorY_SelectedIndexChanged);
            // 
            // comboBoard3MotorY
            // 
            this.comboBoard3MotorY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard3MotorY.FormattingEnabled = true;
            this.comboBoard3MotorY.Location = new System.Drawing.Point(217, 111);
            this.comboBoard3MotorY.Name = "comboBoard3MotorY";
            this.comboBoard3MotorY.Size = new System.Drawing.Size(66, 21);
            this.comboBoard3MotorY.TabIndex = 36;
            this.comboBoard3MotorY.Visible = false;
            this.comboBoard3MotorY.SelectedIndexChanged += new System.EventHandler(this.comboBoard3MotorY_SelectedIndexChanged);
            // 
            // comboBoard2MotorY
            // 
            this.comboBoard2MotorY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard2MotorY.FormattingEnabled = true;
            this.comboBoard2MotorY.Location = new System.Drawing.Point(217, 85);
            this.comboBoard2MotorY.Name = "comboBoard2MotorY";
            this.comboBoard2MotorY.Size = new System.Drawing.Size(66, 21);
            this.comboBoard2MotorY.TabIndex = 35;
            this.comboBoard2MotorY.Visible = false;
            this.comboBoard2MotorY.SelectedIndexChanged += new System.EventHandler(this.comboBoard2MotorY_SelectedIndexChanged);
            // 
            // comboBoard1MotorY
            // 
            this.comboBoard1MotorY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard1MotorY.FormattingEnabled = true;
            this.comboBoard1MotorY.Location = new System.Drawing.Point(217, 59);
            this.comboBoard1MotorY.Name = "comboBoard1MotorY";
            this.comboBoard1MotorY.Size = new System.Drawing.Size(66, 21);
            this.comboBoard1MotorY.TabIndex = 34;
            this.comboBoard1MotorY.SelectedIndexChanged += new System.EventHandler(this.comboBoard1MotorY_SelectedIndexChanged);
            // 
            // comboBoard5MotorZ
            // 
            this.comboBoard5MotorZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard5MotorZ.FormattingEnabled = true;
            this.comboBoard5MotorZ.Location = new System.Drawing.Point(289, 162);
            this.comboBoard5MotorZ.Name = "comboBoard5MotorZ";
            this.comboBoard5MotorZ.Size = new System.Drawing.Size(66, 21);
            this.comboBoard5MotorZ.TabIndex = 43;
            this.comboBoard5MotorZ.Visible = false;
            this.comboBoard5MotorZ.SelectedIndexChanged += new System.EventHandler(this.comboBoard5MotorZ_SelectedIndexChanged);
            // 
            // comboBoard4MotorZ
            // 
            this.comboBoard4MotorZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard4MotorZ.FormattingEnabled = true;
            this.comboBoard4MotorZ.Location = new System.Drawing.Point(289, 137);
            this.comboBoard4MotorZ.Name = "comboBoard4MotorZ";
            this.comboBoard4MotorZ.Size = new System.Drawing.Size(66, 21);
            this.comboBoard4MotorZ.TabIndex = 42;
            this.comboBoard4MotorZ.Visible = false;
            this.comboBoard4MotorZ.SelectedIndexChanged += new System.EventHandler(this.comboBoard4MotorZ_SelectedIndexChanged);
            // 
            // comboBoard3MotorZ
            // 
            this.comboBoard3MotorZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard3MotorZ.FormattingEnabled = true;
            this.comboBoard3MotorZ.Location = new System.Drawing.Point(289, 111);
            this.comboBoard3MotorZ.Name = "comboBoard3MotorZ";
            this.comboBoard3MotorZ.Size = new System.Drawing.Size(66, 21);
            this.comboBoard3MotorZ.TabIndex = 41;
            this.comboBoard3MotorZ.Visible = false;
            this.comboBoard3MotorZ.SelectedIndexChanged += new System.EventHandler(this.comboBoard3MotorZ_SelectedIndexChanged);
            // 
            // comboBoard2MotorZ
            // 
            this.comboBoard2MotorZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard2MotorZ.FormattingEnabled = true;
            this.comboBoard2MotorZ.Location = new System.Drawing.Point(289, 85);
            this.comboBoard2MotorZ.Name = "comboBoard2MotorZ";
            this.comboBoard2MotorZ.Size = new System.Drawing.Size(66, 21);
            this.comboBoard2MotorZ.TabIndex = 40;
            this.comboBoard2MotorZ.Visible = false;
            this.comboBoard2MotorZ.SelectedIndexChanged += new System.EventHandler(this.comboBoard2MotorZ_SelectedIndexChanged);
            // 
            // comboBoard1MotorZ
            // 
            this.comboBoard1MotorZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard1MotorZ.FormattingEnabled = true;
            this.comboBoard1MotorZ.Location = new System.Drawing.Point(289, 59);
            this.comboBoard1MotorZ.Name = "comboBoard1MotorZ";
            this.comboBoard1MotorZ.Size = new System.Drawing.Size(66, 21);
            this.comboBoard1MotorZ.TabIndex = 39;
            this.comboBoard1MotorZ.SelectedIndexChanged += new System.EventHandler(this.comboBoard1MotorZ_SelectedIndexChanged);
            // 
            // comboBoard5MotorE1
            // 
            this.comboBoard5MotorE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard5MotorE1.FormattingEnabled = true;
            this.comboBoard5MotorE1.Location = new System.Drawing.Point(361, 162);
            this.comboBoard5MotorE1.Name = "comboBoard5MotorE1";
            this.comboBoard5MotorE1.Size = new System.Drawing.Size(66, 21);
            this.comboBoard5MotorE1.TabIndex = 48;
            this.comboBoard5MotorE1.Visible = false;
            this.comboBoard5MotorE1.SelectedIndexChanged += new System.EventHandler(this.comboBoard5MotorE1_SelectedIndexChanged);
            // 
            // comboBoard4MotorE1
            // 
            this.comboBoard4MotorE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard4MotorE1.FormattingEnabled = true;
            this.comboBoard4MotorE1.Location = new System.Drawing.Point(361, 137);
            this.comboBoard4MotorE1.Name = "comboBoard4MotorE1";
            this.comboBoard4MotorE1.Size = new System.Drawing.Size(66, 21);
            this.comboBoard4MotorE1.TabIndex = 47;
            this.comboBoard4MotorE1.Visible = false;
            this.comboBoard4MotorE1.SelectedIndexChanged += new System.EventHandler(this.comboBoard4MotorE1_SelectedIndexChanged);
            // 
            // comboBoard3MotorE1
            // 
            this.comboBoard3MotorE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard3MotorE1.FormattingEnabled = true;
            this.comboBoard3MotorE1.Location = new System.Drawing.Point(361, 111);
            this.comboBoard3MotorE1.Name = "comboBoard3MotorE1";
            this.comboBoard3MotorE1.Size = new System.Drawing.Size(66, 21);
            this.comboBoard3MotorE1.TabIndex = 46;
            this.comboBoard3MotorE1.Visible = false;
            this.comboBoard3MotorE1.SelectedIndexChanged += new System.EventHandler(this.comboBoard3MotorE1_SelectedIndexChanged);
            // 
            // comboBoard2MotorE1
            // 
            this.comboBoard2MotorE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard2MotorE1.FormattingEnabled = true;
            this.comboBoard2MotorE1.Location = new System.Drawing.Point(361, 85);
            this.comboBoard2MotorE1.Name = "comboBoard2MotorE1";
            this.comboBoard2MotorE1.Size = new System.Drawing.Size(66, 21);
            this.comboBoard2MotorE1.TabIndex = 45;
            this.comboBoard2MotorE1.Visible = false;
            this.comboBoard2MotorE1.SelectedIndexChanged += new System.EventHandler(this.comboBoard2MotorE1_SelectedIndexChanged);
            // 
            // comboBoard1MotorE1
            // 
            this.comboBoard1MotorE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard1MotorE1.FormattingEnabled = true;
            this.comboBoard1MotorE1.Location = new System.Drawing.Point(361, 59);
            this.comboBoard1MotorE1.Name = "comboBoard1MotorE1";
            this.comboBoard1MotorE1.Size = new System.Drawing.Size(66, 21);
            this.comboBoard1MotorE1.TabIndex = 44;
            this.comboBoard1MotorE1.SelectedIndexChanged += new System.EventHandler(this.comboBoard1MotorE1_SelectedIndexChanged);
            // 
            // lblLayerNotice
            // 
            this.lblLayerNotice.AutoSize = true;
            this.lblLayerNotice.Location = new System.Drawing.Point(79, 199);
            this.lblLayerNotice.Name = "lblLayerNotice";
            this.lblLayerNotice.Size = new System.Drawing.Size(253, 13);
            this.lblLayerNotice.TabIndex = 49;
            this.lblLayerNotice.Text = "*For any motor you don\'t wish to use, select \'Layer 0\'";
            // 
            // lstDeleteSetupFile
            // 
            this.lstDeleteSetupFile.FormattingEnabled = true;
            this.lstDeleteSetupFile.Location = new System.Drawing.Point(454, 63);
            this.lstDeleteSetupFile.Name = "lstDeleteSetupFile";
            this.lstDeleteSetupFile.Size = new System.Drawing.Size(174, 121);
            this.lstDeleteSetupFile.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "Delete Setup File:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(454, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 23);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(79, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 50);
            this.label9.TabIndex = 53;
            this.label9.Text = "*If you can\'t select a layer/port because it says it has been selected somewhere " +
    "else, make sure it is not selected somewhere else or press reset layer/port sele" +
    "ctions.";
            // 
            // btnResetLayers
            // 
            this.btnResetLayers.Location = new System.Drawing.Point(454, 252);
            this.btnResetLayers.Name = "btnResetLayers";
            this.btnResetLayers.Size = new System.Drawing.Size(84, 23);
            this.btnResetLayers.TabIndex = 54;
            this.btnResetLayers.Text = "Reset Layers";
            this.btnResetLayers.UseVisualStyleBackColor = true;
            this.btnResetLayers.Click += new System.EventHandler(this.btnResetLayers_Click);
            // 
            // btnResetPorts
            // 
            this.btnResetPorts.Location = new System.Drawing.Point(544, 252);
            this.btnResetPorts.Name = "btnResetPorts";
            this.btnResetPorts.Size = new System.Drawing.Size(84, 23);
            this.btnResetPorts.TabIndex = 55;
            this.btnResetPorts.Text = "Reset Ports";
            this.btnResetPorts.UseVisualStyleBackColor = true;
            this.btnResetPorts.Click += new System.EventHandler(this.btnResetPorts_Click);
            // 
            // BoardSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 289);
            this.Controls.Add(this.btnResetPorts);
            this.Controls.Add(this.btnResetLayers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstDeleteSetupFile);
            this.Controls.Add(this.lblLayerNotice);
            this.Controls.Add(this.comboBoard5MotorE1);
            this.Controls.Add(this.comboBoard4MotorE1);
            this.Controls.Add(this.comboBoard3MotorE1);
            this.Controls.Add(this.comboBoard2MotorE1);
            this.Controls.Add(this.comboBoard1MotorE1);
            this.Controls.Add(this.comboBoard5MotorZ);
            this.Controls.Add(this.comboBoard4MotorZ);
            this.Controls.Add(this.comboBoard3MotorZ);
            this.Controls.Add(this.comboBoard2MotorZ);
            this.Controls.Add(this.comboBoard1MotorZ);
            this.Controls.Add(this.comboBoard5MotorY);
            this.Controls.Add(this.comboBoard4MotorY);
            this.Controls.Add(this.comboBoard3MotorY);
            this.Controls.Add(this.comboBoard2MotorY);
            this.Controls.Add(this.comboBoard1MotorY);
            this.Controls.Add(this.comboBoard5MotorX);
            this.Controls.Add(this.comboBoard4MotorX);
            this.Controls.Add(this.comboBoard3MotorX);
            this.Controls.Add(this.comboBoard2MotorX);
            this.Controls.Add(this.comboBoard1MotorX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOfLayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoard5Port);
            this.Controls.Add(this.comboBoard4Port);
            this.Controls.Add(this.comboBoard3Port);
            this.Controls.Add(this.comboBoard2Port);
            this.Controls.Add(this.comboBoard1Port);
            this.Controls.Add(this.lblBoard5);
            this.Controls.Add(this.lblBoard4);
            this.Controls.Add(this.lblBoard3);
            this.Controls.Add(this.lblBoard2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.lblBoard1);
            this.Controls.Add(this.numOfBoards);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BoardSetupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board Setup";
            this.Load += new System.EventHandler(this.BoardSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfBoards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfLayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOfBoards;
        private System.Windows.Forms.Label lblBoard1;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBoard2;
        private System.Windows.Forms.Label lblBoard3;
        private System.Windows.Forms.Label lblBoard4;
        private System.Windows.Forms.Label lblBoard5;
        private System.Windows.Forms.ComboBox comboBoard1Port;
        private System.Windows.Forms.ComboBox comboBoard2Port;
        private System.Windows.Forms.ComboBox comboBoard3Port;
        private System.Windows.Forms.ComboBox comboBoard4Port;
        private System.Windows.Forms.ComboBox comboBoard5Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOfLayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoard5MotorX;
        private System.Windows.Forms.ComboBox comboBoard4MotorX;
        private System.Windows.Forms.ComboBox comboBoard3MotorX;
        private System.Windows.Forms.ComboBox comboBoard2MotorX;
        private System.Windows.Forms.ComboBox comboBoard1MotorX;
        private System.Windows.Forms.ComboBox comboBoard5MotorY;
        private System.Windows.Forms.ComboBox comboBoard4MotorY;
        private System.Windows.Forms.ComboBox comboBoard3MotorY;
        private System.Windows.Forms.ComboBox comboBoard2MotorY;
        private System.Windows.Forms.ComboBox comboBoard1MotorY;
        private System.Windows.Forms.ComboBox comboBoard5MotorZ;
        private System.Windows.Forms.ComboBox comboBoard4MotorZ;
        private System.Windows.Forms.ComboBox comboBoard3MotorZ;
        private System.Windows.Forms.ComboBox comboBoard2MotorZ;
        private System.Windows.Forms.ComboBox comboBoard1MotorZ;
        private System.Windows.Forms.ComboBox comboBoard5MotorE1;
        private System.Windows.Forms.ComboBox comboBoard4MotorE1;
        private System.Windows.Forms.ComboBox comboBoard3MotorE1;
        private System.Windows.Forms.ComboBox comboBoard2MotorE1;
        private System.Windows.Forms.ComboBox comboBoard1MotorE1;
        private System.Windows.Forms.Label lblLayerNotice;
        private System.Windows.Forms.ListBox lstDeleteSetupFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResetLayers;
        private System.Windows.Forms.Button btnResetPorts;
    }
}