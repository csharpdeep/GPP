using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param
{
    public class ParamHelper
    {
        private static readonly ParamHelper _paramHelper = new ParamHelper();

        public static ParamHelper Instance
        {
            get
            {
                return _paramHelper;
            }
        }

        //Khai báo từ điển để lưu trữ param và giá trị tương ứng
        private Dictionary<ParamID, Object> _dictionnary;

        //Khai báo lỗi khi ta không tìm thấy key trong từ điển
        public const string _NOT_FOUND_KEY_EXEPTION = "Không tìm thấy ParamID";

        public ParamHelper()
        {
            //Cấp phát bộ nhớ cho biến _dictionnary
            _dictionnary = new Dictionary<ParamID, object>();
        }

        /// <summary>
        /// Khai báo danh sách các Param
        /// </summary>
        public enum ParamID
        {
            IDS_TENDANGNHAP
        }

        /// <summary>
        /// Lấy ra giá trị kiểu string của biến paramID
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public string GetParamStr(ParamID paramID)
        {
            //Nếu ta không tìm thấy paramID thì thông báo lỗi
            if (_dictionnary.ContainsKey(paramID) == false)
            {
                throw new ArgumentException(_NOT_FOUND_KEY_EXEPTION);
            }
            else
            {
                return (string)_dictionnary[paramID];
            }
        }

        /// <summary>
        /// Hàm lấy giá trị kiểu int của paramID
        /// </summary>
        /// <param name="paramID"></param>
        /// <returns></returns>
        public int GetParamInt(ParamID paramID)
        {
            //Nếu ta không tìm thấy paramID thì thông báo lỗi
            if (_dictionnary.ContainsKey(paramID) == false)
            {
                throw new ArgumentException(_NOT_FOUND_KEY_EXEPTION);
            }
            else
            {
                return (int)_dictionnary[paramID];
            }
        }

        /// <summary>
        /// Hàm set giá trị cho paramID kiểu chuỗi
        /// </summary>
        /// <param name="paramID"></param>
        /// <param name="value"></param>
        public void SetParamStr(ParamID paramID, string value)
        {
            //kiểm tra xem đã có param đó chưa
            //nếu chưa có thì thêm vào
            if (_dictionnary.ContainsKey(paramID) == false)
            {
                _dictionnary.Add(paramID, value);
            }
            else
            {
                //cập nhật lại giá trị của param
                _dictionnary[paramID] = value;
            }
        }

        /// <summary>
        /// Hàm set giá trị cho paramID kiểu int
        /// </summary>
        /// <param name="paramID"></param>
        /// <param name="value"></param>
        public void SetParamInt(ParamID paramID, int value)
        {
            //kiểm tra xem đã có param đó chưa
            //nếu chưa có thì thêm vào
            if (_dictionnary.ContainsKey(paramID) == false)
            {
                _dictionnary.Add(paramID, value);
            }
            else
            {
                //cập nhật lại giá trị của param
                _dictionnary[paramID] = value;
            }
        }
    }
}
