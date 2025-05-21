namespace LGSTrackingSystem.Pages
{
    partial class LoginPage
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
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            lblUsernameMsg = new Label();
            lblPasswordMsg = new Label();
            SuspendLayout();
            // 
            // tbxUsername
            // 
            tbxUsername.BorderStyle = BorderStyle.FixedSingle;
            tbxUsername.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.Location = new Point(98, 76);
            tbxUsername.Margin = new Padding(3, 5, 3, 5);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = "Username";
            tbxUsername.Size = new Size(200, 37);
            tbxUsername.TabIndex = 2;
            // 
            // tbxPassword
            // 
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(98, 146);
            tbxPassword.Margin = new Padding(3, 5, 3, 5);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.PlaceholderText = "Password";
            tbxPassword.Size = new Size(200, 37);
            tbxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(133, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsernameMsg
            // 
            lblUsernameMsg.AutoSize = true;
            lblUsernameMsg.BackColor = Color.Transparent;
            lblUsernameMsg.ForeColor = Color.Red;
            lblUsernameMsg.Location = new Point(98, 118);
            lblUsernameMsg.Name = "lblUsernameMsg";
            lblUsernameMsg.Size = new Size(0, 20);
            lblUsernameMsg.TabIndex = 5;
            // 
            // lblPasswordMsg
            // 
            lblPasswordMsg.AutoSize = true;
            lblPasswordMsg.ForeColor = Color.Red;
            lblPasswordMsg.Location = new Point(98, 188);
            lblPasswordMsg.Name = "lblPasswordMsg";
            lblPasswordMsg.Size = new Size(0, 20);
            lblPasswordMsg.TabIndex = 6;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(6F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 303);
            Controls.Add(lblPasswordMsg);
            Controls.Add(lblUsernameMsg);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Font = new Font("Myanmar Text", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsernameMsg;
        private System.Windows.Forms.Label lblPasswordMsg;
    }
}