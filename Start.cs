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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Main_Menu db = new Main_Menu();
            db.Show();
        }
    }
}
