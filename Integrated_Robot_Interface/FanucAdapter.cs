using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    public class FanucAdapter : RobotAdapter
    {
        //變數宣告
        private FRRJIf.Core mobjCore;
        private FRRJIf.DataTable mobjDataTable;
        private FRRJIf.DataCurPos mobjCurPos;
        private FRRJIf.DataPosReg mobjPosReg;
        private FRRJIf.DataSysVar mobjSysVarInt;
        private FRRJIf.DataNumReg mobjNumReg;
        private FRRJIf.DataAlarm mobjAlarmCurrent;

        public FanucAdapter()
        {
            mobjCore = new FRRJIf.Core();
            mobjDataTable = mobjCore.DataTable;
            mobjAlarmCurrent = mobjDataTable.AddAlarm(FRRJIf.FRIF_DATA_TYPE.ALARM_CURRENT, 1, 0);
            mobjCurPos = mobjDataTable.AddCurPos(FRRJIf.FRIF_DATA_TYPE.CURPOS, 1);
            mobjPosReg = mobjDataTable.AddPosReg(FRRJIf.FRIF_DATA_TYPE.POSREG, 1, 1, 10);
            mobjSysVarInt = mobjDataTable.AddSysVar(FRRJIf.FRIF_DATA_TYPE.SYSVAR_INT, "$MCR.$GENOVERRIDE");
            mobjNumReg = mobjDataTable.AddNumReg(FRRJIf.FRIF_DATA_TYPE.NUMREG_REAL, 1, 10);
        }
        public override bool Connect()
        {
            bool ret = false;

            ret = mobjCore.Connect(IP);
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjCore.Connect Fail";
                return ret;
            }
        }
        public override bool Disconnect()
        {
            bool ret = false;

            ret = mobjCore.Disconnect();
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjCore.Disconnect Fail";
                return ret;
            }
        }
        public override bool Refresh()
        {
            bool ret = false;

            ret = mobjDataTable.Refresh();
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjDataTable.Refresh Fail";
                return ret;
            }
        }
        public override bool Alarm()
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
                    Alarmtext = Year + "/" + Month + "/" + Day + ", " + Hour + ":" + Minute + ":" + Second + "\r\n";
                    if (!string.IsNullOrEmpty(AlarmMessage))
                    {
                        Alarmtext += AlarmMessage + "\r\n";
                    }
                    if (!string.IsNullOrEmpty(CauseAlarmMessage))
                    {
                        Alarmtext += CauseAlarmMessage + "\r\n";
                    }
                    if (!string.IsNullOrEmpty(SeverityMessage))
                    {
                        Alarmtext += SeverityMessage + "\r\n";
                    }
                    return ret;
                }
                else
                {
                    Alarmtext = "";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjAlarmCurrent.GetValue Fail";
                return ret;
            }
        }
        public override bool Reset()
        {
            bool ret = false;

            ret = mobjCore.ClearAlarm();
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjCore.ClearAlarm Fail";
                return ret;
            }
        }
        public override bool GetOverride()
        {
            bool ret = false;
            object Value = null;

            ret = mobjSysVarInt.GetValue(ref Value);
            if (ret)
            {
                Getoverride = Convert.ToInt32(Value);
                return ret;
            }
            else
            {
                Apierrtext = "mobjSysVarInt.GetValue Fail";
                return ret;
            }
        }
        public override bool SetOverride()
        {
            bool ret = false;

            ret = mobjSysVarInt.SetValue(Setoverride);
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjSysVarInt.SetValue Fail";
                return ret;
            }
        }
        public override bool GetCPosition()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                GetCposition = Xyzwpr;
                return ret;
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool GetJPosition()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                GetJposition = Joint;
                return ret;
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool PTPC()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array config = new short[7] { 0, 1, 1, 1, 0, 0, 0 };
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                int Index = 1;

                ret = mobjPosReg.SetValueXyzwpr(Index, SetCposition, config, UF, UT);
                if (ret)
                {
                    return ret;
                }
                else
                {
                    Apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool PTPJ()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                int Index = 1;

                ret = mobjPosReg.SetValueJoint(Index, SetJposition, UF, UT);
                if (ret)
                {
                    return ret;
                }
                else
                {
                    Apierrtext = "mobjPosReg.SetValueJoint Fail";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool Line()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array config = new short[7] { 0, 1, 1, 1, 0, 0, 0 };
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                int Index = 1;

                ret = mobjPosReg.SetValueXyzwpr(Index, SetCposition, config, UF, UT);
                if (ret)
                {
                    return ret;
                }
                else
                {
                    Apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool Home()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                int Index = 1;

                Xyzwpr.SetValue(Homeposition.GetValue(2), 2);
                ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                if (ret)
                {
                    ret = mobjPosReg.SetValueXyzwpr(Index, Homeposition, Config, UF, UT);
                    if (ret)
                    {
                        return ret;
                    }
                    else
                    {
                        Apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                        return ret;
                    }
                }
                else
                {
                    Apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool GetVelocity()
        {
            bool ret = false;
            object Value = null;

            ret = mobjNumReg.GetValue(7, ref Value);
            if (ret)
            {
                Getvelocity = (float)Value;
                return ret;
            }
            else
            {
                Apierrtext = "mobjNumReg.GetValue Fail";
                return ret;
            }
        }
        public override bool SetVelocity()
        {
            bool ret = false;
            ret = mobjNumReg.SetValue(7, Setvelocity);
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }
        }
        public override bool GetRegister()
        {
            bool ret = false;
            object Value = null;

            ret = mobjNumReg.GetValue(Convert.ToInt32(Getregister.GetValue(1)), ref Value);
            if (ret)
            {
                Getregister.SetValue(Value, 0);
                return ret;
            }
            else
            {
                Apierrtext = "mobjNumReg.GetValue Fail";
                return ret;
            }
        }
        public override bool SetRegister()
        {
            bool ret = false;
            ret = mobjNumReg.SetValue(Convert.ToInt32(Setregister.GetValue(1)), Convert.ToSingle(Setregister.GetValue(0)));
            if (ret)
            {
                return ret;
            }
            else
            {
                Apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }
        }
        public override bool IncC()
        {
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;
            int Value = (int)Incmove.GetValue(0);

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                int Index = 1;

                switch ((int)Incmove.GetValue(1))
                {
                    case 0:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(0)) + Value, 0);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 1:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(0)) - Value, 0);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 2:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(1)) + Value, 1);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 3:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(1)) - Value, 1);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 4:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(2)) + Value, 2);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 5:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(2)) - Value, 2);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 6:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(3)) + Value, 3);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 7:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(3)) - Value, 3);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 8:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(4)) + Value, 4);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 9:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(4)) - Value, 4);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 10:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(5)) + Value, 5);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                    case 11:
                        Xyzwpr.SetValue(Convert.ToInt32(Xyzwpr.GetValue(5)) - Value, 5);
                        ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
                        break;
                }
                if (ret)
                {
                    return ret;
                }
                else
                {
                    Apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool IncJ()
        {
            int Value = (int)Incmove.GetValue(0);
            
            bool ret = false;
            Array Xyzwpr = new float[9];
            Array Config = new short[7];
            Array Joint = new float[9];
            short UF = 0;
            short UT = 1;
            short ValidC = 0;
            short ValidJ = 0;

            ret = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (ret)
            {
                int Index = 1;

                switch ((int)Incmove.GetValue(1))
                {
                    case 0:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(0)) + Value, 0);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 1:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(0)) - Value, 0);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 2:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(1)) + Value, 1);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 3:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(1)) - Value, 1);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 4:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(2)) + Value, 2);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 5:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(2)) - Value, 2);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 6:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(3)) + Value, 3);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 7:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(3)) - Value, 3);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 8:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(4)) + Value, 4);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 9:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(4)) - Value, 4);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 10:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(5)) + Value, 5);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                    case 11:
                        Joint.SetValue(Convert.ToInt32(Joint.GetValue(5)) - Value, 5);
                        ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
                        break;
                }
                if (ret)
                {
                    return ret;
                }
                else
                {
                    Apierrtext = "mobjPosReg.SetValueJoint Fail";
                    return ret;
                }
            }
            else
            {
                Apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
        }
        public override bool GetInformation()
        {
            bool ret = false;
            short StartIndex = 1;
            short Count = 18;
            Array Buffer = new short[Count];

            Information = "";
            ret = mobjCore.ReadUI(StartIndex, ref Buffer, Count);
            if (ret)
            {
                for (int i = StartIndex; i <= Count; i++)
                {
                    if (Convert.ToInt16(Buffer.GetValue(i-1)) == 1)
                    {
                        Information += $"UI[{i}] = ON\r\n";
                    }
                    else
                    {
                        Information += $"UI[{i}] = OFF\r\n";
                    }
                }
                return ret;
            }
            else
            {
                Apierrtext = "mobjCore.ReadUI Fail";
                return ret;
            }
        }
    }
}
