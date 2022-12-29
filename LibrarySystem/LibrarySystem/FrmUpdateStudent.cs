using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmUpdateStudent : Form
    {
        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
        private UCStudents ucStudents;
        public FrmUpdateStudent(UCStudents uCStudents)
        {
            InitializeComponent();
            this.ucStudents = uCStudents;
            cbUpdateStudentYear.SelectedIndexChanged += (sender, e) =>
            {
                if (cbUpdateStudentYear.SelectedItem.ToString().Contains("Senior High School"))
                {
                    cbUpdateStudentCourse.Items.Clear();

                    string[] seniorHighCourses = { "GAS", "ABM", "HUMSS", "STEM", "TVL" };

                    foreach (string item in seniorHighCourses)
                    {
                        cbUpdateStudentCourse.Items.Add(item);
                    }
                }
                if (cbUpdateStudentYear.SelectedItem.ToString().Contains("Year - College"))
                {
                    cbUpdateStudentCourse.Items.Clear();

                    string[] collegeCourses = { "BSA", "BSBA", "BSCS", "BSCrim", "BSENTRE", "BSFM", "BSHM", "BSIT", "BSMKT", "BSTM" };

                    foreach (string item in collegeCourses)
                    {
                        cbUpdateStudentCourse.Items.Add(item);
                    }
                }
            };
        }

        private void FrmUpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchStudentID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();
                if (string.IsNullOrEmpty(tbSearchStudentID.Text))
                {
                    MessageBox.Show("Please enter a student ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(tbSearchStudentID.Text, out int studentID))
                {
                    MessageBox.Show("The student ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string checkBook = "SELECT IsDeleted FROM Students WHERE studentID = @studentID";
                using (SqlCommand command = new SqlCommand(checkBook, connection))
                {
                    command.Parameters.AddWithValue("@studentID", tbSearchStudentID.Text);
                    object isDeleted = command.ExecuteScalar();
                    if (isDeleted != null && Convert.ToInt32(isDeleted) == 1)
                    {
                        MessageBox.Show("This student is marked as deleted and cannot be updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string searchSql = "SELECT studentFirstName, studentMiddleInitial, studentLastName, studentNumber, studentYear, studentCourse, studentEmail, studentContactNumber FROM Students WHERE studentID = @studentID";
                using (SqlCommand searchCommand = new SqlCommand(searchSql, connection))
                {
                    searchCommand.Parameters.AddWithValue("@studentID", tbSearchStudentID.Text);
                    using (SqlDataReader reader = searchCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbUpdateStudentFirstName.Text = reader.GetString(0);
                            tbUpdateStudentMiddleInitial.Text = reader.GetString(1);
                            tbUpdateStudentLastName.Text = reader.GetString(2);
                            tbUpdateStudentNumber.Text = reader.GetString(3);
                            cbUpdateStudentYear.Text = reader.GetString(4);
                            cbUpdateStudentCourse.Text = reader.GetString(5);
                            tbUpdateEmail.Text = reader.GetString(6);
                            tbUpdateContactNumber.Text = reader.GetString(7);
                        }
                        else
                        {
                            MessageBox.Show("The specified student ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                connection.Close();
            }

        }

        private void btnUpdateStudentConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbUpdateStudentFirstName.Text) || string.IsNullOrEmpty(tbUpdateStudentMiddleInitial.Text) || string.IsNullOrEmpty(tbUpdateStudentLastName.Text) || string.IsNullOrEmpty(tbUpdateStudentNumber.Text) || string.IsNullOrEmpty(cbUpdateStudentYear.Text) || string.IsNullOrEmpty(cbUpdateStudentCourse.Text) || string.IsNullOrEmpty(tbUpdateEmail.Text) || string.IsNullOrEmpty(tbUpdateContactNumber.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentNumber = tbUpdateStudentNumber.Text;
            if (studentNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Student number must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contactNumber = tbUpdateContactNumber.Text;
            if (contactNumber.Any(char.IsLetter))
            {
                MessageBox.Show("Contact number must contain only numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MailAddress email = new MailAddress(tbUpdateEmail.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid email address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbUpdateStudentMiddleInitial.Text.Length > 1)
            {
                MessageBox.Show("Middle initial must be a single letter.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this student's record?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(StringConnection))
                {
                    connection.Open();
                    string updateSql = "UPDATE Students SET studentFirstName = @firstName, studentMiddleInitial = @middleInitial, studentLastName = @lastName, studentNumber = @studentNumber, studentYear = @year, studentCourse = @course, studentEmail = @email, studentContactNumber = @contactNumber WHERE studentID = @studentID";
                    using (SqlCommand updateCommand = new SqlCommand(updateSql, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@firstName", tbUpdateStudentFirstName.Text);
                        updateCommand.Parameters.AddWithValue("@middleInitial", tbUpdateStudentMiddleInitial.Text);
                        updateCommand.Parameters.AddWithValue("@lastName", tbUpdateStudentLastName.Text);
                        updateCommand.Parameters.AddWithValue("@studentNumber", tbUpdateStudentNumber.Text);
                        updateCommand.Parameters.AddWithValue("@year", cbUpdateStudentYear.SelectedItem.ToString());
                        updateCommand.Parameters.AddWithValue("@course", cbUpdateStudentCourse.SelectedItem.ToString());
                        updateCommand.Parameters.AddWithValue("@email", tbUpdateEmail.Text);
                        updateCommand.Parameters.AddWithValue("@contactNumber", tbUpdateContactNumber.Text);
                        updateCommand.Parameters.AddWithValue("@studentID", tbSearchStudentID.Text);
                        updateCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Student record updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSearchStudentID.Clear();
                    tbUpdateStudentFirstName.Clear();
                    tbUpdateStudentMiddleInitial.Clear();
                    tbUpdateStudentLastName.Clear();
                    tbUpdateStudentNumber.Clear();
                    cbUpdateStudentYear.Text = " ";
                    cbUpdateStudentCourse.Text = " ";
                    tbUpdateEmail.Clear();
                    tbUpdateContactNumber.Clear();
                    connection.Close();
                }
            }
            }

        private void FrmUpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucStudents.LoadStudents();
        }
    }
}
