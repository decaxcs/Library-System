using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem
{
    public partial class UCStudents : UserControl
    {
        FrmAddStudent frmAddStudent;
        FrmUpdateStudent frmUpdateStudent;
        FrmDeleteStudent frmDeleteStudent;
        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
        public UCStudents()
        {
            InitializeComponent();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            frmUpdateStudent = new FrmUpdateStudent(this);
            frmUpdateStudent.ShowDialog();

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            frmDeleteStudent = new FrmDeleteStudent(this);
            frmDeleteStudent.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent = new FrmAddStudent(this);
            frmAddStudent.ShowDialog();
        }

        private void UCStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Students WHERE IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    table.Columns["studentID"].ColumnName = "Student ID";
                    table.Columns["studentFirstName"].ColumnName = "First Name";
                    table.Columns["studentMiddleInitial"].ColumnName = "Middle Initial";
                    table.Columns["studentLastName"].ColumnName = "Last Name";
                    table.Columns["studentNumber"].ColumnName = "Student Number";
                    table.Columns["studentYear"].ColumnName = "Year";
                    table.Columns["studentCourse"].ColumnName = "Course";
                    table.Columns["studentEmail"].ColumnName = "Email";
                    table.Columns["studentContactNumber"].ColumnName = "Contact Number";
                    table.Columns["studentAddDate"].ColumnName = "Date Added";
                    table.Columns["studentCurrentlyRentedBooks"].ColumnName = "Currently Rented Books";

                    dgvStudents.DataSource = table;
                    dgvStudents.Columns["IsDeleted"].Visible = false;
                }
                connection.Close();
            }
        }
        private void btnRefreshStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchAndHighlightRow(tbSearchStudent.Text);
        }
        private void tbSearchStudent_GotFocus(object sender, EventArgs e)
        {
            if (tbSearchStudent.Text == "Input your student ID here.")
            {
                tbSearchStudent.Text = "";
                tbSearchStudent.ForeColor = Color.Black;
            }
        }

        private void tbSearchStudent_LostFocus(object sender, EventArgs e)
        {
            if (tbSearchStudent.Text == "")
            {
                tbSearchStudent.Text = "Input your student ID here.";
                tbSearchStudent.ForeColor = Color.Gray;
            }
        }
        public void SearchAndHighlightRow(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("The search box cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

 
            if (!searchText.All(char.IsDigit))
            {
                MessageBox.Show("Search box must contain only numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row?.Cells["Student ID"]?.Value?.ToString().Contains(searchText) == true)
                {
                    found = true;
                    row.Selected = true;
                    dgvStudents.CurrentCell = row.Cells["First Name"];
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Searched Student not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearchStudent_Enter(object sender, EventArgs e)
        {
            tbSearchStudent.Text = "";
            tbSearchStudent.ForeColor = Color.Black;
        }
    }
}
