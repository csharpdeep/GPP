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
using DevComponents.DotNetBar;

namespace GPP
{
    public partial class popupThuoc : DevComponents.DotNetBar.OfficeForm
    {
        private bool _isUpdate;
        public delegate void send(bool change=false);
        public send _send;
        public popupThuoc(bool isUpdate,string maThuoc)
        {
            InitializeComponent();
            _isUpdate = isUpdate;
            
            DataTable LoaiThuoc = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM LOAITHUOC");
            cbLoaiThuoc.DataSource = LoaiThuoc;
            cbLoaiThuoc.DisplayMember = "MOTA";
            cbLoaiThuoc.ValueMember = "MALOAITHUOC";

            //lay do vi quy doi va don vi tinh
            DataTable DVQD = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM DONVITINH");
            cbDonViTinh.DataSource = DVQD;
            cbDonViTinh.DisplayMember = "MOTA";
            cbDonViTinh.ValueMember = "MADONVI";

            cbDVQD1.DataSource = DVQD;
            cbDVQD1.DisplayMember = "MOTA";
            cbDVQD1.ValueMember = "MADONVI";

            cbDVQD2.DataSource = DVQD;
            cbDVQD2.DisplayMember = "MOTA";
            cbDVQD2.ValueMember = "MADONVI";
            
            if (isUpdate == true)
            {
                this.Text = "Chỉnh sửa thông tin thuốc";
                DataTable Thuoc = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM THUOC WHERE MATHUOC='"+maThuoc+"'");
                txtMaThuoc.Text = maThuoc;
                txtTenThuoc.Text=Thuoc.Rows[0][1].ToString();
                //cbLoaiThuoc.ValueMember = Thuoc.Rows[0][2].ToString();
                //cbDonViTinh.ValueMember = Thuoc.Rows[0][3].ToString();
                //cbDVQD1.ValueMember = Thuoc.Rows[0][4].ToString();
                txtTLQD1.Text = Thuoc.Rows[0][5].ToString();
               // cbDVQD2.ValueMember = Thuoc.Rows[0][6].ToString();
                txtTLQD2.Text = Thuoc.Rows[0][7].ToString();
                txtHoatTinh.Text = Thuoc.Rows[0][8].ToString();
                txtCongDung.Text = Thuoc.Rows[0][8].ToString();
                txtCachSuDung.Text = Thuoc.Rows[0][9].ToString();
                txtXuatXu.Text = Thuoc.Rows[0][10].ToString();
                txtNhietDo.Text = Thuoc.Rows[0][11].ToString();
                txtDoAm.Text = Thuoc.Rows[0][12].ToString();
               
            }
            else
            {
                this.Text = "Thêm mới thuốc";
                txtMaThuoc.Text = maThuoc;
            }
        }
        private void InsertData()
        {
            //them moi du lieu  
            int recordEffect = (int)SqlHelper.Instance.Insert("THUOC", new SqlParameter[]
                {
                    new SqlParameter("MATHUOC",txtMaThuoc.Text),
                    new SqlParameter("TENTHUOC",txtTenThuoc.Text),
                    new SqlParameter("MALOAITHUOC",cbLoaiThuoc.ValueMember.ToString()),
                    new SqlParameter("DONVITINH",cbDonViTinh.ValueMember.ToString()),
                    new SqlParameter("DONVIQUYDOICAP_1",cbDVQD1 .ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_1",txtTLQD1.Text),
                    new SqlParameter("DONVIQUYDOI_CAP2",cbDVQD2.ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_2",txtTLQD2.Text),
                    new SqlParameter("HOATCHATCHINH",txtHoatTinh.Text),
                    new SqlParameter("CONGDUNG",txtCongDung.Text),
                    new SqlParameter("CACHSUDUNG",txtCachSuDung.Text),
                    new SqlParameter("XUATXU",txtXuatXu.Text),
                    new SqlParameter("NHIETDOBAOQUAN",txtNhietDo.Text),
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
                this._send(true);
            }
        }
        private void UpdateData()
        {
            //viet cau lenh sua
            int recordEffect = SqlHelper.Instance.Update("THUOC", new SqlParameter[]
                {   
                    new SqlParameter("TENTHUOC",txtTenThuoc.Text),
                    new SqlParameter("MALOAITHUOC",cbLoaiThuoc.ValueMember.ToString()),
                    new SqlParameter("DONVITINH",cbDonViTinh.ValueMember.ToString()),
                    new SqlParameter("DONVIQUYDOICAP_1",cbDVQD1 .ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_1",txtTLQD1.Text),
                    new SqlParameter ("DONVIQUYDOI_CAP2",cbDVQD2.ValueMember.ToString()),
                    new SqlParameter("TYLEQUYDOICAP_2",txtTLQD2.Text),
                    new SqlParameter("HOATCHATCHINH",txtHoatTinh.Text),
                    new SqlParameter("CONGDUNG",txtCongDung.Text),
                    new SqlParameter("CACHSUDUNG",txtCachSuDung.Text),
                    new SqlParameter("XUATXU",txtXuatXu.Text),
                    new SqlParameter("NHIETDOBAOQUAN",txtNhietDo.Text),
                    new SqlParameter("DOAMBAOQUAN",txtDoAm.Text) 
                },
            new SqlParameter[]{new SqlParameter("MATHUOC", txtMaThuoc.Text),});
            if (recordEffect <= 0)
            {
                MessageBox.Show("Không thể sửa dữ liệu này",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this._send(true);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTLQD1_TextChanged(object sender, EventArgs e)
        {
            if (txtTLQD1.Text != "")
            {
                try
                {
                    double.Parse(txtTLQD1.Text);
                    lbErrorTLQD1.Text = "";
                }
                catch
                {
                    lbErrorTLQD1.Text = "Tỷ lệ quy đổi phải là số!";
                }
            }
            else
            {

                lbErrorTLQD1.Text = "";
            }
        }

        private void txtTLQD2_TextChanged(object sender, EventArgs e)
        {
            if (txtTLQD2.Text != "")
            {
                try
                {
                    double.Parse(txtTLQD2.Text);
                    lbErrorTLQD2.Text = "";
                }
                catch
                {
                    lbErrorTLQD2.Text = "Tỷ lệ quy đổi phải là số!";
                }
            }
            else
            {
                lbErrorTLQD2.Text = "";
            }
        }

        private void txtNhietDo_TextChanged(object sender, EventArgs e)
        {
            if (txtNhietDo.Text != "")
            {
                try
                {
                    double.Parse(txtNhietDo.Text);
                    lbErrorNhietDo.Text = "";
                }
                catch
                {
                    lbErrorNhietDo.Text = "Nhiệt độ phải là số!";
                }
            }
            else
            {
                lbErrorNhietDo.Text = "";
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
        }

        private void popupThuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
