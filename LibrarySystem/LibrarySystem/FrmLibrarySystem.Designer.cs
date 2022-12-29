namespace LibrarySystem
{
    partial class FrmLibrarySystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ucDashboard1 = new LibrarySystem.UCDashboard();
            this.ucHistory1 = new LibrarySystem.UCHistory();
            this.ucReturnBooks1 = new LibrarySystem.UCReturnBooks();
            this.ucIssueBooks1 = new LibrarySystem.UCIssueBooks();
            this.ucStudents1 = new LibrarySystem.UCStudents();
            this.ucBooks1 = new LibrarySystem.UCBooks();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(222, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Library Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.Location = new System.Drawing.Point(6, 32);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(131, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBooks.Location = new System.Drawing.Point(6, 86);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(131, 48);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudents.Location = new System.Drawing.Point(6, 139);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(131, 48);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIssueBook.Location = new System.Drawing.Point(6, 192);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(131, 48);
            this.btnIssueBook.TabIndex = 3;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnBook.Location = new System.Drawing.Point(6, 244);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(131, 48);
            this.btnReturnBook.TabIndex = 4;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistory.Location = new System.Drawing.Point(6, 298);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(131, 48);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(6, 352);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDashboard1.BackColor = System.Drawing.Color.LightGray;
            this.ucDashboard1.Location = new System.Drawing.Point(145, 31);
            this.ucDashboard1.Margin = new System.Windows.Forms.Padding(5);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(849, 589);
            this.ucDashboard1.TabIndex = 20;
            this.ucDashboard1.TabStop = false;
            this.ucDashboard1.Load += new System.EventHandler(this.ucDashboard1_Load);
            // 
            // ucHistory1
            // 
            this.ucHistory1.BackColor = System.Drawing.Color.LightGray;
            this.ucHistory1.Location = new System.Drawing.Point(145, 31);
            this.ucHistory1.Margin = new System.Windows.Forms.Padding(5);
            this.ucHistory1.Name = "ucHistory1";
            this.ucHistory1.Size = new System.Drawing.Size(849, 589);
            this.ucHistory1.TabIndex = 19;
            this.ucHistory1.TabStop = false;
            // 
            // ucReturnBooks1
            // 
            this.ucReturnBooks1.BackColor = System.Drawing.Color.LightGray;
            this.ucReturnBooks1.Location = new System.Drawing.Point(145, 31);
            this.ucReturnBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.ucReturnBooks1.Name = "ucReturnBooks1";
            this.ucReturnBooks1.Size = new System.Drawing.Size(849, 589);
            this.ucReturnBooks1.TabIndex = 17;
            this.ucReturnBooks1.TabStop = false;
            // 
            // ucIssueBooks1
            // 
            this.ucIssueBooks1.BackColor = System.Drawing.Color.LightGray;
            this.ucIssueBooks1.Location = new System.Drawing.Point(145, 31);
            this.ucIssueBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.ucIssueBooks1.Name = "ucIssueBooks1";
            this.ucIssueBooks1.Size = new System.Drawing.Size(849, 589);
            this.ucIssueBooks1.TabIndex = 16;
            this.ucIssueBooks1.TabStop = false;
            // 
            // ucStudents1
            // 
            this.ucStudents1.BackColor = System.Drawing.Color.LightGray;
            this.ucStudents1.Location = new System.Drawing.Point(145, 31);
            this.ucStudents1.Margin = new System.Windows.Forms.Padding(2);
            this.ucStudents1.Name = "ucStudents1";
            this.ucStudents1.Size = new System.Drawing.Size(849, 589);
            this.ucStudents1.TabIndex = 15;
            this.ucStudents1.TabStop = false;
            // 
            // ucBooks1
            // 
            this.ucBooks1.BackColor = System.Drawing.Color.LightGray;
            this.ucBooks1.Location = new System.Drawing.Point(145, 31);
            this.ucBooks1.Margin = new System.Windows.Forms.Padding(2);
            this.ucBooks1.Name = "ucBooks1";
            this.ucBooks1.Size = new System.Drawing.Size(849, 589);
            this.ucBooks1.TabIndex = 18;
            this.ucBooks1.TabStop = false;
            // 
            // FrmLibrarySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucDashboard1);
            this.Controls.Add(this.ucHistory1);
            this.Controls.Add(this.ucReturnBooks1);
            this.Controls.Add(this.ucIssueBooks1);
            this.Controls.Add(this.ucStudents1);
            this.Controls.Add(this.ucBooks1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmLibrarySystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookShelf";
            this.Load += new System.EventHandler(this.FrmLibrarySystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnExit;
        private UCStudents ucStudents1;
        private UCIssueBooks ucIssueBooks1;
        private UCReturnBooks ucReturnBooks1;
        private UCBooks ucBooks1;
        private UCHistory ucHistory1;
        private UCDashboard ucDashboard1;
    }
}