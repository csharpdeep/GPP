using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace GPP.View.HeThong.SaoLuuCSDL
{
    public partial class FrmBackupDataBase : DevComponents.DotNetBar.OfficeForm
    {

        private Server srv;
        private ServerConnection conn;
        private SqlCommand _command;
        private SqlConnection _conn;
        private SqlDataReader _read;
        private string sql = "";
        private string _connString = "";
        private string _fileName;


        public FrmBackupDataBase()
        {
            InitializeComponent();
            GetAllServerName();
        }
        private void GetAllServerName()
        {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
                String[] instances = (String[])rk.GetValue("InstalledInstances");
                if (instances.Length > 0)
                {
                    foreach (String element in instances)
                    {
                        if (element == "MSSQLSERVER")
                        {
                            _cbMayChu.Items.Add(System.Environment.MachineName);
                        }
                        else
                        {
                            _cbMayChu.Items.Add(System.Environment.MachineName + @"\" + element);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
       
        private void _txtDuongDan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _txtDuongDan.Text = dlg.SelectedPath;
            }
        }

        private void _txtBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cbTenCSDL.Text.CompareTo("") == 0 || _txtDuongDan.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Vui lòng chọn cơ sở dữ liệu hoặc đường dẫn", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _conn = new SqlConnection(_connString);
                _conn.Open();
                sql = "BACKUP DATABASE " + _cbTenCSDL.Text + " TO DISK = '" + _txtDuongDan.Text + "\\" + _cbTenCSDL.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                _command = new SqlCommand(sql, _conn);
                _command.ExecuteNonQuery();
                _conn.Close();
                _conn.Dispose();
                MessageBox.Show("Sao luu thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _btnKiemTraKetNoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                _connString = "Data Source = '" + _cbMayChu.Text + "'; User Id='" + _txtTenDangNhap.Text + "' ;Password = '" + _txtMatKhau.Text + "'";
                _conn = new SqlConnection(_connString);
                _conn.Open();
                // sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
                _command = new SqlCommand(sql, _conn);
                _read = _command.ExecuteReader();
                _cbTenCSDL.Items.Clear();
                while (_read.Read())
                {
                    _cbTenCSDL.Items.Add(_read[0].ToString());
                }
                _read.Dispose();
                _conn.Close();
                _conn.Dispose();
                _txtTenDangNhap.Enabled = false;
                _txtMatKhau.Enabled = false;
                _btnKiemTraKetNoi.Enabled = false;
                _cbTenCSDL.Focus();
                MessageBox.Show("Kết nối thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi", ex.Message);
            }
        }

        private void _btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi thứ sẽ thật rắc rối khi bạn không thường xuyên sao lưu csdl, nếu gặp bất cứ trục trặc gì trong quá trình sao lưu, hãy gọi ngay cho đội phát triển phần mềm",
                "Thông báo",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void _progressBarSaoLuu_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void _cbTenCSDL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _txtDuongDan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }
    }
}