using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using DongTX.Core;
using DevComponents.DotNetBar;

namespace GPP
{
    public partial class MainWindow : DevComponents.DotNetBar.OfficeForm, IGuiMng
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckAndInitSQL();
        }

        public void ChangeScreen(object obj, GuiResId.ScreenMode screenMode)
        {
            if (screenMode == GuiResId.ScreenMode.Dialog)
            {
                Form frm = obj as Form;
                if (frm != null)
                {
                    frm.ShowInTaskbar = false;
                    frm.ShowDialog(this);
                }
            }
            else if (screenMode == GuiResId.ScreenMode.UserControl)
            {
                UserControl uc = obj as UserControl;
                if (uc != null)
                {
                    _panelMain.Controls.Clear();
                    uc.Dock = DockStyle.Fill;
                    _panelMain.Controls.Add(uc);
                }
            }
        }

        private void CheckAndInitSQL()
        {
            string filePath = Application.StartupPath + @"\Data\config.xml";
            if (File.Exists(filePath) == false)
            {
                SettingSQL frm = new SettingSQL();
                frm.ShowDialog();
            }
            else
            {
                ConfigSqlString(filePath);
            }
        }

        private void ConfigSqlString(string filePath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

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

                    if (_serverName == ""
                        || _databaseName == ""
                        || _userNameDatabase == ""
                        || _passWordsDatabase == "")
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        string strConnect = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                            _serverName,
                            _databaseName,
                            _userNameDatabase,
                            _passWordsDatabase);
                        SqlHelper.Instance.ConnectionString = strConnect;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException();
            }
        }

       

        private void _btnNhanVien_Click(object sender, System.EventArgs e)
        {
            frmNhanVienUC frm = new frmNhanVienUC();
            _panelMain.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            _panelMain.Controls.Add(frm);
            frm.Show();
        }
        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            frmThuocUC frm = new frmThuocUC();
            frm.TopLevel = false;
            _panelMain.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            _panelMain.Controls.Add(frm);
            frm.Show();
        }
    }
}