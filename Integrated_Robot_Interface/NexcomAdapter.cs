using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEXCOMROBOT.MCAT;

namespace Integrated_Robot_Interface
{
    public class NexcomAdapter : RobotAdapter
    {
        private NexMotion_DeviceAdapter mobjDeviceAdapter;
        private NexMotion_GroupAdapter mobjGroupAdapter;
        public Pos_T PosAcs;
        public Pos_T PosPcs;
        public int DeviceId = 0;

        public enum Statenum
        {
            GROUP_STATE_DISABLE,
            GROUP_STATE_STAND_STILL,
            GROUP_STATE_STOPPED,
            GROUP_STATE_STOPPING,
            GROUP_STATE_MOVING,
            GROUP_STATE_HOMING,
            GROUP_STATE_ERROR
        }

        public NexcomAdapter()
        {
            mobjDeviceAdapter = new NexMotion_DeviceAdapter();
            PosAcs = new Pos_T();
            PosAcs.initializ();
            PosPcs = new Pos_T();
            PosPcs.initializ();
        }
        public override bool Connect()
        {
            int ret = 0;
            ret = mobjDeviceAdapter.NMC_SetIniPath("C:\\NEXCOM\\NexMotionLibConfig.ini");
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_SetIniPath Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            ret = mobjDeviceAdapter.NMC_DeviceOpenUp(NexMotion_Define.DEV_TYPE_ETHERCAT, 0);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_DeviceOpenUp Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            ret = mobjDeviceAdapter.NMC_DeviceResetStateAll();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_DeviceResetStateAll Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
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
                Apierrtext = GetErrorMessage("NMC_DeviceShutdown Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            return true;
        }
        public override bool Alarm()
        {
            return true;
        }
        public override bool Reset()
        {
            int ret = mobjGroupAdapter.NMC_GroupResetState();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupResetState Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            return true;
        }
        public override bool GetState()
        {
            int PRetState = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetState(ref PRetState);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetState Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            switch (PRetState)
            {
                case (int)Statenum.GROUP_STATE_DISABLE:
                    Statetext = "DISABLE";
                    break;
                case (int)Statenum.GROUP_STATE_STAND_STILL:
                    Statetext = "STAND_STILL";
                    break;
                case (int)Statenum.GROUP_STATE_STOPPED:
                    Statetext = "STOPPED";
                    break;
                case (int)Statenum.GROUP_STATE_STOPPING:
                    Statetext = "STOPPING";
                    break;
                case (int)Statenum.GROUP_STATE_MOVING:
                    Statetext = "MOVING";
                    break;
                case (int)Statenum.GROUP_STATE_HOMING:
                    Statetext = "HOMING";
                    break;
                case (int)Statenum.GROUP_STATE_ERROR:
                    Statetext = "ERROR";
                    break;
            }
            return true;
        }
        public override bool GetStatus()
        {
            int PRetStatusInBit = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetStatus(ref PRetStatusInBit);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetStatus Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            for (int i = 0; i > 14; i++)
            {
                if ((PRetStatusInBit | 1) == 1)
                {
                    switch (i)
                    {
                        case 0:
                            Statustext += "0:EMG/r/n";
                            break;
                        case 1:
                            Statustext += "1:ALM/r/n";
                            break;
                        case 2:
                            Statustext += "2:PEL/r/n";
                            break;
                        case 3:
                            Statustext += "3:NEL/r/n";
                            break;
                        case 4:
                            Statustext += "4:PSEL/r/n";
                            break;
                        case 5:
                            Statustext += "5:NSEL/r/n";
                            break;
                        case 6:
                            Statustext += "6:ENA/r/n";
                            break;
                        case 7:
                            Statustext += "7:ERR/r/n";
                            break;
                        case 8:
                            Statustext += "8:CSTP/r/n";
                            break;
                        case 9:
                            Statustext += "9:ACC/r/n";
                            break;
                        case 10:
                            Statustext += "10:DEC/r/n";
                            break;
                        case 11:
                            Statustext += "11:MV/r/n";
                            break;
                        case 12:
                            Statustext += "12:OP/r/n";
                            break;
                        case 13:
                            Statustext += "13:STOP/r/n";
                            break;
                        case 14:
                            Statustext += "14:INP/r/n";
                            break;
                    }
                }
                PRetStatusInBit >>= 1;
            }

            return true;
        }
        public override bool GetOverride()
        {
            double PRetPercentage = 0;

            int ret = mobjGroupAdapter.NMC_GroupGetVelRatio(ref PRetPercentage);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetVelRatio Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            Getoverride = (int)PRetPercentage;
            return true;
        }
        public override bool SetOverride()
        {
            int ret = mobjGroupAdapter.NMC_GroupSetVelRatio(Setoverride);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupSetVelRatio Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public override bool GetCPosition()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosPcs(ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetActualPosPcs Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            GetCposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(0)), 0);
            GetCposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(1)), 1);
            GetCposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(2)), 2);
            GetCposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(5)), 3);
            GetCposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(4)), 4);
            GetCposition.SetValue(Convert.ToSingle(PosPcs.pos.GetValue(3)), 5);

            return true;
        }
        public override bool GetJPosition()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosAcs(ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetActualPosAcs Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            GetJposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(0)), 0);
            GetJposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(1)), 1);
            GetJposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(2)), 2);
            GetJposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(3)), 3);
            GetJposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(4)), 4);
            GetJposition.SetValue(Convert.ToSingle(PosAcs.pos.GetValue(5)), 5);

            return true;
        }
        public override bool PTPC()
        {
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(0)), 0);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(1)), 1);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(2)), 2);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(3)), 5);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(4)), 4);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(5)), 3);

            int mesk = (int)Math.Pow(2, 6) - 1;

            int ret = mobjGroupAdapter.NMC_GroupPtpCartAll(mesk, ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupPtpCartAll", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            return true;
        }
        public override bool PTPJ()
        {
            PosAcs.pos.SetValue(Convert.ToSingle(SetJposition.GetValue(0)), 0);
            PosAcs.pos.SetValue(Convert.ToSingle(SetJposition.GetValue(1)), 1);
            PosAcs.pos.SetValue(Convert.ToSingle(SetJposition.GetValue(2)), 2);
            PosAcs.pos.SetValue(Convert.ToSingle(SetJposition.GetValue(3)), 3);
            PosAcs.pos.SetValue(Convert.ToSingle(SetJposition.GetValue(4)), 4);
            PosAcs.pos.SetValue(Convert.ToSingle(SetJposition.GetValue(5)), 5);

            int mesk = (int)Math.Pow(2, 6) - 1;

            int ret = mobjGroupAdapter.NMC_GroupPtpAcsAll(mesk, ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupPtpAcsAll", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            return true;
        }
        public override bool Line()
        {
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(0)), 0);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(1)), 1);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(2)), 2);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(3)), 5);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(4)), 4);
            PosPcs.pos.SetValue(Convert.ToSingle(SetCposition.GetValue(5)), 3);

            int mesk = (int)Math.Pow(2, 6) - 1;
            double retMaxVel = Setvelocity;

            int ret = mobjGroupAdapter.NMC_GroupLine(mesk, ref PosPcs, ref retMaxVel);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupLine Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            return true;
        }
        public override bool GetVelocity()
        {
            double PRetParaValueF64 = 0;
            
            int ret = mobjGroupAdapter.NMC_GroupGetParamF64(0x32, 0, ref PRetParaValueF64);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetParamF64 Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            Getvelocity = Convert.ToSingle(PRetParaValueF64);

            return true;
        }
        public override bool SetVelocity()
        {
            double ParaValueF64 = Setvelocity;

            int ret = mobjGroupAdapter.NMC_GroupSetParamF64(0x32, 0, ParaValueF64);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupSetParamF64 Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            return true;
        }
        public override bool JogC()
        {
            int CartAxis = 0;
            int Dir = 0;
            double PMaxVel = 0;

            switch (Jogmove)
            {
                case 0:
                    CartAxis = 0;
                    Dir = 0;
                    break;
                case 1:
                    CartAxis = 0;
                    Dir = 1;
                    break;
                case 2:
                    CartAxis = 1;
                    Dir = 0;
                    break;
                case 3:
                    CartAxis = 1;
                    Dir = 1;
                    break;
                case 4:
                    CartAxis = 2;
                    Dir = 0;
                    break;
                case 5:
                    CartAxis = 2;
                    Dir = 1;
                    break;
                case 6:
                    CartAxis = 5;
                    Dir = 0;
                    break;
                case 7:
                    CartAxis = 5;
                    Dir = 1;
                    break;
                case 8:
                    CartAxis = 4;
                    Dir = 0;
                    break;
                case 9:
                    CartAxis = 4;
                    Dir = 1;
                    break;
                case 10:
                    CartAxis = 3;
                    Dir = 0;
                    break;
                case 11:
                    CartAxis = 3;
                    Dir = 1;
                    break;
            }

            int ret = mobjGroupAdapter.NMC_GroupJogCartFrame(CartAxis, Dir, ref PMaxVel);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupJogCartFrame", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public override bool JogJ()
        {
            int CartAxis = 0;
            int Dir = 0;
            double PMaxVel = 0;

            switch (Jogmove)
            {
                case 0:
                    CartAxis = 0;
                    Dir = 0;
                    break;
                case 1:
                    CartAxis = 0;
                    Dir = 1;
                    break;
                case 2:
                    CartAxis = 1;
                    Dir = 0;
                    break;
                case 3:
                    CartAxis = 1;
                    Dir = 1;
                    break;
                case 4:
                    CartAxis = 2;
                    Dir = 0;
                    break;
                case 5:
                    CartAxis = 2;
                    Dir = 1;
                    break;
                case 6:
                    CartAxis = 3;
                    Dir = 0;
                    break;
                case 7:
                    CartAxis = 3;
                    Dir = 1;
                    break;
                case 8:
                    CartAxis = 4;
                    Dir = 0;
                    break;
                case 9:
                    CartAxis = 4;
                    Dir = 1;
                    break;
                case 10:
                    CartAxis = 5;
                    Dir = 0;
                    break;
                case 11:
                    CartAxis = 5;
                    Dir = 1;
                    break;
            }

            int ret = mobjGroupAdapter.NMC_GroupJogAcs(CartAxis, Dir, ref PMaxVel);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupJogJogAcs", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public override bool IncC()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosPcs(ref PosPcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetActualPosPcs Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            int CartAxis = 0;
            double CartPos = 0;

            switch (Incmove.GetValue(1))
            {
                case 0:
                    CartAxis = 0;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(0)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 1:
                    CartAxis = 0;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(0)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 2:
                    CartAxis = 1;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(1)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 3:
                    CartAxis = 1;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(1)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 4:
                    CartAxis = 2;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(2)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 5:
                    CartAxis = 2;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(2)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 6:
                    CartAxis = 5;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(5)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 7:
                    CartAxis = 5;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(5)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 8:
                    CartAxis = 4;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(4)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 9:
                    CartAxis = 4;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(4)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 10:
                    CartAxis = 3;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(3)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 11:
                    CartAxis = 3;
                    CartPos = Convert.ToInt32(PosPcs.pos.GetValue(3)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
            }

            ret = mobjGroupAdapter.NMC_GroupPtpCart(CartAxis, CartPos);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupPtpCart Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public override bool IncJ()
        {
            int ret = mobjGroupAdapter.NMC_GroupGetActualPosAcs(ref PosAcs);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupGetActualPosAcs Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }

            int GroupAxisIndex = 0;
            double AcsPos = 0;
            double PAcsMaxVel = 0;

            switch (Incmove.GetValue(1))
            {
                case 0:
                    GroupAxisIndex = 0;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(0)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 1:
                    GroupAxisIndex = 0;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(0)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 2:
                    GroupAxisIndex = 1;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(1)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 3:
                    GroupAxisIndex = 1;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(1)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 4:
                    GroupAxisIndex = 2;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(2)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 5:
                    GroupAxisIndex = 2;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(2)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 6:
                    GroupAxisIndex = 3;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(3)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 7:
                    GroupAxisIndex = 3;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(3)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 8:
                    GroupAxisIndex = 4;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(4)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 9:
                    GroupAxisIndex = 4;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(4)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 10:
                    GroupAxisIndex = 5;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(5)) + Convert.ToInt32(Incmove.GetValue(0));
                    break;
                case 11:
                    GroupAxisIndex = 5;
                    AcsPos = Convert.ToInt32(PosAcs.pos.GetValue(5)) - Convert.ToInt32(Incmove.GetValue(0));
                    break;
            }
            
            ret = mobjGroupAdapter.NMC_GroupPtpAcs(GroupAxisIndex, AcsPos, ref PAcsMaxVel);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupPtpAcs Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public string GetErrorMessage(string api, int errcode)
        {
            string ret = api + "\n";
            ret += "Error Code : " + errcode.ToString() + "\n";
            string errmsg = GetNexMotionErrorMessage(errcode);
            if (errmsg != "")
            {
                ret += "\nDescription :  \n";
                ret += errmsg;
            }
            return ret;
        }
        public string GetNexMotionErrorMessage(int err_code)
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
        public override bool Enable()
        {
            int ret = mobjGroupAdapter.NMC_GroupEnable();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupEnable Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public override bool Disable()
        {
            int ret = mobjGroupAdapter.NMC_GroupDisable();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupDisable Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
        public override bool Hold()
        {
            int ret = mobjGroupAdapter.NMC_GroupHalt();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                Apierrtext = GetErrorMessage("NMC_GroupHalt Fail", ret);
                return false;
            }
            else
            {
                Apierrtext = "";
            }
            return true;
        }
    }
}
