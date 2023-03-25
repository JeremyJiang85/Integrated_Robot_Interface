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
        public static string ip { get; set; } = "";
        public static string alarmtext { get; set; } = "";
        public static string apierrtext { get; set; } = "";
        public static int getoverride { get; set; } = 0;
        public static int setoverride { get; set; } = 0;
        public static Array getcposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array getjposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array setcposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array setjposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array homeposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static float getvelocity { get; set; } = 0;
        public static float setvelocity { get; set; } = 0;
        public static Array getregister { get; set; } = new float[2] { 0, 0 };
        public static Array setregister { get; set; } = new float[2] { 0, 0 };
        public static Array incmove { get; set; } = new int[2] { 0, 0 };
        public static int jogmove { get; set; } = 0;
        public static string information1name { get; set; } = "";
        public static string information1text { get; set; } = "";
        public static string information2name { get; set; } = "";
        public static string information2text { get; set; } = "";
        public static string information3name { get; set; } = "";
        public static string information3text { get; set; } = "";
        public static string information4name { get; set; } = "";
        public static string information4text { get; set; } = "";
        public static Array saferangecheck { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array saferangexyz { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static Array saferangejoint { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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
            information1name = "";
            information1text = "";
            return true;
        }
        public virtual bool GetInformation2()
        {
            information2name = "";
            information2text = "";
            return true;
        }
        public virtual bool GetInformation3()
        {
            information3name = "";
            information3text = "";
            return true;
        }
        public virtual bool GetInformation4()
        {
            information4name = "";
            information4text = "";
            return true;
        }
        public bool SafeRangeCheckXYZ()
        {
            if (Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(0)) < Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(0)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(0)) > Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(1)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(1)) < Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(2)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(1)) > Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(3)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(2)) < Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(4)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(2)) > Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(5)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(3)) < Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(6)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(3)) > Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(7)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(4)) < Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(8)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(4)) > Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(9)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(5)) < Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(10)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(5)) > Convert.ToSingle(RobotAdapter.saferangexyz.GetValue(11)))
            {
                return false;
            }
            return true;
        }
        public bool SafeRangeCheckJoint()
        {
            if (Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(0)) < Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(0)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(0)) > Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(1)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(1)) < Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(2)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(1)) > Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(3)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(2)) < Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(4)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(2)) > Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(5)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(3)) < Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(6)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(3)) > Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(7)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(4)) < Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(8)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(4)) > Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(9)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(5)) < Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(10)) ||
                Convert.ToSingle(RobotAdapter.saferangecheck.GetValue(5)) > Convert.ToSingle(RobotAdapter.saferangejoint.GetValue(11)))
            {
                return false;
            }
            return true;
        }
        public virtual bool Compile()
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
