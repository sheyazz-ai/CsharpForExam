namespace WinFormsApp1
{
    partial class LoginForm
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
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnGuest = new Button();
            lblMessage = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15F);
            lblLogin.Location = new Point(169, 30);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(61, 28);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(157, 103);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(151, 23);
            txtLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(89, 135);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(49, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(88, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(203, 230);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(105, 23);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(193, 267);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(157, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 106);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 8;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(lblMessage);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tАвторизация — ООО «Обувь»";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnGuest;
        private Label lblMessage;
        private TextBox txtPassword;
        private Label label1;
    }
}