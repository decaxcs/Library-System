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
    public partial class UCBooks : UserControl
    {
        FrmAddBook frmAddBook;
        FrmDeleteBook frmDeleteBook;

        String StringConnection = "Data Source=DECA\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
  
        public UCBooks()
        {
            InitializeComponent();
          
        }

        public void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();

                string query = "SELECT * FROM Books WHERE IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    table.Columns["bookID"].ColumnName = "Book ID";
                    table.Columns["bookName"].ColumnName = "Book Name";
                    table.Columns["bookAuthor"].ColumnName = "Author";
                    table.Columns["bookQuantity"].ColumnName = "Quantity";
                    table.Columns["bookAddDate"].ColumnName = "Date Added";
       

                    dgvBooks.DataSource = table;
                    dgvBooks.Columns["IsDeleted"].Visible = false;
                }
                connection.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        public void RefreshDataGridView()
        {
            LoadBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            frmDeleteBook = new FrmDeleteBook(this);
            frmDeleteBook.ShowDialog();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            
            FrmUpdateBook frmUpdateBook = new FrmUpdateBook(this);
            frmUpdateBook.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook = new FrmAddBook(this);
            frmAddBook.ShowDialog();
        }

        private void btnRefreshBooks_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchAndHighlightRow(tbSearchBook.Text);
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
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (row?.Cells["Book ID"]?.Value?.ToString().Contains(searchText) == true)
                {
                    found = true;
                    row.Selected = true;
                    dgvBooks.CurrentCell = row.Cells["Book Name"];
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Searched book not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearchBook_Click(object sender, EventArgs e)
        {
          
        }

        private void tbSearchBook_Enter(object sender, EventArgs e)
        {
            tbSearchBook.Text = "";
            tbSearchBook.ForeColor = Color.Black;
        }
    }
}
