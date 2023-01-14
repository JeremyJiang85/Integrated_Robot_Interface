using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEXCOMROBOT.MCAT;

namespace Integrated_Robot_Interface
{
    public class Nexcom
    {
        private NexMotion_DeviceAdapter mobjDeviceAdapter;
        private NexMotion_GroupAdapter mobjGroupAdapter;
        
        public Nexcom()
        {
            mobjDeviceAdapter = new NexMotion_DeviceAdapter();
        }
        
        public int NMC_SetIniPath(string path)
        {
            return mobjDeviceAdapter.NMC_SetIniPath(path);
        }
        public int NMC_DeviceOpenUp(int devicetype, int deviceindex, ref int deviceid)
        {
            int ret =  mobjDeviceAdapter.NMC_DeviceOpenUp(devicetype, deviceindex, ref deviceid);
            mobjGroupAdapter = new NexMotion_GroupAdapter(deviceid, 0);
            return ret;
        }
        public int NMC_DeviceResetStateAll()
        {
            return mobjDeviceAdapter.NMC_DeviceResetStateAll();
        }

    }

    
}
