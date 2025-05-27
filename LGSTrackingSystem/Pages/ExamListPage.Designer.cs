namespace LGSTrackingSystem.UI.Pages
{
    partial class ExamListPage
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
            examContextMenu = new ContextMenuStrip(components);
            addExamToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel13 = new TableLayoutPanel();
            lblScore = new Label();
            lblTotalNet = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExport = new Button();
            lblExamDate = new Label();
            lblExamName = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            lblEnglishIncorrect = new Label();
            lblEnglishCorrect = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            lblReligionIncorrect = new Label();
            lblReligionCorrect = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            lblHistoryIncorrect = new Label();
            lblHistoryCorrect = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblScienceIncorrect = new Label();
            lblScienceCorrect = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblTurkishIncorrect = new Label();
            lblTurkishCorrect = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMathIncorrect = new Label();
            lblMathCorrect = new Label();
            label2 = new Label();
            label1 = new Label();
            label25 = new Label();
            dgwExamList = new DataGridView();
            tabPage2 = new TabPage();
            chbxDisplayEnglish = new CheckBox();
            chbxDisplayReligion = new CheckBox();
            chbxDisplayHistory = new CheckBox();
            chbxDisplayTurkish = new CheckBox();
            chbxDisplayScience = new CheckBox();
            chbxDisplayMath = new CheckBox();
            chartLesson = new LiveCharts.WinForms.CartesianChart();
            chartGeneral = new LiveCharts.WinForms.CartesianChart();
            examContextMenu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwExamList).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // examContextMenu
            // 
            examContextMenu.Items.AddRange(new ToolStripItem[] { addExamToolStripMenuItem, deleteToolStripMenuItem });
            examContextMenu.Name = "examContextMenu";
            examContextMenu.Size = new Size(139, 48);
            // 
            // addExamToolStripMenuItem
            // 
            addExamToolStripMenuItem.Name = "addExamToolStripMenuItem";
            addExamToolStripMenuItem.Size = new Size(138, 22);
            addExamToolStripMenuItem.Text = "Add Exam";
            addExamToolStripMenuItem.Click += addExamToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(138, 22);
            deleteToolStripMenuItem.Text = "Delete Exam";
            deleteToolStripMenuItem.Click += deleteExamToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 482);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel13);
            tabPage1.Controls.Add(btnExport);
            tabPage1.Controls.Add(lblExamDate);
            tabPage1.Controls.Add(lblExamName);
            tabPage1.Controls.Add(tableLayoutPanel11);
            tabPage1.Controls.Add(tableLayoutPanel9);
            tabPage1.Controls.Add(tableLayoutPanel6);
            tabPage1.Controls.Add(tableLayoutPanel4);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(tableLayoutPanel7);
            tabPage1.Controls.Add(dgwExamList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 454);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Exams";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(lblScore, 1, 1);
            tableLayoutPanel13.Controls.Add(lblTotalNet, 0, 1);
            tableLayoutPanel13.Controls.Add(label3, 0, 0);
            tableLayoutPanel13.Controls.Add(label4, 1, 0);
            tableLayoutPanel13.Location = new Point(492, 341);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(200, 46);
            tableLayoutPanel13.TabIndex = 27;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Dock = DockStyle.Fill;
            lblScore.Location = new Point(103, 23);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(93, 22);
            lblScore.TabIndex = 3;
            lblScore.Text = "0.00";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalNet
            // 
            lblTotalNet.AutoSize = true;
            lblTotalNet.Dock = DockStyle.Fill;
            lblTotalNet.Location = new Point(4, 23);
            lblTotalNet.Name = "lblTotalNet";
            lblTotalNet.Size = new Size(92, 22);
            lblTotalNet.TabIndex = 2;
            lblTotalNet.Text = "0.00";
            lblTotalNet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(4, 1);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 0;
            label3.Text = "Total Net";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(103, 1);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 1;
            label4.Text = "Score";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(682, 417);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(102, 29);
            btnExport.TabIndex = 26;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lblExamDate
            // 
            lblExamDate.AutoSize = true;
            lblExamDate.Location = new Point(424, 57);
            lblExamDate.Name = "lblExamDate";
            lblExamDate.Size = new Size(65, 15);
            lblExamDate.TabIndex = 25;
            lblExamDate.Text = "00/00/0000";
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblExamName.Location = new Point(542, 5);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(94, 30);
            lblExamName.TabIndex = 24;
            lblExamName.Text = "_________";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel11.Controls.Add(label30, 0, 0);
            tableLayoutPanel11.Location = new Point(607, 265);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 29.032259F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 70.96774F));
            tableLayoutPanel11.Size = new Size(157, 62);
            tableLayoutPanel11.TabIndex = 23;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(lblEnglishIncorrect, 1, 1);
            tableLayoutPanel12.Controls.Add(lblEnglishCorrect, 0, 1);
            tableLayoutPanel12.Controls.Add(label28, 1, 0);
            tableLayoutPanel12.Controls.Add(label29, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 21);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel12.Size = new Size(151, 38);
            tableLayoutPanel12.TabIndex = 2;
            // 
            // lblEnglishIncorrect
            // 
            lblEnglishIncorrect.AutoSize = true;
            lblEnglishIncorrect.Dock = DockStyle.Fill;
            lblEnglishIncorrect.Location = new Point(79, 19);
            lblEnglishIncorrect.Name = "lblEnglishIncorrect";
            lblEnglishIncorrect.Size = new Size(68, 18);
            lblEnglishIncorrect.TabIndex = 3;
            lblEnglishIncorrect.Text = "0";
            lblEnglishIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEnglishCorrect
            // 
            lblEnglishCorrect.AutoSize = true;
            lblEnglishCorrect.Dock = DockStyle.Fill;
            lblEnglishCorrect.Location = new Point(4, 19);
            lblEnglishCorrect.Name = "lblEnglishCorrect";
            lblEnglishCorrect.Size = new Size(68, 18);
            lblEnglishCorrect.TabIndex = 2;
            lblEnglishCorrect.Text = "0";
            lblEnglishCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Dock = DockStyle.Fill;
            label28.Location = new Point(79, 1);
            label28.Name = "label28";
            label28.Size = new Size(68, 17);
            label28.TabIndex = 1;
            label28.Text = "Incorrect";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Location = new Point(4, 1);
            label29.Name = "label29";
            label29.Size = new Size(68, 17);
            label29.TabIndex = 0;
            label29.Text = "Correct";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Dock = DockStyle.Fill;
            label30.Location = new Point(3, 0);
            label30.Name = "label30";
            label30.Size = new Size(151, 18);
            label30.TabIndex = 3;
            label30.Text = "English";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel9.Controls.Add(label24, 0, 0);
            tableLayoutPanel9.Location = new Point(424, 265);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 29.032259F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 70.96774F));
            tableLayoutPanel9.Size = new Size(157, 62);
            tableLayoutPanel9.TabIndex = 22;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(lblReligionIncorrect, 1, 1);
            tableLayoutPanel10.Controls.Add(lblReligionCorrect, 0, 1);
            tableLayoutPanel10.Controls.Add(label22, 1, 0);
            tableLayoutPanel10.Controls.Add(label23, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 21);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel10.Size = new Size(151, 38);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // lblReligionIncorrect
            // 
            lblReligionIncorrect.AutoSize = true;
            lblReligionIncorrect.Dock = DockStyle.Fill;
            lblReligionIncorrect.Location = new Point(79, 19);
            lblReligionIncorrect.Name = "lblReligionIncorrect";
            lblReligionIncorrect.Size = new Size(68, 18);
            lblReligionIncorrect.TabIndex = 3;
            lblReligionIncorrect.Text = "0";
            lblReligionIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReligionCorrect
            // 
            lblReligionCorrect.AutoSize = true;
            lblReligionCorrect.Dock = DockStyle.Fill;
            lblReligionCorrect.Location = new Point(4, 19);
            lblReligionCorrect.Name = "lblReligionCorrect";
            lblReligionCorrect.Size = new Size(68, 18);
            lblReligionCorrect.TabIndex = 2;
            lblReligionCorrect.Text = "0";
            lblReligionCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Location = new Point(79, 1);
            label22.Name = "label22";
            label22.Size = new Size(68, 17);
            label22.TabIndex = 1;
            label22.Text = "Incorrect";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = DockStyle.Fill;
            label23.Location = new Point(4, 1);
            label23.Name = "label23";
            label23.Size = new Size(68, 17);
            label23.TabIndex = 0;
            label23.Text = "Correct";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(151, 18);
            label24.TabIndex = 3;
            label24.Text = "Religion";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel6.Controls.Add(label19, 0, 0);
            tableLayoutPanel6.Location = new Point(607, 178);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 29.032259F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 70.96774F));
            tableLayoutPanel6.Size = new Size(157, 62);
            tableLayoutPanel6.TabIndex = 21;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(lblHistoryIncorrect, 1, 1);
            tableLayoutPanel8.Controls.Add(lblHistoryCorrect, 0, 1);
            tableLayoutPanel8.Controls.Add(label17, 1, 0);
            tableLayoutPanel8.Controls.Add(label18, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 21);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel8.Size = new Size(151, 38);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // lblHistoryIncorrect
            // 
            lblHistoryIncorrect.AutoSize = true;
            lblHistoryIncorrect.Dock = DockStyle.Fill;
            lblHistoryIncorrect.Location = new Point(79, 19);
            lblHistoryIncorrect.Name = "lblHistoryIncorrect";
            lblHistoryIncorrect.Size = new Size(68, 18);
            lblHistoryIncorrect.TabIndex = 3;
            lblHistoryIncorrect.Text = "0";
            lblHistoryIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHistoryCorrect
            // 
            lblHistoryCorrect.AutoSize = true;
            lblHistoryCorrect.Dock = DockStyle.Fill;
            lblHistoryCorrect.Location = new Point(4, 19);
            lblHistoryCorrect.Name = "lblHistoryCorrect";
            lblHistoryCorrect.Size = new Size(68, 18);
            lblHistoryCorrect.TabIndex = 2;
            lblHistoryCorrect.Text = "0";
            lblHistoryCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(79, 1);
            label17.Name = "label17";
            label17.Size = new Size(68, 17);
            label17.TabIndex = 1;
            label17.Text = "Incorrect";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point(4, 1);
            label18.Name = "label18";
            label18.Size = new Size(68, 17);
            label18.TabIndex = 0;
            label18.Text = "Correct";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(151, 18);
            label19.TabIndex = 3;
            label19.Text = "History";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(label14, 0, 0);
            tableLayoutPanel4.Location = new Point(607, 88);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 29.032259F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70.96774F));
            tableLayoutPanel4.Size = new Size(157, 62);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lblScienceIncorrect, 1, 1);
            tableLayoutPanel5.Controls.Add(lblScienceCorrect, 0, 1);
            tableLayoutPanel5.Controls.Add(label12, 1, 0);
            tableLayoutPanel5.Controls.Add(label13, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 21);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel5.Size = new Size(151, 38);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // lblScienceIncorrect
            // 
            lblScienceIncorrect.AutoSize = true;
            lblScienceIncorrect.Dock = DockStyle.Fill;
            lblScienceIncorrect.Location = new Point(79, 19);
            lblScienceIncorrect.Name = "lblScienceIncorrect";
            lblScienceIncorrect.Size = new Size(68, 18);
            lblScienceIncorrect.TabIndex = 3;
            lblScienceIncorrect.Text = "0";
            lblScienceIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScienceCorrect
            // 
            lblScienceCorrect.AutoSize = true;
            lblScienceCorrect.Dock = DockStyle.Fill;
            lblScienceCorrect.Location = new Point(4, 19);
            lblScienceCorrect.Name = "lblScienceCorrect";
            lblScienceCorrect.Size = new Size(68, 18);
            lblScienceCorrect.TabIndex = 2;
            lblScienceCorrect.Text = "0";
            lblScienceCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(79, 1);
            label12.Name = "label12";
            label12.Size = new Size(68, 17);
            label12.TabIndex = 1;
            label12.Text = "Incorrect";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(4, 1);
            label13.Name = "label13";
            label13.Size = new Size(68, 17);
            label13.TabIndex = 0;
            label13.Text = "Correct";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(151, 18);
            label14.TabIndex = 3;
            label14.Text = "Science";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Location = new Point(424, 178);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.032259F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70.96774F));
            tableLayoutPanel2.Size = new Size(157, 62);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblTurkishIncorrect, 1, 1);
            tableLayoutPanel3.Controls.Add(lblTurkishCorrect, 0, 1);
            tableLayoutPanel3.Controls.Add(label7, 1, 0);
            tableLayoutPanel3.Controls.Add(label8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel3.Size = new Size(151, 38);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // lblTurkishIncorrect
            // 
            lblTurkishIncorrect.AutoSize = true;
            lblTurkishIncorrect.Dock = DockStyle.Fill;
            lblTurkishIncorrect.Location = new Point(79, 19);
            lblTurkishIncorrect.Name = "lblTurkishIncorrect";
            lblTurkishIncorrect.Size = new Size(68, 18);
            lblTurkishIncorrect.TabIndex = 3;
            lblTurkishIncorrect.Text = "0";
            lblTurkishIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTurkishCorrect
            // 
            lblTurkishCorrect.AutoSize = true;
            lblTurkishCorrect.Dock = DockStyle.Fill;
            lblTurkishCorrect.Location = new Point(4, 19);
            lblTurkishCorrect.Name = "lblTurkishCorrect";
            lblTurkishCorrect.Size = new Size(68, 18);
            lblTurkishCorrect.TabIndex = 2;
            lblTurkishCorrect.Text = "0";
            lblTurkishCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(79, 1);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 1;
            label7.Text = "Incorrect";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(4, 1);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 0;
            label8.Text = "Correct";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(151, 18);
            label9.TabIndex = 3;
            label9.Text = "Turkish";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel7.Controls.Add(label25, 0, 0);
            tableLayoutPanel7.Location = new Point(424, 88);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 29.032259F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 70.96774F));
            tableLayoutPanel7.Size = new Size(157, 62);
            tableLayoutPanel7.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblMathIncorrect, 1, 1);
            tableLayoutPanel1.Controls.Add(lblMathCorrect, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel1.Size = new Size(151, 38);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMathIncorrect
            // 
            lblMathIncorrect.AutoSize = true;
            lblMathIncorrect.Dock = DockStyle.Fill;
            lblMathIncorrect.Location = new Point(79, 19);
            lblMathIncorrect.Name = "lblMathIncorrect";
            lblMathIncorrect.Size = new Size(68, 18);
            lblMathIncorrect.TabIndex = 3;
            lblMathIncorrect.Text = "0";
            lblMathIncorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMathCorrect
            // 
            lblMathCorrect.AutoSize = true;
            lblMathCorrect.Dock = DockStyle.Fill;
            lblMathCorrect.Location = new Point(4, 19);
            lblMathCorrect.Name = "lblMathCorrect";
            lblMathCorrect.Size = new Size(68, 18);
            lblMathCorrect.TabIndex = 2;
            lblMathCorrect.Text = "0";
            lblMathCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(79, 1);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 1;
            label2.Text = "Incorrect";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "Correct";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Dock = DockStyle.Fill;
            label25.Location = new Point(3, 0);
            label25.Name = "label25";
            label25.Size = new Size(151, 18);
            label25.TabIndex = 3;
            label25.Text = "Math";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgwExamList
            // 
            dgwExamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwExamList.BackgroundColor = Color.White;
            dgwExamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwExamList.ContextMenuStrip = examContextMenu;
            dgwExamList.Dock = DockStyle.Left;
            dgwExamList.Location = new Point(3, 3);
            dgwExamList.Name = "dgwExamList";
            dgwExamList.RowHeadersVisible = false;
            dgwExamList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExamList.Size = new Size(398, 448);
            dgwExamList.TabIndex = 17;
            dgwExamList.CellDoubleClick += dgwExamList_CellDoubleClick;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 454);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Statistics";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chbxDisplayEnglish
            // 
            chbxDisplayEnglish.AutoSize = true;
            chbxDisplayEnglish.ForeColor = Color.DeepPink;
            chbxDisplayEnglish.Location = new Point(688, 376);
            chbxDisplayEnglish.Name = "chbxDisplayEnglish";
            chbxDisplayEnglish.Size = new Size(64, 19);
            chbxDisplayEnglish.TabIndex = 9;
            chbxDisplayEnglish.Text = "English";
            chbxDisplayEnglish.UseVisualStyleBackColor = true;
            chbxDisplayEnglish.CheckedChanged += chbxDisplayEnglish_CheckedChangedAsync;
            // 
            // chbxDisplayReligion
            // 
            chbxDisplayReligion.AutoSize = true;
            chbxDisplayReligion.ForeColor = Color.DarkGreen;
            chbxDisplayReligion.Location = new Point(688, 351);
            chbxDisplayReligion.Name = "chbxDisplayReligion";
            chbxDisplayReligion.Size = new Size(69, 19);
            chbxDisplayReligion.TabIndex = 8;
            chbxDisplayReligion.Text = "Religion";
            chbxDisplayReligion.UseVisualStyleBackColor = true;
            chbxDisplayReligion.CheckedChanged += chbxDisplayReligion_CheckedChangedAsync;
            // 
            // chbxDisplayHistory
            // 
            chbxDisplayHistory.AutoSize = true;
            chbxDisplayHistory.ForeColor = Color.Peru;
            chbxDisplayHistory.Location = new Point(688, 326);
            chbxDisplayHistory.Name = "chbxDisplayHistory";
            chbxDisplayHistory.Size = new Size(64, 19);
            chbxDisplayHistory.TabIndex = 7;
            chbxDisplayHistory.Text = "History";
            chbxDisplayHistory.UseVisualStyleBackColor = true;
            chbxDisplayHistory.CheckedChanged += chbxDisplayHistory_CheckedChangedAsync;
            // 
            // chbxDisplayTurkish
            // 
            chbxDisplayTurkish.AutoSize = true;
            chbxDisplayTurkish.ForeColor = Color.DarkOrange;
            chbxDisplayTurkish.Location = new Point(688, 301);
            chbxDisplayTurkish.Name = "chbxDisplayTurkish";
            chbxDisplayTurkish.Size = new Size(65, 19);
            chbxDisplayTurkish.TabIndex = 6;
            chbxDisplayTurkish.Text = "Turkish";
            chbxDisplayTurkish.UseVisualStyleBackColor = true;
            chbxDisplayTurkish.CheckedChanged += chbxDisplayTurkish_CheckedChangedAsync;
            // 
            // chbxDisplayScience
            // 
            chbxDisplayScience.AutoSize = true;
            chbxDisplayScience.ForeColor = Color.Lime;
            chbxDisplayScience.Location = new Point(688, 276);
            chbxDisplayScience.Name = "chbxDisplayScience";
            chbxDisplayScience.Size = new Size(66, 19);
            chbxDisplayScience.TabIndex = 5;
            chbxDisplayScience.Text = "Science";
            chbxDisplayScience.UseVisualStyleBackColor = true;
            chbxDisplayScience.CheckedChanged += chbxDisplayScience_CheckedChangedAsync;
            // 
            // chbxDisplayMath
            // 
            chbxDisplayMath.AutoSize = true;
            chbxDisplayMath.ForeColor = Color.DodgerBlue;
            chbxDisplayMath.Location = new Point(688, 251);
            chbxDisplayMath.Name = "chbxDisplayMath";
            chbxDisplayMath.Size = new Size(54, 19);
            chbxDisplayMath.TabIndex = 4;
            chbxDisplayMath.Text = "Math";
            chbxDisplayMath.UseVisualStyleBackColor = true;
            chbxDisplayMath.CheckedChanged += chbxDisplayMath_CheckedChanged;
            // 
            // chartLesson
            // 
            chartLesson.Dock = DockStyle.Left;
            chartLesson.Location = new Point(3, 199);
            chartLesson.Name = "chartLesson";
            chartLesson.Size = new Size(646, 252);
            chartLesson.TabIndex = 3;
            chartLesson.Text = "Lession Chart";
            // 
            // chartGeneral
            // 
            chartGeneral.Dock = DockStyle.Top;
            chartGeneral.Location = new Point(3, 3);
            chartGeneral.Name = "chartGeneral";
            chartGeneral.Size = new Size(786, 196);
            chartGeneral.TabIndex = 2;
            chartGeneral.Text = "General Chart";
            // 
            // ExamListPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExamListPage";
            ShowIcon = false;
            Text = "ExamListPage";
            Load += ExamListPage_Load;
            examContextMenu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwExamList).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip examContextMenu;
        private ToolStripMenuItem addExamToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel13;
        private Label lblScore;
        private Label lblTotalNet;
        private Label label3;
        private Label label4;
        private Button btnExport;
        private Label lblExamDate;
        private Label lblExamName;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Label lblEnglishIncorrect;
        private Label lblEnglishCorrect;
        private Label label28;
        private Label label29;
        private Label label30;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private Label lblReligionIncorrect;
        private Label lblReligionCorrect;
        private Label label22;
        private Label label23;
        private Label label24;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lblHistoryIncorrect;
        private Label lblHistoryCorrect;
        private Label label17;
        private Label label18;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblScienceIncorrect;
        private Label lblScienceCorrect;
        private Label label12;
        private Label label13;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblTurkishIncorrect;
        private Label lblTurkishCorrect;
        private Label label7;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMathIncorrect;
        private Label lblMathCorrect;
        private Label label2;
        private Label label1;
        private Label label25;
        private DataGridView dgwExamList;
        private TabPage tabPage2;
        private LiveCharts.WinForms.CartesianChart chartLesson;
        private LiveCharts.WinForms.CartesianChart chartGeneral;
        private CheckBox chbxDisplayEnglish;
        private CheckBox chbxDisplayReligion;
        private CheckBox chbxDisplayHistory;
        private CheckBox chbxDisplayTurkish;
        private CheckBox chbxDisplayScience;
        private CheckBox chbxDisplayMath;
    }
}