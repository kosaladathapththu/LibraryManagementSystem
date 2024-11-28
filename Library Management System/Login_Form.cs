using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox3.Text;

            // For simplicity, hardcoding the credentials here.
            // In a real application, you would retrieve these from a database.
            if ((username == "admin" && password == "admin123") ||
                (username == "librarian" && password == "lib123"))
            {
                
                Form1 mainForm = new Form1();
                this.Hide(); // Hide the login form
                mainForm.ShowDialog();
                this.Close(); // Close the login form after the main form is closed
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
