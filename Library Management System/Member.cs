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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string sql = "SELECT MAX (MemberID) FROM Members";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr.GetValue(0) == DBNull.Value)
                        {
                            this.txtmid.Text = "1";
                        }
                        else
                        {
                            this.txtmid.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                        }
                    }
                    else
                    {
                        this.txtmid.Text = "1";
                    }
                }
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "INSERT INTO Members(Name, Email, Phone, Address) VALUES(@name, @mail, @phone, @address)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);

                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Member Added Successfully", "Information");
                }
                con.Close();

                Form2_Load(this, null);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                errorProvider.SetError(txtname, "Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                errorProvider.SetError(txtemail, "Email is required.");
                isValid = false;
            }
            else if (!IsValidEmail(txtemail.Text))
            {
                errorProvider.SetError(txtemail, "Invalid email format.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                errorProvider.SetError(txtphone, "Phone number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                errorProvider.SetError(txtaddress, "Address is required.");
                isValid = false;
            }

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }




        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtmid.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtaddress.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }
    }
}
