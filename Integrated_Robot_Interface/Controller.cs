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
        public string IP { get; set; } = "";
        public enum Robotnum
        {
            None, Fanuc, Nexcom, Ourarm
        }

        public bool Connect()
        {
            switch (robot)
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
            switch (robot)
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
        public void Refresh()
        {
            switch (robot)
            {
                case (int)Robotnum.Fanuc:
                    myfanuc.Refresh();
                    break;
                case (int)Robotnum.Nexcom:
                    break;
                case (int)Robotnum.Ourarm:
                    break;
                default:
                    break;
            }
        }
        public void Alarm() { }
    }
}
