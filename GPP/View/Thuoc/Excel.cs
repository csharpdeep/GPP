using System.Data.OleDb;
using System.Data;
namespace GPP
{
    public class MoFileExcel
    {
        private string _cn;
        private OleDbConnection _con;
        public MoFileExcel(string pathFile)
        {
            if (pathFile.Contains("xlsx")) _cn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathFile + ";" + "Extended Properties=Excel 12.0;";
            else
                _cn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + pathFile + ";" + "Extended Properties=Excel 8.0;";
            _con = new OleDbConnection(_cn);
            _con.Open();
        }

        public DataTable getDataFromExel()
        {
            string _qr="select * from [Sheet1$]";
            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter _da = new OleDbDataAdapter(_qr,_con);
                _da.Fill(dt);
                return dt;
            }
            catch (OleDbException ex)
            {
                return dt;
            }
        }
    }
}