using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPP.Common;

namespace GPP.View
{
    public partial class FormLogin : Form
    {
        private string _userName, _passWord;
        bool userFirstClick = true, passFirstClick = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "Tên đăng nhập" || txtPassWord.Text != "Mật khẩu") && txtPassWord.Text != "" && txtUser.Text != "")
            {
                _userName = txtUser.Text;
                _passWord = txtPassWord.Text;
               // DataTable userTable = new DataTable();
                ConnectSQL.Istance.InitInstance();
                string qr = "select MatKhau from NhanVien where TaiKhoan='" + _userName + "'";
                string tg = ConnectSQL.Istance.ReturnString(qr);
                if (tg=="")
                {
                    MessageBox.Show("Tên đăng nhập hoặc tài khoản không tồn tại!");
                }
                else
                {
                    if (_passWord == tg)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.\nVui lòng kiểm tra và đăng nhập lại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           // ConnectSQL.Istance.InitInstance();
            label1.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (userFirstClick == true)
            {
                txtUser.Text = "";
                userFirstClick = false;
            }
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            if (passFirstClick == true)
            {
                txtPassWord.Text = "";
                txtPassWord.PasswordChar = '*';
                txtPassWord.UseSystemPasswordChar = true;
                passFirstClick = false;
            }

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
