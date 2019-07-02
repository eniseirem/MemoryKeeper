namespace MemoryKeeper
{
    partial class frmMainPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.txtHastag = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstHastagList = new System.Windows.Forms.ListBox();
            this.btnSearchForHastag = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Write A  Journay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "You have entered 0 day";
            // 
            // dtSearchDate
            // 
            this.dtSearchDate.Location = new System.Drawing.Point(22, 27);
            this.dtSearchDate.Name = "dtSearchDate";
            this.dtSearchDate.Size = new System.Drawing.Size(227, 20);
            this.dtSearchDate.TabIndex = 2;
            // 
            // txtHastag
            // 
            this.txtHastag.Location = new System.Drawing.Point(6, 17);
            this.txtHastag.Name = "txtHastag";
            this.txtHastag.Size = new System.Drawing.Size(161, 20);
            this.txtHastag.TabIndex = 3;
            this.txtHastag.Text = "Enter Your hastag";
            this.txtHastag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(227, 72);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtSearchDate);
            this.groupBox1.Location = new System.Drawing.Point(2, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search with Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchForHastag);
            this.groupBox2.Controls.Add(this.lstHastagList);
            this.groupBox2.Controls.Add(this.txtHastag);
            this.groupBox2.Location = new System.Drawing.Point(307, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 458);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search with Hastag #";
            // 
            // lstHastagList
            // 
            this.lstHastagList.FormattingEnabled = true;
            this.lstHastagList.Location = new System.Drawing.Point(6, 47);
            this.lstHastagList.Name = "lstHastagList";
            this.lstHastagList.Size = new System.Drawing.Size(275, 394);
            this.lstHastagList.TabIndex = 4;
            this.lstHastagList.DoubleClick += new System.EventHandler(this.lstHastagList_DoubleClick);
            // 
            // btnSearchForHastag
            // 
            this.btnSearchForHastag.Location = new System.Drawing.Point(173, 14);
            this.btnSearchForHastag.Name = "btnSearchForHastag";
            this.btnSearchForHastag.Size = new System.Drawing.Size(108, 23);
            this.btnSearchForHastag.TabIndex = 5;
            this.btnSearchForHastag.Text = "Search for Hastag";
            this.btnSearchForHastag.UseVisualStyleBackColor = true;
            this.btnSearchForHastag.Click += new System.EventHandler(this.btnSearchForHastag_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtSearchDate;
        private System.Windows.Forms.TextBox txtHastag;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstHastagList;
        private System.Windows.Forms.Button btnSearchForHastag;
    }
}