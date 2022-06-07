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

namespace WindowsFormsApp1.Client
{
    public partial class ForgotPasswordPage : Form
    {
        private ClientDAO clientDao = new ClientDAO();
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Bạn cần nhập mật khẩu");
                textEmail.Focus();
                return;
            }
            bool result = clientDao.update(textEmail.Text, "123");
            Helper.Helper.sentMail("Mật khẩu mới của bạn là: 123");
            if (result)
            {
                MessageBox.Show("Mật khẩu đã được cấp mới thành công. Vui lòng kiểm tra mail để sử dụng mật khẩu");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại.");
            }
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}
