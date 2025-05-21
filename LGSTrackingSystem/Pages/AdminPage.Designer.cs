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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLogout = new Button();
            dgwStudentList = new DataGridView();
            studentContextMenu = new ContextMenuStrip(components);
            addExamToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            listExamsToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwStudentList).BeginInit();
            studentContextMenu.SuspendLayout();
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
            tabPage1.Controls.Add(btnLogout);
            tabPage1.Controls.Add(dgwStudentList);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(778, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Students";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(8, 381);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(49, 40);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "﻿\u23fb";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgwStudentList
            // 
            dgwStudentList.AllowUserToAddRows = false;
            dgwStudentList.AllowUserToDeleteRows = false;
            dgwStudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudentList.BackgroundColor = Color.White;
            dgwStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwStudentList.ContextMenuStrip = studentContextMenu;
            dgwStudentList.Dock = DockStyle.Top;
            dgwStudentList.Location = new Point(3, 3);
            dgwStudentList.Name = "dgwStudentList";
            dgwStudentList.RowHeadersVisible = false;
            dgwStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwStudentList.Size = new Size(772, 372);
            dgwStudentList.TabIndex = 0;
            // 
            // studentContextMenu
            // 
            studentContextMenu.Items.AddRange(new ToolStripItem[] { addExamToolStripMenuItem, editToolStripMenuItem, addStudentToolStripMenuItem, listExamsToolStripMenuItem });
            studentContextMenu.Name = "contextMenuStrip1";
            studentContextMenu.Size = new Size(141, 92);
            // 
            // addExamToolStripMenuItem
            // 
            addExamToolStripMenuItem.Name = "addExamToolStripMenuItem";
            addExamToolStripMenuItem.Size = new Size(140, 22);
            addExamToolStripMenuItem.Text = "Add Exam";
            addExamToolStripMenuItem.Click += addExamToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(140, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_ClickAsync;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(140, 22);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_ClickAsync;
            // 
            // listExamsToolStripMenuItem
            // 
            listExamsToolStripMenuItem.Name = "listExamsToolStripMenuItem";
            listExamsToolStripMenuItem.Size = new Size(140, 22);
            listExamsToolStripMenuItem.Text = "List Exams";
            listExamsToolStripMenuItem.Click += listExamsToolStripMenuItem_Click;
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
            studentContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgwStudentList;
        private Button btnLogout;
        private ContextMenuStrip studentContextMenu;
        private ToolStripMenuItem addExamToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem listExamsToolStripMenuItem;
    }
}