namespace MemoryKeeper
{
    partial class frmCreateNewMemory
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.pbMemory = new System.Windows.Forms.PictureBox();
            this.rTxtDescription = new System.Windows.Forms.RichTextBox();
            this.dtpMemoryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(503, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 190);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "You can use hastag(#) for your keywords.So you can search them later!";
            // 
            // nudRate
            // 
            this.nudRate.Location = new System.Drawing.Point(343, 70);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(120, 20);
            this.nudRate.TabIndex = 11;
            // 
            // pbMemory
            // 
            this.pbMemory.Location = new System.Drawing.Point(503, 96);
            this.pbMemory.Name = "pbMemory";
            this.pbMemory.Size = new System.Drawing.Size(264, 229);
            this.pbMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemory.TabIndex = 10;
            this.pbMemory.TabStop = false;
            // 
            // rTxtDescription
            // 
            this.rTxtDescription.Location = new System.Drawing.Point(12, 96);
            this.rTxtDescription.Name = "rTxtDescription";
            this.rTxtDescription.Size = new System.Drawing.Size(485, 425);
            this.rTxtDescription.TabIndex = 9;
            this.rTxtDescription.Text = "";
            // 
            // dtpMemoryDate
            // 
            this.dtpMemoryDate.Location = new System.Drawing.Point(95, 70);
            this.dtpMemoryDate.Name = "dtpMemoryDate";
            this.dtpMemoryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMemoryDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Created Date :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Select Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCreateNewMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.pbMemory);
            this.Controls.Add(this.rTxtDescription);
            this.Controls.Add(this.dtpMemoryDate);
            this.Name = "frmCreateNewMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewMemory";
            this.Load += new System.EventHandler(this.frmCreateNewMemory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.PictureBox pbMemory;
        private System.Windows.Forms.RichTextBox rTxtDescription;
        private System.Windows.Forms.DateTimePicker dtpMemoryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}