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
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxEmail = new TextBox();
            tbxSchoolName = new TextBox();
            msktbxPhone = new MaskedTextBox();
            btnOK = new Button();
            btnCancel = new Button();
            lblFirstNameMsg = new Label();
            lblPhoneMsg = new Label();
            lblSchoolNameMsg = new Label();
            lblEmailMsg = new Label();
            lblLastNameMsg = new Label();
            cbxClass = new ComboBox();
            SuspendLayout();
            // 
            // tbxFirstName
            // 
            tbxFirstName.BorderStyle = BorderStyle.FixedSingle;
            tbxFirstName.Font = new Font("Myanmar Text", 9.75F);
            tbxFirstName.Location = new Point(100, 70);
            tbxFirstName.Margin = new Padding(0, 0, 0, 10);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "First Name";
            tbxFirstName.RightToLeft = RightToLeft.No;
            tbxFirstName.Size = new Size(217, 32);
            tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            tbxLastName.BorderStyle = BorderStyle.FixedSingle;
            tbxLastName.Font = new Font("Myanmar Text", 9.75F);
            tbxLastName.Location = new Point(100, 110);
            tbxLastName.Margin = new Padding(0, 0, 0, 10);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "Last Name";
            tbxLastName.RightToLeft = RightToLeft.No;
            tbxLastName.Size = new Size(217, 32);
            tbxLastName.TabIndex = 2;
            // 
            // tbxEmail
            // 
            tbxEmail.BorderStyle = BorderStyle.FixedSingle;
            tbxEmail.Font = new Font("Myanmar Text", 9.75F);
            tbxEmail.Location = new Point(100, 150);
            tbxEmail.Margin = new Padding(0, 0, 0, 10);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "example@gmail.com";
            tbxEmail.RightToLeft = RightToLeft.No;
            tbxEmail.Size = new Size(217, 32);
            tbxEmail.TabIndex = 3;
            tbxEmail.Leave += tbxEmail_Leave;
            // 
            // tbxSchoolName
            // 
            tbxSchoolName.BorderStyle = BorderStyle.FixedSingle;
            tbxSchoolName.Font = new Font("Myanmar Text", 9.75F);
            tbxSchoolName.Location = new Point(100, 230);
            tbxSchoolName.Margin = new Padding(0, 0, 0, 10);
            tbxSchoolName.Name = "tbxSchoolName";
            tbxSchoolName.PlaceholderText = "School Name";
            tbxSchoolName.RightToLeft = RightToLeft.No;
            tbxSchoolName.Size = new Size(160, 32);
            tbxSchoolName.TabIndex = 5;
            // 
            // msktbxPhone
            // 
            msktbxPhone.BorderStyle = BorderStyle.FixedSingle;
            msktbxPhone.Font = new Font("Myanmar Text", 9.75F);
            msktbxPhone.Location = new Point(100, 190);
            msktbxPhone.Margin = new Padding(0, 0, 0, 10);
            msktbxPhone.Mask = "(999) 000-0000";
            msktbxPhone.Name = "msktbxPhone";
            msktbxPhone.RightToLeft = RightToLeft.No;
            msktbxPhone.Size = new Size(217, 32);
            msktbxPhone.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(324, 365);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(105, 32);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(213, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFirstNameMsg
            // 
            lblFirstNameMsg.AutoSize = true;
            lblFirstNameMsg.ForeColor = Color.Red;
            lblFirstNameMsg.Location = new Point(320, 77);
            lblFirstNameMsg.Name = "lblFirstNameMsg";
            lblFirstNameMsg.Size = new Size(0, 21);
            lblFirstNameMsg.TabIndex = 9;
            // 
            // lblPhoneMsg
            // 
            lblPhoneMsg.AutoSize = true;
            lblPhoneMsg.ForeColor = Color.Red;
            lblPhoneMsg.Location = new Point(320, 197);
            lblPhoneMsg.Name = "lblPhoneMsg";
            lblPhoneMsg.Size = new Size(0, 21);
            lblPhoneMsg.TabIndex = 12;
            // 
            // lblSchoolNameMsg
            // 
            lblSchoolNameMsg.AutoSize = true;
            lblSchoolNameMsg.ForeColor = Color.Red;
            lblSchoolNameMsg.Location = new Point(100, 272);
            lblSchoolNameMsg.Name = "lblSchoolNameMsg";
            lblSchoolNameMsg.Size = new Size(0, 21);
            lblSchoolNameMsg.TabIndex = 13;
            // 
            // lblEmailMsg
            // 
            lblEmailMsg.AutoSize = true;
            lblEmailMsg.ForeColor = Color.Red;
            lblEmailMsg.Location = new Point(320, 156);
            lblEmailMsg.Name = "lblEmailMsg";
            lblEmailMsg.Size = new Size(0, 21);
            lblEmailMsg.TabIndex = 14;
            // 
            // lblLastNameMsg
            // 
            lblLastNameMsg.AutoSize = true;
            lblLastNameMsg.ForeColor = Color.Red;
            lblLastNameMsg.Location = new Point(320, 117);
            lblLastNameMsg.Name = "lblLastNameMsg";
            lblLastNameMsg.Size = new Size(0, 21);
            lblLastNameMsg.TabIndex = 10;
            // 
            // cbxClass
            // 
            cbxClass.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxClass.FormattingEnabled = true;
            cbxClass.Location = new Point(263, 230);
            cbxClass.Name = "cbxClass";
            cbxClass.Size = new Size(55, 31);
            cbxClass.TabIndex = 6;
            // 
            // ManageStudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 409);
            Controls.Add(cbxClass);
            Controls.Add(lblEmailMsg);
            Controls.Add(lblSchoolNameMsg);
            Controls.Add(lblPhoneMsg);
            Controls.Add(lblLastNameMsg);
            Controls.Add(lblFirstNameMsg);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(msktbxPhone);
            Controls.Add(tbxSchoolName);
            Controls.Add(tbxEmail);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
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
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxEmail;
        private TextBox tbxSchoolName;
        private MaskedTextBox msktbxPhone;
        private Button btnOK;
        private Button btnCancel;
        private Label lblFirstNameMsg;
        private Label lblPhoneMsg;
        private Label lblSchoolNameMsg;
        private Label lblEmailMsg;
        private Label lblLastNameMsg;
        private ComboBox cbxClass;
    }
}