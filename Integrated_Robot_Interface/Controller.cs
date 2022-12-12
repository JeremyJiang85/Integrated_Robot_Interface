using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Robot_Interface
{
    public class Controller
    {
        //變數宣告
        RobotAdapter myRobotAdapter = null;
        
        public int Robot
        {
            get
            {
                return robot;
            }
            set
            {

                if (value >= (int)Robotnum.None && value <= (int)Robotnum.Ourarm)
                {
                    robot = value;
                }
                else
                {
                    MessageBox.Show("手臂選擇超出範圍");
                }
            }
        }
        private int robot = (int)Robotnum.None;
        public enum Robotnum
        {
            None, Fanuc, Nexcom, Ourarm
        }


        public bool Connect()
        {
            switch (robot)
            {
                case (int)Robotnum.Fanuc:
                    myRobotAdapter = new FanucAdapter();
                    return myRobotAdapter.Connect();
                case (int)Robotnum.Nexcom:
                    return false;
                case (int)Robotnum.Ourarm:
                    return false;
                default:
                    return false;
            }
        }
        public bool Disconnect()
        {
            switch (robot)
            {
                case (int)Robotnum.Fanuc:
                    return myRobotAdapter.Disconnect();
                case (int)Robotnum.Nexcom:
                    return false;
                case (int)Robotnum.Ourarm:
                    return false;
                default:
                    return false;
            }
        }
        public bool Refresh()
        {
            return myRobotAdapter.Refresh();
        }
        public bool Alarm()
        {
            return myRobotAdapter.Alarm();
        }
        public bool CPosition()
        {
            return myRobotAdapter.CPosition();
        }
        public bool JPosition()
        {
            return myRobotAdapter.JPosition();
        }
    }
}
