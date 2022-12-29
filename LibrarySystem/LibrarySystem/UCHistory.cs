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
    public partial class UCHistory : UserControl
    {
        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
        public UCHistory()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadHistory()
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();

                string Issuedquery = "SELECT i.issueID, i.bookID, b.bookName, i.studentID, s.studentFirstName, s.studentMiddleInitial, s.studentLastName, s.studentNumber, i.issueDate, i.dueDate FROM IssueHistory i INNER JOIN Books b ON i.bookID = b.bookID INNER JOIN Students s ON i.studentID = s.studentID"; ;

                using (SqlCommand command = new SqlCommand(Issuedquery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    table.Columns["issueID"].ColumnName = "Issue ID";
                    table.Columns["bookID"].ColumnName = "Book ID";
                    table.Columns["bookName"].ColumnName = "Book Name";
                    table.Columns["studentID"].ColumnName = "Student ID";
                    table.Columns["studentFirstName"].ColumnName = "First Name";
                    table.Columns["studentMiddleInitial"].ColumnName = "Middle Initial";
                    table.Columns["studentNumber"].ColumnName = "Student Number";
                    table.Columns["studentLastName"].ColumnName = "Last Name";
                    table.Columns["issueDate"].ColumnName = "Issue Date";
                    table.Columns["dueDate"].ColumnName = "Due Date";
                    dgvIssuedHistory.DataSource = table;
                }
                string Returnedquery = "SELECT rh.returnID, rh.issueID, rh.bookID, b.bookName, rh.studentID, s.studentFirstName, s.studentMiddleInitial, s.studentLastName, s.studentNumber, rh.issueDate, rh.dueDate, rh.returnDate FROM ReturnHistory rh INNER JOIN Books b ON rh.bookID = b.bookID INNER JOIN Students s ON rh.studentID = s.studentID"; ;

                using (SqlCommand command = new SqlCommand(Returnedquery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    table.Columns["returnID"].ColumnName = "Return ID";
                    table.Columns["issueID"].ColumnName = "Issue ID";
                    table.Columns["bookID"].ColumnName = "Book ID";
                    table.Columns["bookName"].ColumnName = "Book Name";
                    table.Columns["studentID"].ColumnName = "Student ID";
                    table.Columns["studentFirstName"].ColumnName = "First Name";
                    table.Columns["studentMiddleInitial"].ColumnName = "Middle Initial";
                    table.Columns["studentNumber"].ColumnName = "Student Number";
                    table.Columns["studentLastName"].ColumnName = "Last Name";
                    table.Columns["issueDate"].ColumnName = "Issue Date";
                    table.Columns["dueDate"].ColumnName = "Due Date";
                    table.Columns["returnDate"].ColumnName = "Return Date";
                    dgvReturnedHistory.DataSource = table;
                }
                connection.Close();
            }

        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
        public void RefreshDataGridView()
        {
            LoadHistory();
        }

        private void btnClearIssueBook_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to clear the issue and returned book history?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(StringConnection))
                {
                    connection.Open();

                    string deleteIssueHistorySql = "DELETE FROM IssueHistory";
                    using (SqlCommand deleteIssueHistoryCommand = new SqlCommand(deleteIssueHistorySql, connection))
                    {
                        deleteIssueHistoryCommand.ExecuteNonQuery();
                    }

                    string deleteReturnHistorySql = "DELETE FROM ReturnHistory";
                    using (SqlCommand deleteReturnHistoryCommand = new SqlCommand(deleteReturnHistorySql, connection))
                    {
                        deleteReturnHistoryCommand.ExecuteNonQuery();
                    }

                    string deleteDeletedBooksSql = "DELETE FROM Books WHERE IsDeleted = 1";
                    using (SqlCommand deleteDeletedBooksCommand = new SqlCommand(deleteDeletedBooksSql, connection))
                    {
                        deleteDeletedBooksCommand.ExecuteNonQuery();
                    }

                    string deleteDeletedStudentsSql = "DELETE FROM Students WHERE IsDeleted = 1";
                    using (SqlCommand deleteDeletedStudentsCommand = new SqlCommand(deleteDeletedStudentsSql, connection))
                    {
                        deleteDeletedStudentsCommand.ExecuteNonQuery();
                    }

                    LoadHistory();
                    connection.Close();
                }
            }
        }

        private void btnClearReturnedBooks_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRefreshHistory_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
