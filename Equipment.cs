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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        Equip eq = new Equip();

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ename.Text))
                 {
                     MessageBox.Show("Please enter the Equipment Name" , "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_ename.Focus();
                 }
            else

            try
            {
                string query = "Insert into Equipment values  ('"+txt_ename.Text+"' , '"+txt_description.Text+"' , '"+txt_muscles+"' , '"+delivery_picker.Value+"' , '"+txt_cost.Text +"' )";
                 int i = eq.save_update_delete(query);      
                if(i == 1)
                        MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                else
                    MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            View_Equipment ve = new View_Equipment();
            ve.Show();
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu mm = new Main_Menu();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_ename.Clear();
            txt_description.Clear();
            txt_muscles.Clear();
            delivery_picker.Value = DateTime.Now;
            txt_cost.Clear();
        }

        private void txt_ename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}  
