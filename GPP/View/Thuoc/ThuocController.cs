using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DongTX.Core;

namespace GPP
{
    public class ThuocController
    {
        /// <summary>
        /// Hàm thêm mới một loại thuốc vào bảng THUOC
        /// </summary>
        /// <returns>TRUE nếu thêm mới thành công, FALSE nếu ngược lại
        /// </returns>
        public bool AddNewsDrug(string maThuoc,  
            string tenThuoc, 
            string maLoaiThuoc, 
            string maDonViTinh,
            string maDonViTinhQuyDoiCap1,
            string tyLeQuyDoiCap1,
            string maDonViTinhQuyDoiCap2,
            string tyLeQuyDoiCap2,
            string hoatChatChinh, 
            string congDung,
            string cachSuDung, 
            string xuatXu,
            string nhietDoBaoQuan, 
            string doAmBaoQuan)
        {
            //Sử dụng thư viện để thêm mới dữ liệu
            int recordEffect = (int)SqlHelper.Instance.Insert("THUOC", new SqlParameter[]
                        {
                            new SqlParameter("MATHUOC",maThuoc),
                            new SqlParameter("TENTHUOC",tenThuoc),
                            new SqlParameter("MALOAITHUOC",maLoaiThuoc),
                            new SqlParameter("DONVITINH",maDonViTinh),
                            new SqlParameter("DONVIQUYDOICAP_1",maDonViTinhQuyDoiCap1),
                            new SqlParameter("TYLEQUYDOICAP_1",tyLeQuyDoiCap1),
                            new SqlParameter("DONVIQUYDOI_CAP2", maDonViTinhQuyDoiCap2),
                            new SqlParameter("TYLEQUYDOICAP_2",tyLeQuyDoiCap2),
                            new SqlParameter("HOATCHATCHINH",hoatChatChinh),
                            new SqlParameter("CONGDUNG",congDung),
                            new SqlParameter("CACHSUDUNG",cachSuDung),
                            new SqlParameter("XUATXU",xuatXu),
                            new SqlParameter("NHIETDOBAOQUAN",nhietDoBaoQuan),
                            new SqlParameter("DOAMBAOQUAN",doAmBaoQuan) 
                        });
            //Nếu ta thêm mới thành công được thì đồng nghĩa
            //với việc ta có 1 bản ghi <=> recordEffect = 1
            if (recordEffect > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Thêm mới 1 loại thuốc
        /// </summary>
        /// <returns></returns>
        public bool AddNewsTypeOfDrug(string maLoaiThuoc, string moTa)
        {
            int record = (int)SqlHelper.Instance.Insert("LOAITHUOC", new SqlParameter[] 
            { 
                new SqlParameter("MALOAITHUOC", maLoaiThuoc),
                new SqlParameter("MOTA", moTa)
            });
            if (record > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Thêm mới một đơn vị tính
        /// </summary>
        /// <returns></returns>
        public bool AddNewsUnitOfDrug(string maDonVi, string moTa)
        {
            int record = (int)SqlHelper.Instance.Insert("DONVITINH", new SqlParameter[] 
            { 
                new SqlParameter("MADONVI", maDonVi),
                new SqlParameter("MOTA", moTa)
            });
            if (record > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra sự tồn tại của loại thuốc
        /// </summary>
        /// <param name="moTa"></param>
        /// <returns></returns>
        public bool CheckExistTypeOfDrug(string moTa)
        {
            return SqlHelper.Instance.CheckExistKey("LOAITHUOC", "MOTA", moTa);
        }

        /// <summary>
        /// Hàm kiểm tra sự tồn tại của đơn vị tính
        /// </summary>
        /// <param name="moTa"></param>
        /// <returns></returns>
        public bool CheckExistUnitOfDrug(string moTa)
        {
            return SqlHelper.Instance.CheckExistKey("DONVITINH", "MOTA", moTa);
        }

        /// <summary>
        /// Hàm kiểm tra xem tên thuốc đã có trong CSDL hay chưa
        /// </summary>
        /// <param name="tenThuoc"></param>
        /// <returns></returns>
        public bool CheckExistDrugByName(string tenThuoc)
        {
            return SqlHelper.Instance.CheckExistKey("THUOC", "TENTHUOC", tenThuoc);
        }


        /// <summary>
        /// Hàm lấy mã kế tiếp của loại thuốc
        /// </summary>
        /// <returns></returns>
        public string GetNextPrimaryKeyTypeOfDrug()
        {
            return SqlHelper.Instance.GetNextPrimaryKey("LOAITHUOC", "MALOAITHUOC", "LT001");
        }

        /// <summary>
        /// Hàm lấy mã kế tiếp của đơn vị tính
        /// </summary>
        /// <returns></returns>
        public string GetNextPromaryKeyUnitOfDrug()
        {
            return SqlHelper.Instance.GetNextPrimaryKey("DONVITINH", "MADONVI", "DV001");
        }

        /// <summary>
        /// Hàm lấy mã kế tiếp của thuốc
        /// </summary>
        /// <returns></returns>
        public string GetNextPrimaryKeyDrug()
        {
            return SqlHelper.Instance.GetNextPrimaryKey("THUOC", "MATHUOC", "T0000001");
        }

        /// <summary>
        /// Hàm lấy mã loại thuốc từ mô tả loại thuốc
        /// </summary>
        /// <param name="moTa"></param>
        /// <returns></returns>
        public string GetIDTypeOfDrugByName(string moTa)
        {
            string strSQL = "SELECT MALOAITHUOC FROM LOAITHUOC WHERE MOTA = N'"+moTa+"'";
            return (string)SqlHelper.Instance.ExecuteScalar(strSQL);
        }

        /// <summary>
        /// Hàm lấy mã đơn vị tính từ mô tả đơn vị
        /// </summary>
        /// <param name="moTa"></param>
        /// <returns></returns>
        public string GetIDUnitOfDrugByName(string moTa)
        {
            string strSQL = "SELECT MADONVI FROM DONVITINH WHERE MOTA = N'" + moTa + "'";
            return (string)SqlHelper.Instance.ExecuteScalar(strSQL);
        }
    }
}
