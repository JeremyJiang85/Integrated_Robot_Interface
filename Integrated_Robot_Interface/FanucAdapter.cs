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
        public override bool Refresh()
        {
            return myfanuc.Refresh();
        }
        public override bool Alarm()
        {
            bool ret = false;
            string txt = "";
            ret = myfanuc.Alarm(ref txt);
            AlarmText = txt;
            return ret;
        }
    }
}
