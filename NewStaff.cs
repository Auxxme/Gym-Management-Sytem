using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gym_Management_System
{
    class NewStaff
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public NewStaff()  
        {
            con = new SqlConnection("Data Source=DESKTOP-A134ED6;Initial Catalog=GymManagementSystem;Integrated Security=True");
        }
        public void openConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
        public int save_update_delete(string a)
        {
            openConnection();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            closeConnection();
            return i;
        }
        public DataTable getData(string a)
        {
            openConnection();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }
    }
}
