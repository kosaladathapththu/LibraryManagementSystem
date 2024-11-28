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
    public partial class reportgenarate : Form
    {
        public reportgenarate()
        {
            InitializeComponent();
        }

        private void reportgenarate_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=AMKD-PC;Initial catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Get data from Returnbooks table
            string sql = "SELECT ReturnID, IssueID, Membename, Fine FROM Returnbooks";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            // Bind data with the crystal report
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"D:\Working\Library Management System\Library Management System\Report.rpt");
            rpt.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer1.ReportSource = rpt;

            con.Close();
        }
    }
}
