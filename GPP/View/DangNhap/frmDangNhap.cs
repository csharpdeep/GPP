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
    public partial class frmDangNhap : Form
    {
        #region Field
        private string _userName;
        private string _passWord;

        private bool _firstClickUserName = true;
        private bool _firstClickPassWords = true;
        #endregion

        #region Contructor
        public frmDangNhap()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        private void OnBtnLoginClick(object sender, EventArgs e)
        {
            if ((_txtUser.Text != "Tên đăng nhập" || _txtPassWords.Text != "Mật khẩu") 
                && _txtPassWords.Text != "" 
                && _txtUser.Text != "")
            {
                _userName = _txtUser.Text;
                _passWord = _txtPassWords.Text;

                ConnectSQL.Istance.InitInstance();
                string strQuery = "select MatKhau from NhanVien where TaiKhoan='" + _userName + "'";
                string strPassWords = ConnectSQL.Istance.ReturnString(strQuery);

                if (string.IsNullOrEmpty(strPassWords))
                {
                    MessageBox.Show("Tên đăng nhập hoặc tài khoản không tồn tại!");
                }
                else
                {
                    if (_passWord.Equals(strPassWords))
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.\nVui lòng kiểm tra và đăng nhập lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OnFrmDangNhapLoad(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void OnPictureBoxClosedClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
        }

        private void OnTxtUserClicked(object sender, EventArgs e)
        {
            if (_firstClickUserName == true)
            {
                _txtUser.Text = "";
                _firstClickUserName = false;
            }
        }

        private void OnTxtPassWordsClick(object sender, EventArgs e)
        {
            if (_firstClickPassWords == true)
            {
                _txtPassWords.Text = "";
                _txtPassWords.PasswordChar = '*';
                _txtPassWords.UseSystemPasswordChar = true;
                _firstClickPassWords = false;
            }

        }

        private void OnTxtUserTextChange(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
