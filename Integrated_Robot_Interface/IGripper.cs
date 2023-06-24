using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    interface IGripper
    {
        bool GripperConnect();
        bool GripperDisconnect();
        bool GripperGrap();
        bool GripperOpen();
        bool GripperStop();
    }
}
