namespace LibrarySystem
{
    partial class FrmAddBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddBookConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAddBookDate = new System.Windows.Forms.DateTimePicker();
            this.tbAddBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Add Book";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "________________________________________";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAddBookConfirm
            // 
            this.btnAddBookConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBookConfirm.Location = new System.Drawing.Point(158, 331);
            this.btnAddBookConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBookConfirm.Name = "btnAddBookConfirm";
            this.btnAddBookConfirm.Size = new System.Drawing.Size(131, 47);
            this.btnAddBookConfirm.TabIndex = 25;
            this.btnAddBookConfirm.Text = "Confirm";
            this.btnAddBookConfirm.UseVisualStyleBackColor = true;
            this.btnAddBookConfirm.Click += new System.EventHandler(this.btnAddBookConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Add Date:";
            // 
            // dtpAddBookDate
            // 
            this.dtpAddBookDate.Location = new System.Drawing.Point(93, 303);
            this.dtpAddBookDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAddBookDate.Name = "dtpAddBookDate";
            this.dtpAddBookDate.Size = new System.Drawing.Size(265, 22);
            this.dtpAddBookDate.TabIndex = 23;
            // 
            // tbAddBookName
            // 
            this.tbAddBookName.ForeColor = System.Drawing.Color.Black;
            this.tbAddBookName.Location = new System.Drawing.Point(93, 134);
            this.tbAddBookName.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddBookName.Name = "tbAddBookName";
            this.tbAddBookName.Size = new System.Drawing.Size(265, 22);
            this.tbAddBookName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Book Name:";
            // 
            // tbAddQuantity
            // 
            this.tbAddQuantity.ForeColor = System.Drawing.Color.Black;
            this.tbAddQuantity.Location = new System.Drawing.Point(93, 246);
            this.tbAddQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddQuantity.Name = "tbAddQuantity";
            this.tbAddQuantity.Size = new System.Drawing.Size(265, 22);
            this.tbAddQuantity.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantity:";
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.ForeColor = System.Drawing.Color.Black;
            this.tbAddAuthor.Location = new System.Drawing.Point(93, 190);
            this.tbAddAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(265, 22);
            this.tbAddAuthor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Author:";
            // 
            // FrmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.tbAddQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddBookConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpAddBookDate);
            this.Controls.Add(this.tbAddBookName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddBook_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddBook_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddBookConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAddBookDate;
        private System.Windows.Forms.TextBox tbAddBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.Label label7;
    }
}