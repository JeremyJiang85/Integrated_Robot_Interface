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
            mobjAlarmCurrent = mobjDataTable.AddAlarm(FRRJIf.FRIF_DATA_TYPE.ALARM_CURRENT, 1, 0);
            mobjCurPos = mobjDataTable.AddCurPos(FRRJIf.FRIF_DATA_TYPE.CURPOS, 1);
            mobjPosReg = mobjDataTable.AddPosReg(FRRJIf.FRIF_DATA_TYPE.POSREG, 1, 1, 10);
            mobjSysVarInt = mobjDataTable.AddSysVar(FRRJIf.FRIF_DATA_TYPE.SYSVAR_INT, "$MCR.$GENOVERRIDE");
        }

        public bool Connect(string IP)
        {
            return mobjCore.Connect(IP);
        }

        public bool Disconnect()
        {
            return mobjCore.Disconnect();
        }

        public bool Refresh()
        {
            return mobjDataTable.Refresh();
        }

        public bool Alarm(ref string AlarmText)
        {
            bool ret = false;
            const int Count = 1;
            short AlarmID = 0;
            short AlarmNumber = 0;
            short CauseAlarmID = 0;
            short CauseAlarmNumber = 0;
            short Severity = 0;
            short Year = 0;
            short Month = 0;
            short Day = 0;
            short Hour = 0;
            short Minute = 0;
            short Second = 0;
            string AlarmMessage = null;
            string CauseAlarmMessage = null;
            string SeverityMessage = null;
            ret = mobjAlarmCurrent.GetValue(Count, ref AlarmID, ref AlarmNumber, ref CauseAlarmID, ref CauseAlarmNumber, ref Severity,
                ref Year, ref Month, ref Day, ref Hour, ref Minute, ref Second, ref AlarmMessage, ref CauseAlarmMessage, ref SeverityMessage);
            if (ret)
            {
                if (AlarmID != 0)
                {
                    AlarmText = AlarmID + ", " + AlarmNumber + ", " + CauseAlarmID + ", " + CauseAlarmNumber + ", " + Severity + "\r\n" +
                    Year + "/" + Month + "/" + Day + ", " + Hour + ":" + Minute + ":" + Second + "\r\n";
                    if (!string.IsNullOrEmpty(AlarmMessage))
                    {
                        AlarmText += AlarmMessage + "\r\n";
                    }
                    if (!string.IsNullOrEmpty(CauseAlarmMessage))
                    {
                        AlarmText += CauseAlarmMessage + "\r\n";
                    }
                    if (!string.IsNullOrEmpty(SeverityMessage))
                    {
                        AlarmText += SeverityMessage;
                    }
                    return ret;
                }
                else
                {
                    AlarmText = "";
                    return ret;
                }
            }
            else
            {
                AlarmText = "取得警示失敗";
                return ret;
            }
        }
    }
}
