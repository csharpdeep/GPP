using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPP.Model
{
    class Model_NhaCC
    {
        private string _maNhaCC,
                       _tenNhaCC,
                       _diaChi,
                       _soDT,
                       _email,
                       _maSoThue,
                       _fax,
                       _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public string MaSoThue
        {
            get { return _maSoThue; }
            set { _maSoThue = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public string TenNhaCC
        {
            get { return _tenNhaCC; }
            set { _tenNhaCC = value; }
        }

        public string MaNhaCC
        {
            get { return _maNhaCC; }
            set { _maNhaCC = value; }
        }

    }
}
