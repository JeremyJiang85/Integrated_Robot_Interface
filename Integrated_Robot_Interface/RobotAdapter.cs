using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    public abstract class RobotAdapter
    {
        //變數宣告



        //功能介面
        public abstract bool Connect();           //連線與開啟手臂

        public abstract bool Disconnect();        //離線與關閉手臂
        public void Refresh()                   //更新資料
        {

        }
        public void Alarm()
        {

        }
        public void CPosition()
        {

        }
        public void JPosition()
        {

        }
        public void Home()
        {

        }
        public void CPositionSet()
        {

        }
        public void JPositionSet()
        {

        }
        public void Override()
        {

        }
        public void Velocity()
        {

        }
        public void VelocitySet()
        {

        }
        public void Register()
        {

        }
        public void RegisterSet()
        {

        }
        public void PositionMove()
        {

        }
    }
}
