namespace ArduinoComputingProject
{
    partial class CreateEditSequenceForm
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
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveToNewFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSequenceFiles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDeleteSequenceFile = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOverwriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSequence
            // 
            this.txtSequence.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSequence.Location = new System.Drawing.Point(15, 28);
            this.txtSequence.Multiline = true;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSequence.Size = new System.Drawing.Size(390, 329);
            this.txtSequence.TabIndex = 0;
            this.txtSequence.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnSaveToNewFile
            // 
            this.btnSaveToNewFile.Location = new System.Drawing.Point(15, 363);
            this.btnSaveToNewFile.Name = "btnSaveToNewFile";
            this.btnSaveToNewFile.Size = new System.Drawing.Size(103, 23);
            this.btnSaveToNewFile.TabIndex = 2;
            this.btnSaveToNewFile.Text = "Save to New File";
            this.btnSaveToNewFile.UseVisualStyleBackColor = true;
            this.btnSaveToNewFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(233, 363);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(103, 23);
            this.btnLoadFromFile.TabIndex = 3;
            this.btnLoadFromFile.Text = "Load from File";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(342, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create/Edit Sequence:";
            // 
            // lstSequenceFiles
            // 
            this.lstSequenceFiles.FormattingEnabled = true;
            this.lstSequenceFiles.Location = new System.Drawing.Point(411, 28);
            this.lstSequenceFiles.Name = "lstSequenceFiles";
            this.lstSequenceFiles.Size = new System.Drawing.Size(155, 329);
            this.lstSequenceFiles.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select File to Edit:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(252, 414);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delete File:";
            // 
            // lstDeleteSequenceFile
            // 
            this.lstDeleteSequenceFile.FormattingEnabled = true;
            this.lstDeleteSequenceFile.Location = new System.Drawing.Point(572, 28);
            this.lstDeleteSequenceFile.Name = "lstDeleteSequenceFile";
            this.lstDeleteSequenceFile.Size = new System.Drawing.Size(155, 329);
            this.lstDeleteSequenceFile.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(572, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOverwriteFile
            // 
            this.btnOverwriteFile.Location = new System.Drawing.Point(124, 363);
            this.btnOverwriteFile.Name = "btnOverwriteFile";
            this.btnOverwriteFile.Size = new System.Drawing.Size(103, 23);
            this.btnOverwriteFile.TabIndex = 12;
            this.btnOverwriteFile.Text = "Overwrite File";
            this.btnOverwriteFile.UseVisualStyleBackColor = true;
            this.btnOverwriteFile.Click += new System.EventHandler(this.btnOverwriteFile_Click);
            // 
            // CreateEditSequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 449);
            this.Controls.Add(this.btnOverwriteFile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDeleteSequenceFile);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSequenceFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveToNewFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSequence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateEditSequenceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create/Edit Sequence";
            this.Activated += new System.EventHandler(this.CreateEditSequenceForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEditSequenceForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateSequenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveToNewFile;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSequenceFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDeleteSequenceFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOverwriteFile;
    }
}