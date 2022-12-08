using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Robot_Interface
{
    public class FanucAdapter : RobotAdapter
    {
        //變數宣告
        Fanuc myfanuc;
        public string IP { get; set; } = "";

        public FanucAdapter()
        {
            myfanuc = new Fanuc();
        }

        public override void Connect()
        {
            myfanuc.Connect(IP);
        }
        public override void Disconnect()
        {
            myfanuc.Disconnect();
        }
    }
}
