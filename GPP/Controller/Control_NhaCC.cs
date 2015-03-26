using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPP.Model;
using System.Data;

namespace GPP.Controller
{
    class Control_NhaCC
    {
        public bool ThemNhaCC(Model_NhaCC ncc)
        {
            string querry = "insert into NhaCungCap values('"+ncc.MaNhaCC+"','"+ncc.TenNhaCC+"','"+ncc.DiaChi+"','"+ncc.SoDT+"','"+ncc.Email+"','"+ncc.MaSoThue+"','"+ncc.Fax+"','"+ncc.GhiChu+"') ";
            try
            {
                ConnectSQL.Istance.ThucThiSQL(querry);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaNhaCC(string _maNhaCC)
        {
            string querry = "delete from NhaCungCap where MaNhaCC='"+_maNhaCC+"'";
            try
            {

                return true;
            }
            catch { return false; }
        }
        public bool SuaNhaCC(Model_NhaCC ncc)
        {
            string querry = "update NhaCungCap set TenNhaCC='"+ncc.TenNhaCC+"',DiaChi='"+ncc.DiaChi+"',SDT='"+ncc.SoDT+"' ,Email='"+ncc.Email+"',MaSoThue='"+ncc.MaSoThue+"',Fax='"+ncc.Fax+"' GhiChu='"+ncc.GhiChu+"' where MaNhaCC='"+ncc.MaNhaCC+"'";
            try
            {
                ConnectSQL.Istance.ThucThiSQL(querry);
                return true;
            }
            catch { return false; }
        }
        public DataTable GetNhaCC()
        {
            String qr = "select * from NhaCungCap";
            DataTable dt = ConnectSQL.Istance.Getdata(qr);
            return dt;
        }
    }
}
