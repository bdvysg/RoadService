namespace RoadService
{
    partial class Login
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
            btnLogin = new Button();
            lblName = new Label();
            txtBLogin = new TextBox();
            lblPassword = new Label();
            txtBPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.Location = new Point(327, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 35);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F);
            lblName.Location = new Point(297, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(158, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Ім'я користувача";
            // 
            // txtBLogin
            // 
            txtBLogin.Font = new Font("Segoe UI", 14F);
            txtBLogin.Location = new Point(326, 122);
            txtBLogin.Name = "txtBLogin";
            txtBLogin.Size = new Size(100, 32);
            txtBLogin.TabIndex = 2;
            txtBLogin.Text = "manager1";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14F);
            lblPassword.Location = new Point(337, 197);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            // 
            // txtBPassword
            // 
            txtBPassword.Font = new Font("Segoe UI", 14F);
            txtBPassword.Location = new Point(326, 235);
            txtBPassword.Name = "txtBPassword";
            txtBPassword.PasswordChar = '*';
            txtBPassword.Size = new Size(100, 32);
            txtBPassword.TabIndex = 4;
            txtBPassword.Text = "temp1212";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBLogin);
            Controls.Add(lblName);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Вхід";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblName;
        private TextBox txtBLogin;
        private Label lblPassword;
        private TextBox txtBPassword;
    }
}