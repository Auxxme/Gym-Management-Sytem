using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;




namespace Gym_Management_System
{
    public partial class New_Staff : Form
    {
        public New_Staff()
        {
            InitializeComponent();
        }

        NewStaff ns = new NewStaff();
        string gender = "";

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmb_mTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_gymTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void New_Staff_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sid.Text))
            {
                MessageBox.Show("Please enter the Staff Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sid.Focus();
            }
            else if (string.IsNullOrEmpty(txt_fname.Text))
            {
                MessageBox.Show("Please enter the Full Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fname.Focus();
            }
            else if (txt_fname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Full Name cannot be number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_fname.Focus();
            }

            else if (txt_mobile.Text.Length != 10 || txt_mobile.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Mobile number must have 10 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mobile.Focus();
            }
            else if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email. Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }
            else if (string.IsNullOrEmpty(cmb_status.Text))
            {
                MessageBox.Show("Please enter the Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_status.Focus();
            }
            else if (string.IsNullOrEmpty(txt_city.Text))
            {
                MessageBox.Show("Please enter the City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_city.Focus();
            }
            else
                try
                {
                    string query = "Insert into NewStaff values ('" + txt_sid.Text + "' , '" + txt_fname.Text + "' , '" + gender + "' , '" + dob_picker.Value + "' , '" + txt_mobile.Text + "' , '" + txt_email.Text + "' , '" + cmb_status.Text + "' , '" + txt_city.Text + "' , '" + join_picker.Value + "')";
                    int i = ns.save_update_delete(query);
                    if (i == 1)
                        MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dateTimePicker_dob_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void dateTimePicker_joinDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {  
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu mm = new Main_Menu();
            mm.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_sid.Clear();
            txt_fname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dob_picker.Value = DateTime.Now;

            txt_mobile.Clear();
            txt_email.Clear();
            cmb_status.ResetText();
            txt_city.Clear();

            join_picker.Value = DateTime.Now;
        }

        private void txt_view_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_sid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
