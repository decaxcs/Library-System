using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class UCDashboard : UserControl
    {
        SqlConnection sqlConnection;
        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(StringConnection);
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM Books";
                SqlCommand command = new SqlCommand(sql, connection);
                int count = (int)command.ExecuteScalar();

                sql = "SELECT COUNT(*) FROM Students";
                command = new SqlCommand(sql, connection);
                int count2 = (int)command.ExecuteScalar();

                lblNumberOfBooks.Text = count.ToString();
                lblNumberOfStudents.Text = count2.ToString();
            }
        }
    }
}
