namespace LibrarySystem
{
    partial class FrmUpdateBook
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
            this.btnUpdateBookConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUpdateBookName = new System.Windows.Forms.TextBox();
            this.tbUpdateQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBookID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateBookConfirm
            // 
            this.btnUpdateBookConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateBookConfirm.Location = new System.Drawing.Point(158, 359);
            this.btnUpdateBookConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateBookConfirm.Name = "btnUpdateBookConfirm";
            this.btnUpdateBookConfirm.Size = new System.Drawing.Size(131, 47);
            this.btnUpdateBookConfirm.TabIndex = 36;
            this.btnUpdateBookConfirm.Text = "Update";
            this.btnUpdateBookConfirm.UseVisualStyleBackColor = true;
            this.btnUpdateBookConfirm.Click += new System.EventHandler(this.btnUpdateBookConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Book Name:";
            // 
            // tbUpdateBookName
            // 
            this.tbUpdateBookName.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateBookName.Location = new System.Drawing.Point(93, 219);
            this.tbUpdateBookName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUpdateBookName.Name = "tbUpdateBookName";
            this.tbUpdateBookName.Size = new System.Drawing.Size(265, 22);
            this.tbUpdateBookName.TabIndex = 27;
            // 
            // tbUpdateQuantity
            // 
            this.tbUpdateQuantity.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateQuantity.Location = new System.Drawing.Point(93, 331);
            this.tbUpdateQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbUpdateQuantity.Name = "tbUpdateQuantity";
            this.tbUpdateQuantity.Size = new System.Drawing.Size(265, 22);
            this.tbUpdateQuantity.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Update Book";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Author:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbUpdateAuthor
            // 
            this.tbUpdateAuthor.ForeColor = System.Drawing.Color.Black;
            this.tbUpdateAuthor.Location = new System.Drawing.Point(93, 275);
            this.tbUpdateAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.tbUpdateAuthor.Name = "tbUpdateAuthor";
            this.tbUpdateAuthor.Size = new System.Drawing.Size(265, 22);
            this.tbUpdateAuthor.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quantity:";
            // 
            // tbSearchBookID
            // 
            this.tbSearchBookID.ForeColor = System.Drawing.Color.Black;
            this.tbSearchBookID.Location = new System.Drawing.Point(93, 107);
            this.tbSearchBookID.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchBookID.Name = "tbSearchBookID";
            this.tbSearchBookID.Size = new System.Drawing.Size(265, 22);
            this.tbSearchBookID.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Book ID:";
            // 
            // btnSearchBookID
            // 
            this.btnSearchBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchBookID.Location = new System.Drawing.Point(158, 135);
            this.btnSearchBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBookID.Name = "btnSearchBookID";
            this.btnSearchBookID.Size = new System.Drawing.Size(131, 47);
            this.btnSearchBookID.TabIndex = 39;
            this.btnSearchBookID.Text = "Search";
            this.btnSearchBookID.UseVisualStyleBackColor = true;
            this.btnSearchBookID.Click += new System.EventHandler(this.btnSearchBookID_Click);
            // 
            // FrmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.tbSearchBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchBookID);
            this.Controls.Add(this.tbUpdateQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUpdateAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateBookConfirm);
            this.Controls.Add(this.tbUpdateBookName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUpdateBook_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUpdateBook_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateBookConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUpdateBookName;
        private System.Windows.Forms.TextBox tbUpdateQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpdateAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearchBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBookID;
    }
}