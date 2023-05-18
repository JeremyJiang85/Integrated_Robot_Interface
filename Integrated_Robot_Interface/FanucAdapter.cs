using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace Integrated_Robot_Interface
{
    public class FanucAdapter : RobotAdapter
    {
        //變數宣告
        private FRRJIf.Core mobjCore;
        private FRRJIf.DataTable mobjDataTable;
        private FRRJIf.DataCurPos mobjCurPos;
        private FRRJIf.DataCurPos mobjCurPosUF;
        private FRRJIf.DataPosReg mobjPosReg;
        private FRRJIf.DataSysVar mobjSysVarInt;
        private FRRJIf.DataNumReg mobjNumReg;
        private FRRJIf.DataAlarm mobjAlarmCurrent;
        private FRRJIf.DataTask mobjTask;
        private StreamWriter sw;
        private SerialPort serialPort1;
        private int programlinecount = 0;
        private int programPRcount = 0;
        private Array Xyzwpr = new float[9];
        private Array Config = new short[7];
        private Array Joint = new float[9];
        private short UF = 0;
        private short UT = 1;
        private short ValidC = 0;
        private short ValidJ = 0;

        public FanucAdapter()
        {
            mobjCore = new FRRJIf.Core();
            mobjDataTable = mobjCore.DataTable;
            mobjAlarmCurrent = mobjDataTable.AddAlarm(FRRJIf.FRIF_DATA_TYPE.ALARM_CURRENT, 1, 0);
            mobjCurPos = mobjDataTable.AddCurPos(FRRJIf.FRIF_DATA_TYPE.CURPOS, 1);
            mobjCurPosUF = mobjDataTable.AddCurPosUF(FRRJIf.FRIF_DATA_TYPE.CURPOS, 1, 15);
            mobjPosReg = mobjDataTable.AddPosReg(FRRJIf.FRIF_DATA_TYPE.POSREG, 1, 1, 50);
            mobjSysVarInt = mobjDataTable.AddSysVar(FRRJIf.FRIF_DATA_TYPE.SYSVAR_INT, "$MCR.$GENOVERRIDE");
            mobjNumReg = mobjDataTable.AddNumReg(FRRJIf.FRIF_DATA_TYPE.NUMREG_REAL, 1, 20);
            mobjTask = mobjDataTable.AddTask(FRRJIf.FRIF_DATA_TYPE.TASK, 1);
        }
        public override bool Connect()
        {
            bool ret = false;
            Array Buffer = new short[8] { 1,1,1,0,0,0,0,1 };

            ret = mobjCore.Connect(ip);
            if (!ret)
            {
                apierrtext = "mobjCore.Connect Fail";
                return ret;
            }


            ret = mobjCore.WriteSDI(1, ref Buffer, 8);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }
            return ret;
        }
        public override bool Disconnect()
        {
            bool ret = false;

            ret = mobjCore.Disconnect();
            if (!ret)
            {
                apierrtext = "mobjCore.Disconnect Fail";
                return ret;
            }
            return ret;
        }
        public override bool Refresh()
        {
            bool ret = false;

            ret = mobjDataTable.Refresh();
            if (!ret)
            {
                apierrtext = "mobjDataTable.Refresh Fail";
                return ret;
            }
            return ret;
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
            if (!ret)
            {
                apierrtext = "mobjAlarmCurrent.GetValue Fail";
                return ret;
            }

            if (AlarmID == 0)
            {
                alarmtext = "";
                return ret;
            }

            alarmtext = Year + "/" + Month + "/" + Day + ", " + Hour + ":" + Minute + ":" + Second + "\r\n";
            if (!string.IsNullOrEmpty(AlarmMessage))
            {
                alarmtext += AlarmMessage + "\r\n";
            }
            if (!string.IsNullOrEmpty(CauseAlarmMessage))
            {
                alarmtext += CauseAlarmMessage + "\r\n";
            }
            if (!string.IsNullOrEmpty(SeverityMessage))
            {
                alarmtext += SeverityMessage;
            }
            return ret;
        }
        public override bool Enable()
        {
            bool ret = false;
            Array Buffer = new short[1] { 1 };

            ret = mobjCore.WriteSDI(8, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }
            
            ret = mobjCore.WriteSDI(6, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }

            Buffer.SetValue((short)0, 0);
            ret = mobjCore.WriteSDI(6, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }
            return ret;
        }
        public override bool Disable()
        {
            bool ret = false;
            Array Buffer = new short[1] { 0 };

            ret = mobjCore.WriteSDI(8, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }
            return ret;
        }
        public override bool Reset()
        {
            bool ret = false;
            Array Buffer = new short[1] { 1 };
            
            Buffer.SetValue((short)0, 0);
            ret = mobjCore.WriteSDI(4, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }

            Buffer.SetValue((short)1, 0);
            ret = mobjCore.WriteSDI(5, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }

            Buffer.SetValue((short)0, 0);
            ret = mobjCore.WriteSDI(5, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }

            return ret;
        }
        public override bool Hold()
        {
            bool ret = false;
            Array Buffer = new short[1] { 0 };

            ret = mobjCore.WriteSDI(2, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }

            Buffer.SetValue((short)1, 0);
            ret = mobjCore.WriteSDI(2, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }
            return ret;
        }
        public override bool Stop()
        {
            bool ret = false;
            Array Buffer = new short[1] { 1 };

            ret = mobjCore.WriteSDI(4, ref Buffer, 1);
            if (!ret)
            {
                apierrtext = "mobjCore.WriteDI Fail";
                return ret;
            }
            return ret;
        }
        public override bool Home()
        {
            bool ret = false;
            int Index = 1;

            ret = mobjNumReg.SetValue(6, 1);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }

            ret = mobjPosReg.SetValueJoint(Index, homeposition, UF, UT);
            if (!ret)
            {
                apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                return ret;
            }
            return ret;
        }
        public override bool GetState()
        {
            bool ret = false;
            string ProgName = "";
            short LineNumber = 0;
            short State = 0;
            string ParentProgName = "";

            ret = mobjTask.GetValue(ref ProgName, ref LineNumber, ref State, ref ParentProgName);
            if (!ret)
            {
                apierrtext = "mobjTask.GetValue Fail";
                return ret;
            }

            switch (State)
            {
                case 0:
                    getstate = "Stopped";
                    break;
                case 1:
                    getstate = "Paused";
                    break;
                case 2:
                    getstate = "Executing";
                    break;
            }
            return ret;
        }
        public override bool GetTool()
        {
            bool ret = false;

            ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (!ret)
            {
                apierrtext = "mobjCurPosUF.GetValue Fail";
                return ret;
            }
            gettool = UT;
            return ret;
        }
        public override bool GetUFrame()
        {
            bool ret = false;
            
            ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (!ret)
            {
                apierrtext = "mobjCurPosUF.GetValue Fail";
                return ret;
            }
            getuframe = UF;
            return ret;
        }
        public override bool GetOverride()
        {
            bool ret = false;
            object Value = null;

            ret = mobjSysVarInt.GetValue(ref Value);
            if (!ret)
            {
                apierrtext = "mobjSysVarInt.GetValue Fail";
                return ret;
            }
            getoverride = Convert.ToInt32(Value);
            return ret;
        }
        public override bool SetOverride()
        {
            bool ret = false;

            ret = mobjSysVarInt.SetValue(setoverride);
            if (!ret)
            {
                apierrtext = "mobjSysVarInt.SetValue Fail";
                return ret;
            }
            return ret;
        }
        public override bool GetCPosition()
        {
            bool ret = false;

            ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (!ret)
            {
                apierrtext = "mobjCurPosUF.GetValue Fail";
                return ret;
            }
            getcposition = Xyzwpr;
            return ret;
        }
        public override bool GetJPosition()
        {
            bool ret = false;

            ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (!ret)
            {
                apierrtext = "mobjCurPosUF.GetValue Fail";
                return ret;
            }
            getjposition = Joint;
            return ret;
        }
        public override bool PointMoveC()
        {
            bool ret = false;
            Array config = new short[7] { 0, 1, 1, 1, 0, 0, 0 };
            int Index = 1;

            ret = mobjNumReg.SetValue(6, 1);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }

            ret = mobjPosReg.SetValueXyzwpr(Index, setcposition, config, UF, UT);
            if (!ret)
            {
                apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                return ret;
            }
            return ret;
        }
        public override bool PointMoveJ()
        {
            bool ret = false;
            int Index = 1;

            ret = mobjNumReg.SetValue(6, 1);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }

            ret = mobjPosReg.SetValueJoint(Index, setjposition, UF, UT);
            if (!ret)
            {
                apierrtext = "mobjPosReg.SetValueJoint Fail";
                return ret;
            }
            return ret;
        }
        public override bool LineMove()
        {
            bool ret = false;
            Array config = new short[7] { 0, 1, 1, 1, 0, 0, 0 };
            int Index = 1;

            ret = mobjNumReg.SetValue(6, 2);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }

            ret = mobjPosReg.SetValueXyzwpr(Index, setcposition, config, UF, UT);
            if (!ret)
            {
                apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                return ret;
            }
            return ret;
        }
        public override bool GetVelocity()
        {
            bool ret = false;
            object Value = null;

            ret = mobjNumReg.GetValue(7, ref Value);
            if (!ret)
            {
                apierrtext = "mobjNumReg.GetValue Fail";
                return ret;
            }
            getvelocity = Convert.ToSingle(Value);
            return ret;
        }
        public override bool SetVelocity()
        {
            bool ret = false;
            ret = mobjNumReg.SetValue(7, setvelocity);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }
            return ret;
        }
        public override bool GetRegister()
        {
            bool ret = false;
            object Value = null;

            ret = mobjNumReg.GetValue(Convert.ToInt32(getregister.GetValue(1)), ref Value);
            if (!ret)
            {
                apierrtext = "mobjNumReg.GetValue Fail";
                return ret;
            }
            getregister.SetValue(Value, 0);
            return ret;
        }
        public override bool SetRegister()
        {
            bool ret = false;

            ret = mobjNumReg.SetValue(Convert.ToInt32(setregister.GetValue(1)), Convert.ToSingle(setregister.GetValue(0)));
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }
            return ret;
        }
        public override bool JogMoveC()
        {
            bool ret = false;
            float Value = Convert.ToSingle(jogmove.GetValue(0));
            int Index = 1;

            ret = mobjNumReg.SetValue(6, 1);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }

            switch (Convert.ToInt32(jogmove.GetValue(1)))
            {
                case 0:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(0)) + Value, 0);
                    break;
                case 1:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(0)) - Value, 0);
                    break;
                case 2:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(1)) + Value, 1);
                    break;
                case 3:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(1)) - Value, 1);
                    break;
                case 4:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(2)) + Value, 2);
                    break;
                case 5:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(2)) - Value, 2);
                    break;
                case 6:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(3)) + Value, 3);
                    break;
                case 7:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(3)) - Value, 3);
                    break;
                case 8:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(4)) + Value, 4);
                    break;
                case 9:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(4)) - Value, 4);
                    break;
                case 10:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(5)) + Value, 5);
                    break;
                case 11:
                    Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(5)) - Value, 5);
                    break;
            }

            ret = mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT);
            if (!ret)
            {
                apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                return ret;
            }
            return ret;
        }
        public override bool JogMoveJ()
        {
            bool ret = false;
            float Value = Convert.ToSingle(jogmove.GetValue(0));
            int Index = 1;

            ret = mobjNumReg.SetValue(6, 1);
            if (!ret)
            {
                apierrtext = "mobjNumReg.SetValue Fail";
                return ret;
            }

            switch (Convert.ToInt32(jogmove.GetValue(1)))
            {
                case 0:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(0)) + Value, 0);
                    break;
                case 1:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(0)) - Value, 0);
                    break;
                case 2:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(1)) + Value, 1);
                    break;
                case 3:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(1)) - Value, 1);
                    break;
                case 4:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(2)) + Value, 2);
                    break;
                case 5:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(2)) - Value, 2);
                    break;
                case 6:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(3)) + Value, 3);
                    break;
                case 7:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(3)) - Value, 3);
                    break;
                case 8:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(4)) + Value, 4);
                    break;
                case 9:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(4)) - Value, 4);
                    break;
                case 10:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(5)) + Value, 5);
                    break;
                case 11:
                    Joint.SetValue(Convert.ToSingle(Joint.GetValue(5)) - Value, 5);
                    break;
            }

            ret = mobjPosReg.SetValueJoint(Index, Joint, UF, UT);
            if (!ret)
            {
                apierrtext = "mobjPosReg.SetValueJoint Fail";
                return ret;
            }
            return ret;
        }
        public override bool GetInformation1()
        {
            bool ret = false;
            short StartIndex = 1;
            short Count = 18;
            Array Buffer = new short[Count];
            information1name = "UI";
            information1text = "";

            ret = mobjCore.ReadUI(StartIndex, ref Buffer, Count);
            if (!ret)
            {
                apierrtext = "mobjCore.ReadUI Fail";
                return ret;
            }

            for (int i = StartIndex; i <= Count; i++)
            {
                if (Convert.ToInt16(Buffer.GetValue(i - 1)) == 1)
                {
                    information1text += $"UI[{i}] = ON\r\n";
                }
                else
                {
                    information1text += $"UI[{i}] = OFF\r\n";
                }
            }
            return ret;
        }
        public override bool GetInformation2()
        {
            bool ret = false;
            short StartIndex = 1;
            short Count = 20;
            Array Buffer = new short[Count];
            information2name = "UO";
            information2text = "";

            ret = mobjCore.ReadUO(StartIndex, ref Buffer, Count);
            if (!ret)
            {
                apierrtext = "mobjCore.ReadUO Fail";
                return ret;
            }

            for (int i = StartIndex; i <= Count; i++)
            {
                if (Convert.ToInt16(Buffer.GetValue(i - 1)) == 1)
                {
                    information2text += $"UO[{i}] = ON\r\n";
                }
                else
                {
                    information2text += $"UO[{i}] = OFF\r\n";
                }
            }
            return ret;
        }
        public override bool SafeRangeChangeXYZ()
        {
            bool ret = false;
            Array Xyzwprworld = new float[9];
            Array Configworld = new short[7];
            Array Jointworld = new float[9];
            short UFworld = 0;
            short UTworld = 1;
            short ValidCworld = 0;
            short ValidJworld = 0;
            float Xerror = 0;
            float Yerror = 0;
            float Zerror = 0;
            float Werror = 0;
            float Perror = 0;
            float Rerror = 0;

            ret = mobjCurPos.GetValue(ref Xyzwprworld, ref Configworld, ref Jointworld, ref UFworld, ref UTworld, ref ValidCworld, ref ValidJworld);
            if (!ret)
            {
                apierrtext = "mobjCurPos.GetValue Fail";
                return ret;
            }
            ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
            if (!ret)
            {
                apierrtext = "mobjCurPosUF.GetValue Fail";
                return ret;
            }

            Xerror = Convert.ToSingle(Xyzwprworld.GetValue(0)) - Convert.ToSingle(Xyzwpr.GetValue(0));
            Yerror = Convert.ToSingle(Xyzwprworld.GetValue(1)) - Convert.ToSingle(Xyzwpr.GetValue(1));
            Zerror = Convert.ToSingle(Xyzwprworld.GetValue(2)) - Convert.ToSingle(Xyzwpr.GetValue(2));
            Werror = Convert.ToSingle(Xyzwprworld.GetValue(3)) - Convert.ToSingle(Xyzwpr.GetValue(3));
            Perror = Convert.ToSingle(Xyzwprworld.GetValue(4)) - Convert.ToSingle(Xyzwpr.GetValue(4));
            Rerror = Convert.ToSingle(Xyzwprworld.GetValue(5)) - Convert.ToSingle(Xyzwpr.GetValue(5));

            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(0)) - Xerror, 0);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(1)) - Xerror, 1);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(2)) - Yerror, 2);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(3)) - Yerror, 3);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(4)) - Zerror, 4);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(5)) - Zerror, 5);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(6)) - Werror, 6);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(7)) - Werror, 7);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(8)) - Perror, 8);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(9)) - Perror, 9);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(10)) - Rerror, 10);
            saferangexyz.SetValue(Convert.ToSingle(saferangexyzorginal.GetValue(11)) - Rerror, 11);
            Console.WriteLine("1");
            Console.WriteLine(Xerror);
            Console.WriteLine(Convert.ToSingle(saferangexyzorginal.GetValue(0)));
            Console.WriteLine(Convert.ToSingle(saferangexyz.GetValue(0)));
            return ret;
        }
        public override bool Compile()
        {
            bool ret = false;
            Array config = new short[7] { 0, 1, 1, 1, 0, 0, 0 };

            if (Convert.ToInt32(compile.GetValue(0)) == 1)
            {
                programlinecount = 0;
                programPRcount = 0;
                sw = new StreamWriter($"C:/Users/shanbingchi/Desktop/C#/Integrated_Robot_Interface/{programname}.LS", false);
                sw.WriteLine($"/PROG  {programname}");
                sw.WriteLine("/ATTR");
                sw.WriteLine("OWNER		= MNEDITOR;");
                sw.WriteLine("COMMENT		= \"\";");
                sw.WriteLine("PROG_SIZE	= 0;");
                sw.WriteLine("CREATE		= DATE 23-03-19  TIME 20:28:08;");
                sw.WriteLine("MODIFIED	= DATE 23-03-19  TIME 20:28:08;");
                sw.WriteLine("FILE_NAME	= ;");
                sw.WriteLine("VERSION		= 0;");
                sw.WriteLine("LINE_COUNT	= 0;");
                sw.WriteLine("MEMORY_SIZE	= 0;");
                sw.WriteLine("PROTECT		= READ_WRITE;");
                sw.WriteLine("TCD:  STACK_SIZE	= 0,");
                sw.WriteLine("      TASK_PRIORITY	= 50,");
                sw.WriteLine("      TIME_SLICE	= 0,");
                sw.WriteLine("      BUSY_LAMP_OFF	= 0,");
                sw.WriteLine("      ABORT_REQUEST	= 0,");
                sw.WriteLine("      PAUSE_REQUEST	= 0;");
                sw.WriteLine("DEFAULT_GROUP	= 1,*,*,*,*;");
                sw.WriteLine("CONTROL_CODE	= 00000000 00000000;");
                sw.WriteLine("/MN");
            }

            if (Convert.ToInt32(compile.GetValue(0)) == -1)
            {
                sw.WriteLine("/POS");
                sw.WriteLine("/END");
                sw.Close();
                return true;
            }

            switch (Convert.ToInt32(compile.GetValue(1)))
            {
                case 0:
                    programlinecount++;
                    sw.WriteLine($"   {programlinecount}:  OVERRIDE={Convert.ToInt32(compile.GetValue(2))}% ;");
                    break;
                case 1:
                    programlinecount++;
                    programPRcount++;
                    sw.WriteLine($"   {programlinecount}:J PR[{programPRcount}] 100% FINE    ;");
                    
                    ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
                    if (!ret)
                    {
                        apierrtext = "mobjCurPos.GetValue Fail";
                        return ret;
                    }

                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(2)), 0);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(3)), 1);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(4)), 2);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(5)), 3);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(6)), 4);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(7)), 5);

                    ret = mobjPosReg.SetValueXyzwpr(programPRcount, setcposition, config, UF, UT);
                    if (!ret)
                    {
                        apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                        return ret;
                    }
                    break;
                case 2:
                    programlinecount++;
                    programPRcount++;
                    sw.WriteLine($"   {programlinecount}:J PR[{programPRcount}] 100% FINE    ;");

                    ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
                    if (!ret)
                    {
                        apierrtext = "mobjCurPos.GetValue Fail";
                        return ret;
                    }

                    setjposition.SetValue(Convert.ToSingle(compile.GetValue(2)), 0);
                    setjposition.SetValue(Convert.ToSingle(compile.GetValue(3)), 1);
                    setjposition.SetValue(Convert.ToSingle(compile.GetValue(4)), 2);
                    setjposition.SetValue(Convert.ToSingle(compile.GetValue(5)), 3);
                    setjposition.SetValue(Convert.ToSingle(compile.GetValue(6)), 4);
                    setjposition.SetValue(Convert.ToSingle(compile.GetValue(7)), 5);

                    ret = mobjPosReg.SetValueJoint(programPRcount, setjposition, UF, UT);
                    if (!ret)
                    {
                        apierrtext = "mobjPosReg.SetValueJoint Fail";
                        return ret;
                    }
                    break;
                case 3:
                    programlinecount++;
                    programPRcount++;
                    sw.WriteLine($"   {programlinecount}:L PR[{programPRcount}] {Convert.ToSingle(compile.GetValue(8))}mm/sec FINE    ;");

                    ret = mobjCurPosUF.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ);
                    if (!ret)
                    {
                        apierrtext = "mobjCurPos.GetValue Fail";
                        return ret;
                    }

                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(2)), 0);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(3)), 1);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(4)), 2);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(5)), 3);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(6)), 4);
                    setcposition.SetValue(Convert.ToSingle(compile.GetValue(7)), 5);

                    ret = mobjPosReg.SetValueXyzwpr(programPRcount, setcposition, config, UF, UT);
                    if (!ret)
                    {
                        apierrtext = "mobjPosReg.SetValueXyzwpr Fail";
                        return ret;
                    }
                    break;
                case 4:
                    programlinecount++;
                    sw.WriteLine($"   {programlinecount}:  WAIT   {Convert.ToSingle(compile.GetValue(2))}(sec) ;");
                    break;
                case 5:
                    programlinecount++;
                    sw.WriteLine($"   {programlinecount}:  UTOOL_NUM={Convert.ToInt32(compile.GetValue(2))} ;");
                    break;
                case 6:
                    programlinecount++;
                    sw.WriteLine($"   {programlinecount}:  UFRAME_NUM={Convert.ToInt32(compile.GetValue(2))} ;");
                    break;
            }
            
            return true;
        }
        public override bool GripperConnect()
        {
            serialPort1 = new SerialPort();
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.PortName = "COM3";
            serialPort1.Open();
            return true;
        }
        public override bool GripperDisconnect()
        {
            serialPort1.Close();
            return true;
        }
        public override bool GripperGrap()
        {
            GripperDirState = 1;
            fgGripperState = true;
            Thread thread = new Thread(grab);
            thread.Start();
            return true;
        }
        public override bool GripperOpen()
        {
            GripperDirState = 0;
            fgGripperState = true;
            Thread thread = new Thread(grab);
            thread.Start();
            return true;
        }
        public override bool GripperStop()
        {
            fgGripperState = false;
            return true;
        }
        private void grab()
        {
            while (fgGripperState)
            {
                if (GripperDirState == 1)
                {
                    serialPort1.Write("1");
                }
                else
                {
                    serialPort1.Write("0");
                }
            }
        }
    }
}
