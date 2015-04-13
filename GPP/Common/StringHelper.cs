using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPP
{
    class StringHelper
    {
        /// <summary>
        /// Hàm xóa ký tự đặc biệt
        /// </summary>
        /// <param name="str"></param>
        public static void RemoveSpecialSymbol(ref string str)
        {
            while (str.Length > 0)
            {
                if (str.Contains("\""))
                {
                    int index = str.IndexOf("\"");
                    str = str.Remove(index, 1);
                }
                else if (str.Contains("'"))
                {
                    int index = str.IndexOf("'");
                    str = str.Remove(index, 1);
                }
                else
                {
                    break;
                }
            }
            str = str.Trim();
        }

        /// <summary>
        /// Hàm kiểm tra xem chuỗi có phải là chữ số hay không
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }
    }
}
