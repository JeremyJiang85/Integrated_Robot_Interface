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
        public int Coordinate
        {
            get
            {
                return coordinate;
            }
            set
            {
                if (value >= (int)Coordinatenum.Cartesian && value <= (int)Coordinatenum.Joint)
                {
                    coordinate = value;
                }
                else
                {
                    MessageBox.Show("座標選擇超出範圍");
                }
            }
        }
        private int coordinate = (int)Coordinatenum.Cartesian;
        public enum Coordinatenum
        {
            Cartesian, Joint
        }
        public int Step
        {
            get
            {
                return step;
            }
            set
            {
                if (value >= (int)Stepnum.One && value <= (int)Stepnum.Cont)
                {
                    step = value;
                }
                else
                {
                    MessageBox.Show("步數選擇超出範圍");
                }
            }
        }
        private int step = (int)Stepnum.One;
        public enum Stepnum
        {
            One, Five, Ten, Cont
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
        public bool Override()
        {
            return myRobotAdapter.Override();
        }
        public bool GetCPosition()
        {
            return myRobotAdapter.GetCPosition();
        }
        public bool GetJPosition()
        {
            return myRobotAdapter.GetJPosition();
        }
        public bool SetCPosition()
        {
            return myRobotAdapter.SetCPosition();
        }
        public bool SetJPosition()
        {
            return myRobotAdapter.SetJPosition();
        }
        public bool Home()
        {
            return myRobotAdapter.Home();
        }
        public bool GetRegister()
        {
            return myRobotAdapter.GetRegister();
        }
        public bool SetRegister()
        {
            return myRobotAdapter.SetRegister();
        }
        public bool Inc()
        {
            return myRobotAdapter.Inc();
        }
    }
}
