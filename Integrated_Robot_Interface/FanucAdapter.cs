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
        public override bool Override()
        {
            bool ret = false;
            string txt = "";
            ret = myfanuc.Override(ref txt);
            OverrideText = txt;
            return ret;
        }
        public override bool GetCPosition()
        {
            bool ret = false;
            Array Xyzwpr = new float[6];
            ret = myfanuc.GetCPosition(ref Xyzwpr);
            GetCposition = Xyzwpr;
            return ret;
        }
        public override bool GetJPosition()
        {
            bool ret = false;
            Array Joint = new float[6];
            ret = myfanuc.GetJPosition(ref Joint);
            GetJposition = Joint;
            return ret;
        }
        public override bool SetCPosition()
        {
            Array Xyzwpr = new float[6];
            Xyzwpr = SetCposition;
            return myfanuc.SetCPosition(Xyzwpr);
        }
        public override bool SetJPosition()
        {
            Array Joint = new float[6];
            Joint = SetJposition;
            return myfanuc.SetJPosition(Joint);
        }
        public override bool Home()
        {
            Array Home = new float[6];
            Home = Homeposition;
            return myfanuc.Home(Home);
        }
        public override bool GetVelocity()
        {
            bool ret = false;
            int Index = 7;
            object Value = null;

            ret = myfanuc.GetRegister(ref Value, Index);
            Getvelocity = (float)Value;
            return ret;
        }
        public override bool SetVelocity()
        {
            int Index = 7;
            object Value = Setvelocity;

            return myfanuc.SetRegister(Value, Index);
        }
        public override bool GetRegister()
        {
            bool ret = false;
            int Index = Convert.ToInt32(Getregister.GetValue(1));
            object Value = null;

            ret = myfanuc.GetRegister(ref Value, Index);
            Getregister.SetValue(Value, 0);
            return ret;
        }
        public override bool SetRegister()
        {
            int Index = Convert.ToInt32(Setregister.GetValue(1));
            object Value = Convert.ToSingle(Setregister.GetValue(0));

            return myfanuc.SetRegister(Value, Index);
        }
        public override bool Inc()
        {
            int Index = Convert.ToInt32(Axismove.GetValue(1));
            int Value = Convert.ToInt32(Axismove.GetValue(0));
            
            return myfanuc.Inc(Value, Index);
        }
    }
}
