namespace Library_Management_System
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnbookissue = new System.Windows.Forms.Button();
            this.membrreg = new System.Windows.Forms.Button();
            this.btnbookadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnbookissue);
            this.panel1.Controls.Add(this.membrreg);
            this.panel1.Controls.Add(this.btnbookadd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(108, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 328);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Returend Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnbookissue
            // 
            this.btnbookissue.BackColor = System.Drawing.Color.Red;
            this.btnbookissue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbookissue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookissue.Location = new System.Drawing.Point(336, 172);
            this.btnbookissue.Name = "btnbookissue";
            this.btnbookissue.Size = new System.Drawing.Size(200, 54);
            this.btnbookissue.TabIndex = 3;
            this.btnbookissue.Text = "Book Return";
            this.btnbookissue.UseVisualStyleBackColor = false;
            this.btnbookissue.Click += new System.EventHandler(this.btnbookissue_Click);
            // 
            // membrreg
            // 
            this.membrreg.BackColor = System.Drawing.Color.Aqua;
            this.membrreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membrreg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membrreg.Location = new System.Drawing.Point(47, 32);
            this.membrreg.Name = "membrreg";
            this.membrreg.Size = new System.Drawing.Size(200, 54);
            this.membrreg.TabIndex = 2;
            this.membrreg.Text = "Member Add";
            this.membrreg.UseVisualStyleBackColor = false;
            this.membrreg.Click += new System.EventHandler(this.membrreg_Click);
            // 
            // btnbookadd
            // 
            this.btnbookadd.BackColor = System.Drawing.Color.Blue;
            this.btnbookadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbookadd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookadd.Location = new System.Drawing.Point(336, 32);
            this.btnbookadd.Name = "btnbookadd";
            this.btnbookadd.Size = new System.Drawing.Size(200, 54);
            this.btnbookadd.TabIndex = 1;
            this.btnbookadd.Text = "Book Add";
            this.btnbookadd.UseVisualStyleBackColor = false;
            this.btnbookadd.Click += new System.EventHandler(this.btnbookadd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Book Issue ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(704, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button membrreg;
        private System.Windows.Forms.Button btnbookadd;
        private System.Windows.Forms.Button btnbookissue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
    }
}

