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
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
        }

        NewMember nm = new NewMember();
        string gender = "";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu mm = new Main_Menu();
            mm.Show();
        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mid.Text))
            {
                MessageBox.Show("Please enter the Member Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mid.Focus();
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
            else if (string.IsNullOrEmpty(cmb_mTime.Text))
            {
                MessageBox.Show("Please Enter Membership Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_mTime.Focus();
            }
            else if (string.IsNullOrEmpty(cmb_gymTime.Text))
            {
                MessageBox.Show("Please Enter Gym Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_gymTime.Focus();
            }
            else if (string.IsNullOrEmpty(txt_address.Text))
            {
                MessageBox.Show("Address cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address.Focus();
            }
            else
                try
                {
                    string query = "Insert into NeMember values ('" + txt_mid.Text + "' , '" + txt_fname.Text + "' , '" + gender + "' , '" + dob_picker.Value + "' , '" + txt_mobile.Text + "' , '" + txt_email.Text + "' , '" + cmb_mTime.Text + "' , '" + join_picker.Value + "' , '" + cmb_gymTime.Text + "' , '" + txt_address.Text + "')";
                    int i = nm.save_update_delete(query);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_mid.Clear();
            txt_fname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dob_picker.Value = DateTime.Now;

            txt_mobile.Clear();
            txt_email.Clear();

            cmb_mTime.ResetText();

            join_picker.Value = DateTime.Now;

            cmb_gymTime.ResetText();

            txt_address.Clear();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
