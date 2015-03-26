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

namespace GPP
{
    public partial class MainWindow : Form
    {
        private int childFormNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CheckAndInitSQL();
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

                //add test form here
                frmChucVuUC frm = new frmChucVuUC();
                frm.Dock = DockStyle.Fill;
                panel1.Controls.Add(frm);
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
    }
}
