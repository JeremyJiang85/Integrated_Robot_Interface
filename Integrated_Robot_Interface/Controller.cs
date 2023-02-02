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
        
        public Robotnum Robot { get; set; } = Robotnum.None;
        public enum Robotnum { None, Fanuc, Nexcom, Ourarm }
        public Coordinatenum Coordinate { get; set; } = Coordinatenum.Cartesian;
        public enum Coordinatenum { Cartesian, Joint }
        public Stepnum Step { get; set; } = Stepnum.One;
        public enum Stepnum : int { One = 1, Five = 5, Ten = 10, Cont = 20 }

        #region <共用>
        public bool Connect()
        {
            switch (Robot)
            {
                case Robotnum.Fanuc:
                    myRobotAdapter = new FanucAdapter();
                    return myRobotAdapter.Connect();
                case Robotnum.Nexcom:
                    myRobotAdapter = new NexcomAdapter();
                    return myRobotAdapter.Connect();
                case Robotnum.Ourarm:
                    return false;
                default:
                    return false;
            }
        }
        public bool Disconnect()
        {
            switch (Robot)
            {
                case Robotnum.Fanuc:
                    return myRobotAdapter.Disconnect();
                case Robotnum.Nexcom:
                    return myRobotAdapter.Disconnect();
                case Robotnum.Ourarm:
                    return false;
                default:
                    return false;
            }
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
        public bool GetVelocity()
        {
            return myRobotAdapter.GetVelocity();
        }
        public bool SetVelocity()
        {
            return myRobotAdapter.SetVelocity();
        }
        public bool Inc()
        {
            return myRobotAdapter.Inc();
        }
        #endregion

        #region <Fanuc>
        public bool Refresh()
        {
            return myRobotAdapter.Refresh();
        }
        public bool GetRegister()
        {
            return myRobotAdapter.GetRegister();
        }
        public bool SetRegister()
        {
            return myRobotAdapter.SetRegister();
        }
        #endregion

        #region <Nexcom>
        public bool GetState()
        {
            return myRobotAdapter.GetState();
        }
        public bool GetStatus()
        {
            return myRobotAdapter.GetStatus();
        }
        #endregion
    }
}
