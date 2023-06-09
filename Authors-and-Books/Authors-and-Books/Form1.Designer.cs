namespace Authors_and_Books
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxAuthorName = new TextBox();
            tbxBookName = new TextBox();
            tbxContent = new TextBox();
            lblAuthorName = new Label();
            lblBookName = new Label();
            lblContent = new Label();
            btnList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            gbxAdmin = new GroupBox();
            gbxList = new GroupBox();
            dgwList = new DataGridView();
            gbxAdmin.SuspendLayout();
            gbxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwList).BeginInit();
            SuspendLayout();
            // 
            // tbxAuthorName
            // 
            tbxAuthorName.Location = new Point(167, 63);
            tbxAuthorName.Name = "tbxAuthorName";
            tbxAuthorName.Size = new Size(254, 27);
            tbxAuthorName.TabIndex = 0;
            // 
            // tbxBookName
            // 
            tbxBookName.Location = new Point(167, 109);
            tbxBookName.Name = "tbxBookName";
            tbxBookName.Size = new Size(254, 27);
            tbxBookName.TabIndex = 1;
            // 
            // tbxContent
            // 
            tbxContent.Location = new Point(167, 154);
            tbxContent.Name = "tbxContent";
            tbxContent.Size = new Size(254, 27);
            tbxContent.TabIndex = 2;
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Location = new Point(45, 66);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(116, 20);
            lblAuthorName.TabIndex = 3;
            lblAuthorName.Text = "Author Name:";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(60, 112);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(101, 20);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name:";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(87, 157);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(74, 20);
            lblContent.TabIndex = 5;
            lblContent.Text = "Content:";
            // 
            // btnList
            // 
            btnList.Location = new Point(303, 201);
            btnList.Name = "btnList";
            btnList.Size = new Size(118, 29);
            btnList.TabIndex = 6;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(303, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(303, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(303, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbxAdmin
            // 
            gbxAdmin.Controls.Add(btnDelete);
            gbxAdmin.Controls.Add(tbxAuthorName);
            gbxAdmin.Controls.Add(btnUpdate);
            gbxAdmin.Controls.Add(tbxBookName);
            gbxAdmin.Controls.Add(btnAdd);
            gbxAdmin.Controls.Add(tbxContent);
            gbxAdmin.Controls.Add(btnList);
            gbxAdmin.Controls.Add(lblAuthorName);
            gbxAdmin.Controls.Add(lblContent);
            gbxAdmin.Controls.Add(lblBookName);
            gbxAdmin.Location = new Point(15, 12);
            gbxAdmin.Name = "gbxAdmin";
            gbxAdmin.Size = new Size(493, 431);
            gbxAdmin.TabIndex = 10;
            gbxAdmin.TabStop = false;
            gbxAdmin.Text = "System Admin Panel";
            // 
            // gbxList
            // 
            gbxList.Controls.Add(dgwList);
            gbxList.Location = new Point(545, 12);
            gbxList.Name = "gbxList";
            gbxList.Size = new Size(887, 431);
            gbxList.TabIndex = 11;
            gbxList.TabStop = false;
            gbxList.Text = "Author and Book List";
            // 
            // dgwList
            // 
            dgwList.BackgroundColor = SystemColors.ControlDarkDark;
            dgwList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwList.Location = new Point(19, 26);
            dgwList.Name = "dgwList";
            dgwList.RowHeadersWidth = 51;
            dgwList.RowTemplate.Height = 29;
            dgwList.Size = new Size(852, 387);
            dgwList.TabIndex = 0;
            dgwList.CellClick += dgwList_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 468);
            Controls.Add(gbxList);
            Controls.Add(gbxAdmin);
            Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Author and Books";
            Load += Form1_Load;
            gbxAdmin.ResumeLayout(false);
            gbxAdmin.PerformLayout();
            gbxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxAuthorName;
        private TextBox tbxBookName;
        private TextBox tbxContent;
        private Label lblAuthorName;
        private Label lblBookName;
        private Label lblContent;
        private Button btnList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox gbxAdmin;
        private GroupBox gbxList;
        private DataGridView dgwList;
    }
}