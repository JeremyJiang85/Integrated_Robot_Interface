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
        Fanuc myfanuc;
        
        public int Robot
        {
            get
            {
                return _robot;
            }
            set
            {

                if (value >= (int)Robotnum.None && value <= (int)Robotnum.Ourarm)
                {
                    _robot = value;
                }
                else
                {
                    MessageBox.Show("手臂選擇超出範圍");
                }
            }
        }
        private int _robot = (int)Robotnum.None;

        public string IP = "";
        public enum Robotnum
        {
            None, Fanuc, Nexcom, Ourarm
        }

        public bool Connect()
        {
            switch (_robot)
            {
                case (int)Robotnum.Fanuc:
                    myfanuc = new Fanuc();
                    return myfanuc.Connect(IP);
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
            switch (_robot)
            {
                case (int)Robotnum.Fanuc:
                    return myfanuc.Disconnect();
                case (int)Robotnum.Nexcom:
                    return false;
                case (int)Robotnum.Ourarm:
                    return false;
                default:
                    return false;
            }
        }
        public void Refresh() { }
        public void Alarm() { }
    }
}
