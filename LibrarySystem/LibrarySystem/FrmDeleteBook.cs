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
    public partial class FrmDeleteBook : Form
    {
        SqlConnection sqlConnection;
        private UCBooks ucBooks;
        public FrmDeleteBook(UCBooks uCBooks)
        {
            InitializeComponent();
            String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
            sqlConnection = new SqlConnection(StringConnection);
            sqlConnection.Open();
            this.ucBooks = uCBooks;
        }

        private void FrmDeleteBook_Load(object sender, EventArgs e)
        {

        }

        private void tbDeleteBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(tbDeleteBookID.Text))
            {
          
                MessageBox.Show("Please enter a book ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbDeleteBookID.Text, out int primaryKeyValue))
            {
         
                MessageBox.Show("The book ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
    
            string selectBook = "SELECT bookName FROM Books WHERE bookID = @primaryKeyValue";
            string bookName = "";
            using (SqlCommand command = new SqlCommand(selectBook, sqlConnection))
            {
                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bookName = reader["bookName"].ToString();
                    }
                }
            }

            if (string.IsNullOrEmpty(bookName))
            {
      
                MessageBox.Show("The specified book ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkBook = "SELECT COUNT(*) FROM IssueBooks WHERE bookID = @primaryKeyValue";
            using (SqlCommand command = new SqlCommand(checkBook, sqlConnection))
            {
                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                int issuedCount = (int)command.ExecuteScalar();
                if (issuedCount > 0)
                {
                    MessageBox.Show("This book is currently issued and cannot be deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }


            DialogResult result = MessageBox.Show($"Are you sure you want to delete the book '{bookName}'?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
 
                string deleteBook = "UPDATE Books SET IsDeleted = 1 WHERE bookID = @primaryKeyValue";
                using (SqlCommand command = new SqlCommand(deleteBook, sqlConnection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Book deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                tbDeleteBookID.Clear();
            }
           
        }

        private void FrmDeleteBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucBooks.LoadBooks();
        }
    }
}

