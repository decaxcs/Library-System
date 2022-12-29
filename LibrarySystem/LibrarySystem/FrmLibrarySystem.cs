using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmLibrarySystem : Form
    {

        public FrmLibrarySystem()
        {
            InitializeComponent();

        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            ucDashboard1.BringToFront();
        }
        private void UpdateBookForm_Closed(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ucDashboard2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucBooks1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucStudents1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ucIssueBooks1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucReturnBooks1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ucHistory1.BringToFront();
        }

        private void ucDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void FrmLibrarySystem_Load(object sender, EventArgs e)
        {
        }
        private void RefreshDataGridViews()
        {

        }
    }
}
