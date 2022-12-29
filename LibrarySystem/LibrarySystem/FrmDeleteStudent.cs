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

namespace LibrarySystem
{
    public partial class FrmDeleteStudent : Form
    {
        SqlConnection sqlConnection;
        UCBooks uCBooks = new UCBooks();
        private UCStudents ucStudents;
        public FrmDeleteStudent(UCStudents uCStudents)
        {
            InitializeComponent();
            String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
            sqlConnection = new SqlConnection(StringConnection);
            sqlConnection.Open();
            this.ucStudents = uCStudents;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbDeleteStudentID.Text))
            {

                MessageBox.Show("Please enter a student ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbDeleteStudentID.Text, out int primaryKeyValue))
            {

                MessageBox.Show("The student ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectStudent = "SELECT studentFirstName, studentMiddleInitial, studentLastName FROM Students WHERE studentID = @primaryKeyValue";
            string studentName = "";
            using (SqlCommand command = new SqlCommand(selectStudent, sqlConnection))
            {
                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader["studentFirstName"].ToString();
                        string middleInitial = reader["studentMiddleInitial"].ToString();
                        string lastName = reader["studentLastName"].ToString();
                        studentName = $"{firstName} {middleInitial} {lastName}";
                    }
                }
            }

            if (string.IsNullOrEmpty(studentName))
            {

                MessageBox.Show("The specified student ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkStudent = "SELECT COUNT(*) FROM IssueBooks WHERE studentID = @studentID";
            using (SqlCommand command = new SqlCommand(checkStudent, sqlConnection))
            {
                command.Parameters.AddWithValue("@studentID", primaryKeyValue);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
            
                    MessageBox.Show("The student cannot be deleted because they have a book currently issued.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the student '{studentName}'?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                string deleteStudent = "UPDATE Students SET IsDeleted = 1 WHERE studentID = @primaryKeyValue";
                using (SqlCommand command = new SqlCommand(deleteStudent, sqlConnection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Student deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                tbDeleteStudentID.Clear();
            }
            sqlConnection.Close();
        }

        private void FrmDeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void FrmDeleteStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucStudents.LoadStudents();
        }
    }
}
