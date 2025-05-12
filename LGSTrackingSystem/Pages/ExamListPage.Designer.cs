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
            dgwExamList = new DataGridView();
            examContextMenu = new ContextMenuStrip(components);
            addExamToolStripMenuItem = new ToolStripMenuItem();
            editExamToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgwExamList).BeginInit();
            examContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dgwExamList
            // 
            dgwExamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwExamList.BackgroundColor = Color.White;
            dgwExamList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwExamList.ContextMenuStrip = examContextMenu;
            dgwExamList.Dock = DockStyle.Fill;
            dgwExamList.Location = new Point(0, 0);
            dgwExamList.Name = "dgwExamList";
            dgwExamList.RowHeadersVisible = false;
            dgwExamList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExamList.Size = new Size(776, 449);
            dgwExamList.TabIndex = 0;
            // 
            // examContextMenu
            // 
            examContextMenu.Items.AddRange(new ToolStripItem[] { addExamToolStripMenuItem, editExamToolStripMenuItem, deleteToolStripMenuItem });
            examContextMenu.Name = "examContextMenu";
            examContextMenu.Size = new Size(139, 70);
            // 
            // addExamToolStripMenuItem
            // 
            addExamToolStripMenuItem.Name = "addExamToolStripMenuItem";
            addExamToolStripMenuItem.Size = new Size(138, 22);
            addExamToolStripMenuItem.Text = "Add Exam";
            addExamToolStripMenuItem.Click += addExamToolStripMenuItem_Click;
            // 
            // editExamToolStripMenuItem
            // 
            editExamToolStripMenuItem.Name = "editExamToolStripMenuItem";
            editExamToolStripMenuItem.Size = new Size(138, 22);
            editExamToolStripMenuItem.Text = "Edit Exam";
            editExamToolStripMenuItem.Click += editExamToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(138, 22);
            deleteToolStripMenuItem.Text = "Delete Exam";
            deleteToolStripMenuItem.Click += deleteExamToolStripMenuItem_Click;
            // 
            // ExamListPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 449);
            Controls.Add(dgwExamList);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExamListPage";
            ShowIcon = false;
            Text = "ExamListPage";
            Load += ExamListPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgwExamList).EndInit();
            examContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwExamList;
        private ContextMenuStrip examContextMenu;
        private ToolStripMenuItem addExamToolStripMenuItem;
        private ToolStripMenuItem editExamToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}