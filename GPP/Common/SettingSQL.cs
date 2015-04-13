using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace GPP
{
    public partial class SettingSQL: Form
    {
        #region Field
        private Server srv;
        private ServerConnection conn;
        #endregion

        #region Contructor
        public SettingSQL()
        {
            InitializeComponent();
            GetAllServerName();
            ReadXML();
        }
        #endregion

        #region Event
        private void OnBtnKiemTraKetNoiClick(object sender, EventArgs e)
        {
            try
            {
                _cbTenCSDL.Items.Clear();
                string sqlSErverInstance;
                sqlSErverInstance = _cbMayChu.SelectedItem.ToString();
                conn = new ServerConnection(sqlSErverInstance, _txtTenDangNhap.Text, _txtMatKhau.Text);
                srv = new Server(conn);
                foreach (Database db in srv.Databases)
                {
                    _cbTenCSDL.Items.Add(db.Name);
                }
                MessageBox.Show("Kết nối thành công đến CSDL","Thông báo");
            }
            catch (Exception err)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + err.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                _cbMayChu.Focus();
                return;
            }
        }

        private void OnBtnLuuCSDLClick(object sender, EventArgs e)
        {
            SaveToXML();
        }
        #endregion

        #region Method
        private void SaveToXML()
        {
            try
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Data\");

                XmlTextWriter xtw = new XmlTextWriter(@"Data/Config.xml", null);
                xtw.Formatting = Formatting.Indented;
                xtw.WriteStartDocument();
                xtw.WriteStartElement("application");
                xtw.WriteElementString("serverName", _cbMayChu.Text);
                xtw.WriteElementString("userNameDatabase", _txtTenDangNhap.Text);
                xtw.WriteElementString("passWordsDatabase", _txtMatKhau.Text);
                xtw.WriteElementString("databaseName", _cbTenCSDL.Text);
                xtw.WriteEndElement();
                xtw.WriteEndDocument();
                xtw.Flush();
                xtw.Close();
                MessageBox.Show("Lưu thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình lưu thông tin: " + ex.Message);
            }
        }
        
        private bool ReadXML()
        {
            try
            {
                string tenfile = @"Data/Config.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(tenfile);
                //Lấy dữ liệu từ file đổ vào XmlNodeList
                XmlNode goc = doc.DocumentElement;
                XmlNodeList ds = doc.SelectNodes("/application");
                foreach (XmlNode node in ds)
                {
                    XmlNode serverName = node.FirstChild;
                    XmlNode userNameDatabase = serverName.NextSibling;
                    XmlNode passWordsDatabase = userNameDatabase.NextSibling;
                    XmlNode databaseName = passWordsDatabase.NextSibling;


                    string _serverName = serverName.InnerText;
                    string _databaseName = databaseName.InnerText;
                    string _userNameDatabase = userNameDatabase.InnerText;
                    string _passWordsDatabase = passWordsDatabase.InnerText;

                    if (_serverName == "" && _databaseName == "" && _userNameDatabase == "" && _passWordsDatabase == "")
                        return false;
                    _cbMayChu.Text = _serverName;
                    _txtTenDangNhap.Text = _userNameDatabase;
                    _txtMatKhau.Text = _passWordsDatabase;
                    _cbTenCSDL.Text = _databaseName;
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
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
        #endregion
    }
}
