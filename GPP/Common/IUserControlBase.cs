using System.Windows.Forms;

namespace GPP
{
    interface IUserControlBase
    {
        #region Implement member
        /// <summary>
        /// Hàm tìm kiếm dữ liệu
        /// </summary>
        /// <param name="keyWords">Từ khóa</param>
        void Search(string keyWords);

        /// <summary>
        /// Hàm xử lý sự kiện nhấn phím
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        void ProcessKeyUp(ref Message msg, Keys keyData);

        #endregion Implement member
    }
}