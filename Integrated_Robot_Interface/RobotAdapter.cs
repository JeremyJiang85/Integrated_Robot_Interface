using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    public class RobotAdapter
    {
        //變數宣告
        #region <共用>
        public static string IP { get; set; } = "";
        public static string Alarmtext { get; set; } = "";
        public static string Apierrtext { get; set; } = "";
        public static string Overridetext { get; set; } = "";
        public static Array GetCposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array GetJposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array SetCposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array SetJposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array Homeposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static float Getvelocity { get; set; } = 0;
        public static float Setvelocity { get; set; } = 0;
        public static Array Getregister { get; set; } = new float[2] { 0, 0 };
        public static Array Setregister { get; set; } = new float[2] { 0, 0 };
        public static Array Axismove { get; set; } = new int[2] { 0, 0 };
        #endregion

        #region <Fanuc>

        #endregion

        #region <Nexcom>
        public static string Statetext { get; set; } = "";
        public static string Statustext { get; set; } = "";
        #endregion


        //功能介面
        #region <共用>
        public virtual bool Connect()           //連線與開啟手臂
        {
            return false;
        }
        public virtual bool Disconnect()        //離線與關閉手臂
        {
            return false;
        }
        public virtual bool Alarm()             //警示檢查
        {
            return false;
        }
        public virtual bool Override()
        {
            return false;
        }
        public virtual bool GetCPosition()
        {
            return false;
        }
        public virtual bool GetJPosition()
        {
            return false;
        }
        public virtual bool SetCPosition()
        {
            return false;
        }
        public virtual bool SetJPosition()
        {
            return false;
        }
        public virtual bool Home()
        {
            return false;
        }
        public virtual bool GetVelocity()
        {
            return false;
        }
        public virtual bool SetVelocity()
        {
            return false;
        }
        public virtual bool Inc()
        {
            return false;
        }
        #endregion

        #region <Fanuc>
        public virtual bool Refresh()           //更新資料
        {
            return false;
        }
        public virtual bool GetRegister()
        {
            return false;
        }
        public virtual bool SetRegister()
        {
            return false;
        }
        #endregion

        #region <Nexcom>
        public virtual bool GetState()
        {
            return false;
        }
        public virtual bool GetStatus()
        {
            return false;
        }
        #endregion
    }
}
