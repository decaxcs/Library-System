namespace LibrarySystem
{
    partial class UCHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIssuedHistory = new System.Windows.Forms.DataGridView();
            this.dgvReturnedHistory = new System.Windows.Forms.DataGridView();
            this.btnClearIssueBook = new System.Windows.Forms.Button();
            this.btnRefreshHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-5, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Issued Books:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Returned Books:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvIssuedHistory
            // 
            this.dgvIssuedHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssuedHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedHistory.Location = new System.Drawing.Point(0, 56);
            this.dgvIssuedHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIssuedHistory.Name = "dgvIssuedHistory";
            this.dgvIssuedHistory.ReadOnly = true;
            this.dgvIssuedHistory.RowHeadersWidth = 51;
            this.dgvIssuedHistory.Size = new System.Drawing.Size(888, 228);
            this.dgvIssuedHistory.TabIndex = 13;
            this.dgvIssuedHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvReturnedHistory
            // 
            this.dgvReturnedHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnedHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnedHistory.Location = new System.Drawing.Point(0, 341);
            this.dgvReturnedHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReturnedHistory.Name = "dgvReturnedHistory";
            this.dgvReturnedHistory.ReadOnly = true;
            this.dgvReturnedHistory.RowHeadersWidth = 51;
            this.dgvReturnedHistory.Size = new System.Drawing.Size(888, 228);
            this.dgvReturnedHistory.TabIndex = 14;
            // 
            // btnClearIssueBook
            // 
            this.btnClearIssueBook.Location = new System.Drawing.Point(761, 0);
            this.btnClearIssueBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearIssueBook.Name = "btnClearIssueBook";
            this.btnClearIssueBook.Size = new System.Drawing.Size(131, 47);
            this.btnClearIssueBook.TabIndex = 19;
            this.btnClearIssueBook.Text = "Clear History";
            this.btnClearIssueBook.UseVisualStyleBackColor = true;
            this.btnClearIssueBook.Click += new System.EventHandler(this.btnClearIssueBook_Click);
            // 
            // btnRefreshHistory
            // 
            this.btnRefreshHistory.Location = new System.Drawing.Point(624, 0);
            this.btnRefreshHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshHistory.Name = "btnRefreshHistory";
            this.btnRefreshHistory.Size = new System.Drawing.Size(131, 47);
            this.btnRefreshHistory.TabIndex = 23;
            this.btnRefreshHistory.Text = "Refresh";
            this.btnRefreshHistory.UseVisualStyleBackColor = true;
            this.btnRefreshHistory.Click += new System.EventHandler(this.btnRefreshHistory_Click);
            // 
            // UCHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnRefreshHistory);
            this.Controls.Add(this.btnClearIssueBook);
            this.Controls.Add(this.dgvIssuedHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvReturnedHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(892, 597);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIssuedHistory;
        private System.Windows.Forms.DataGridView dgvReturnedHistory;
        private System.Windows.Forms.Button btnClearIssueBook;
        private System.Windows.Forms.Button btnRefreshHistory;
    }
}
