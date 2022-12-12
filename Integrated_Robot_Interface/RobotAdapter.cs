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
        public static string IP { get; set; } = "";
        public static string AlarmText { get; set; } = "";
        public static Array Cposition { get; set; } = new float[6];
        public static Array Jposition { get; set; } = new float[6];


        //功能介面
        public virtual bool Connect()           //連線與開啟手臂
        {
            return false;
        }
        public virtual bool Disconnect()        //離線與關閉手臂
        {
            return false;
        }
        public virtual bool Refresh()           //更新資料
        {
            return false;
        }
        public virtual bool Alarm()             //警示檢查
        {
            return false;
        }
        public virtual bool CPosition()
        {
            return false;
        }
        public virtual bool JPosition()
        {
            return false;
        }
        //public void Home()
        //public void CPositionSet()
        //public void JPositionSet()
        //public void Override()
        //public void Velocity()
        //public void VelocitySet()
        //public void Register()
        //public void RegisterSet()
        //public void PositionMove()
    }
}
