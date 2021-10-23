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
    public partial class View_Equipment : Form
    {
        public View_Equipment()
        {
            InitializeComponent();
        }

        Equip eq = new Equip();

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Close();
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void View_Equipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymManagementSystemDataSet13.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter7.Fill(this.gymManagementSystemDataSet13.Equipment);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
