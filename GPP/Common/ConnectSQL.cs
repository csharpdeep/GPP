using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace GPP.Common
{
    class ConnectSQL
    {
        private static ConnectSQL _connectSQL = new ConnectSQL();
        private static SqlConnection connect;
        private SqlDataAdapter da;
        private DataTable dt;
        private string SQLString;
        public void InitInstance()
        {
            if ((System.IO.Directory.Exists(@"Data\Config.xml")))
            {
                SettingSQL s = new SettingSQL();
                s.Show();
            }
            ReadXML();
            connect = new SqlConnection(SQLString);
            connect.Open();
        }

        public void ReadXML()
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
                    SQLString = "Data Source=" + _serverName + ";" + "Initial Catalog=" + _databaseName + ";Integrated Security=True";
                }
            }
            catch
            {
            }
        }

        public static ConnectSQL Istance
        {
            get
            {
                return _connectSQL;
            }
        }
        public DataTable Getdata(string sql)
        {
            da = new SqlDataAdapter(sql, connect);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string ReturnString(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            string s="";
            try
            {
                s = cmd.ExecuteScalar().ToString();
            }
            catch { s = ""; }
            return s;
        }
        public bool ThucThiSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
