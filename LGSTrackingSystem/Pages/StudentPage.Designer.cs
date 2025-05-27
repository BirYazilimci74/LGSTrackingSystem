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
            btnExport = new Button();
            btnLogout = new Button();
            dgwExamList = new DataGridView();
            examContextMenu = new ContextMenuStrip(components);
            addExamToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            chbxDisplayEnglish = new CheckBox();
            chbxDisplayReligion = new CheckBox();
            chbxDisplayHistory = new CheckBox();
            chbxDisplayTurkish = new CheckBox();
            chbxDisplayScience = new CheckBox();
            chbxDisplayMath = new CheckBox();
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
            tabPage1.Controls.Add(btnExport);
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
            // btnExport
            // 
            btnExport.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(657, 399);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(126, 40);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
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
            tabPage2.Controls.Add(chbxDisplayEnglish);
            tabPage2.Controls.Add(chbxDisplayReligion);
            tabPage2.Controls.Add(chbxDisplayHistory);
            tabPage2.Controls.Add(chbxDisplayTurkish);
            tabPage2.Controls.Add(chbxDisplayScience);
            tabPage2.Controls.Add(chbxDisplayMath);
            tabPage2.Controls.Add(chartLesson);
            tabPage2.Controls.Add(chartGeneral);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Statistics";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chbxDisplayEnglish
            // 
            chbxDisplayEnglish.AutoSize = true;
            chbxDisplayEnglish.ForeColor = Color.DeepPink;
            chbxDisplayEnglish.Location = new Point(689, 368);
            chbxDisplayEnglish.Name = "chbxDisplayEnglish";
            chbxDisplayEnglish.Size = new Size(66, 24);
            chbxDisplayEnglish.TabIndex = 15;
            chbxDisplayEnglish.Text = "English";
            chbxDisplayEnglish.UseVisualStyleBackColor = true;
            chbxDisplayEnglish.CheckedChanged += chbxDisplayEnglish_CheckedChanged;
            // 
            // chbxDisplayReligion
            // 
            chbxDisplayReligion.AutoSize = true;
            chbxDisplayReligion.ForeColor = Color.DarkGreen;
            chbxDisplayReligion.Location = new Point(689, 343);
            chbxDisplayReligion.Name = "chbxDisplayReligion";
            chbxDisplayReligion.Size = new Size(71, 24);
            chbxDisplayReligion.TabIndex = 14;
            chbxDisplayReligion.Text = "Religion";
            chbxDisplayReligion.UseVisualStyleBackColor = true;
            chbxDisplayReligion.CheckedChanged += chbxDisplayReligion_CheckedChanged;
            // 
            // chbxDisplayHistory
            // 
            chbxDisplayHistory.AutoSize = true;
            chbxDisplayHistory.ForeColor = Color.Peru;
            chbxDisplayHistory.Location = new Point(689, 318);
            chbxDisplayHistory.Name = "chbxDisplayHistory";
            chbxDisplayHistory.Size = new Size(64, 24);
            chbxDisplayHistory.TabIndex = 13;
            chbxDisplayHistory.Text = "History";
            chbxDisplayHistory.UseVisualStyleBackColor = true;
            chbxDisplayHistory.CheckedChanged += chbxDisplayHistory_CheckedChanged;
            // 
            // chbxDisplayTurkish
            // 
            chbxDisplayTurkish.AutoSize = true;
            chbxDisplayTurkish.ForeColor = Color.DarkOrange;
            chbxDisplayTurkish.Location = new Point(689, 293);
            chbxDisplayTurkish.Name = "chbxDisplayTurkish";
            chbxDisplayTurkish.Size = new Size(65, 24);
            chbxDisplayTurkish.TabIndex = 12;
            chbxDisplayTurkish.Text = "Turkish";
            chbxDisplayTurkish.UseVisualStyleBackColor = true;
            chbxDisplayTurkish.CheckedChanged += chbxDisplayTurkish_CheckedChanged;
            // 
            // chbxDisplayScience
            // 
            chbxDisplayScience.AutoSize = true;
            chbxDisplayScience.ForeColor = Color.Lime;
            chbxDisplayScience.Location = new Point(689, 268);
            chbxDisplayScience.Name = "chbxDisplayScience";
            chbxDisplayScience.Size = new Size(66, 24);
            chbxDisplayScience.TabIndex = 11;
            chbxDisplayScience.Text = "Science";
            chbxDisplayScience.UseVisualStyleBackColor = true;
            chbxDisplayScience.CheckedChanged += chbxDisplayScience_CheckedChanged;
            // 
            // chbxDisplayMath
            // 
            chbxDisplayMath.AutoSize = true;
            chbxDisplayMath.ForeColor = Color.DodgerBlue;
            chbxDisplayMath.Location = new Point(689, 243);
            chbxDisplayMath.Name = "chbxDisplayMath";
            chbxDisplayMath.Size = new Size(55, 24);
            chbxDisplayMath.TabIndex = 10;
            chbxDisplayMath.Text = "Math";
            chbxDisplayMath.UseVisualStyleBackColor = true;
            chbxDisplayMath.CheckedChanged += chbxDisplayMath_CheckedChanged;
            // 
            // chartLesson
            // 
            chartLesson.Dock = DockStyle.Left;
            chartLesson.Location = new Point(3, 199);
            chartLesson.Name = "chartLesson";
            chartLesson.Size = new Size(654, 246);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 448);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "MyProfile";
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
            tabPage2.PerformLayout();
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
        private CheckBox chbxDisplayEnglish;
        private CheckBox chbxDisplayReligion;
        private CheckBox chbxDisplayHistory;
        private CheckBox chbxDisplayTurkish;
        private CheckBox chbxDisplayScience;
        private CheckBox chbxDisplayMath;
        private Button btnExport;
    }
}