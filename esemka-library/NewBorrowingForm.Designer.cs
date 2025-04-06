namespace esemka_library
{
    partial class NewBorrowingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Borrowing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(181, 106);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(732, 26);
            this.tbBookTitle.TabIndex = 2;
            this.tbBookTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookTitle_KeyPress);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(932, 105);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(98, 29);
            this.btnSearchBook.TabIndex = 3;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // dgBooks
            // 
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookTitle,
            this.genre,
            this.author,
            this.publishDate,
            this.stock});
            this.dgBooks.Location = new System.Drawing.Point(45, 173);
            this.dgBooks.Name = "dgBooks";
            this.dgBooks.RowHeadersWidth = 62;
            this.dgBooks.RowTemplate.Height = 28;
            this.dgBooks.RowTemplate.ReadOnly = true;
            this.dgBooks.Size = new System.Drawing.Size(985, 272);
            this.dgBooks.TabIndex = 4;
            this.dgBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBooks_CellContentClick);
            // 
            // bookId
            // 
            this.bookId.HeaderText = "Id";
            this.bookId.MinimumWidth = 8;
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Visible = false;
            // 
            // bookTitle
            // 
            this.bookTitle.HeaderText = "Title";
            this.bookTitle.MinimumWidth = 8;
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 8;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publishDate
            // 
            this.publishDate.HeaderText = "Publish Date";
            this.publishDate.MinimumWidth = 8;
            this.publishDate.Name = "publishDate";
            this.publishDate.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 8;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // NewBorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 504);
            this.Controls.Add(this.dgBooks);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.tbBookTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewBorrowingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESEMKA Library - New Borrowing Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}