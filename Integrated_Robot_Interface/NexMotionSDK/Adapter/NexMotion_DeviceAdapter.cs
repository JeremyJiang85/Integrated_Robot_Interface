using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public class NexMotion_DeviceAdapter
    {
        private int mDeviceId = 0;
        private int mDeviceIndex = 0;
        private int mDeviceType = 0;

        #region property
        public int DeviceId
        {
            get { return mDeviceId;}
        }
        #endregion

        public Int32 NMC_DeviceOpenUp( Int32 DevType, Int32 DevIndex)
        {
            mDeviceType = DevType;
            mDeviceIndex = DevIndex;

            return NexMotion_API.NMC_DeviceOpenUp(DevType, DevIndex, ref mDeviceId);
        }

        public Int32 NMC_DeviceResetStateAll()
        {
            return NexMotion_API.NMC_DeviceResetStateAll( mDeviceId );
        }

        public Int32 NMC_DeviceEnableAll()
        {
            return NexMotion_API.NMC_DeviceEnableAll( mDeviceId );
        }
        
        public Int32 NMC_DeviceShutdown()
        {
            return NexMotion_API.NMC_DeviceShutdown(mDeviceId);
        }

        public Int32 NMC_SetIniPath( string PIniPath )
        {
            return NexMotion_API.NMC_SetIniPath(PIniPath);
        }

        public Int32 NMC_DeviceStart( )
        {
            return NexMotion_API.NMC_DeviceStart(mDeviceId);
        }

        public Int32 NMC_DeviceStop( )
        {
            return NexMotion_API.NMC_DeviceStop(mDeviceId);
        }

        public Int32 NMC_DeviceGetState(ref Int32 PRetDeviceState )
        {
            return NexMotion_API.NMC_DeviceGetState(mDeviceId, ref PRetDeviceState);
        }

        public Int32 NMC_DeviceGetGroupCount( ref Int32 PRetGroupCount )
        {
            return NexMotion_API.NMC_DeviceGetGroupCount( mDeviceId, ref PRetGroupCount );
        }

        public Int32 NMC_DeviceGetAxisCount( ref Int32 PRetAxisCount )
        {
            return NexMotion_API.NMC_DeviceGetAxisCount( mDeviceId, ref PRetAxisCount );
        }

        public Int32 NMC_DeviceStopAll()
        {
            return NexMotion_API.NMC_DeviceStopAll( mDeviceId );
        }
    }
}
