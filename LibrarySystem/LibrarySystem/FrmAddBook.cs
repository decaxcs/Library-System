using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmAddBook : Form
    {
        SqlConnection sqlConnection;
        private UCBooks ucBooks;

        public FrmAddBook(UCBooks uCBooks)
        {
            InitializeComponent();
            String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
            sqlConnection = new SqlConnection(StringConnection);
            sqlConnection.Open();
            this.ucBooks = uCBooks;

        }

        private void btnAddBookConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddBookName.Text) || string.IsNullOrEmpty(tbAddAuthor.Text) || string.IsNullOrEmpty(tbAddQuantity.Text))
            {
                MessageBox.Show("Please ensure that all fields are filled out.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(tbAddQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a numeric value.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "SELECT COUNT(*) FROM Books WHERE bookName = @bookName AND bookAuthor = @bookAuthor";
            using (SqlCommand command = new SqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@bookName", tbAddBookName.Text);
                command.Parameters.AddWithValue("@bookAuthor", tbAddAuthor.Text);
                int bookCount = (int)command.ExecuteScalar();

                if (bookCount > 0)
                {
                    MessageBox.Show("A book with the same name and author already exists in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to add this book?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Book added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string bookName = tbAddBookName.Text;
                string bookAuthor = tbAddAuthor.Text;

                char[] bookNameArray = bookName.ToCharArray();
                bookNameArray[0] = char.ToUpper(bookNameArray[0]);
                bookName = new string(bookNameArray);

                char[] bookAuthorArray = bookAuthor.ToCharArray();
                bookAuthorArray[0] = char.ToUpper(bookAuthorArray[0]);
                bookAuthor = new string(bookAuthorArray);

                tbAddBookName.Text = bookName;
                tbAddAuthor.Text = bookAuthor;

                string query = "INSERT INTO Books (bookName, bookAuthor, bookQuantity, bookAddDate) VALUES (@value1, @value2, @value3, @value4)";
                using (SqlCommand sqlCcommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCcommand.Parameters.AddWithValue("@value1", tbAddBookName.Text);
                    sqlCcommand.Parameters.AddWithValue("@value2", tbAddAuthor.Text);
                    sqlCcommand.Parameters.AddWithValue("@value3", tbAddQuantity.Text);
                    sqlCcommand.Parameters.AddWithValue("@value4", dtpAddBookDate.Value);

                    int rowsAffected = sqlCcommand.ExecuteNonQuery();
                }

                this.Show();
                tbAddBookName.Clear();
                tbAddAuthor.Clear();
                tbAddQuantity.Clear();
                dtpAddBookDate.Value = DateTime.Today;
            }
            sqlConnection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {

        }

        private void FrmAddBook_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucBooks.LoadBooks();
        }
    }
}
