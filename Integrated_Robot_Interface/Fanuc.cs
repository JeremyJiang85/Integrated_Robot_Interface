using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Robot_Interface
{
    public class Fanuc
    {
        //變數宣告
        private FRRJIf.Core mobjCore;
        private FRRJIf.DataTable mobjDataTable;
        private FRRJIf.DataCurPos mobjCurPos;
        private FRRJIf.DataPosReg mobjPosReg;
        private FRRJIf.DataSysVar mobjSysVarInt;
        private FRRJIf.DataNumReg mobjNumReg;
        private FRRJIf.DataAlarm mobjAlarmCurrent;

        public Fanuc()
        {
            mobjCore = new FRRJIf.Core();
            mobjDataTable = mobjCore.DataTable;
        }

        public bool Connect(string IP)
        {
            return mobjCore.Connect(IP);
        }

        public bool Disconnect()
        {
            return mobjCore.Disconnect();
        }

        public void Refresh()
        {
            if (!(mobjDataTable.Refresh()))
            {
                MessageBox.Show("Refresh失敗");
            }
        }
    }
}
