using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmUpdateBook : Form
    {
        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
        private UCBooks ucBooks;
        public FrmUpdateBook(UCBooks uCBooks)
        {
            InitializeComponent();
            this.ucBooks = uCBooks;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBookID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();
                if (string.IsNullOrEmpty(tbSearchBookID.Text))
                {
                    MessageBox.Show("Please enter a book ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(tbSearchBookID.Text, out int bookID))
                {
                    MessageBox.Show("The book ID must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string checkBook = "SELECT IsDeleted FROM Books WHERE bookID = @bookID";
                using (SqlCommand command = new SqlCommand(checkBook, connection))
                {
                    command.Parameters.AddWithValue("@bookID", tbSearchBookID.Text);
                    object isDeleted = command.ExecuteScalar();
                    if (isDeleted != null && Convert.ToInt32(isDeleted) == 1)
                    {
                        MessageBox.Show("This book is marked as deleted and cannot be updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string sql = "SELECT bookName, bookAuthor, bookQuantity FROM Books WHERE bookID = @bookID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@bookID", bookID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbUpdateBookName.Text = reader.GetString(0);
                            tbUpdateAuthor.Text = reader.GetString(1);
                            tbUpdateQuantity.Text = reader.GetInt32(2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("The specified book ID was not found in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
                connection.Close();
            }
        }

        private void btnUpdateBookConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbSearchBookID.Text) || string.IsNullOrEmpty(tbUpdateBookName.Text) || string.IsNullOrEmpty(tbUpdateAuthor.Text) || string.IsNullOrEmpty(tbUpdateQuantity.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(tbUpdateQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update the book?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(StringConnection))
                {
                    connection.Open();

                    string sql = "SELECT COUNT(*) FROM Books WHERE bookName = @bookName AND bookAuthor = @bookAuthor";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@bookName", tbUpdateBookName.Text);
                        command.Parameters.AddWithValue("@bookAuthor", tbUpdateQuantity.Text);
                        int bookCount = (int)command.ExecuteScalar();

                        if (bookCount > 0)
                        {
                            MessageBox.Show("A book with the same name and author already exists in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string updateSql = "UPDATE Books SET bookName = @bookName, bookAuthor = @bookAuthor, bookQuantity = @bookQuantity WHERE bookID = @bookID";
                    using (SqlCommand updateCommand = new SqlCommand(updateSql, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@bookName", tbUpdateBookName.Text);
                        updateCommand.Parameters.AddWithValue("@bookAuthor", tbUpdateAuthor.Text);
                        updateCommand.Parameters.AddWithValue("@bookQuantity", quantity);
                        updateCommand.Parameters.AddWithValue("@bookID", tbSearchBookID.Text);
                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSearchBookID.Clear();
                    tbUpdateBookName.Clear();
                    tbUpdateAuthor.Clear();
                    tbUpdateQuantity.Clear();
                    connection.Close();
                }
            }
        }
        private void FrmUpdateBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucBooks.LoadBooks();
        }
   
        private void FrmUpdateBook_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
