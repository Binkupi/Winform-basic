using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Client
{
    public partial class LoginPage : Form
    {
        private ClientDAO clientDao = new ClientDAO();
        public LoginPage()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Bạn cần nhập tên đăng nhập");
                textName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Bạn cần nhập mật khẩu");
                textPassword.Focus();
                return;
            }
            ClientModel client = new ClientModel(textName.Text, textPassword.Text);
            
            ClientModel clientSuccess = clientDao.getInfoClient(client);
            if (clientSuccess == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu vui lòng kiểm tra lại.");
            }
            else
            {
                this.Hide();
                Home home = new Home(clientSuccess);
                home.Show();
                Helper.Helper.sentAutoMessage(clientSuccess);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage register = new RegisterPage();
            register.Show();

        }

        private void btnForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordPage forgot = new ForgotPasswordPage();
            forgot.Show();
        }

        private void LoginPage_SizeChanged(object sender, EventArgs e)
        {
            panel.Location = new Point((panel.Parent.Width - panel.Width) / 2, (panel.Parent.Height - panel.Height) / 2);
        }
    }
}
