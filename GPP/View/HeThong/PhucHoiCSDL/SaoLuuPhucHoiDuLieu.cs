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

namespace GPP.View.HeThong.PhucHoiCSDL
{
    public partial class SaoLuuPhucHoiDuLieu : DevComponents.DotNetBar.OfficeForm
    {

        private Server srv;
        private ServerConnection conn;
        private SqlCommand _command;
        private SqlConnection _conn;
        private SqlDataReader _read;
        private string sql = "";
        string connString = "";
        private string _fileName;


        public SaoLuuPhucHoiDuLieu()
        {
            InitializeComponent();
            GetAllServerName();
        }
        private void SaoLuuPhucHoiDuLieu_Load(object sender, EventArgs e)
        {

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

        private void _btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                connString = "Data Source = '" + _cbMayChu.Text + "'; User Id='" + _txtTenDangNhap.Text + "' ;Password = '" + _txtMatKhau.Text + "'";
                _conn = new SqlConnection(connString);
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
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi", ex.Message);
            }
        }
        private void _txtBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cbTenCSDL.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Vui lòng chọn cơ sở dữ liệu", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _conn = new SqlConnection(connString);
                _conn.Open();
                sql = "BACKUP DATABASE '" + _cbTenCSDL.Text + "' TO DISK = '" + _txtDuongDan.Text + "\\" + _cbTenCSDL.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
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

        private void _txtDuongDan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _txtDuongDan.Text = dlg.SelectedPath;
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Backup Files(*.bak)|*.bak|All File(*.*)|*.*";
            openFileDlg.FilterIndex = 0;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDlg.FileName;
                textBox1.Text = _fileName;
            }
        }

        private void _btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cbTenCSDL.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Vui lòng chọn csdl", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _conn = new SqlConnection();
                _conn.Open();
                sql = "ALTER DATABASE " + _cbTenCSDL.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ";
                sql += "RESTORE DATABASE " + _cbTenCSDL.Text + " FROM DISK='" + textBox1.Text + "' WITH REPLACE;";
                _command = new SqlCommand(sql, _conn);
                _command.ExecuteNonQuery();
                _conn.Close();
                _conn.Dispose();
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}