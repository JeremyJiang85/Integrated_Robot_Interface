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
        public RobotAdapter myRobotAdapter = null;

        public Robotnum Robot { get; set; } = Robotnum.None;
        public enum Robotnum { None, Fanuc, Nexcom, Ourarm }
        public Coordinatenum Coordinate { get; set; } = Coordinatenum.Cartesian;
        public enum Coordinatenum { Cartesian, Joint }
        public Stepnum Step { get; set; } = Stepnum.One;
        public enum Stepnum : int { One = 1, Five = 5, Ten = 10 }
        public Instructionnum Instruction { get; set; } = Instructionnum.OVERRIDE;
        public enum Instructionnum : int { OVERRIDE, MOVEC, MOVEJ, MOVEL, WAIT, TOOL, BASE };
        
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
                    myRobotAdapter = new MiniABBAdapter();
                    return myRobotAdapter.Connect();
                default:
                    return false;
            }
        }
        public bool Disconnect()
        {
            return myRobotAdapter.Disconnect();
        }
        public bool Alarm()
        {
            return myRobotAdapter.Alarm();
        }
        public bool Enable()
        {
            return myRobotAdapter.Enable();
        }
        public bool Disable()
        {
            return myRobotAdapter.Disable();
        }
        public bool Reset()
        {
            return myRobotAdapter.Reset();
        }
        public bool Hold()
        {
            return myRobotAdapter.Hold();
        }
        public bool Stop()
        {
            return myRobotAdapter.Stop();
        }
        public bool Home()
        {
            return myRobotAdapter.Home();
        }
        public bool GetState()
        {
            return myRobotAdapter.GetState();
        }
        public bool GetTool()
        {
            return myRobotAdapter.GetTool();
        }
        public bool SetTool()
        {
            return myRobotAdapter.SetTool();
        }
        public bool GetBase()
        {
            return myRobotAdapter.GetBase();
        }
        public bool SetBase()
        {
            return myRobotAdapter.SetBase();
        }
        public bool GetOverride()
        {
            return myRobotAdapter.GetOverride();
        }
        public bool SetOverride()
        {
            return myRobotAdapter.SetOverride();
        }
        public bool GetCPosition()
        {
            return myRobotAdapter.GetCPosition();
        }
        public bool GetJPosition()
        {
            return myRobotAdapter.GetJPosition();
        }
        public bool PointMoveC()
        {
            return myRobotAdapter.PointMoveC();
        }
        public bool PointMoveJ()
        {
            return myRobotAdapter.PointMoveJ();
        }
        public bool LineMove()
        {
            return myRobotAdapter.LineMove();
        }
        public bool GetVelocity()
        {
            return myRobotAdapter.GetVelocity();
        }
        public bool SetVelocity()
        {
            return myRobotAdapter.SetVelocity();
        }
        public bool JogMoveC()
        {
            return myRobotAdapter.JogMoveC();
        }
        public bool JogMoveJ()
        {
            return myRobotAdapter.JogMoveJ();
        }
        public bool GetInformation1()
        {
            return myRobotAdapter.GetInformation1();
        }
        public bool GetInformation2()
        {
            return myRobotAdapter.GetInformation2();
        }
        public bool GetInformation3()
        {
            return myRobotAdapter.GetInformation3();
        }
        public bool LimitRangeChangeXYZ()
        {
            return myRobotAdapter.LimitRangeChangeXYZ();
        }
        public bool LimitRangeCheckXYZ()
        {
            return myRobotAdapter.LimitRangeCheckXYZ();
        }
        public bool LimitRangeCheckJoint()
        {
            return myRobotAdapter.LimitRangeCheckJoint();
        }
        public bool LimitRangeCheckVelocity()
        {
            return myRobotAdapter.LimitRangeCheckVelocity();
        }
        public bool LimitRangeCheckOverride()
        {
            return myRobotAdapter.LimitRangeCheckOverride();
        }
        public bool LimitRangeCheckTool()
        {
            return myRobotAdapter.LimitRangeCheckTool();
        }
        public bool LimitRangeCheckBase()
        {
            return myRobotAdapter.LimitRangeCheckBase();
        }
        public bool Compile()
        {
            return myRobotAdapter.Compile();
        }
    }
}
