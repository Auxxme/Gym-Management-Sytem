using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "1234")
            {
                Start st = new Start();
                st.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar== '\0')
            {
                btn_show.BringToFront();
                txt_password.PasswordChar= '*';
            }
        }

        private void btn_hide_Click_1(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }
    }
}
