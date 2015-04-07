using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPP
{
    public class GuiResId
    {
        public enum ScreenMode
        {
            None,
            Dialog,
            UserControl,
        }

        public enum ScreenID
        {
            None,
            LoaiThuoc,
            NhanVien,
            PhanQuyen,
            ChucVu,
            DonViTinh,
            DangNhap,
            HoaDon,
            Thuoc
        }

        public enum ParamId
        {
            None,
            IDS_TENDANGNHAP
        }
    }
}
