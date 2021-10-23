using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gym_Management_System
{
    public partial class View_Staff : Form
    {
        public View_Staff()
        {
            InitializeComponent();
        }

        private void View_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymManagementSystemDataSet14.NewStaff' table. You can move, or remove it, as needed.
            this.newStaffTableAdapter3.Fill(this.gymManagementSystemDataSet14.NewStaff);
            string mainconn = ConfigurationManager.ConnectionStrings["Gym_Management_System.Properties.Settings.GymManagementSystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[NewStaff]";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu mm = new Main_Menu();
            mm.Show();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Gym_Management_System.Properties.Settings.GymManagementSystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[NewStaff] where Fname like '" +txt_id.Text+ "%'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_Staff es = new Edit_Staff();
            es.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
