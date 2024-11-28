namespace Library_Management_System
{
    partial class Book_Issue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Issue));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtissueid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.dtissue = new System.Windows.Forms.DateTimePicker();
            this.dtreturn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.cmbmemberid = new System.Windows.Forms.ComboBox();
            this.cmbbookid = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(876, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue ID";
            // 
            // txtissueid
            // 
            this.txtissueid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtissueid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtissueid.Location = new System.Drawing.Point(183, 138);
            this.txtissueid.Multiline = true;
            this.txtissueid.Name = "txtissueid";
            this.txtissueid.Size = new System.Drawing.Size(197, 36);
            this.txtissueid.TabIndex = 2;
            this.txtissueid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member ID";
            // 
            // txtmname
            // 
            this.txtmname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(457, 226);
            this.txtmname.Multiline = true;
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(317, 36);
            this.txtmname.TabIndex = 6;
            this.txtmname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmname.TextChanged += new System.EventHandler(this.txtmname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Issue Date";
            // 
            // txtbname
            // 
            this.txtbname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbname.Location = new System.Drawing.Point(457, 326);
            this.txtbname.Multiline = true;
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(317, 36);
            this.txtbname.TabIndex = 12;
            // 
            // dtissue
            // 
            this.dtissue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtissue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtissue.Location = new System.Drawing.Point(197, 443);
            this.dtissue.Name = "dtissue";
            this.dtissue.Size = new System.Drawing.Size(144, 22);
            this.dtissue.TabIndex = 13;
            this.dtissue.Value = new System.DateTime(2024, 7, 14, 19, 26, 19, 0);
            // 
            // dtreturn
            // 
            this.dtreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtreturn.Location = new System.Drawing.Point(580, 442);
            this.dtreturn.Name = "dtreturn";
            this.dtreturn.Size = new System.Drawing.Size(144, 22);
            this.dtreturn.TabIndex = 15;
            this.dtreturn.Value = new System.DateTime(2024, 7, 14, 19, 26, 19, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Return Date";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(492, 598);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(172, 55);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Issue";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Aqua;
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(169, 598);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(172, 55);
            this.btnview.TabIndex = 17;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Blue;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(802, 598);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(172, 55);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(1148, 598);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(172, 55);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cmbmemberid
            // 
            this.cmbmemberid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbmemberid.FormattingEnabled = true;
            this.cmbmemberid.Location = new System.Drawing.Point(183, 237);
            this.cmbmemberid.Name = "cmbmemberid";
            this.cmbmemberid.Size = new System.Drawing.Size(214, 24);
            this.cmbmemberid.TabIndex = 21;
            this.cmbmemberid.SelectedIndexChanged += new System.EventHandler(this.cmbmemberid_SelectedIndexChanged);
            // 
            // cmbbookid
            // 
            this.cmbbookid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbbookid.FormattingEnabled = true;
            this.cmbbookid.Location = new System.Drawing.Point(183, 337);
            this.cmbbookid.Name = "cmbbookid";
            this.cmbbookid.Size = new System.Drawing.Size(214, 24);
            this.cmbbookid.TabIndex = 22;
            this.cmbbookid.SelectedIndexChanged += new System.EventHandler(this.cmbbookid_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Management_System.Properties.Resources.home;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1421, 641);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 85);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 82);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(693, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Library Management System-Book Issue";
            // 
            // Book_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1525, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbbookid);
            this.Controls.Add(this.cmbmemberid);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtreturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtissue);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtissueid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Book_Issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Issue";
            this.Load += new System.EventHandler(this.Book_Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtissueid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.DateTimePicker dtissue;
        private System.Windows.Forms.DateTimePicker dtreturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbmemberid;
        private System.Windows.Forms.ComboBox cmbbookid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}