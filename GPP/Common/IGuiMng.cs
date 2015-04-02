using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPP
{
    interface IGuiMng
    {
        void ChangeScreen(object obj, GuiResId.ScreenMode screenMode);
    }
}
