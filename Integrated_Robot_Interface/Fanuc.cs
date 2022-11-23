using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    public class Fanuc
    {
        //變數宣告
        private FRRJIf.Core mobjCore;
        private FRRJIf.DataTable mobjDataTable;

        public Fanuc()
        {
            mobjCore = new FRRJIf.Core();
            mobjDataTable = mobjCore.DataTable;
        }

        public bool Connect(string ip)
        {
            return mobjCore.Connect(ip);
        }

        public bool Disconnect()
        {
            return mobjCore.Disconnect();
        }
    }
}
