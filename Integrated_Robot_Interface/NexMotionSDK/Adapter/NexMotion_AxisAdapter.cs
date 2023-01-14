using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public class NexMotion_AxisAdapter
    {
        private readonly int mDeviceId = 0;
        private readonly int mAxisIndex = 0;
        public NexMotion_AxisAdapter(int device_id, int axis_index)
        {
            mDeviceId = device_id;
            mAxisIndex = axis_index;
        }

        public Int32 NMC_AxisSetParamI32(Int32 ParamNum, Int32 SubIndex, Int32 ParaValueI32 )
        {
            return NexMotion_API.NMC_AxisSetParamI32(mDeviceId, mAxisIndex, ParamNum, SubIndex, ParaValueI32);
        }

        public Int32 NMC_AxisGetParamI32(Int32 ParamNum, Int32 SubIndex, ref Int32 PRetParaValueI32 )
        {
            return NexMotion_API.NMC_AxisGetParamI32(mDeviceId, mAxisIndex, ParamNum, SubIndex, ref PRetParaValueI32);
        }

        public Int32 NMC_AxisSetParamF64(Int32 ParamNum, Int32 SubIndex, Double ParaValueF64 )
        {
            return NexMotion_API.NMC_AxisSetParamF64(mDeviceId, mAxisIndex, ParamNum, SubIndex, ParaValueF64);
        }

        public Int32 NMC_AxisGetParamF64(Int32 ParamNum, Int32 SubIndex, ref Double PRetParaValueF64 )
        {
            return NexMotion_API.NMC_AxisGetParamF64(mDeviceId, mAxisIndex, ParamNum, SubIndex, ref PRetParaValueF64);
        }

        public Int32 NMC_AxisEnable( )
        {
            return NexMotion_API.NMC_AxisEnable(mDeviceId, mAxisIndex);
        }

        public Int32 NMC_AxisDisable()
        {
            return NexMotion_API.NMC_AxisDisable(mDeviceId, mAxisIndex);
        }

        public Int32 NMC_AxisGetStatus(ref Int32 PRetAxisStatus )
        {
            return NexMotion_API.NMC_AxisGetStatus(mDeviceId, mAxisIndex, ref PRetAxisStatus);
        }


        public Int32 NMC_AxisGetState(ref Int32 PRetAxisState )
        {
            return NexMotion_API.NMC_AxisGetState(mDeviceId, mAxisIndex, ref PRetAxisState);
        }

        public Int32 NMC_AxisResetState( )
        {
            return NexMotion_API.NMC_AxisResetState(mDeviceId, mAxisIndex);
        }

        public Int32 NMC_AxisGetActualPos(ref Double PRetActPos )
        {
            return NexMotion_API.NMC_AxisGetActualPos(mDeviceId, mAxisIndex, ref PRetActPos);
        }

        public Int32 NMC_AxisGetActualVel(ref Double PRetActVel )
        {
            return NexMotion_API.NMC_AxisGetActualVel(mDeviceId, mAxisIndex, ref PRetActVel);
        }

        public Int32 NMC_AxisSetVelRatio( Double Percentage )
        {
            return NexMotion_API.NMC_AxisSetVelRatio(mDeviceId, mAxisIndex, Percentage);
        }
        public Int32 NMC_AxisGetVelRatio( ref Double PPercentage )
        {
            return NexMotion_API.NMC_AxisGetVelRatio(mDeviceId, mAxisIndex, ref PPercentage);
        }

        public Int32 NMC_AxisPtp(Double TargetPos, ref Double PMaxVel )
        {
            return NexMotion_API.NMC_AxisPtp(mDeviceId, mAxisIndex, TargetPos, ref PMaxVel);
        }

        public Int32 NMC_AxisJog(Int32 Dir, ref Double PMaxVel )
        {
            return NexMotion_API.NMC_AxisJog(mDeviceId, mAxisIndex, Dir, ref PMaxVel);
        }

        public Int32 NMC_AxisHalt()
        {
            return NexMotion_API.NMC_AxisHalt(mDeviceId, mAxisIndex);
        }

        public Int32 NMC_AxisStop( )
        {
            return NexMotion_API.NMC_AxisStop(mDeviceId, mAxisIndex);
        }

        public Int32 NMC_AxisVelOverride(Double TargetVel )
        {
            return NexMotion_API.NMC_AxisVelOverride(mDeviceId, mAxisIndex, TargetVel);
        }

        public Int32 NMC_AxisSetHomePos( Double HomePos )
        {
            return NexMotion_API.NMC_AxisSetHomePos( mDeviceId, mAxisIndex, HomePos );
        }
    }
}
