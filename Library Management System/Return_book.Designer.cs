namespace Library_Management_System
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtreturn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMembername = new System.Windows.Forms.TextBox();
            this.dttoday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIssueID = new System.Windows.Forms.ComboBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Return Id";
            // 
            // txtReturnID
            // 
            this.txtReturnID.BackColor = System.Drawing.SystemColors.Control;
            this.txtReturnID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturnID.Location = new System.Drawing.Point(220, 119);
            this.txtReturnID.Multiline = true;
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.Size = new System.Drawing.Size(213, 46);
            this.txtReturnID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Due Date";
            // 
            // dtreturn
            // 
            this.dtreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtreturn.Location = new System.Drawing.Point(220, 308);
            this.dtreturn.Name = "dtreturn";
            this.dtreturn.Size = new System.Drawing.Size(187, 22);
            this.dtreturn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(287, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fine";
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.SystemColors.Control;
            this.txtFine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFine.Location = new System.Drawing.Point(364, 418);
            this.txtFine.Multiline = true;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(213, 46);
            this.txtFine.TabIndex = 9;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Fuchsia;
            this.btnreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreturn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(52, 507);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(204, 63);
            this.btnreturn.TabIndex = 10;
            this.btnreturn.Text = "Check";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(645, 507);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(204, 63);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(511, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Issue Id";
            // 
            // txtMembername
            // 
            this.txtMembername.BackColor = System.Drawing.SystemColors.Control;
            this.txtMembername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMembername.Location = new System.Drawing.Point(220, 207);
            this.txtMembername.Multiline = true;
            this.txtMembername.Name = "txtMembername";
            this.txtMembername.Size = new System.Drawing.Size(213, 50);
            this.txtMembername.TabIndex = 15;
            // 
            // dttoday
            // 
            this.dttoday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dttoday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttoday.Location = new System.Drawing.Point(671, 298);
            this.dttoday.Name = "dttoday";
            this.dttoday.Size = new System.Drawing.Size(187, 22);
            this.dttoday.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(498, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Today Date";
            // 
            // txtbookname
            // 
            this.txtbookname.BackColor = System.Drawing.SystemColors.Control;
            this.txtbookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbookname.Location = new System.Drawing.Point(645, 207);
            this.txtbookname.Multiline = true;
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(213, 50);
            this.txtbookname.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(472, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Book Name";
            // 
            // cmbIssueID
            // 
            this.cmbIssueID.BackColor = System.Drawing.SystemColors.Control;
            this.cmbIssueID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbIssueID.FormattingEnabled = true;
            this.cmbIssueID.Location = new System.Drawing.Point(645, 129);
            this.cmbIssueID.Name = "cmbIssueID";
            this.cmbIssueID.Size = new System.Drawing.Size(176, 24);
            this.cmbIssueID.TabIndex = 20;
            this.cmbIssueID.SelectedIndexChanged += new System.EventHandler(this.cmbIssueID_SelectedIndexChanged);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(349, 507);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(204, 63);
            this.btnprint.TabIndex = 21;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 82);
            this.panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(720, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Library Management System-Book Return";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Library_Management_System.Properties.Resources.home;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(886, 507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 83);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(980, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cmbIssueID);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dttoday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMembername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtreturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReturnID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReturnID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtreturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMembername;
        private System.Windows.Forms.DateTimePicker dttoday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIssueID;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}