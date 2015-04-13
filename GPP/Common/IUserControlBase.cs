using System.Windows.Forms;

namespace GPP
{
    public interface IUserControlBase
    {
        #region Implement member

        /// <summary>
        /// Hàm xử lý sự kiện nhấn phím
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        void ProcessKeyUp(ref Message msg, Keys keyData);

        void OnBtnSearchClick();
        void OnBtnExportToExcelClick();
        void OnBtnImportFromExcelClick();
        void OnBtnAddClick();
        void OnBtnEditClick();
        void OnBtnDeleteClick();
        #endregion Implement member
    }
}