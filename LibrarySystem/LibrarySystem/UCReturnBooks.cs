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
    public partial class UCReturnBooks : UserControl
    {
        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
        public UCReturnBooks()
        {
            InitializeComponent();
        }

        private void btnReturnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();
                if (string.IsNullOrEmpty(tbReturnStudentID.Text) || string.IsNullOrEmpty(tbReturnBookID.Text))
                {
                    MessageBox.Show("Please enter a student ID and a book ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(tbReturnStudentID.Text, out int studentID) || !int.TryParse(tbReturnBookID.Text, out int bookID))
                {
                    MessageBox.Show("The student ID and book ID must be numeric values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sql = "SELECT COUNT(*) FROM IssueBooks WHERE studentID = @studentID AND bookID = @bookID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.Parameters.AddWithValue("@bookID", bookID);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("The specified student ID and book ID combination was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DialogResult result = MessageBox.Show("Do you want to return the book?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string getIssueSql = "SELECT issueID, issueDate, dueDate FROM IssueBooks WHERE studentID = @studentID AND bookID = @bookID";
                    using (SqlCommand getIssueCommand = new SqlCommand(getIssueSql, connection))
                    {
                        getIssueCommand.Parameters.AddWithValue("@studentID", tbReturnStudentID.Text);
                        getIssueCommand.Parameters.AddWithValue("@bookID", tbReturnBookID.Text);
                        using (SqlDataReader reader = getIssueCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int issueID = reader.GetInt32(0);
                                DateTime issueDate = reader.GetDateTime(1);
                                DateTime dueDate = reader.GetDateTime(2);
                                reader.Close();
                                string insertHistorySql = "INSERT INTO ReturnHistory (issueID, bookID, studentID, issueDate, dueDate, returnDate) VALUES (@issueID, @bookID, @studentID, @issueDate, @dueDate, @returnDate)";
                                using (SqlCommand insertHistoryCommand = new SqlCommand(insertHistorySql, connection))
                                {
                                    insertHistoryCommand.Parameters.AddWithValue("@issueID", issueID);
                                    insertHistoryCommand.Parameters.AddWithValue("@bookID", tbReturnBookID.Text);
                                    insertHistoryCommand.Parameters.AddWithValue("@studentID", tbReturnStudentID.Text);
                                    insertHistoryCommand.Parameters.AddWithValue("@issueDate", issueDate);
                                    insertHistoryCommand.Parameters.AddWithValue("@dueDate", dueDate);
                                    insertHistoryCommand.Parameters.AddWithValue("@returnDate", dtpReturnDate.Value);
                                    insertHistoryCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    string deleteSql = "DELETE FROM IssueBooks WHERE studentID = @studentID AND bookID = @bookID";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteSql, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@studentID", tbReturnStudentID.Text);
                        deleteCommand.Parameters.AddWithValue("@bookID", tbReturnBookID.Text);
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Book returned successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string updateBooksSql = "UPDATE Books SET bookQuantity = bookQuantity + 1 WHERE bookID = @bookID";
                    using (SqlCommand updateBooksCommand = new SqlCommand(updateBooksSql, connection))
                    {
                        updateBooksCommand.Parameters.AddWithValue("@bookID", tbReturnBookID.Text);
                        updateBooksCommand.ExecuteNonQuery();
                    }
                    string updateStudentsSql = "UPDATE Students SET studentCurrentlyRentedBooks = studentCurrentlyRentedBooks - 1 WHERE studentID = @studentID";
                    using (SqlCommand updateStudentsCommand = new SqlCommand(updateStudentsSql, connection))
                    {
                        updateStudentsCommand.Parameters.AddWithValue("@studentID", tbReturnStudentID.Text);
                        updateStudentsCommand.ExecuteNonQuery();
                    }
                    
                    tbReturnBookID.Clear();
                    tbReturnStudentID.Clear();
                    dtpReturnDate.Value = DateTime.Now;
                }
                connection.Close();
            }
        }
    }
}
