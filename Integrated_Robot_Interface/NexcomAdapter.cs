﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NEXCOMROBOT.MCAT;
using System.IO;
using System.IO.Ports;

namespace Integrated_Robot_Interface
{
    public class NexcomAdapter : RobotAdapter, IGripper
    {
        private NexMotion_DeviceAdapter mobjDeviceAdapter;
        private NexMotion_GroupAdapter mobjGroupAdapter;
        private Pos_T PosAcs;
        private Pos_T PosPcs;
        private Pos_T PosMcs;
        private int DeviceId = 0;
        private SerialPort serialPort1;


        public NexcomAdapter()
        {
            mobjDeviceAdapter = new NexMotion_DeviceAdapter();
            PosAcs = new Pos_T();
            PosAcs.initializ();
            PosPcs = new Pos_T();
            PosPcs.initializ();
            PosMcs = new Pos_T();
            PosMcs.initializ();
        }

        #region <RobotAdapter>
        public override bool Connect()
        {
            int ret = 0;

            ret = mobjDeviceAdapter.NMC_SetIniPath("C:\\NEXCOBOT\\NexMotionLibConfig.ini");
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = "NMC_SetIniPath Fail";
                alarmtext = GetErrorMessage("NMC_SetIniPath Fail", ret);
                return false;
            }

            ret = mobjDeviceAdapter.NMC_DeviceOpenUp(NexMotion_Define.DEV_TYPE_ETHERCAT, 0);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = "NMC_DeviceOpenUp Fail";
                alarmtext = GetErrorMessage("NMC_DeviceOpenUp Fail", ret);
                return false;
            }

