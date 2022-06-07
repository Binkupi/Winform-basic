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
    public partial class RegisterPage : Form
    {
        private ClientDAO clientDao = new ClientDAO();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Bạn cần nhập email");
                textEmail.Focus();
                return;
            }
            ClientModel client = new ClientModel(textName.Text, textPassword.Text, textEmail.Text);
            bool result = clientDao.insertClient(client);
            if (result)
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}
