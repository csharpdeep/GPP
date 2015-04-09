using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using DongTX.Core;
using System.Data.SqlClient;
using ExcelConnection;

namespace GPP
{
    public partial class frmImportThuoc : DevComponents.DotNetBar.OfficeForm
    {

        public delegate void send(bool change = false);
        public send _send;
        private string _fileName;
        private int _error = 0;

        public frmImportThuoc()
        {
            InitializeComponent();
        }

        private void OnBtnDuyetTimClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Excel 2007 (*.xls)|*.xls|Laster version (*.xlsx*)|*.xlsx*";
            openFileDlg.Title = "Mở file Exel để import dữ liệu";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDlg.FileName;
                _txtDuongDan.Text = _fileName;
            }
        }

        private void OnBtnDongClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnBtnImportClick(object sender, EventArgs e)
        {
            //Kiem tra du lieu truoc khi import
            if (CheckBeforeImportData() == false)
            {
                return;
            }

            //Tien hanh import du lieu vao bang thuoc

            _btnDuyet.Enabled = false;
            _btnImport.Enabled = false;

            if (_checkBoxXoaTruocKhiImport.Checked == true)
            {
                SqlHelper.Instance.Execute("DELETE FROM THUOC");
                this._send(true);
            }

            //chen du lieu vao
            DataTable dataThuoc = ExcelUtility.Instance.GetDataTable(_txtDuongDan.Text,"SELECT * FROM  [Sheet1$]");

            //Khoi tao gia tri cho ProgressBar
            _progressBar.Maximum = dataThuoc.Rows.Count;
            _progressBar.Value = 0;

            int _soLuong = dataThuoc.Rows.Count;
            for (int i = 0; i < _soLuong; i++)
            {
                string _maThuoc = SqlHelper.Instance.GetNextPrimaryKey("THUOC", "MATHUOC", "T000001");
                string _tenThuoc = dataThuoc.Rows[i][2].ToString();
                string _loaiTHuoc = "LT00000";
                string _hoatChatChinh = dataThuoc.Rows[i][3].ToString();
                string _donViTinh = dataThuoc.Rows[i][4].ToString();
                string _DVQD1 = dataThuoc.Rows[i][5].ToString();
                string _TLQD1 = dataThuoc.Rows[i][6].ToString();
                string _xuatXu = dataThuoc.Rows[i][15].ToString();
                string _doAm = "";
                string _nhietDo = "";
                string _congDung = "";
                string _cachDung = "";

                if (_checkBoxTuDongVietHoa.Checked == true)
                {
                    _maThuoc.ToUpper();
                    _tenThuoc.ToUpper();
                    _loaiTHuoc.ToUpper();
                    _hoatChatChinh.ToUpper();
                    _donViTinh.ToUpper();
                    _DVQD1.ToUpper();
                    _TLQD1.ToUpper();
                    _xuatXu.ToUpper();
                    _doAm.ToUpper();
                    _congDung.ToUpper();
                    _cachDung.ToUpper();
                    _nhietDo.ToUpper();
                }

                if (SqlHelper.Instance.CheckExistKey("DONVITINH", "MOTA", _donViTinh.ToString()) == true)
                {
                    if (SqlHelper.Instance.CheckExistKey("THUOC", "TENTHUOC", _tenThuoc) == false)
                    {
                        DataTable DVT = SqlHelper.Instance.ExecuteDataTable("Select MADONVI from DONVITINH Where MOTA='" + _donViTinh + "'");
                        _donViTinh = DVT.Rows[0][0].ToString();
                        int recordEffect = (int)SqlHelper.Instance.Insert("THUOC", new SqlParameter[]
                            {
                                new SqlParameter("MATHUOC",_maThuoc),
                                new SqlParameter("TENTHUOC",_tenThuoc),
                                new SqlParameter("MALOAITHUOC",_loaiTHuoc),
                                new SqlParameter("DONVITINH",_donViTinh),
                                new SqlParameter("DONVIQUYDOICAP_1",_DVQD1),
                                new SqlParameter("TYLEQUYDOICAP_1",_TLQD1),
                                new SqlParameter("DONVIQUYDOI_CAP2",""),
                                new SqlParameter("TYLEQUYDOICAP_2",""),
                                new SqlParameter("HOATCHATCHINH",_hoatChatChinh),
                                new SqlParameter("CONGDUNG",_congDung),
                                new SqlParameter("CACHSUDUNG",_cachDung),
                                new SqlParameter("XUATXU",_xuatXu),
                                new SqlParameter("NHIETDOBAOQUAN",_nhietDo),
                                new SqlParameter("DOAMBAOQUAN",_doAm) 
                            });
                    }
                    else
                    {
                        _richTexBoxEdit.Text += "Lỗi dòng " + i + " : THuốc đã tồn tại trong CSDL.\n";
                        _error++;
                        _lbError.Text = _error.ToString();
                        SendKeys.Flush();
                    }
                }
                else
                {
                    _richTexBoxEdit.Text += "Lỗi dòng " + i + " : Không có thông tin về đơn vị tính.\n";
                    _error++;
                    _lbError.Text = _error.ToString();
                    SendKeys.Flush();
                }
                _progressBar.Value++;
                _lbPecen.Text = i.ToString() + "/" + _soLuong.ToString();
                SendKeys.Flush();
            }

            this._send(true);

            _btnImport.Enabled = true;
            _btnDuyet.Enabled = true;

            MessageBox.Show("Import dữ liệu thành công!", 
                "Thông báo",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Hàm kiểm tra các điều kiện cơ bản trước khi import dữ liệu
        /// </summary>
        /// <returns></returns>
        private bool CheckBeforeImportData()
        {
            //Kiem tra xem nguoi dung da chon file hay chua?
            if (string.IsNullOrEmpty(_txtDuongDan.Text))
            {
                ToastNotification.Show(this, "Chưa chọn file import");
                return false;
            }

            //Neu da co file roi thi file do co ton tai hay khong
            if (File.Exists(_txtDuongDan.Text) == false)
            {
                ToastNotification.Show(this, "File không tồn tại");
                return false;
            }

            return true;
        }
    }
}