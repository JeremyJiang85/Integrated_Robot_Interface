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
        public static string IP { get; set; } = "";

        public FanucAdapter()
        {
            myfanuc = new Fanuc();
        }

        public override bool Connect()
        {
            return myfanuc.Connect(IP);
        }
        public override bool Disconnect()
        {
            return myfanuc.Disconnect();
        }
    }
}
