using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GPP
{
    /// <summary>
    /// Class quản lý toàn bộ hoạt động của hệ thống
    /// </summary>
    class GuiResInfoMng
    {
        #region Delegate
        /// <summary>
        /// Delegate truyền thông điệp đến các form
        /// </summary>
        /// <param name="e">Event ID</param>
        /// <param name="data">Dữ liệu bất kỳ</param>
        internal delegate void DelegateGuiEvent(GuiEventID e, object data);

        /// <summary>
        /// Event quản lý việc truyền dữ liệu
        /// </summary>
        public static event DelegateGuiEvent GuiEventHandle;
        #endregion Delegate

        #region Inner Class
        /// <summary>
        /// Class định nghĩa event ID
        /// </summary>
        internal class GuiEventID
        {
            /// <summary>
            /// Định nghĩa các event ID
            /// </summary>
            internal enum EventID
            {
                /// <summary>
                /// None
                /// </summary>
                None,

                /// <summary>
                /// Event thay đổi màn hình
                /// </summary>
                ChangeScreen,

                /// <summary>
                /// Event thay đổi người sử dụng
                /// </summary>
                ChangeUser,

                /// <summary>
                /// Event thông báo LogInScreen
                /// </summary>
                Login,

                /// <summary>
                /// Event thông báo Logout
                /// </summary>
                LogOut,

                /// <summary>
                /// Cho phép button click
                /// </summary>
                EnableButton,

                /// <summary>
                /// Không cho phép button click
                /// </summary>
                DisableButton,
            }

            /// <summary>
            /// ID của event
            /// </summary>
            public EventID ID = EventID.None; 
        }
        #endregion Inner Class

        #region Field
        private List<ScreenInfo> _listScreenInfo;
        private const string _SCREEN_ID_NOT_FOUND = @"Not found screen";
        #endregion Field

        #region Contructor
        public GuiResInfoMng()
        {
            _listScreenInfo = new List<ScreenInfo>
            {
                new ScreenInfo()
                { 
                    ID = ScreenID.BAN_THUOC, 
                    Name = "Quản lý bán thuốc", 
                    Instance = null
                },
            };
        }
        #endregion

        #region Method
        /// <summary>
        /// Hàm thay đổi màn hình
        /// </summary>
        /// <param name="screenID">ID của màn hình</param>
        public void ChangeScreen(ScreenID screenID)
        {

        }

        /// <summary>
        /// Hàm gửi event đến toàn bộ các form
        /// </summary>
        /// <param name="e">EventID muốn thông báo</param>
        /// <param name="data">Nội dung muốn thông báo</param>
        public void SendInternalEvent(GuiEventID e, object data)
        {
            if (GuiEventHandle != null)
            {
                GuiEventHandle(e, data);
            }
        }
        
        /// <summary>
        /// Hàm lấy ra form main
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Hàm lấy screenID hiện tại
        /// </summary>
        /// <returns>ScreenID</returns>
        public uint GetCurrentScreen()
        {
            return 0;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được phép thêm mới dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public bool CanInsert()
        {
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được phép sửa dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public bool CanUpdate()
        {
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được phép xóa dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public bool CanDelete()
        {
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được xem dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public bool CanView()
        {
            return false;
        }
        #endregion Method
    }

    class ScreenInfo
    {
        /// <summary>
        /// ID của màn hình
        /// </summary>
        public uint ID;

        /// <summary>
        /// Tên, diễn giải chức năng của màn hình
        /// </summary>
        public string Name;

        /// <summary>
        /// Thực thể của màn  hình
        /// </summary>
        public object Instance;
    }
}
