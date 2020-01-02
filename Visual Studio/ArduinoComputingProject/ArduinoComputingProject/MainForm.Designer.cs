namespace ArduinoComputingProject
{
    public partial class MainForm
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.btnBoardSetup = new System.Windows.Forms.Button();
            this.btnCreateEditSequence = new System.Windows.Forms.Button();
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort5 = new System.IO.Ports.SerialPort(this.components);
            this.lstSequenceFiles = new System.Windows.Forms.ListBox();
            this.lstExecutionList = new System.Windows.Forms.ListBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstBoardSetupFiles = new System.Windows.Forms.ListBox();
            this.btnAssignPorts = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBoardSetup
            // 
            this.btnBoardSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoardSetup.Location = new System.Drawing.Point(6, 255);
            this.btnBoardSetup.Name = "btnBoardSetup";
            this.btnBoardSetup.Size = new System.Drawing.Size(167, 23);
            this.btnBoardSetup.TabIndex = 28;
            this.btnBoardSetup.Text = "Board Setup";
            this.btnBoardSetup.UseVisualStyleBackColor = true;
            this.btnBoardSetup.Click += new System.EventHandler(this.btnBoardSetup_Click);
            // 
            // btnCreateEditSequence
            // 
            this.btnCreateEditSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEditSequence.Location = new System.Drawing.Point(6, 210);
            this.btnCreateEditSequence.Name = "btnCreateEditSequence";
            this.btnCreateEditSequence.Size = new System.Drawing.Size(167, 39);
            this.btnCreateEditSequence.TabIndex = 29;
            this.btnCreateEditSequence.Text = "Create/Edit Sequence";
            this.btnCreateEditSequence.UseVisualStyleBackColor = true;
            this.btnCreateEditSequence.Click += new System.EventHandler(this.btnCreateSequence_Click);
            // 
            // lstSequenceFiles
            // 
            this.lstSequenceFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSequenceFiles.FormattingEnabled = true;
            this.lstSequenceFiles.Location = new System.Drawing.Point(6, 18);
            this.lstSequenceFiles.Name = "lstSequenceFiles";
            this.lstSequenceFiles.Size = new System.Drawing.Size(167, 186);
            this.lstSequenceFiles.TabIndex = 30;
            this.lstSequenceFiles.DoubleClick += new System.EventHandler(this.lstSequenceFiles_DoubleClick);
            // 
            // lstExecutionList
            // 
            this.lstExecutionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExecutionList.FormattingEnabled = true;
            this.lstExecutionList.Location = new System.Drawing.Point(7, 18);
            this.lstExecutionList.Name = "lstExecutionList";
            this.lstExecutionList.Size = new System.Drawing.Size(167, 186);
            this.lstExecutionList.TabIndex = 32;
            this.lstExecutionList.DoubleClick += new System.EventHandler(this.lstExecutionList_DoubleClick);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(8, 210);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(166, 23);
            this.btnExecute.TabIndex = 34;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Double click a sequence to add it or remove it from the execution queue.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSequenceFiles);
            this.groupBox2.Controls.Add(this.btnBoardSetup);
            this.groupBox2.Controls.Add(this.btnCreateEditSequence);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 285);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saved Sequences";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstExecutionList);
            this.groupBox3.Controls.Add(this.btnExecute);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(197, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 240);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execution List";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstBoardSetupFiles);
            this.groupBox4.Controls.Add(this.btnAssignPorts);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(383, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 240);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Board Setup FIles";
            // 
            // lstBoardSetupFiles
            // 
            this.lstBoardSetupFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoardSetupFiles.FormattingEnabled = true;
            this.lstBoardSetupFiles.Location = new System.Drawing.Point(7, 18);
            this.lstBoardSetupFiles.Name = "lstBoardSetupFiles";
            this.lstBoardSetupFiles.Size = new System.Drawing.Size(167, 186);
            this.lstBoardSetupFiles.TabIndex = 32;
            // 
            // btnAssignPorts
            // 
            this.btnAssignPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignPorts.Location = new System.Drawing.Point(8, 210);
            this.btnAssignPorts.Name = "btnAssignPorts";
            this.btnAssignPorts.Size = new System.Drawing.Size(166, 23);
            this.btnAssignPorts.TabIndex = 34;
            this.btnAssignPorts.Text = "Assign Ports";
            this.btnAssignPorts.UseVisualStyleBackColor = true;
            this.btnAssignPorts.Click += new System.EventHandler(this.btnAssignPorts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 332);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Button btnBoardSetup;
        private System.Windows.Forms.Button btnCreateEditSequence;
        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort5;
        private System.Windows.Forms.ListBox lstSequenceFiles;
        private System.Windows.Forms.ListBox lstExecutionList;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstBoardSetupFiles;
        private System.Windows.Forms.Button btnAssignPorts;
    }
}

