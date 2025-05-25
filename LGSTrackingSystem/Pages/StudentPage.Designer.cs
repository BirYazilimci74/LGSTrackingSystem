namespace LGSTrackingSystem.Pages
{
    partial class StudentPage
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
            tbCtrl = new TabControl();
            tabPage1 = new TabPage();
            btnLogout = new Button();
            dgwExamList = new DataGridView();
            examContextMenu = new ContextMenuStrip(components);
            addExamToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            chartLesson = new LiveCharts.WinForms.CartesianChart();
            chartGeneral = new LiveCharts.WinForms.CartesianChart();
            tabPage3 = new TabPage();
            tbCtrl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwExamList).BeginInit();
            examContextMenu.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tbCtrl
            // 
            tbCtrl.Controls.Add(tabPage1);
            tbCtrl.Controls.Add(tabPage2);
            tbCtrl.Controls.Add(tabPage3);
            tbCtrl.Dock = DockStyle.Fill;
            tbCtrl.Location = new Point(0, 0);
            tbCtrl.Name = "tbCtrl";
            tbCtrl.SelectedIndex = 0;
            tbCtrl.Size = new Size(797, 481);
            tbCtrl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogout);
            tabPage1.Controls.Add(dgwExamList);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 448);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Exams";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(8, 399);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(49, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "﻿\u23fb";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgwExamList
            // 
            dgwExamList.AllowUserToAddRows = false;
            dgwExamList.AllowUserToDeleteRows = false;
            dgwExamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwExamList.BackgroundColor = Color.White;
            dgwExamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwExamList.ContextMenuStrip = examContextMenu;
            dgwExamList.Dock = DockStyle.Top;
            dgwExamList.Location = new Point(3, 3);
            dgwExamList.Name = "dgwExamList";
            dgwExamList.RowHeadersVisible = false;
            dgwExamList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExamList.ShowEditingIcon = false;
            dgwExamList.Size = new Size(783, 390);
            dgwExamList.TabIndex = 0;
            // 
            // examContextMenu
            // 
            examContextMenu.Items.AddRange(new ToolStripItem[] { addExamToolStripMenuItem });
            examContextMenu.Name = "examContextMenu";
            examContextMenu.Size = new Size(128, 26);
            // 
            // addExamToolStripMenuItem
            // 
            addExamToolStripMenuItem.Name = "addExamToolStripMenuItem";
            addExamToolStripMenuItem.Size = new Size(127, 22);
            addExamToolStripMenuItem.Text = "Add Exam";
            addExamToolStripMenuItem.Click += addExamToolStripMenuItem_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chartLesson);
            tabPage2.Controls.Add(chartGeneral);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartLesson
            // 
            chartLesson.Dock = DockStyle.Bottom;
            chartLesson.Location = new Point(3, 233);
            chartLesson.Name = "chartLesson";
            chartLesson.Size = new Size(783, 212);
            chartLesson.TabIndex = 1;
            chartLesson.Text = "Lession Chart";
            // 
            // chartGeneral
            // 
            chartGeneral.Dock = DockStyle.Top;
            chartGeneral.Location = new Point(3, 3);
            chartGeneral.Name = "chartGeneral";
            chartGeneral.Size = new Size(783, 196);
            chartGeneral.TabIndex = 0;
            chartGeneral.Text = "General Chart";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 453);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(6F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 481);
            Controls.Add(tbCtrl);
            Font = new Font("Myanmar Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentPage";
            ShowIcon = false;
            Text = "StudentPage";
            Load += StudentPage_Load;
            tbCtrl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwExamList).EndInit();
            examContextMenu.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbCtrl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgwExamList;
        private Button btnLogout;
        private ContextMenuStrip examContextMenu;
        private ToolStripMenuItem addExamToolStripMenuItem;
        private TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart chartLesson;
        private LiveCharts.WinForms.CartesianChart chartGeneral;
    }
}