using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class FrmLogIn : Form
    {
        Thread th;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DECA\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True");
        public FrmLogIn()
        {
            InitializeComponent();
        }

        

        public void openfrmLibrarySystem(object obj)
        {
            Application.Run(new FrmLibrarySystem());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_pw;
            username = tbUsername.Text;
            user_pw = tbPassword.Text;

            try
            {
                String check = "SELECT * FROM Login WHERE username = '" + tbUsername.Text + "' AND password = '" + tbPassword.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(check, sqlConnection);
   
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    username = tbUsername.Text;
                    user_pw = tbPassword.Text;

                    this.Close();
                    th = new Thread(openfrmLibrarySystem);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Clear();
                    tbPassword.Clear();

                    tbUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else 
            {
                this.Show();
            }
        }
    }
}
