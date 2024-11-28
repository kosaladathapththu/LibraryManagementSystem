using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Book_Registration : Form
    {
        public Book_Registration()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Book_Registration_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();


                string sql = "SELECT MAX (BookID) FROM books";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr.GetValue(0) == DBNull.Value)
                        {
                            this.txtid.Text = "1";
                        }
                        else
                        {
                            this.txtid.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                        }
                    }
                    else
                    {
                        this.txtid.Text = "1";
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

                string sql = "INSERT INTO books(Title, Author, Genre, Availability) VALUES(@Title, @Author, @Genre, @Availability)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Title", txttitle.Text);
                cmd.Parameters.AddWithValue("@Author", txtauthor.Text);
                cmd.Parameters.AddWithValue("@Genre", txtgernre.Text);
                cmd.Parameters.AddWithValue("@Availability", cmbyn.SelectedItem.ToString());

                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Book added to the Database", "Information");
                }
                con.Close();

                Book_Registration_Load(this, null);
                //Book_Registration_Load(this, null); // Refresh the book ID field
                LoadDataIntoDataGridView(); // Refresh the DataGridView
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txttitle.Text))
            {
                errorProvider.SetError(txttitle, "Title is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtauthor.Text))
            {
                errorProvider.SetError(txtauthor, "Author is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtgernre.Text))
            {
                errorProvider.SetError(txtgernre, "Genre is required.");
                isValid = false;
            }

            if (cmbyn.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbyn, "Availability must be selected.");
                isValid = false;
            }

            return isValid;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtid.Clear();
            txttitle.Clear();
            txtauthor.Clear();
            txtgernre.Clear();
            cmbyn.SelectedIndex = -1;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sql = "SELECT * FROM books";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["BookID"].Value.ToString();
                txttitle.Text = row.Cells["Title"].Value.ToString();
                txtauthor.Text = row.Cells["Author"].Value.ToString();
                txtgernre.Text = row.Cells["Genre"].Value.ToString();
                cmbyn.SelectedItem = row.Cells["Availability"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string sql = "UPDATE books SET Title=@Title, Author=@Author, Genre=@Genre, Availability=@Availability WHERE BookID=@BookID";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@BookID", txtid.Text);
                        cmd.Parameters.AddWithValue("@Title", txttitle.Text);
                        cmd.Parameters.AddWithValue("@Author", txtauthor.Text);
                        cmd.Parameters.AddWithValue("@Genre", txtgernre.Text);
                        cmd.Parameters.AddWithValue("@Availability", cmbyn.SelectedItem.ToString());

                        int ret = cmd.ExecuteNonQuery();
                        if (ret == 1)
                        {
                            MessageBox.Show("Book updated in the Database", "Information");

                            // Refresh the DataGridView
                            LoadDataIntoDataGridView();  // ✨ Add this line to refresh the grid view
                        }
                    }
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtid.Text))
            {
                string cs = @"Data Source=AMKD-PC;Initial Catalog=Library;Integrated Security=true";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string sql = "DELETE FROM books WHERE BookID=@BookID";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@BookID", txtid.Text);

                        int ret = cmd.ExecuteNonQuery();
                        if (ret == 1)
                        {
                            MessageBox.Show("Book deleted from the Database", "Information");
                        }
                    }
                }

                ClearForm(); // Clear the form after deletion
                LoadDataIntoDataGridView(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Error");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }
    }

}      
    

