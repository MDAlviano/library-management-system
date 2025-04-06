namespace esemka_library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgMemberBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.btnToNewBorrowing = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.borrowingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESEMKA Library Management System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchMember);
            this.groupBox1.Controls.Add(this.tbMemberName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Data";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(837, 41);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(113, 31);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(144, 43);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(654, 26);
            this.tbMemberName.TabIndex = 1;
            this.tbMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMemberName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgMemberBorrowedBooks);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrowing Data";
            // 
            // dgMemberBorrowedBooks
            // 
            this.dgMemberBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMemberBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberBorrowedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowingId,
            this.borrowedBookTitle,
            this.borrowDate,
            this.dueDate,
            this.overdueDays});
            this.dgMemberBorrowedBooks.Location = new System.Drawing.Point(18, 35);
            this.dgMemberBorrowedBooks.Name = "dgMemberBorrowedBooks";
            this.dgMemberBorrowedBooks.RowHeadersWidth = 62;
            this.dgMemberBorrowedBooks.RowTemplate.Height = 28;
            this.dgMemberBorrowedBooks.Size = new System.Drawing.Size(932, 127);
            this.dgMemberBorrowedBooks.TabIndex = 0;
            this.dgMemberBorrowedBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMemberBorrowedBooks_CellContentClick);
            // 
            // btnToNewBorrowing
            // 
            this.btnToNewBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToNewBorrowing.Location = new System.Drawing.Point(54, 443);
            this.btnToNewBorrowing.Name = "btnToNewBorrowing";
            this.btnToNewBorrowing.Size = new System.Drawing.Size(152, 36);
            this.btnToNewBorrowing.TabIndex = 3;
            this.btnToNewBorrowing.Text = "New Borrowing";
            this.btnToNewBorrowing.UseVisualStyleBackColor = true;
            this.btnToNewBorrowing.Click += new System.EventHandler(this.btnToNewBorrowing_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(759, 451);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(260, 20);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Sunday, 21 April 2024 14:55:20";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // borrowingId
            // 
            this.borrowingId.HeaderText = "Id";
            this.borrowingId.MinimumWidth = 8;
            this.borrowingId.Name = "borrowingId";
            this.borrowingId.ReadOnly = true;
            this.borrowingId.Visible = false;
            // 
            // borrowedBookTitle
            // 
            this.borrowedBookTitle.HeaderText = "Title";
            this.borrowedBookTitle.MinimumWidth = 8;
            this.borrowedBookTitle.Name = "borrowedBookTitle";
            this.borrowedBookTitle.ReadOnly = true;
            // 
            // borrowDate
            // 
            this.borrowDate.HeaderText = "Borrow Date";
            this.borrowDate.MinimumWidth = 8;
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.ReadOnly = true;
            // 
            // dueDate
            // 
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.MinimumWidth = 8;
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            // 
            // overdueDays
            // 
            this.overdueDays.HeaderText = "Overdue Day(s)";
            this.overdueDays.MinimumWidth = 8;
            this.overdueDays.Name = "overdueDays";
            this.overdueDays.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 504);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.btnToNewBorrowing);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESEMKA Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgMemberBorrowedBooks;
        private System.Windows.Forms.Button btnToNewBorrowing;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueDays;
    }
}

