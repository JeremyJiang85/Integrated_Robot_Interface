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
        private int _robot = -1;
        public int Robot
        {
            get
            {
                return _robot;
            }
            set
            {

                if (value >= (int)Robotnum.Fanuc && value <= (int)Robotnum.Ourarm)
                {
                    _robot = value;
                }
                else
                {
                    MessageBox.Show("Controller setting out of range");
                }
            }
        }
        public string IP { get; set; }
        public enum Robotnum
        {
            Null = -1,
            Fanuc = 0,
            Nexcom = 1,
            Ourarm = 2
        }

        public void Connect()
        {
            switch (_robot)
            {
                case (int)Robotnum.Fanuc :
                    myfanuc = new Fanuc();

                    if (myfanuc.Connect(IP))
                    {
                        MessageBox.Show("Fanuc Robot is successfully connected");
                    }
                    else
                    {
                        MessageBox.Show("Fanuc Robot connect is failed");
                    }
                    break;

            }
        }
        public void Disconnect() { }
        public void Refresh() { }
        public void Alarm() { }
    }
}
