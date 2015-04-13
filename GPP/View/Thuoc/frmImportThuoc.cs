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
        #region Field
        /// <summary>
        /// Danh sách các lỗi khi import thuốc
        /// </summary>
        private List<string> _errorMsg;

        /// <summary>
        /// Class quản lý việc import thuốc
        /// </summary>
        private ThuocController _thuocController;

        /// <summary>
        /// Đối tượng lưu trữ dữ liệu từ excel
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// Đối tượng chạy ngầm bên dưới khi import dữ liệu
        /// </summary>
        private BackgroundWorker _backgroundWorker;

        /// <summary>
        /// Số dòng của file excel
        /// </summary>
        private int MAX_ROWS = 0;
        #endregion

        #region Contructor
        public frmImportThuoc()
        {
            InitializeComponent();

            HandleCreated += OnHandleCreated;
            HandleDestroyed += OnHandleDestroyed;
        }
        #endregion

        #region Event
        private void OnHandleDestroyed(object sender, EventArgs e)
        {
            //Xóa các đối tượng ko dùng đến

            _errorMsg.Clear();
            _errorMsg = null;
            _thuocController = null;

            if (_backgroundWorker != null)
            {
                _backgroundWorker.CancelAsync();
                _backgroundWorker.RunWorkerCompleted -= OnBackgroundWorkerRunWorkerCompleted;
                _backgroundWorker.DoWork -= OnBackgroundWorkerDoWork;
                _backgroundWorker.ProgressChanged -= OnBackgroundWorkerProgressChanged;

                _backgroundWorker.Dispose();
            }

            if (_dataTable != null)
            {
                _dataTable.Dispose();
            }
        }

        private void OnHandleCreated(object sender, EventArgs e)
        {
            _errorMsg = new List<string>();
            _thuocController = new ThuocController();
        }

        private void OnBtnDuyetTimClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Excel 2007 (*.xls)|*.xls|Laster version (*.xlsx*)|*.xlsx*";
            openFileDlg.Title = "Mở file Exel để import dữ liệu";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _txtDuongDan.Text = openFileDlg.FileName;
            }
        }

        private void OnBtnDongClick(object sender, EventArgs e)
        {
            if (_btnDong.Text == "Dừng" && _backgroundWorker != null)
            {
                _backgroundWorker.CancelAsync();

                _btnDong.Text = "Đóng";
                _btnDuyet.Enabled = true;
                _btnImport.Enabled = true;
                _checkBoxXoaTruocKhiImport.Enabled = true;
            }
            else
            {
                this.Close();
            }
        }

        private void OnBtnImportClick(object sender, EventArgs e)
        {
            //Kiem tra du lieu truoc khi import
            if (CheckBeforeImportData() == false)
            {
                return;
            }

            if (_checkBoxXoaTruocKhiImport.Checked == true)
            {
                SqlHelper.Instance.Execute("DELETE FROM THUOC");
            }

            //Lấy dữ liệu từ file excel
            _dataTable = ExcelUtility.Instance.GetDataTable(_txtDuongDan.Text, "SELECT * FROM  [" + _txtTenSheet.Text + "$]");
            MAX_ROWS = _dataTable.Rows.Count;

            //Khoi tao gia tri mặc định
            _progressBar.Maximum = MAX_ROWS;
            _progressBar.Value = 0;

            //Sử dụng background worker để thực hiện import và hiển thị quá trình import lên giao diện
            if (_backgroundWorker != null)
            {
                _backgroundWorker.CancelAsync();
                _backgroundWorker.RunWorkerCompleted -= OnBackgroundWorkerRunWorkerCompleted;
                _backgroundWorker.DoWork -= OnBackgroundWorkerDoWork;
                _backgroundWorker.ProgressChanged -= OnBackgroundWorkerProgressChanged;

                _backgroundWorker.Dispose();
            }

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.RunWorkerCompleted += OnBackgroundWorkerRunWorkerCompleted;
            _backgroundWorker.DoWork += OnBackgroundWorkerDoWork;
            _backgroundWorker.ProgressChanged += OnBackgroundWorkerProgressChanged;

            _btnDong.Text = "Dừng";
            _btnDuyet.Enabled = false;
            _btnImport.Enabled = false;
            _checkBoxXoaTruocKhiImport.Enabled = false;

            _backgroundWorker.RunWorkerAsync();
        }

        private void OnBackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _progressBar.Value = e.ProgressPercentage;
            _lbErrorCount.Text = _errorMsg.Count.ToString();
        }

        private void OnBackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < MAX_ROWS; i++)
            {
                if (_backgroundWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                //Lấy dữ liệu
                string maThuoc = _thuocController.GetNextPrimaryKeyDrug();

                string tenThuoc = _dataTable.Rows[i][0].ToString();
                string loaiThuoc = _dataTable.Rows[i][1].ToString();
                string hoatChatChinh = _dataTable.Rows[i][2].ToString();
                string donViTinh = _dataTable.Rows[i][3].ToString();
                string donViQuyDoi1 = _dataTable.Rows[i][4].ToString();
                string tyLeQuyDoi1 = _dataTable.Rows[i][5].ToString();
                string donViQuyDoi2 = _dataTable.Rows[i][6].ToString();
                string tyLeQuyDoi2 = _dataTable.Rows[i][7].ToString();
                string xuatXu = _dataTable.Rows[i][8].ToString();

                string doAm = "";
                string nhietDo = "";
                string congDung = "";
                string cachSuDung = "";

                //Loại bỏ ký tự đặc biệt
                StringHelper.RemoveSpecialSymbol(ref tenThuoc);
                StringHelper.RemoveSpecialSymbol(ref loaiThuoc);
                StringHelper.RemoveSpecialSymbol(ref hoatChatChinh);
                StringHelper.RemoveSpecialSymbol(ref donViTinh);
                StringHelper.RemoveSpecialSymbol(ref donViQuyDoi1);
                StringHelper.RemoveSpecialSymbol(ref donViQuyDoi2);
                StringHelper.RemoveSpecialSymbol(ref xuatXu);

                //Kiểm tra tính hợp lệ:
                string maLoaiThuoc = "";
                string maDonViTinh = "";
                string maDonViQuyDoi1 = "";
                string maDonViQuyDoi2 = "";

                //Kiểm tra xem tên thuốc đã có trong CSDL hay chưa
                if (_thuocController.CheckExistDrugByName(tenThuoc))
                {
                    _errorMsg.Add("Dòng " + i + ": Tên thuốc " + tenThuoc + " đã có trong CSDL");
                }
                else
                {
                    if (CheckRowsExcel(i, ref maLoaiThuoc, ref maDonViTinh, ref maDonViQuyDoi1, ref maDonViQuyDoi2) == false)
                    {
                        bool isSuccess = _thuocController.AddNewsDrug(maThuoc,
                            tenThuoc, maLoaiThuoc,
                            maDonViTinh, maDonViQuyDoi1,
                            tyLeQuyDoi1, maDonViQuyDoi2,
                            tyLeQuyDoi2, hoatChatChinh,
                            congDung, cachSuDung, xuatXu,
                            nhietDo, doAm);

                        if (isSuccess == false)
                        {
                            _errorMsg.Add("Dòng " + i + ": Thêm dữ liệu Thuốc lỗi");
                        }
                    }
                }
                _backgroundWorker.ReportProgress(i);
                System.Threading.Thread.Sleep(10);
            }
        }

        private void OnBackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //send internal event

            _btnDong.Text = "Đóng";
            _btnDuyet.Enabled = true;
            _btnImport.Enabled = true;
            _checkBoxXoaTruocKhiImport.Enabled = true;

            //Ghi danh sách lỗi ra ngoài file
            WriteLog();
            MessageBox.Show("Đã import xong!", "thông báo");
        }

        #endregion

        #region Method
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

            //Kiểm tra xem đã nhập tên sheet hay chưa?
            if (string.IsNullOrEmpty(_txtTenSheet.Text))
            {
                ToastNotification.Show(this, "Chưa nhập tên sheet");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Hàm kiểm tra dữ liệu hợp lệ của một rows
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="maLoaiThuoc"></param>
        /// <param name="maDonViTinh"></param>
        /// <param name="maDonViQuyDoi1"></param>
        /// <param name="maDonViQuyDoi2"></param>
        /// <returns></returns>
        private bool CheckRowsExcel(int rows,
            ref string maLoaiThuoc,
            ref string maDonViTinh,
            ref string maDonViQuyDoi1,
            ref string maDonViQuyDoi2)
        {
            bool error = false;

            string moTaLoaiThuoc = _dataTable.Rows[rows][1].ToString();
            string moTaDonViTinh = _dataTable.Rows[rows][3].ToString();
            string moTaDonViQuyDoi1 = _dataTable.Rows[rows][4].ToString();
            string tyLeQuyDoi1 = _dataTable.Rows[rows][5].ToString();
            string moTaDonViQuyDoi2 = _dataTable.Rows[rows][6].ToString();
            string tyLeQuyDoi2 = _dataTable.Rows[rows][7].ToString();

            //Loại bỏ ký tự đặc biệt
            StringHelper.RemoveSpecialSymbol(ref moTaLoaiThuoc);
            StringHelper.RemoveSpecialSymbol(ref moTaDonViTinh);
            StringHelper.RemoveSpecialSymbol(ref moTaDonViQuyDoi1);
            StringHelper.RemoveSpecialSymbol(ref moTaDonViQuyDoi2);
            StringHelper.RemoveSpecialSymbol(ref tyLeQuyDoi1);
            StringHelper.RemoveSpecialSymbol(ref tyLeQuyDoi2);

            //Kiểm tra dữ liệu dạng số
            if (StringHelper.IsNumber(tyLeQuyDoi1) == false)
            {
                _errorMsg.Add("Dòng " + rows + ": Cột [Tỷ lệ quy đổi 1] dữ liệu không phải dạng chữ số");
                error = true;
            }
            if (StringHelper.IsNumber(tyLeQuyDoi2) == false)
            {
                _errorMsg.Add("Dòng " + rows + ": Cột [Tỷ lệ quy đổi 2] dữ liệu không phải dạng chữ số");
                error = true;
            }

            //Kiểm tra xem dữ liệu loại thuốc và đơn vị tính đã có chưa
            //Chưa có thì thêm mới
            if (_thuocController.CheckExistTypeOfDrug(moTaLoaiThuoc) == false)
            {
                maLoaiThuoc = _thuocController.GetNextPrimaryKeyTypeOfDrug();
                if (_thuocController.AddNewsTypeOfDrug(maLoaiThuoc, moTaLoaiThuoc) == false)
                {
                    _errorMsg.Add("Dòng " + rows + ": Cột [Loại thuốc] dữ liệu thêm mới lỗi");
                    error = true;
                }
            }
            else
            {
                maLoaiThuoc = _thuocController.GetIDTypeOfDrugByName(moTaLoaiThuoc);
            }
            //__________________________________________________________

            if (_thuocController.CheckExistUnitOfDrug(moTaDonViTinh) == false)
            {
                maDonViTinh = _thuocController.GetNextPromaryKeyUnitOfDrug();
                if (_thuocController.AddNewsUnitOfDrug(maDonViTinh, moTaDonViTinh) == false)
                {
                    _errorMsg.Add("Dòng " + rows + ": Cột [Đơn vị tính] dữ liệu thêm mới lỗi");
                    error = true;
                }
            }
            else
            {
                maDonViTinh = _thuocController.GetIDUnitOfDrugByName(moTaDonViTinh);
            }

            //__________________________________________________________
            if (_thuocController.CheckExistUnitOfDrug(moTaDonViQuyDoi1) == false)
            {
                maDonViQuyDoi1 = _thuocController.GetNextPromaryKeyUnitOfDrug();
                if (_thuocController.AddNewsUnitOfDrug(maDonViQuyDoi1, moTaDonViQuyDoi1) == false)
                {
                    _errorMsg.Add("Dòng " + rows + ": Cột [Đơn vị quy đổi 1] dữ liệu thêm mới lỗi");
                    error = true;
                }
            }
            else
            {
                maDonViQuyDoi1 = _thuocController.GetIDUnitOfDrugByName(moTaDonViQuyDoi1);
            }

            //__________________________________________________________
            if (_thuocController.CheckExistUnitOfDrug(moTaDonViQuyDoi2) == false)
            {
                maDonViQuyDoi2 = _thuocController.GetNextPromaryKeyUnitOfDrug();
                if (_thuocController.AddNewsUnitOfDrug(maDonViQuyDoi2, moTaDonViQuyDoi2) == false)
                {
                    _errorMsg.Add("Dòng " + rows + ": Cột [Đơn vị quy đổi 2] dữ liệu thêm mới lỗi");
                    error = true;
                }
            }
            else
            {
                maDonViQuyDoi2 = _thuocController.GetIDUnitOfDrugByName(moTaDonViQuyDoi2);
            }
            return error;
        }

        /// <summary>
        /// Ghi lỗi ra file
        /// </summary>
        private void WriteLog()
        {
            if (Directory.Exists(Application.StartupPath + @"\Data\") == false)
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Data\");
            }
            if (Directory.Exists(Application.StartupPath + @"\Data\Log\") == false)
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Data\Log\");
            }
            string fileName = Application.StartupPath + @"\Data\Log\Log.txt";
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            for (int i = 0; i < _errorMsg.Count; i++)
            {
                file.WriteLine(_errorMsg[i]);
            }
            file.Close();
            _errorMsg.Clear();

            System.Diagnostics.Process.Start(fileName);
        }
        #endregion
    }
}