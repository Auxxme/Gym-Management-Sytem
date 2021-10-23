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
    public partial class View_Member : Form
    {
        public View_Member()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymManagementSystemDataSet12.NeMember' table. You can move, or remove it, as needed.
            this.neMemberTableAdapter.Fill(this.gymManagementSystemDataSet12.NeMember);
            string mainconn = ConfigurationManager.ConnectionStrings["Gym_Management_System.Properties.Settings.GymManagementSystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[NeMember]";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu mm = new Main_Menu();
            mm.Show();
        }

        private void Search_Member_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mid_TextChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Gym_Management_System.Properties.Settings.GymManagementSystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[NeMember] where Fname like '" + txt_mid.Text + "%'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        public SqlConnection sqlcon { get; set; }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_Member em = new Edit_Member();
            em.Show();
        }
    }
} 
