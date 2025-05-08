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
            tbCtrl = new TabControl();
            tabPage1 = new TabPage();
            btnAddExam = new Button();
            dgwExamList = new DataGridView();
            tabPage2 = new TabPage();
            label2 = new Label();
            tbCtrl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwExamList).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tbCtrl
            // 
            tbCtrl.Controls.Add(tabPage1);
            tbCtrl.Controls.Add(tabPage2);
            tbCtrl.Dock = DockStyle.Fill;
            tbCtrl.Location = new Point(0, 0);
            tbCtrl.Name = "tbCtrl";
            tbCtrl.SelectedIndex = 0;
            tbCtrl.Size = new Size(797, 481);
            tbCtrl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddExam);
            tabPage1.Controls.Add(dgwExamList);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 448);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Exams";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddExam
            // 
            btnAddExam.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddExam.Location = new Point(741, 399);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(40, 40);
            btnAddExam.TabIndex = 1;
            btnAddExam.Text = "+";
            btnAddExam.UseVisualStyleBackColor = true;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // dgwExamList
            // 
            dgwExamList.AllowUserToAddRows = false;
            dgwExamList.AllowUserToDeleteRows = false;
            dgwExamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwExamList.BackgroundColor = Color.White;
            dgwExamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwExamList.Dock = DockStyle.Top;
            dgwExamList.Location = new Point(3, 3);
            dgwExamList.Name = "dgwExamList";
            dgwExamList.RowHeadersVisible = false;
            dgwExamList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExamList.ShowEditingIcon = false;
            dgwExamList.Size = new Size(783, 390);
            dgwExamList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 140);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbCtrl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private DataGridView dgwExamList;
        private Button btnAddExam;
    }
}