using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public class NexMotion_IOAdapter
    {
        private readonly int mDeviceId = 0;

        public NexMotion_IOAdapter( int device_id )
        {
            mDeviceId = device_id;
        }

        public Int32 NMC_GetInputMemorySize( ref UInt32 PRetSizeByte)
        {
            return NexMotion_API.NMC_GetInputMemorySize(mDeviceId, ref PRetSizeByte);
        }

        public Int32 NMC_GetOutputMemorySize(ref UInt32 PRetSizeByte)
        {
            return NexMotion_API.NMC_GetOutputMemorySize(mDeviceId, ref PRetSizeByte);
        }

        public Int32 NMC_ReadInputMemory(UInt32 OffsetByte, UInt32 SizeByte, ref NexMotionDataValue PRetValues)
        {
            return NexMotion_API.NMC_ReadInputMemory(mDeviceId, OffsetByte, SizeByte, ref PRetValues);
        }

        public Int32 NMC_ReadOutputMemory(UInt32 OffsetByte, UInt32 SizeByte, ref NexMotionDataValue PRetValues)
        {
            return NexMotion_API.NMC_ReadOutputMemory(mDeviceId, OffsetByte, SizeByte, ref PRetValues);
        }

        public Int32 NMC_WriteOutput(UInt32 OffsetByte, UInt32 SizeByte, ref NexMotionDataValue PRetValues)
        {
            return NexMotion_API.NMC_WriteOutputMemory(mDeviceId, OffsetByte, SizeByte, ref PRetValues);
        }
    }
}