            ret = mobjDeviceAdapter.NMC_DeviceResetStateAll();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_DeviceResetStateAll Fail", ret);
                return false;
            }

            DeviceId = mobjDeviceAdapter.DeviceId;
            mobjGroupAdapter = new NexMotion_GroupAdapter(DeviceId, 0);
            return true;
        }
        public override bool Disconnect()
        {
            int ret = mobjDeviceAdapter.NMC_DeviceShutdown();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_DeviceShutdown Fail", ret);
                return false;
            }
            return true;
        }
        public override bool Enable()
        {
            int ret = mobjGroupAdapter.NMC_GroupEnable();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupEnable Fail", ret);
                return false;
            }
            return true;
        }
        public override bool Disable()
        {
            int ret = mobjGroupAdapter.NMC_GroupDisable();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupDisable Fail", ret);
                return false;
            }
            return true;
        }
        public override bool Reset()
        {
            int ret = mobjGroupAdapter.NMC_GroupResetState();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupResetState Fail", ret);
                return false;
            }
            return true;
        }
        public override bool Hold()
        {
            int ret = mobjGroupAdapter.NMC_GroupHalt();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupHalt Fail", ret);
                return false;
            }
            return true;
        }
        public override bool Stop()
        {
            int ret = mobjGroupAdapter.NMC_GroupStop();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupHalt Stop", ret);
                return false;
            }
            return true;
        }
        public override bool Home()
        {
            PosAcs.pos.SetValue(Convert.ToDouble(homeposition.GetValue(0)), 0);
            PosAcs.pos.SetValue(-Convert.ToDouble(homeposition.GetValue(1)) + 90, 1);
            PosAcs.pos.SetValue(Convert.ToDouble(homeposition.GetValue(2)), 2);
            PosAcs.pos.SetValue(-Convert.ToDouble(homeposition.GetValue(3)), 3);
            PosAcs.pos.SetValue(Convert.ToDouble(homeposition.GetValue(4)), 4);
            PosAcs.pos.SetValue(-Convert.ToDouble(homeposition.GetValue(5)), 5);

            int mesk = (int)Math.Pow(2, 6) - 1;

            int ret = mobjGroupAdapter.NMC_GroupPtpAcsAll(mesk, ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupPtpAcsAll", ret);
                return false;
            }
            return true;
        }
        public override bool GetState()
        {
            int PRetState = 0;
            
            int ret = mobjGroupAdapter.NMC_GroupGetState(ref PRetState);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetState Fail", ret);
                return false;
            }

            switch (PRetState)
            {
                case 0:
                    getstate = "DISABLE";
                    break;
                case 1:
                    getstate = "STAND_STILL";
                    break;
                case 2:
                    getstate = "STOPPED";
                    break;
                case 3:
                    getstate = "STOPPING";
                    break;
                case 4:
                    getstate = "MOVING";
                    break;
                case 5:
                    getstate = "HOMING";
                    break;
                case 6:
                    getstate = "ERROR";
                    break;
            }
            return true;
        }
        public override bool GetTool()
        {
            int PRetParaValueI32 = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetParamI32(0x40, 0, ref PRetParaValueI32);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetParamI32 Fail", ret);
                return false;
            }
            gettool = Convert.ToInt16(PRetParaValueI32);
            return true;
        }
        public override bool SetTool()
        {
            int PRetParaValueI32 = settool;

            int ret = mobjGroupAdapter.NMC_GroupSetParamI32(0x40, 0, PRetParaValueI32);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupSetParamI32 Fail", ret);
                return false;
            }
            return true;
        }
        public override bool GetBase()
        {
            int PRetParaValueI32 = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetParamI32(0x48, 0, ref PRetParaValueI32);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetParamI32 Fail", ret);
                return false;
            }
            getbase = Convert.ToInt16(PRetParaValueI32);
            return true;
        }
        public override bool SetBase()
        {
            int PRetParaValueI32 = setbase;

            int ret = mobjGroupAdapter.NMC_GroupSetParamI32(0x48, 0, PRetParaValueI32);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupSetParamI32 Fail", ret);
                return false;
            }
            return true;
        }
        public override bool GetOverride()
        {
            double PRetPercentage = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetVelRatio(ref PRetPercentage);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetVelRatio Fail", ret);
                return false;
            }
            getoverride = (int)PRetPercentage;
            return true;
        }
        public override bool SetOverride()
        {
            int ret = mobjGroupAdapter.NMC_GroupSetVelRatio(setoverride);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupSetVelRatio Fail", ret);
                return false;
            }
            return true;
        }
        public override bool GetCPosition()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosPcs(ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetActualPosPcs Fail", ret);
                return false;
            }
            getcposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(0)), 0);
            getcposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(1)), 1);
            getcposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(2)), 2);
            getcposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(5)), 3);
            getcposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(4)), 4);
            getcposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(3)), 5);
            return true;
        }
        public override bool GetJPosition()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosAcs(ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetActualPosAcs Fail", ret);
                return false;
            }
            getjposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(0)), 0);
            getjposition.SetValue(-Convert.ToSingle(PosAcs.pos.GetValue(1)) + 90, 1);
            getjposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(2)), 2);
            getjposition.SetValue(-Convert.ToSingle(PosAcs.pos.GetValue(3)), 3);
            getjposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(4)), 4);
            getjposition.SetValue(-Convert.ToSingle(PosAcs.pos.GetValue(5)), 5);
            return true;
        }
        public override bool PointMoveC()
        {
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(0)), 0);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(1)), 1);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(2)), 2);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(3)), 5);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(4)), 4);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(5)), 3);

            int mesk = (int)Math.Pow(2, 6) - 1;

            int ret = mobjGroupAdapter.NMC_GroupPtpCartAll(mesk, ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupPtpCartAll", ret);
                return false;
            }
            return true;
        }
        public override bool PointMoveJ()
        {
            PosAcs.pos.SetValue(Convert.ToDouble(setjposition.GetValue(0)), 0);
            PosAcs.pos.SetValue(-Convert.ToDouble(setjposition.GetValue(1)) + 90, 1);
            PosAcs.pos.SetValue(Convert.ToDouble(setjposition.GetValue(2)), 2);
            PosAcs.pos.SetValue(-Convert.ToDouble(setjposition.GetValue(3)), 3);
            PosAcs.pos.SetValue(Convert.ToDouble(setjposition.GetValue(4)), 4);
            PosAcs.pos.SetValue(-Convert.ToDouble(setjposition.GetValue(5)), 5);

            int mesk = (int)Math.Pow(2, 6) - 1;

            int ret = mobjGroupAdapter.NMC_GroupPtpAcsAll(mesk, ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupPtpAcsAll", ret);
                return false;
            }
            return true;
        }
        public override bool LineMove()
        {
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(0)), 0);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(1)), 1);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(2)), 2);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(3)), 5);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(4)), 4);
            PosPcs.pos.SetValue(Convert.ToDouble(setcposition.GetValue(5)), 3);

            int mesk = (int)Math.Pow(2, 6) - 1;
            double retMaxVel = setvelocity;

            int ret = mobjGroupAdapter.NMC_GroupLine(mesk, ref PosPcs, ref retMaxVel);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupLine Fail", ret);
                return false;
            }
            return true;
        }
        public override bool GetVelocity()
        {
            double PRetParaValueF64 = 0;
            
            int ret = mobjGroupAdapter.NMC_GroupGetParamF64(0x32, 0, ref PRetParaValueF64);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetParamF64 Fail", ret);
                return false;
            }
            getvelocity = Convert.ToSingle(PRetParaValueF64);
            return true;
        }
        public override bool SetVelocity()
        {
            double ParaValueF64 = setvelocity;

            int ret = mobjGroupAdapter.NMC_GroupSetParamF64(0x32, 0, ParaValueF64);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupSetParamF64 Fail", ret);
                return false;
            }
            return true;
        }
        public override bool JogMoveC()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosPcs(ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetActualPosPcs Fail", ret);
                return false;
            }

            int CartAxis = 0;
            double CartPos = 0;
            double Value = Convert.ToDouble(jogmove.GetValue(0));

            switch (Convert.ToInt32(jogmove.GetValue(1)))
            {
                case 0:
                    CartAxis = 0;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(0)) + Value;
                    break;
                case 1:
                    CartAxis = 0;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(0)) - Value;
                    break;
                case 2:
                    CartAxis = 1;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(1)) + Value;
                    break;
                case 3:
                    CartAxis = 1;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(1)) - Value;
                    break;
                case 4:
                    CartAxis = 2;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(2)) + Value;
                    break;
                case 5:
                    CartAxis = 2;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(2)) - Value;
                    break;
                case 6:
                    CartAxis = 5;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(5)) + Value;
                    break;
                case 7:
                    CartAxis = 5;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(5)) - Value;
                    break;
                case 8:
                    CartAxis = 4;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(4)) + Value;
                    break;
                case 9:
                    CartAxis = 4;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(4)) - Value;
                    break;
                case 10:
                    CartAxis = 3;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(3)) + Value;
                    break;
                case 11:
                    CartAxis = 3;
                    CartPos = Convert.ToDouble(PosPcs.pos.GetValue(3)) - Value;
                    break;
            }

            ret = mobjGroupAdapter.NMC_GroupPtpCart(CartAxis, CartPos);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupPtpCart Fail", ret);
                return false;
            }
            return true;
        }
        public override bool JogMoveJ()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosAcs(ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetActualPosAcs Fail", ret);
                return false;
            }

            int GroupAxisIndex = 0;
            double AcsPos = 0;
            double PAcsMaxVel = 10;
            double Value = Convert.ToDouble(jogmove.GetValue(0));

            switch (Convert.ToInt32(jogmove.GetValue(1)))
            {
                case 0:
                    GroupAxisIndex = 0;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(0)) + Value;
                    break;
                case 1:
                    GroupAxisIndex = 0;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(0)) - Value;
                    break;
                case 2:
                    GroupAxisIndex = 1;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(1)) - Value;
                    break;
                case 3:
                    GroupAxisIndex = 1;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(1)) + Value;
                    break;
                case 4:
                    GroupAxisIndex = 2;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(2)) + Value;
                    break;
                case 5:
                    GroupAxisIndex = 2;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(2)) - Value;
                    break;
                case 6:
                    GroupAxisIndex = 3;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(3)) - Value;
                    break;
                case 7:
                    GroupAxisIndex = 3;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(3)) + Value;
                    break;
                case 8:
                    GroupAxisIndex = 4;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(4)) + Value;
                    break;
                case 9:
                    GroupAxisIndex = 4;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(4)) - Value;
                    break;
                case 10:
                    GroupAxisIndex = 5;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(5)) - Value;
                    break;
                case 11:
                    GroupAxisIndex = 5;
                    AcsPos = Convert.ToDouble(PosAcs.pos.GetValue(5)) + Value;
                    break;
            }
            
            ret = mobjGroupAdapter.NMC_GroupPtpAcs(GroupAxisIndex, AcsPos, ref PAcsMaxVel);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupPtpAcs Fail", ret);
                return false;
            }
            return true;
        }
        public override bool GetInformation1()
        {
            informationname1 = "Status";
            informationtext1 = "";

            int PRetStatusInBit = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetStatus(ref PRetStatusInBit);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetStatus Fail", ret);
                return false;
            }
            
            for (int i = 0; i <= 14; i++)
            {
                if ((PRetStatusInBit & 1) == 1)
                {
                    switch (i)
                    {
                        case 0:
                            informationtext1 += "EMG = ON\r\n";
                            break;
                        case 1:
                            informationtext1 += "ALM = ON\r\n";
                            break;
                        case 2:
                            informationtext1 += "PEL = ON\r\n";
                            break;
                        case 3:
                            informationtext1 += "NEL = ON\r\n";
                            break;
                        case 4:
                            informationtext1 += "PSEL = ON\r\n";
                            break;
                        case 5:
                            informationtext1 += "NSEL = ON\r\n";
                            break;
                        case 6:
                            informationtext1 += "ENA = ON\r\n";
                            break;
                        case 7:
                            informationtext1 += "ERR = ON\r\n";
                            break;
                        case 9:
                            informationtext1 += "CSTP = ON\r\n";
                            break;
                        case 10:
                            informationtext1 += "ACC = ON\r\n";
                            break;
                        case 11:
                            informationtext1 += "DEC = ON\r\n";
                            break;
                        case 12:
                            informationtext1 += "MV = ON\r\n";
                            break;
                        case 13:
                            informationtext1 += "OP = ON\r\n";
                            break;
                        case 14:
                            informationtext1 += "STOP = ON\r\n";
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            informationtext1 += "EMG = OFF\r\n";
                            break;
                        case 1:
                            informationtext1 += "ALM = OFF\r\n";
                            break;
                        case 2:
                            informationtext1 += "PEL = OFF\r\n";
                            break;
                        case 3:
                            informationtext1 += "NEL = OFF\r\n";
                            break;
                        case 4:
                            informationtext1 += "PSEL = OFF\r\n";
                            break;
                        case 5:
                            informationtext1 += "NSEL = OFF\r\n";
                            break;
                        case 6:
                            informationtext1 += "ENA = OFF\r\n";
                            break;
                        case 7:
                            informationtext1 += "ERR = OFF\r\n";
                            break;
                        case 9:
                            informationtext1 += "CSTP = OFF\r\n";
                            break;
                        case 10:
                            informationtext1 += "ACC = OFF\r\n";
                            break;
                        case 11:
                            informationtext1 += "DEC = OFF\r\n";
                            break;
                        case 12:
                            informationtext1 += "MV = OFF\r\n";
                            break;
                        case 13:
                            informationtext1 += "OP = OFF\r\n";
                            break;
                        case 14:
                            informationtext1 += "STOP = OFF\r\n";
                            break;
                    }
                }
                PRetStatusInBit >>= 1;
            }
            return true;
        }
        public override bool LimitRangeChangeXYZ()
        {
            float Xerror = 0;
            float Yerror = 0;
            float Zerror = 0;
            float Werror = 0;
            float Perror = 0;
            float Rerror = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetActualPosPcs(ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetActualPosPcs Fail", ret);
                return false;
            }
            ret = mobjGroupAdapter.NMC_GroupGetActualPos(0, ref PosMcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetActualPosPcs Fail", ret);
                return false;
            }

            Xerror = Convert.ToSingle(PosMcs.pos.GetValue(0)) - Convert.ToSingle(PosPcs.pos.GetValue(0));
            Yerror = Convert.ToSingle(PosMcs.pos.GetValue(1)) - Convert.ToSingle(PosPcs.pos.GetValue(1));
            Zerror = Convert.ToSingle(PosMcs.pos.GetValue(2)) - Convert.ToSingle(PosPcs.pos.GetValue(2));
            Werror = Convert.ToSingle(PosMcs.pos.GetValue(5)) - Convert.ToSingle(PosPcs.pos.GetValue(5));
            Perror = Convert.ToSingle(PosMcs.pos.GetValue(4)) - Convert.ToSingle(PosPcs.pos.GetValue(4));
            Rerror = Convert.ToSingle(PosMcs.pos.GetValue(3)) - Convert.ToSingle(PosPcs.pos.GetValue(3));

            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(0)) - Xerror, 0);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(1)) - Xerror, 1);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(2)) - Yerror, 2);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(3)) - Yerror, 3);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(4)) - Zerror, 4);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(5)) - Zerror, 5);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(6)) - Werror, 6);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(7)) - Werror, 7);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(8)) - Perror, 8);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(9)) - Perror, 9);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(10)) - Rerror, 10);
            limitrangexyz.SetValue(Convert.ToSingle(limitrangexyzorginal.GetValue(11)) - Rerror, 11);
            return true;
        }
        public override bool Compile()
        {
            int ret = 0;
            int PRetState = 0;
            int mesk = (int)Math.Pow(2, 6) - 1;

            ret = mobjGroupAdapter.NMC_GroupGetState(ref PRetState);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                apierrtext = GetErrorMessage("NMC_GroupGetState Fail", ret);
                return false;
            }

            if (Convert.ToInt32(compile.GetValue(0)) == 1)
            {
                if (PRetState != 1)
                {
                    apierrtext = "未處於STAND_STILL狀態";
                    return false;
                }
            }

            if (Convert.ToInt32(compile.GetValue(0)) == -1)
            {
                return true;
            }

            while (true)
            {
                ret = mobjGroupAdapter.NMC_GroupGetState(ref PRetState);
                if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                {
                    apierrtext = GetErrorMessage("NMC_GroupGetState Fail", ret);
                    return false;
                }

                if (PRetState == 1)
                {
                    break;
                }
                else if (PRetState == 4)
                {

                }
                else
                {
                    return false;
                }
            }

            switch (Convert.ToInt32(compile.GetValue(1)))
            {
                case 0:
                    ret = mobjGroupAdapter.NMC_GroupSetVelRatio(Convert.ToSingle(compile.GetValue(2)));
                    if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                    {
                        apierrtext = GetErrorMessage("NMC_GroupSetVelRatio Fail", ret);
                        return false;
                    }
                    break;
                case 1:
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(2)), 0);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(3)), 1);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(4)), 2);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(5)), 5);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(6)), 4);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(7)), 3);
                    
                    ret = mobjGroupAdapter.NMC_GroupPtpCartAll(mesk, ref PosPcs);
                    if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                    {
                        apierrtext = GetErrorMessage("NMC_GroupPtpCartAll", ret);
                        return false;
                    }
                    break;
                case 2:
                    PosAcs.pos.SetValue(Convert.ToSingle(compile.GetValue(2)), 0);
                    PosAcs.pos.SetValue(-Convert.ToSingle(compile.GetValue(3)) + 90, 1);
                    PosAcs.pos.SetValue(Convert.ToSingle(compile.GetValue(4)), 2);
                    PosAcs.pos.SetValue(-Convert.ToSingle(compile.GetValue(5)), 3);
                    PosAcs.pos.SetValue(Convert.ToSingle(compile.GetValue(6)), 4);
                    PosAcs.pos.SetValue(-Convert.ToSingle(compile.GetValue(7)), 5);
                    
                    ret = mobjGroupAdapter.NMC_GroupPtpAcsAll(mesk, ref PosAcs);
                    if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                    {
                        apierrtext = GetErrorMessage("NMC_GroupPtpAcsAll", ret);
                        return false;
                    }
                    break;
                case 3:
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(2)), 0);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(3)), 1);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(4)), 2);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(5)), 5);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(6)), 4);
                    PosPcs.pos.SetValue(Convert.ToSingle(compile.GetValue(7)), 3);

                    double retMaxVel = Convert.ToSingle(compile.GetValue(8));

                    ret = mobjGroupAdapter.NMC_GroupLine(mesk, ref PosPcs, ref retMaxVel);
                    if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                    {
                        apierrtext = GetErrorMessage("NMC_GroupLine Fail", ret);
                        return false;
                    }
                    break;
                case 4:
                    Thread.Sleep(Convert.ToInt32(compile.GetValue(2))*1000);
                    break;
                case 5:
                    int PRetParaValueI32 = Convert.ToInt32(compile.GetValue(2));

                    ret = mobjGroupAdapter.NMC_GroupSetParamI32(0x40, 0, PRetParaValueI32);
                    if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                    {
                        apierrtext = GetErrorMessage("NMC_GroupSetParamI32 Fail", ret);
                        return false;
                    }
                    break;
                case 6:
                    PRetParaValueI32 = Convert.ToInt32(compile.GetValue(2));

                    ret = mobjGroupAdapter.NMC_GroupSetParamI32(0x48, 0, PRetParaValueI32);
                    if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
                    {
                        apierrtext = GetErrorMessage("NMC_GroupSetParamI32 Fail", ret);
                        return false;
                    }
                    break;
            }
            return true;
        }
        private string GetErrorMessage(string api, int errcode)
        {
            string ret = "Error Code : " + errcode.ToString() + "\n";
            string errmsg = GetNexMotionErrorMessage(errcode);
            if (errmsg != "")
            {
                ret += errmsg;
            }
            return ret;
        }
        private string GetNexMotionErrorMessage(int err_code)
        {
            int err_desc_length = 256;
            StringBuilder err_des = new StringBuilder(err_desc_length);
            IntPtr int_ptr = NexMotion_API.NMC_GetErrorDescription(err_code, err_des, (UInt32)err_desc_length);
            if (int_ptr != null)
            {
                return err_des.ToString();
            }
            return "";
        }
        #endregion

        #region <NexcomNative>
        #endregion

        #region <Gripper>
        public bool GripperConnect()
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
        public bool GripperDisconnect()
        {
            serialPort1.Close();
            return true;
        }
        public bool GripperGrap()
        {
            GripperDirState = 1;
            fgGripperState = true;
            Thread thread = new Thread(grab);
            thread.Start();
            return true;
        }
        public bool GripperOpen()
        {
            GripperDirState = 0;
            fgGripperState = true;
            Thread thread = new Thread(grab);
            thread.Start();
            return true;
        }
        public bool GripperStop()
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
        #endregion
    }
}
