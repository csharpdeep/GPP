using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Param;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test param
            ParamHelper.Instance.SetParamStr(ParamHelper.ParamID.IDS_TENDANGNHAP, "COng hoa ABC");
            ParamHelper.Instance.SetParamStr(ParamHelper.ParamID.IDS_TENDANGNHAP, "COng hoa ABCD");
            Console.WriteLine(ParamHelper.Instance.GetParamStr(ParamHelper.ParamID.IDS_TENDANGNHAP));
            new Form1().ShowDialog();
            Console.ReadLine();
        }
    }
}
