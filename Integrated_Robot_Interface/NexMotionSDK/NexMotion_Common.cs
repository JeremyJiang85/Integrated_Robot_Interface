using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public static class NexMotion_Common
    {
        public static string GetNexMotionErrorMessage(int err_code)
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
        public static void ShowMessageBox(string msg, int err_code)
        {
            string show_msg = msg +"\n";

            //set error code 
            show_msg += "Error Code : " + err_code.ToString() + "\n";

            //get error description
            string err_msg = GetNexMotionErrorMessage(err_code);
            if (err_msg != "")
            {
                show_msg += "\nDescription :  \n";
                show_msg += err_msg;
            }


            System.Windows.Forms.MessageBox.Show(show_msg, 
                                                 "Warning", 
                                                 System.Windows.Forms.MessageBoxButtons.OK, 
                                                 System.Windows.Forms.MessageBoxIcon.Warning);
        }
    }
}
