using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPP.Model;
using System.Windows.Forms;

namespace GPP.Controller
{
    class Control_PhanQyen
    {
        public void ThayDoiQuyen(Model_PhanQuyen p)
        {
            String query = "update PhanQuyen set Xem='"+p.Xem+"',Them'"+p.Them+"',Sua='"+p.Sua+"',Xoa='"+p.Xoa+"' where MaChucVu='"+p.MaChucVu+"' and MaChucNang='"+p.MaChucNang+"'";
            if (!ConnectSQL.Istance.ThucThiSQL(query))
                MessageBox.Show("Xay ra lỗi trong khi thay đổi quyền hạn!");
            else
                MessageBox.Show("Thay đổi thành công!");
        }
    }
}
