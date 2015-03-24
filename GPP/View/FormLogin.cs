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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text != "" && txtUser.Text != "")
            {
    
                _userName = txtUser.Text;
                _passWord = txtPassWord.Text;
                DataTable userTable = new DataTable();
                string qr = "select TaiKhoan,MatKhau from user where TaiKhoan='" + _userName + "'";
                userTable = ConnectSQL.Istance.Getdata(qr);
                if (userTable.Rows.Count == 0)
                {
                    MessageBox.Show("Ten dang nhap hoac tai khoan khong ton tai!");
                }
                {
                    if (_passWord == userTable.Rows[0][1].ToString())
                    {
                        MessageBox.Show("Dang nhap thanh cong!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.\nVui lòng kiểm tra và đăng nhập lại","Lỗi",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
