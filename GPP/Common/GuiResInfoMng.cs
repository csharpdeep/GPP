using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GPP
{
    class GuiResInfoMng : GuiResInfoBaseMng
    {
        private  static GuiResInfoMng _instance = new GuiResInfoMng();
        public static GuiResInfoMng Instance
        {
            get
            {
                return _instance;
            }
        }

        public event EventHandler OnGuiEvent;

        #region Field
        private const string _SCREEN_ID_NOT_FOUND = @"Not found screen";
        #endregion Field

        #region Method
        public override void ChangeScreen(GuiResId.ScreenID screenID)
        {
            GuiResId.ScreenMode mode = GetScreenMode(screenID);
            object instance = GetIntanceScreen(screenID);
            IGuiMng iGuiMng = GetMainWindow() as IGuiMng;
            if (iGuiMng != null)
            {
                iGuiMng.ChangeScreen(instance, mode);
            }
        }

        private object GetIntanceScreen(GuiResId.ScreenID screenID)
        {
            object instance = null;
            switch (screenID)
            {
               
                case GuiResId.ScreenID.DonViTinh:
                    instance = new frmDonViTinh();
                    break;
                case GuiResId.ScreenID.LoaiThuoc:
                    instance = new frmLoaiThuoc();
                    break;
                case GuiResId.ScreenID.NhanVien:
                    instance = new frmNhanVienUC();
                    break;
                case GuiResId.ScreenID.PhanQuyen:
                    instance = new frmPhanQuyen();
                    break;
                case GuiResId.ScreenID.DangNhap:
                    instance = new frmDangNhapUC();
                    break;
                case GuiResId.ScreenID.HoaDon:
                    break;
                case GuiResId.ScreenID.Thuoc:
                    instance = new frmThuocUC();
                    break;
            };
            return instance;
        }

        private GuiResId.ScreenMode GetScreenMode(GuiResId.ScreenID screenID)
        {
            GuiResId.ScreenMode mode  = GuiResId.ScreenMode.None;
            switch (screenID)
            {
                case GuiResId.ScreenID.ChucVu:
                case GuiResId.ScreenID.DonViTinh:
                case GuiResId.ScreenID.LoaiThuoc:
                case GuiResId.ScreenID.PhanQuyen:
                case GuiResId.ScreenID.Thuoc:
                    mode = GuiResId.ScreenMode.Dialog;
                    break;
                case GuiResId.ScreenID.NhanVien:
                case GuiResId.ScreenID.DangNhap:
                case GuiResId.ScreenID.HoaDon:
                    mode = GuiResId.ScreenMode.UserControl;
                    break;
            };
            return mode;
        }

        public void SendInternalEvent(object sender, EventArgs e)
        {
            if (OnGuiEvent != null)
            {
                OnGuiEvent(sender,e);
            }
        }

        public MainWindow GetMainWindow()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "MainWindow")
                {
                    return (MainWindow)frm;
                }
            }
            return null;
        }

        public bool CanInsert()
        {
            return false;
        }

        public bool CanUpdate()
        {
            return false;
        }

        public bool CanDelete()
        {
            return false;
        }

        public bool CanView()
        {
            return false;
        }
        #endregion Method
    }

    class EventID : EventArgs
    {
        public enum ID
        {
            None,
            ChangeScreen,
            Login,
            Logout
        }
    }
}