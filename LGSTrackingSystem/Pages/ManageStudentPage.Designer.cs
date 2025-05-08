namespace LGSTrackingSystem.Pages
{
    partial class ManageStudentPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxEmail = new TextBox();
            tbxSchoolName = new TextBox();
            msktbxPhone = new MaskedTextBox();
            tbxClass = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 12F);
            label1.Location = new Point(89, 66);
            label1.Name = "label1";
            label1.Size = new Size(96, 29);
            label1.TabIndex = 0;
            label1.Text = "First Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 12F);
            label2.Location = new Point(90, 107);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 1;
            label2.Text = "Last Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 12F);
            label3.Location = new Point(126, 148);
            label3.Name = "label3";
            label3.Size = new Size(58, 29);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 12F);
            label4.Location = new Point(120, 189);
            label4.Name = "label4";
            label4.Size = new Size(64, 29);
            label4.TabIndex = 3;
            label4.Text = "Phone: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 12F);
            label5.Location = new Point(71, 230);
            label5.Name = "label5";
            label5.Size = new Size(113, 29);
            label5.TabIndex = 4;
            label5.Text = "School Name: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Myanmar Text", 12F);
            label6.Location = new Point(128, 270);
            label6.Name = "label6";
            label6.Size = new Size(56, 29);
            label6.TabIndex = 5;
            label6.Text = "Class: ";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(185, 65);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(152, 30);
            tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(185, 106);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(152, 30);
            tbxLastName.TabIndex = 2;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(185, 147);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(152, 30);
            tbxEmail.TabIndex = 3;
            // 
            // tbxSchoolName
            // 
            tbxSchoolName.Location = new Point(185, 229);
            tbxSchoolName.Name = "tbxSchoolName";
            tbxSchoolName.Size = new Size(152, 30);
            tbxSchoolName.TabIndex = 5;
            // 
            // msktbxPhone
            // 
            msktbxPhone.Location = new Point(185, 188);
            msktbxPhone.Mask = "(999) 000-0000";
            msktbxPhone.Name = "msktbxPhone";
            msktbxPhone.Size = new Size(152, 30);
            msktbxPhone.TabIndex = 4;
            // 
            // tbxClass
            // 
            tbxClass.Location = new Point(185, 270);
            tbxClass.Name = "tbxClass";
            tbxClass.Size = new Size(152, 30);
            tbxClass.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(378, 373);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(105, 32);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(267, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ManageStudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 417);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(tbxClass);
            Controls.Add(msktbxPhone);
            Controls.Add(tbxSchoolName);
            Controls.Add(tbxEmail);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageStudentPage";
            ShowIcon = false;
            Text = "ManageStudentPage";
            Load += ManageStudentPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxEmail;
        private TextBox tbxSchoolName;
        private MaskedTextBox msktbxPhone;
        private TextBox tbxClass;
        private Button btnOK;
        private Button btnCancel;
    }
}