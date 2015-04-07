using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DongTX.Core;
using System.Data.SqlClient;

namespace GPP
{
    public partial class popupThuoc : Form
    {
        private bool _isUpdate;
        public popupThuoc(bool isUpdate,string maThuoc)
        {
            InitializeComponent();
            _isUpdate = isUpdate;
            
            DataTable LoaiThuoc = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM LOAITHUOC");
            cbLoaiTThuoc.DataSource = LoaiThuoc;
            cbLoaiTThuoc.DisplayMember = "MOTA";
            cbLoaiTThuoc.ValueMember = "MALOAITHUOC";

            //lay nha cung cap
            DataTable NhaCC = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM NHACUNGCAP");
            cbNhaCC.DataSource = NhaCC;
            cbNhaCC.DisplayMember = "TENNHACUNGCAP";
            cbNhaCC.ValueMember = "MANHACUNGCAP";

            //lay do vi quy doi va don vi tinh
            DataTable DVQD = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM DONVITINH");
            cbDonViTinh.DataSource = DVQD;
            cbDonViTinh.DisplayMember = "MOTA";
            cbDonViTinh.ValueMember = "MADONVI";

            cbDVQDCap1.DataSource = DVQD;
            cbDVQDCap1.DisplayMember = "MOTA";
            cbDVQDCap1.ValueMember = "MADONVI";

            cbDVQDCap2.DataSource = DVQD;
            cbDVQDCap2.DisplayMember = "MOTA";
            cbDVQDCap2.ValueMember = "MADONVI";
            
            if (isUpdate == true)
            {
                this.Text = "Chỉnh sửa thông tin thuốc";
               
                //lay loai thuo
            }
            else
            {
                this.Text = "Thêm mới thuốc";
                txtMaThuoc.Text = maThuoc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isUpdate == false)
            {
                //them moi thuoc
                InsertData();
            }
            else
            {
                //chinh sua thuoc
                UpdateData();
            }
        }
        private void InsertData()
        {
            //them moi du lieu  
            int recordEffect = (int)SqlHelper.Instance.Insert("THUOC", new SqlParameter[]
                {
                    new SqlParameter("MATHUOC",txtMaThuoc.Text),
                    new SqlParameter("TENTHUOC",txtTenThuoc.Text),
                    new SqlParameter("MALOAITHUOC",cbLoaiTThuoc.ValueMember.ToString()),
                    new SqlParameter("DONVITINH",cbDonViTinh.ValueMember.ToString()),
                    new SqlParameter("DONVIQUYDOICAP_1",cbDVQDCap1.ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_1",txtTLQDCap1.Text),
                    new SqlParameter ("DONVIQUYDOI_CAP2",cbDVQDCap1.ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_2",txtTLQDCap2.Text),
                    new SqlParameter("MANHACUNGCAP",cbNhaCC.ValueMember.ToString()),
                    new SqlParameter("CONGDUNG",txtCongDung.Text),
                    new SqlParameter("CACHSUDUNG",txtCachSuDung.Text),
                    new SqlParameter("XUATXU",cbXuatXu.Text),
                    new SqlParameter("NHIETDOBAOQUAN",txtNDBaoQuan.Text),
                    new SqlParameter("DOAMBAOQUAN",txtDoAm.Text)

                });
            if (recordEffect <= 0)
            {
                MessageBox.Show("Không thể thêm mới dữ liệu",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thêm mới thuốc thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void UpdateData()
        {
            //viet cau lenh sua
            int recordEffect = SqlHelper.Instance.Update("THUOC", new SqlParameter[]
                {   
                   new SqlParameter("MATHUOC",txtMaThuoc.Text),
                    new SqlParameter("TENTHUOC",txtTenThuoc.Text),
                    new SqlParameter("MALOAITHUOC",cbLoaiTThuoc.ValueMember.ToString()),
                    new SqlParameter("DONVITINH",cbDonViTinh.ValueMember.ToString()),
                    new SqlParameter("DONVIQUYDOICAP_1",cbDVQDCap1.ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_1",txtTLQDCap1.Text),
                    new SqlParameter ("DONVIQUYDOICAP_2",cbDVQDCap1.ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_2",txtTLQDCap2.Text),
                    new SqlParameter("MANHACUNGCAP",cbNhaCC.ValueMember.ToString()),
                    new SqlParameter("CONGDUNG",txtCongDung.Text),
                    new SqlParameter("CACHSUDUNG",txtCachSuDung.Text),
                    new SqlParameter("XUATXU",cbXuatXu.Text),
                    new SqlParameter("NHIETDOBAOQUAN",txtNDBaoQuan.Text),
                    new SqlParameter("DOAMBAOQUAN",txtDoAm.Text) 
                },
                new SqlParameter[]{
                    new SqlParameter("MATHUOC", txtMaThuoc.Text),
                });
            if (recordEffect <= 0)
            {
                MessageBox.Show("Không thể sửa dữ liệu này",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
