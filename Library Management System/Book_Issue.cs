using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class Book_Issue : Form
    {
        public Book_Issue()
        {
            InitializeComponent();
        }

        private void Book_Issue_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKD-PC;Initial catalog=Library;Integrated Security=true";

            //Create Issue ID
            SqlConnection con2 = new SqlConnection(cs);
            con2.Open();


            string sql2 = "SELECT MAX(IssueID) FROM Issuebooks";
            SqlCommand com2 = new SqlCommand(sql2, con2);

            SqlDataReader dr2 = com2.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2.GetValue(0).ToString() == "")
                {
                    this.txtissueid.Text = "1";
                }
                else
                {
                    this.txtissueid.Text = (Convert.ToInt32(dr2.GetValue(0).ToString()) + 1).ToString();
                }
            }
            else
            {
                this.txtissueid.Text = "1";
            }
            con2.Close();

            //MemberIDs inset to member Id
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT MemberID FROM Members";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                this.cmbmemberid.Items.Add(dr.GetValue(0));
            }
            con.Close();

            //BookIds insert to book Id 
            SqlConnection con1 = new SqlConnection(cs);
            con1.Open();

            string sql1 = "SELECT BookID FROM books";
            SqlCommand com1 = new SqlCommand(sql1, con1);

            SqlDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                this.cmbbookid.Items.Add(dr1.GetValue(0));
            }
            con1.Close();
             
        }

       
        private void cmbmemberid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //data insert to member Name
            string cs = @"Data Source=AMKD-PC;Initial catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT Name FROM Members WHERE MemberID=@memid";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@memid", this.cmbmemberid.Text);

            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            this.txtmname.Text = dr.GetValue(0).ToString();
            con.Close();
        }

        private void cmbbookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //data inset For Book Name
            string cs1 = @"Data Source=AMKD-PC;Initial catalog=Library;Integrated Security=true";
            SqlConnection con1 = new SqlConnection(cs1);
            con1.Open();

            string sql1 = "SELECT Title FROM books WHERE BookID=@bookid";
            SqlCommand com1 = new SqlCommand(sql1, con1);
            com1.Parameters.AddWithValue("@bookid", this.cmbbookid.Text);

            SqlDataReader dr1 = com1.ExecuteReader();
            dr1.Read();

            this.txtbname.Text = dr1.GetValue(0).ToString();
            con1.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Issuebooks(Membername,Bookname,IssueDate,ReturnDate) VALUES(@mname, @bname,@issdt,@rtdt)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@txtmid", Convert.ToInt32(txtid.Text));
            cmd.Parameters.AddWithValue("@mname", txtmname.Text);
            cmd.Parameters.AddWithValue("@bname", txtbname.Text);
            cmd.Parameters.AddWithValue("@issdt", dtissue.Text);
            cmd.Parameters.AddWithValue("@rtdt", dtreturn.Text);

            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Book Issued", "Information");
            }
            con.Close();

            string sqlSelect = "SELECT IssueID, MemberName, BookName, IssueDate, ReturnDate FROM Issuebooks WHERE IssueID = (SELECT MAX(IssueID) FROM Issuebooks)";
            SqlCommand cmdSelect = new SqlCommand(sqlSelect, con);
            {
                SqlDataAdapter dap = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];
            }

            // Call to Load Event
            Book_Issue_Load(this, null);



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtissueid.Clear();
            txtbname.Clear();
            txtmname.Clear();


        }

        private void btnview_Click(object sender, EventArgs e)

        {
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // SQL query to fetch data
                string sql = "SELECT * FROM books";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Use SqlDataAdapter to fetch data
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    // Bind DataSet to DataGridView
                    this.dataGridView1.DataSource = ds.Tables[0];
                }

                con.Close();

            }

        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }

         
    }
    
}
