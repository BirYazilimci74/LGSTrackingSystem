namespace LGSTrackingSystem.Pages
{
    partial class ExamPage
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
            btnOK = new Button();
            btnCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbxEnglishNet = new TextBox();
            tbxReligionNet = new TextBox();
            tbxHistoryNet = new TextBox();
            tbxTurkishNet = new TextBox();
            tbxScienceNet = new TextBox();
            numEnglishIncorrect = new NumericUpDown();
            numEnglishCorrect = new NumericUpDown();
            numReligionIncorrect = new NumericUpDown();
            numReligionCorrect = new NumericUpDown();
            numHistoryIncorrect = new NumericUpDown();
            numHistoryCorrect = new NumericUpDown();
            numTurkishIncorrect = new NumericUpDown();
            numTurkishCorrect = new NumericUpDown();
            numScienceIncorrect = new NumericUpDown();
            numScienceCorrect = new NumericUpDown();
            numMathIncorrect = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numMathCorrect = new NumericUpDown();
            tbxMathNet = new TextBox();
            label7 = new Label();
            tbxExamName = new TextBox();
            dtpExamDate = new DateTimePicker();
            label11 = new Label();
            lblMsg = new Label();
            tbxTotalNet = new TextBox();
            tbxScore = new TextBox();
            label12 = new Label();
            label13 = new Label();
            btnCalculate = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEnglishIncorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEnglishCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReligionIncorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReligionCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHistoryIncorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHistoryCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTurkishIncorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTurkishCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numScienceIncorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numScienceCorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMathIncorrect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMathCorrect).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(581, 510);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(120, 40);
            btnOK.TabIndex = 12;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(457, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3123875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.1867142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.8276482F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8527832F));
            tableLayoutPanel1.Controls.Add(tbxEnglishNet, 3, 6);
            tableLayoutPanel1.Controls.Add(tbxReligionNet, 3, 5);
            tableLayoutPanel1.Controls.Add(tbxHistoryNet, 3, 4);
            tableLayoutPanel1.Controls.Add(tbxTurkishNet, 3, 3);
            tableLayoutPanel1.Controls.Add(tbxScienceNet, 3, 2);
            tableLayoutPanel1.Controls.Add(numEnglishIncorrect, 2, 6);
            tableLayoutPanel1.Controls.Add(numEnglishCorrect, 1, 6);
            tableLayoutPanel1.Controls.Add(numReligionIncorrect, 2, 5);
            tableLayoutPanel1.Controls.Add(numReligionCorrect, 1, 5);
            tableLayoutPanel1.Controls.Add(numHistoryIncorrect, 2, 4);
            tableLayoutPanel1.Controls.Add(numHistoryCorrect, 1, 4);
            tableLayoutPanel1.Controls.Add(numTurkishIncorrect, 2, 3);
            tableLayoutPanel1.Controls.Add(numTurkishCorrect, 1, 3);
            tableLayoutPanel1.Controls.Add(numScienceIncorrect, 2, 2);
            tableLayoutPanel1.Controls.Add(numScienceCorrect, 1, 2);
            tableLayoutPanel1.Controls.Add(numMathIncorrect, 2, 1);
            tableLayoutPanel1.Controls.Add(label10, 3, 0);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(label8, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(numMathCorrect, 1, 1);
            tableLayoutPanel1.Controls.Add(tbxMathNet, 3, 1);
            tableLayoutPanel1.Location = new Point(101, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(558, 267);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tbxEnglishNet
            // 
            tbxEnglishNet.Dock = DockStyle.Fill;
            tbxEnglishNet.Font = new Font("Segoe UI", 12F);
            tbxEnglishNet.Location = new Point(413, 229);
            tbxEnglishNet.Margin = new Padding(0);
            tbxEnglishNet.Name = "tbxEnglishNet";
            tbxEnglishNet.ReadOnly = true;
            tbxEnglishNet.Size = new Size(144, 29);
            tbxEnglishNet.TabIndex = 34;
            // 
            // tbxReligionNet
            // 
            tbxReligionNet.Dock = DockStyle.Fill;
            tbxReligionNet.Font = new Font("Segoe UI", 12F);
            tbxReligionNet.Location = new Point(413, 191);
            tbxReligionNet.Margin = new Padding(0);
            tbxReligionNet.Name = "tbxReligionNet";
            tbxReligionNet.ReadOnly = true;
            tbxReligionNet.Size = new Size(144, 29);
            tbxReligionNet.TabIndex = 33;
            // 
            // tbxHistoryNet
            // 
            tbxHistoryNet.Dock = DockStyle.Fill;
            tbxHistoryNet.Font = new Font("Segoe UI", 12F);
            tbxHistoryNet.Location = new Point(413, 153);
            tbxHistoryNet.Margin = new Padding(0);
            tbxHistoryNet.Name = "tbxHistoryNet";
            tbxHistoryNet.ReadOnly = true;
            tbxHistoryNet.Size = new Size(144, 29);
            tbxHistoryNet.TabIndex = 32;
            // 
            // tbxTurkishNet
            // 
            tbxTurkishNet.Dock = DockStyle.Fill;
            tbxTurkishNet.Font = new Font("Segoe UI", 12F);
            tbxTurkishNet.Location = new Point(413, 115);
            tbxTurkishNet.Margin = new Padding(0);
            tbxTurkishNet.Name = "tbxTurkishNet";
            tbxTurkishNet.ReadOnly = true;
            tbxTurkishNet.Size = new Size(144, 29);
            tbxTurkishNet.TabIndex = 31;
            // 
            // tbxScienceNet
            // 
            tbxScienceNet.Dock = DockStyle.Fill;
            tbxScienceNet.Font = new Font("Segoe UI", 12F);
            tbxScienceNet.Location = new Point(413, 77);
            tbxScienceNet.Margin = new Padding(0);
            tbxScienceNet.Name = "tbxScienceNet";
            tbxScienceNet.ReadOnly = true;
            tbxScienceNet.Size = new Size(144, 29);
            tbxScienceNet.TabIndex = 30;
            // 
            // numEnglishIncorrect
            // 
            numEnglishIncorrect.Dock = DockStyle.Fill;
            numEnglishIncorrect.Font = new Font("Myanmar Text", 12F);
            numEnglishIncorrect.Location = new Point(259, 229);
            numEnglishIncorrect.Margin = new Padding(0);
            numEnglishIncorrect.Name = "numEnglishIncorrect";
            numEnglishIncorrect.Size = new Size(153, 37);
            numEnglishIncorrect.TabIndex = 27;
            numEnglishIncorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numEnglishCorrect
            // 
            numEnglishCorrect.Dock = DockStyle.Fill;
            numEnglishCorrect.Font = new Font("Myanmar Text", 12F);
            numEnglishCorrect.Location = new Point(103, 229);
            numEnglishCorrect.Margin = new Padding(0);
            numEnglishCorrect.Name = "numEnglishCorrect";
            numEnglishCorrect.Size = new Size(155, 37);
            numEnglishCorrect.TabIndex = 26;
            numEnglishCorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numReligionIncorrect
            // 
            numReligionIncorrect.Dock = DockStyle.Fill;
            numReligionIncorrect.Font = new Font("Myanmar Text", 12F);
            numReligionIncorrect.Location = new Point(259, 191);
            numReligionIncorrect.Margin = new Padding(0);
            numReligionIncorrect.Name = "numReligionIncorrect";
            numReligionIncorrect.Size = new Size(153, 37);
            numReligionIncorrect.TabIndex = 24;
            numReligionIncorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numReligionCorrect
            // 
            numReligionCorrect.Dock = DockStyle.Fill;
            numReligionCorrect.Font = new Font("Myanmar Text", 12F);
            numReligionCorrect.Location = new Point(103, 191);
            numReligionCorrect.Margin = new Padding(0);
            numReligionCorrect.Name = "numReligionCorrect";
            numReligionCorrect.Size = new Size(155, 37);
            numReligionCorrect.TabIndex = 23;
            numReligionCorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numHistoryIncorrect
            // 
            numHistoryIncorrect.Dock = DockStyle.Fill;
            numHistoryIncorrect.Font = new Font("Myanmar Text", 12F);
            numHistoryIncorrect.Location = new Point(259, 153);
            numHistoryIncorrect.Margin = new Padding(0);
            numHistoryIncorrect.Name = "numHistoryIncorrect";
            numHistoryIncorrect.Size = new Size(153, 37);
            numHistoryIncorrect.TabIndex = 21;
            numHistoryIncorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numHistoryCorrect
            // 
            numHistoryCorrect.Dock = DockStyle.Fill;
            numHistoryCorrect.Font = new Font("Myanmar Text", 12F);
            numHistoryCorrect.Location = new Point(103, 153);
            numHistoryCorrect.Margin = new Padding(0);
            numHistoryCorrect.Name = "numHistoryCorrect";
            numHistoryCorrect.Size = new Size(155, 37);
            numHistoryCorrect.TabIndex = 20;
            numHistoryCorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numTurkishIncorrect
            // 
            numTurkishIncorrect.Dock = DockStyle.Fill;
            numTurkishIncorrect.Font = new Font("Myanmar Text", 12F);
            numTurkishIncorrect.Location = new Point(259, 115);
            numTurkishIncorrect.Margin = new Padding(0);
            numTurkishIncorrect.Name = "numTurkishIncorrect";
            numTurkishIncorrect.Size = new Size(153, 37);
            numTurkishIncorrect.TabIndex = 18;
            numTurkishIncorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numTurkishCorrect
            // 
            numTurkishCorrect.Dock = DockStyle.Fill;
            numTurkishCorrect.Font = new Font("Myanmar Text", 12F);
            numTurkishCorrect.Location = new Point(103, 115);
            numTurkishCorrect.Margin = new Padding(0);
            numTurkishCorrect.Name = "numTurkishCorrect";
            numTurkishCorrect.Size = new Size(155, 37);
            numTurkishCorrect.TabIndex = 17;
            numTurkishCorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numScienceIncorrect
            // 
            numScienceIncorrect.Dock = DockStyle.Fill;
            numScienceIncorrect.Font = new Font("Myanmar Text", 12F);
            numScienceIncorrect.Location = new Point(259, 77);
            numScienceIncorrect.Margin = new Padding(0);
            numScienceIncorrect.Name = "numScienceIncorrect";
            numScienceIncorrect.Size = new Size(153, 37);
            numScienceIncorrect.TabIndex = 15;
            numScienceIncorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numScienceCorrect
            // 
            numScienceCorrect.Dock = DockStyle.Fill;
            numScienceCorrect.Font = new Font("Myanmar Text", 12F);
            numScienceCorrect.Location = new Point(103, 77);
            numScienceCorrect.Margin = new Padding(0);
            numScienceCorrect.Name = "numScienceCorrect";
            numScienceCorrect.Size = new Size(155, 37);
            numScienceCorrect.TabIndex = 14;
            numScienceCorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // numMathIncorrect
            // 
            numMathIncorrect.Dock = DockStyle.Fill;
            numMathIncorrect.Font = new Font("Myanmar Text", 12F);
            numMathIncorrect.Location = new Point(259, 39);
            numMathIncorrect.Margin = new Padding(0);
            numMathIncorrect.Name = "numMathIncorrect";
            numMathIncorrect.Size = new Size(153, 37);
            numMathIncorrect.TabIndex = 12;
            numMathIncorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(416, 1);
            label10.Name = "label10";
            label10.Size = new Size(138, 37);
            label10.TabIndex = 9;
            label10.Text = "Net";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(262, 1);
            label9.Name = "label9";
            label9.Size = new Size(147, 37);
            label9.TabIndex = 8;
            label9.Text = "Incorrect";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(106, 1);
            label8.Name = "label8";
            label8.Size = new Size(149, 37);
            label8.TabIndex = 7;
            label8.Text = "Correct";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(4, 229);
            label6.Name = "label6";
            label6.Size = new Size(95, 37);
            label6.TabIndex = 5;
            label6.Text = "English";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(4, 191);
            label5.Name = "label5";
            label5.Size = new Size(95, 37);
            label5.TabIndex = 4;
            label5.Text = "Religion";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(4, 153);
            label4.Name = "label4";
            label4.Size = new Size(95, 37);
            label4.TabIndex = 3;
            label4.Text = "History";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(4, 115);
            label3.Name = "label3";
            label3.Size = new Size(95, 37);
            label3.TabIndex = 2;
            label3.Text = "Turkish";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(4, 77);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 1;
            label2.Text = "Science";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(4, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 37);
            label1.TabIndex = 0;
            label1.Text = "Math";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numMathCorrect
            // 
            numMathCorrect.Dock = DockStyle.Fill;
            numMathCorrect.Font = new Font("Myanmar Text", 12F);
            numMathCorrect.Location = new Point(103, 39);
            numMathCorrect.Margin = new Padding(0);
            numMathCorrect.Name = "numMathCorrect";
            numMathCorrect.Size = new Size(155, 37);
            numMathCorrect.TabIndex = 10;
            numMathCorrect.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxMathNet
            // 
            tbxMathNet.Dock = DockStyle.Fill;
            tbxMathNet.Font = new Font("Segoe UI", 12F);
            tbxMathNet.Location = new Point(413, 39);
            tbxMathNet.Margin = new Padding(0);
            tbxMathNet.Name = "tbxMathNet";
            tbxMathNet.ReadOnly = true;
            tbxMathNet.Size = new Size(144, 29);
            tbxMathNet.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(103, 29);
            label7.TabIndex = 15;
            label7.Text = "Exam Name: ";
            // 
            // tbxExamName
            // 
            tbxExamName.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxExamName.Location = new Point(121, 11);
            tbxExamName.Name = "tbxExamName";
            tbxExamName.Size = new Size(229, 30);
            tbxExamName.TabIndex = 16;
            // 
            // dtpExamDate
            // 
            dtpExamDate.Location = new Point(121, 50);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(227, 23);
            dtpExamDate.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(63, 50);
            label11.Name = "label11";
            label11.Size = new Size(52, 29);
            label11.TabIndex = 18;
            label11.Text = "Date: ";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(101, 412);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 15);
            lblMsg.TabIndex = 19;
            // 
            // tbxTotalNet
            // 
            tbxTotalNet.Font = new Font("Segoe UI", 12F);
            tbxTotalNet.Location = new Point(514, 369);
            tbxTotalNet.Margin = new Padding(0);
            tbxTotalNet.Name = "tbxTotalNet";
            tbxTotalNet.ReadOnly = true;
            tbxTotalNet.Size = new Size(144, 29);
            tbxTotalNet.TabIndex = 29;
            // 
            // tbxScore
            // 
            tbxScore.Font = new Font("Segoe UI", 12F);
            tbxScore.Location = new Point(514, 412);
            tbxScore.Margin = new Padding(0);
            tbxScore.Name = "tbxScore";
            tbxScore.ReadOnly = true;
            tbxScore.Size = new Size(144, 29);
            tbxScore.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(454, 412);
            label12.Name = "label12";
            label12.Size = new Size(59, 29);
            label12.TabIndex = 31;
            label12.Text = "Score: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(430, 369);
            label13.Name = "label13";
            label13.Size = new Size(83, 29);
            label13.TabIndex = 32;
            label13.Text = "Total Net: ";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(101, 370);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(127, 29);
            btnCalculate.TabIndex = 33;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // ExamPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 576);
            Controls.Add(btnCalculate);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(tbxScore);
            Controls.Add(tbxTotalNet);
            Controls.Add(lblMsg);
            Controls.Add(label11);
            Controls.Add(dtpExamDate);
            Controls.Add(tbxExamName);
            Controls.Add(label7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExamPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Exam";
            Load += ExamPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEnglishIncorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEnglishCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReligionIncorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReligionCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHistoryIncorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHistoryCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTurkishIncorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTurkishCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numScienceIncorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numScienceCorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMathIncorrect).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMathCorrect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOK;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private NumericUpDown numEnglishIncorrect;
        private NumericUpDown numEnglishCorrect;
        private NumericUpDown numReligionIncorrect;
        private NumericUpDown numReligionCorrect;
        private NumericUpDown numHistoryIncorrect;
        private NumericUpDown numHistoryCorrect;
        private NumericUpDown numTurkishIncorrect;
        private NumericUpDown numTurkishCorrect;
        private NumericUpDown numScienceIncorrect;
        private NumericUpDown numScienceCorrect;
        private NumericUpDown numMathIncorrect;
        private NumericUpDown numMathCorrect;
        private TextBox tbxEnglishNet;
        private TextBox tbxReligionNet;
        private TextBox tbxHistoryNet;
        private TextBox tbxTurkishNet;
        private TextBox tbxScienceNet;
        private TextBox tbxMathNet;
        private Label label7;
        private TextBox tbxExamName;
        private DateTimePicker dtpExamDate;
        private Label label11;
        private Label lblMsg;
        private TextBox tbxTotalNet;
        private TextBox tbxScore;
        private Label label12;
        private Label label13;
        private Button btnCalculate;
    }
}