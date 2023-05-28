using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static string getstate { get; set; } = "";
        public static short gettool { get; set; } = 0;
        public static short settool { get; set; } = 0;
        public static short getuframe { get; set; } = 0;
        public static short setuframe { get; set; } = 0;
        public static short preuframe { get; set; } = 0;
        public static Array getcposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array getjposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array setcposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array setjposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array homeposition { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static float getvelocity { get; set; } = 0;
        public static float setvelocity { get; set; } = 0;
        public static Array getregister { get; set; } = new float[2] { 0, 0 };
        public static Array setregister { get; set; } = new float[2] { 0, 0 };
        public static Array jogmove { get; set; } = new int[2] { 0, 0 };
        public static string information1name { get; set; } = "";
        public static string information1text { get; set; } = "";
        public static string information2name { get; set; } = "";
        public static string information2text { get; set; } = "";
        public static string information3name { get; set; } = "";
        public static string information3text { get; set; } = "";
        public static string information4name { get; set; } = "";
        public static string information4text { get; set; } = "";
        public static Array safecheck { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array saferangexyzorginal { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static Array saferangexyz { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static Array saferangejoint { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static float safevelocity { get; set; } = 0;
        public static Array saferangevelocity { get; set; } = new float[2] { 0, 0 }; 
        public static int safeoverride { get; set; } = 0;
        public static Array saferangeoverride { get; set; } = new int[2] { 0, 0 };
        public static Array compile { get; set; } = new float[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string programname { get; set; } = "";
        public static bool fgGripperState { get; set; } = false;
        public static short GripperDirState { get; set; } = 0;
        #endregion

        #region <Fanuc>

        #endregion

        #region <Nexcom>

        #endregion


        //功能介面
        #region <共用>
        public virtual bool Connect()           //連線與開啟手臂
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Disconnect()        //離線與關閉手臂
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Alarm()             //警示檢查
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Enable()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Disable()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Reset()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Hold()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Stop()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool Home()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetState()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetTool ()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool SetTool()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetUFrame()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool SetUFrame()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetOverride()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool SetOverride()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetCPosition()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetJPosition()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool PointMoveC()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool PointMoveJ()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool LineMove()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetVelocity()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool SetVelocity()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool JogMoveC()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool JogMoveJ()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
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
        public virtual bool SafeRangeChangeXYZ()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public bool SafeRangeCheckXYZ()
        {
            if (Convert.ToSingle(safecheck.GetValue(0)) < Convert.ToSingle(saferangexyz.GetValue(0)) ||
                Convert.ToSingle(safecheck.GetValue(0)) > Convert.ToSingle(saferangexyz.GetValue(1)) ||
                Convert.ToSingle(safecheck.GetValue(1)) < Convert.ToSingle(saferangexyz.GetValue(2)) ||
                Convert.ToSingle(safecheck.GetValue(1)) > Convert.ToSingle(saferangexyz.GetValue(3)) ||
                Convert.ToSingle(safecheck.GetValue(2)) < Convert.ToSingle(saferangexyz.GetValue(4)) ||
                Convert.ToSingle(safecheck.GetValue(2)) > Convert.ToSingle(saferangexyz.GetValue(5)) ||
                Convert.ToSingle(safecheck.GetValue(3)) < Convert.ToSingle(saferangexyz.GetValue(6)) ||
                Convert.ToSingle(safecheck.GetValue(3)) > Convert.ToSingle(saferangexyz.GetValue(7)) ||
                Convert.ToSingle(safecheck.GetValue(4)) < Convert.ToSingle(saferangexyz.GetValue(8)) ||
                Convert.ToSingle(safecheck.GetValue(4)) > Convert.ToSingle(saferangexyz.GetValue(9)) ||
                Convert.ToSingle(safecheck.GetValue(5)) < Convert.ToSingle(saferangexyz.GetValue(10)) ||
                Convert.ToSingle(safecheck.GetValue(5)) > Convert.ToSingle(saferangexyz.GetValue(11)))
            {
                return false;
            }
            return true;
        }
        public bool SafeRangeCheckJoint()
        {
            if (Convert.ToSingle(safecheck.GetValue(0)) < Convert.ToSingle(saferangejoint.GetValue(0)) ||
                Convert.ToSingle(safecheck.GetValue(0)) > Convert.ToSingle(saferangejoint.GetValue(1)) ||
                Convert.ToSingle(safecheck.GetValue(1)) < Convert.ToSingle(saferangejoint.GetValue(2)) ||
                Convert.ToSingle(safecheck.GetValue(1)) > Convert.ToSingle(saferangejoint.GetValue(3)) ||
                Convert.ToSingle(safecheck.GetValue(2)) < Convert.ToSingle(saferangejoint.GetValue(4)) ||
                Convert.ToSingle(safecheck.GetValue(2)) > Convert.ToSingle(saferangejoint.GetValue(5)) ||
                Convert.ToSingle(safecheck.GetValue(3)) < Convert.ToSingle(saferangejoint.GetValue(6)) ||
                Convert.ToSingle(safecheck.GetValue(3)) > Convert.ToSingle(saferangejoint.GetValue(7)) ||
                Convert.ToSingle(safecheck.GetValue(4)) < Convert.ToSingle(saferangejoint.GetValue(8)) ||
                Convert.ToSingle(safecheck.GetValue(4)) > Convert.ToSingle(saferangejoint.GetValue(9)) ||
                Convert.ToSingle(safecheck.GetValue(5)) < Convert.ToSingle(saferangejoint.GetValue(10)) ||
                Convert.ToSingle(safecheck.GetValue(5)) > Convert.ToSingle(saferangejoint.GetValue(11)))
            {
                return false;
            }
            return true;
        }
        public bool SafeRangeCheckVelocity()
        {
            if (safevelocity < Convert.ToSingle(saferangevelocity.GetValue(0)) ||
                safevelocity > Convert.ToSingle(saferangevelocity.GetValue(1)))
            {
                return false;
            }
            return true;
        }
        public bool SafeRangeCheckOverride()
        {
            if (safeoverride < Convert.ToSingle(saferangeoverride.GetValue(0)) ||
                safeoverride > Convert.ToSingle(saferangeoverride.GetValue(1)))
            {
                return false;
            }
            return true;
        }
        public virtual bool Compile()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GripperConnect()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GripperDisconnect()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GripperGrap()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GripperOpen()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GripperStop()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        #endregion

        #region <Fanuc>
        public virtual bool Refresh()           //更新資料
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool GetRegister()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool SetRegister()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        #endregion

        #region <Nexcom>

        #endregion
    }
}
