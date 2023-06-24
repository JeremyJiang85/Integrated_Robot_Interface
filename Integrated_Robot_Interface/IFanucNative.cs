using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    interface IFanucNative
    {
        bool Refresh();
        bool GetRegister();
        bool SetRegister();
    }
}
