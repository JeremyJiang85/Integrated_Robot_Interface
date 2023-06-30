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
        public static short getbase { get; set; } = 0;
        public static short setbase { get; set; } = 0;
        public static short prebase { get; set; } = 0;
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
        public static string informationname1 { get; set; } = "";
        public static string informationtext1 { get; set; } = "";
        public static string informationname2 { get; set; } = "";
        public static string informationtext2 { get; set; } = "";
        public static string informationname3 { get; set; } = "";
        public static string informationtext3 { get; set; } = "";
        public static Array limitcheck { get; set; } = new float[6] { 0, 0, 0, 0, 0, 0 };
        public static Array limitrangexyzorginal { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static Array limitrangexyz { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static Array limitrangejoint { get; set; } = new float[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static float limitvelocity { get; set; } = 0;
        public static Array limitrangevelocity { get; set; } = new float[2] { 0, 0 }; 
        public static int limitoverride { get; set; } = 0;
        public static Array limitrangeoverride { get; set; } = new int[2] { 0, 0 };
        public static short limittool { get; set; } = 0;
        public static Array limitrangetool { get; set; } = new int[2] { 0, 0 };
        public static short limitbase { get; set; } = 0;
        public static Array limitrangebase { get; set; } = new int[2] { 0, 0 };
        public static Array compile { get; set; } = new float[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string programname { get; set; } = "";
        public static bool fgGripperState { get; set; } = false;
        public static short GripperDirState { get; set; } = 0;
        #endregion
        
        //功能介面
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
        public virtual bool GetBase()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public virtual bool SetBase()
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
            informationname1 = "";
            informationtext1 = "";
            return true;
        }
        public virtual bool GetInformation2()
        {
            informationname2 = "";
            informationtext2 = "";
            return true;
        }
        public virtual bool GetInformation3()
        {
            informationname3 = "";
            informationtext3 = "";
            return true;
        }
        public virtual bool LimitRangeChangeXYZ()
        {
            MessageBox.Show("此功能目前無法使用或無實作");
            return false;
        }
        public bool LimitRangeCheckXYZ()
        {
            if (Convert.ToSingle(limitcheck.GetValue(0)) < Convert.ToSingle(limitrangexyz.GetValue(0)) ||
                Convert.ToSingle(limitcheck.GetValue(0)) > Convert.ToSingle(limitrangexyz.GetValue(1)) ||
                Convert.ToSingle(limitcheck.GetValue(1)) < Convert.ToSingle(limitrangexyz.GetValue(2)) ||
                Convert.ToSingle(limitcheck.GetValue(1)) > Convert.ToSingle(limitrangexyz.GetValue(3)) ||
                Convert.ToSingle(limitcheck.GetValue(2)) < Convert.ToSingle(limitrangexyz.GetValue(4)) ||
                Convert.ToSingle(limitcheck.GetValue(2)) > Convert.ToSingle(limitrangexyz.GetValue(5)) ||
                Convert.ToSingle(limitcheck.GetValue(3)) < Convert.ToSingle(limitrangexyz.GetValue(6)) ||
                Convert.ToSingle(limitcheck.GetValue(3)) > Convert.ToSingle(limitrangexyz.GetValue(7)) ||
                Convert.ToSingle(limitcheck.GetValue(4)) < Convert.ToSingle(limitrangexyz.GetValue(8)) ||
                Convert.ToSingle(limitcheck.GetValue(4)) > Convert.ToSingle(limitrangexyz.GetValue(9)) ||
                Convert.ToSingle(limitcheck.GetValue(5)) < Convert.ToSingle(limitrangexyz.GetValue(10)) ||
                Convert.ToSingle(limitcheck.GetValue(5)) > Convert.ToSingle(limitrangexyz.GetValue(11)))
            {
                return false;
            }
            return true;
        }
        public bool LimitRangeCheckJoint()
        {
            if (Convert.ToSingle(limitcheck.GetValue(0)) < Convert.ToSingle(limitrangejoint.GetValue(0)) ||
                Convert.ToSingle(limitcheck.GetValue(0)) > Convert.ToSingle(limitrangejoint.GetValue(1)) ||
                Convert.ToSingle(limitcheck.GetValue(1)) < Convert.ToSingle(limitrangejoint.GetValue(2)) ||
                Convert.ToSingle(limitcheck.GetValue(1)) > Convert.ToSingle(limitrangejoint.GetValue(3)) ||
                Convert.ToSingle(limitcheck.GetValue(2)) < Convert.ToSingle(limitrangejoint.GetValue(4)) ||
                Convert.ToSingle(limitcheck.GetValue(2)) > Convert.ToSingle(limitrangejoint.GetValue(5)) ||
                Convert.ToSingle(limitcheck.GetValue(3)) < Convert.ToSingle(limitrangejoint.GetValue(6)) ||
                Convert.ToSingle(limitcheck.GetValue(3)) > Convert.ToSingle(limitrangejoint.GetValue(7)) ||
                Convert.ToSingle(limitcheck.GetValue(4)) < Convert.ToSingle(limitrangejoint.GetValue(8)) ||
                Convert.ToSingle(limitcheck.GetValue(4)) > Convert.ToSingle(limitrangejoint.GetValue(9)) ||
                Convert.ToSingle(limitcheck.GetValue(5)) < Convert.ToSingle(limitrangejoint.GetValue(10)) ||
                Convert.ToSingle(limitcheck.GetValue(5)) > Convert.ToSingle(limitrangejoint.GetValue(11)))
            {
                return false;
            }
            return true;
        }
        public bool LimitRangeCheckVelocity()
        {
            if (limitvelocity < Convert.ToSingle(limitrangevelocity.GetValue(0)) ||
                limitvelocity > Convert.ToSingle(limitrangevelocity.GetValue(1)))
            {
                return false;
            }
            return true;
        }
        public bool LimitRangeCheckOverride()
        {
            if (limitoverride < Convert.ToSingle(limitrangeoverride.GetValue(0)) ||
                limitoverride > Convert.ToSingle(limitrangeoverride.GetValue(1)))
            {
                return false;
            }
            return true;
        }
        public bool LimitRangeCheckTool()
        {
            if (limittool < Convert.ToSingle(limitrangetool.GetValue(0)) ||
                limittool > Convert.ToSingle(limitrangetool.GetValue(1)))
            {
                return false;
            }
            return true;
        }
        public bool LimitRangeCheckBase()
        {
            if (limitbase < Convert.ToSingle(limitrangebase.GetValue(0)) ||
                limitbase > Convert.ToSingle(limitrangebase.GetValue(1)))
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
    }
}
