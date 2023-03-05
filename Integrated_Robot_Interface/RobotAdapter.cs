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
        public static int Getoverride { get; set; } = 0;
        public static int Setoverride { get; set; } = 0;
        public static Array GetCposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array GetJposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array SetCposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array SetJposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array Homeposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static float Getvelocity { get; set; } = 0;
        public static float Setvelocity { get; set; } = 0;
        public static Array Getregister { get; set; } = new float[2] { 0, 0 };
        public static Array Setregister { get; set; } = new float[2] { 0, 0 };
        public static Array Incmove { get; set; } = new int[2] { 0, 0 };
        public static int Jogmove { get; set; } = 0;
        public static string Information1name { get; set; } = "";
        public static string Information1text { get; set; } = "";
        public static string Information2name { get; set; } = "";
        public static string Information2text { get; set; } = "";
        public static string Information3name { get; set; } = "";
        public static string Information3text { get; set; } = "";
        public static string Information4name { get; set; } = "";
        public static string Information4text { get; set; } = "";
        #endregion

        #region <Fanuc>

        #endregion

        #region <Nexcom>
        
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
        public virtual bool Reset()
        {
            return false;
        }
        public virtual bool GetOverride()
        {
            return false;
        }
        public virtual bool SetOverride()
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
        public virtual bool PTPC()
        {
            return false;
        }
        public virtual bool PTPJ()
        {
            return false;
        }
        public virtual bool Line()
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
        public virtual bool IncC()
        {
            return false;
        }
        public virtual bool IncJ()
        {
            return false;
        }
        public virtual bool GetInformation1()
        {
            Information1name = "";
            Information1text = "";
            return false;
        }
        public virtual bool GetInformation2()
        {
            Information2name = "";
            Information2text = "";
            return false;
        }
        public virtual bool GetInformation3()
        {
            Information3name = "";
            Information3text = "";
            return true;
        }
        public virtual bool GetInformation4()
        {
            Information4name = "";
            Information4text = "";
            return true;
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
        public virtual bool JogC()
        {
            return false;
        }
        public virtual bool JogJ()
        {
            return false;
        }
        public virtual bool Enable()
        {
            return false;
        }
        public virtual bool Disable()
        {
            return false;
        }
        public virtual bool Hold()
        {
            return false;
        }
        #endregion
    }
}
