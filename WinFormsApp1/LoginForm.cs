using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Вы вошли как гость";
            Form1 mainform = new Form1("Guest");
            mainform.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtPassword.Text == "Admin123")
            {
                lblMessage.Text = "Вход как админ";
                Form1 mainform = new Form1("Admin");
                mainform.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "не корректные данные!!";
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
