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
        Nexcom mynexcom;
        public int DeviceId = 0;

        public NexcomAdapter()
        {
            mynexcom = new Nexcom();
        }
        public override bool Connect()
        {
            int ret = 0;
            ret = mynexcom.NMC_SetIniPath("C:\\NEXCOM\\NexMotionLibConfig.ini");
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                ErrorMessage = GetErrorMessage("NMC_SetIniPath Fail", ret);
                return false;
            }

            ret = mynexcom.NMC_DeviceOpenUp(NexMotion_Define.DEV_TYPE_ETHERCAT, 0, ref DeviceId);
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                ErrorMessage = GetErrorMessage("NMC_DeviceOpenUp Fail", ret);
                return false;
            }

            ret = mynexcom.NMC_DeviceResetStateAll();
            if (ret != NexMotion_ErrCode.NMCERR_SUCCESS)
            {
                ErrorMessage = GetErrorMessage("NMC_DeviceResetStateAll Fail", ret);
                return false;
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
    }
}
