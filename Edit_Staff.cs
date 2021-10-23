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

namespace Gym_Management_System
{
    public partial class Edit_Staff : Form
    {
        public Edit_Staff()
        {
            InitializeComponent();
        }

        NewStaff ns = new NewStaff();
        string gender = "";

        private void btn_update_Click(object sender, EventArgs e)
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
                string query = "Update NewStaff set Fname = '" + txt_fname.Text + "' , Gender = '" + gender + "' , Dob = '" + dob_picker.Value + "' , Mobile = '" + txt_mobile.Text + "' , Email = '" + txt_email.Text + "' , Status = '" + cmb_status.Text + "' , City = '" + txt_city.Text + "' , JoinDate = '" + join_picker.Value + "' where StaffId = '" + txt_sid.Text + "'";
                int i = ns.save_update_delete(query);
                if (i == 1)
                    MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            View_Staff vs = new View_Staff();
            vs.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Delete this Data?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete from NewStaff where StaffId = '" + txt_sid.Text + "'";
                    int i = ns.save_update_delete(query);
                    if (i == 1)
                        MessageBox.Show(this, "Data Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }
            
        }

        private void Edit_Staff_Load(object sender, EventArgs e)
        {

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

        private void txt_sid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
