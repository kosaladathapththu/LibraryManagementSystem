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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooksForm = new ReturnBooks();
            returnBooksForm.ShowDialog();
        }

        private void issuBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Issue returnBooksForm = new Book_Issue();
            returnBooksForm.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member returnBooksForm = new Member();
            returnBooksForm.ShowDialog();
        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Book_Registration returnBooksForm = new Book_Registration();
            returnBooksForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       /* private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } */

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Issue returnBooksForm = new Book_Issue();
            returnBooksForm.ShowDialog();
        }

        private void membrreg_Click(object sender, EventArgs e)
        {
            Member returnBooksForm = new Member();
            returnBooksForm.ShowDialog();
        }

        private void btnbookadd_Click(object sender, EventArgs e)
        {
            Book_Registration returnBooksForm = new Book_Registration();
            returnBooksForm.ShowDialog();
        }

        private void btnbookissue_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooksForm = new ReturnBooks();
            returnBooksForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportgenarate reportForm = new reportgenarate();
            reportForm.Show();
        }
    }
    
}
