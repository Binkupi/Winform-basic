using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            textPasswordAgain.PasswordChar = '*';
            textPassword.PasswordChar = '*';
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
            if (string.IsNullOrEmpty(textPasswordAgain.Text))
            {
                MessageBox.Show("Bạn cần nhập lại mật khẩu");
                textPasswordAgain.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Bạn cần nhập email");
                textEmail.Focus();
                return;
            }
            if (!textPassword.Text.Equals(textPasswordAgain.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp.");
                textPasswordAgain.Text = "";
                textPasswordAgain.Focus();
                return;
            }
            string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex myRegex = new Regex(pattern);
            Match m = myRegex.Match(textEmail.Text);
            if (!m.Success)
            {
                MessageBox.Show("Email của bạn không đúng. Vui lòng kiểm tra lại");
                textEmail.Focus();
                return;
            }
            if (clientDao.CheckClient(textEmail.Text))
            {
                MessageBox.Show("Email đã được sử dụng vui lòng dùng email đăng kí khác");
            
                return;
            }
            ClientModel client = new ClientModel(textName.Text, textPasswordAgain.Text, textEmail.Text);
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

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void RegisterPage_SizeChanged(object sender, EventArgs e)
        {
            panel.Location = new Point((panel.Parent.Width - panel.Width) / 2, (panel.Parent.Height - panel.Height) / 2);
        }
    }
}
