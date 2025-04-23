namespace AdBoard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(189, 25);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(189, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(189, 148);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 30);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Зареєструватись";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += new EventHandler(this.btnRegister_Click);
            // 
            // btnShowReports 
            // 
            btnShowReports = new Button();
            btnShowReports.Location = new Point(189, 190);
            btnShowReports.Name = "btnShowReports";
            btnShowReports.Size = new Size(200, 30);
            btnShowReports.TabIndex = 4;
            btnShowReports.Text = "Показати звіти";
            btnShowReports.UseVisualStyleBackColor = true;
            btnShowReports.Click += new EventHandler(this.btnShowReports_Click);

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 33);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(103, 15);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Ім’я користувача:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 113);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Пароль:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 250);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnShowReports);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }   

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnShowReports;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
    }
}
