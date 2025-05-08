namespace LGSTrackingSystem.Pages
{
    partial class AdminPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAddStudent = new Button();
            dgwStudentList = new DataGridView();
            tabPage2 = new TabPage();
            btnUpdate = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwStudentList).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnAddStudent);
            tabPage1.Controls.Add(dgwStudentList);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(778, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Students";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(732, 381);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(40, 40);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "➕";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dgwStudentList
            // 
            dgwStudentList.AllowUserToAddRows = false;
            dgwStudentList.AllowUserToDeleteRows = false;
            dgwStudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudentList.BackgroundColor = Color.White;
            dgwStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwStudentList.Dock = DockStyle.Top;
            dgwStudentList.Location = new Point(3, 3);
            dgwStudentList.Name = "dgwStudentList";
            dgwStudentList.RowHeadersVisible = false;
            dgwStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwStudentList.Size = new Size(772, 372);
            dgwStudentList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 432);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(686, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(40, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "🛠️";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(6F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 460);
            Controls.Add(tabControl1);
            Font = new Font("Myanmar Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            Load += AdminPage_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwStudentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgwStudentList;
        private Button btnAddStudent;
        private Button btnUpdate;
    }
}