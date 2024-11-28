using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            dttoday.Value = DateTime.Now;

            // Generate ReturnID
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT MAX(ReturnID) FROM Returnbooks";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr.GetValue(0).ToString() == "")
                {
                    txtReturnID.Text = "1";
                }
                else
                {
                    txtReturnID.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                }
            }
            else
            {
                txtReturnID.Text = "1";
            }
            con.Close();

            // Load IssueIDs into cmbIssueID
            con.Open();
            string sqlIssueIDs = "SELECT IssueID FROM Issuebooks";
            SqlCommand cmdIssueIDs = new SqlCommand(sqlIssueIDs, con);
            SqlDataReader drIssueIDs = cmdIssueIDs.ExecuteReader();
            while (drIssueIDs.Read())
            {
                cmbIssueID.Items.Add(drIssueIDs["IssueID"].ToString());
            }
            con.Close();

        }

        private void cmbIssueID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load member name, return date based on IssueID
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT Membername,Bookname,ReturnDate FROM Issuebooks WHERE IssueID = @issueID";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@issueID", cmbIssueID.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMembername.Text = dr["MemberName"].ToString();
                txtbookname.Text = dr["BookName"].ToString();
                dtreturn.Value = Convert.ToDateTime(dr["ReturnDate"]);
            }

            con.Close();

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            // Check if the book is already returned
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string checkSql = "SELECT COUNT(*) FROM Returnbooks WHERE IssueID = @issueID";
            SqlCommand checkCmd = new SqlCommand(checkSql, con);
            checkCmd.Parameters.AddWithValue("@issueID", cmbIssueID.Text);

            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("You returned it previously.", "Notification");
                con.Close();
                return; // Exit the method if the book was already returned
            }

            con.Close();

            // Calculate fine
            TimeSpan overdue = dttoday.Value - dtreturn.Value;
            int fine = (overdue.Days > 0) ? overdue.Days * 5 : 0;
            txtFine.Text = fine.ToString();

            // Notify user if there is a fine
            if (fine > 0)
            {
                MessageBox.Show($"You have a fine of Rs.{fine}.", "Fine Notification");
            }

            // Insert return data into Returnbooks table
            con.Open();
            string sql = "INSERT INTO Returnbooks (IssueID, Membename, Bookname, Fine) VALUES (@issueID, @memberName, @bname, @fine)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@issueID", cmbIssueID.Text);
            cmd.Parameters.AddWithValue("@memberName", txtMembername.Text);
            cmd.Parameters.AddWithValue("@bname", txtbookname.Text);
            cmd.Parameters.AddWithValue("@fine", fine);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Book returned successfully.", "Information");

            con.Close();
        }

        /* private void btnclear_Click(object sender, EventArgs e)
         {
             // Clear all fields
             txtReturnID.Clear();
             cmbIssueID.SelectedIndex = -1;
             txtMembername.Clear();
             txtbookname.Clear();
             dtreturn.Value = DateTime.Now;
             dttoday.Value = DateTime.Now;
             txtFine.Clear();

             // Regenerate ReturnID
             ReturnBooks_Load(sender, e);
         }
        */
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            reportgenarate reportForm = new reportgenarate();
            reportForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }
    }
}