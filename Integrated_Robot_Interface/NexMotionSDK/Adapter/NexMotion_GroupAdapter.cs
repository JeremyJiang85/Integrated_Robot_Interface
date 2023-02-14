using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public class NexMotion_GroupAdapter
    {        
        private readonly int mDeviceId = 0;
        private readonly int mGroupIndex = 0;

        public NexMotion_GroupAdapter(int device_id, int group_index)
        {
            mDeviceId   = device_id;
            mGroupIndex = group_index;
        }

        public Int32 NMC_GroupGetKintype(ref Int32 Kintype)
        {
            return NMC_GroupGetParamI32( 0, 0, ref Kintype);
        }

        public Int32 NMC_GroupAxSetParamF64(Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, Double ParaValueF64)
        {
            return NexMotion_API.NMC_GroupAxSetParamF64(mDeviceId, mGroupIndex, GroupAxisIndex, ParamNum, SubIndex, ParaValueF64);
        }
        
        public Int32 NMC_GroupAxGetParamF64(Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, ref Double PRetParaValueF64)
        {
            return NexMotion_API.NMC_GroupAxGetParamF64(mDeviceId, mGroupIndex, GroupAxisIndex, ParamNum, SubIndex, ref PRetParaValueF64);
        }

        public Int32 NMC_GroupAxSetParamI32(Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, Int32 ParaValueI32)
        {
            return NexMotion_API.NMC_GroupAxSetParamI32(mDeviceId, mGroupIndex, GroupAxisIndex, ParamNum, SubIndex, ParaValueI32);
        }

        public Int32 NMC_GroupAxSetParamI32(Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, ref Int32 PRetParaValueI32)
        {
            return NexMotion_API.NMC_GroupAxGetParamI32(mDeviceId, mGroupIndex, GroupAxisIndex, ParamNum, SubIndex, ref PRetParaValueI32);
        }

        public Int32 NMC_GroupSetParamI32(Int32 ParamNum, Int32 SubIndex, Int32 ParaValueI32)
        {
            return NexMotion_API.NMC_GroupSetParamI32(mDeviceId, mGroupIndex, ParamNum, SubIndex, ParaValueI32);
        }

        public Int32 NMC_GroupGetParamI32(Int32 ParamNum, Int32 SubIndex, ref Int32 PRetParaValueI32)
        {
            return NexMotion_API.NMC_GroupGetParamI32(mDeviceId, mGroupIndex, ParamNum, SubIndex, ref PRetParaValueI32);
        }

        public Int32 NMC_GroupSetParamF64(Int32 ParamNum, Int32 SubIndex, Double ParaValueI32)
        {
            return NexMotion_API.NMC_GroupSetParamF64(mDeviceId, mGroupIndex, ParamNum, SubIndex, ParaValueI32);
        }

        public Int32 NMC_GroupGetParamF64(Int32 ParamNum, Int32 SubIndex, ref Double PRetParaValueI32)
        {
            return NexMotion_API.NMC_GroupGetParamF64(mDeviceId, mGroupIndex, ParamNum, SubIndex, ref PRetParaValueI32);
        }

        public Int32 NMC_GroupGetState( ref Int32 PRetState )
        {
            return NexMotion_API.NMC_GroupGetState( mDeviceId, mGroupIndex, ref PRetState );
        }

        public Int32 NMC_GroupGetStatus( ref Int32 PRetStatusInBit )
        {
            return NexMotion_API.NMC_GroupGetStatus( mDeviceId, mGroupIndex, ref PRetStatusInBit );
        }

        public Int32 NMC_GroupSetHomePos(Int32 GroupAxesIdxMask, ref Pos_T PHomePosAcs )
        {
            return NexMotion_API.NMC_GroupSetHomePos( mDeviceId , mGroupIndex, GroupAxesIdxMask, ref PHomePosAcs );
        }

        public Int32 NMC_GroupAxesHomeDrive(Int32 GroupAxesIdxMask)
        {
            return NexMotion_API.NMC_GroupAxesHomeDrive(mDeviceId, mGroupIndex, GroupAxesIdxMask);
        }

        public Int32 NMC_GroupGetActualPosAcs( ref Pos_T PRetActPosAcs )
        {
            return NexMotion_API.NMC_GroupGetActualPosAcs( mDeviceId, mGroupIndex, ref PRetActPosAcs );
        }

        public Int32 NMC_GroupGetActualPosPcs( ref Pos_T PRetActPosPCS )
        {
            return NexMotion_API.NMC_GroupGetActualPosPcs( mDeviceId, mGroupIndex, ref PRetActPosPCS );
        }

        public Int32 NMC_DeviceGetGroupAxisCount( ref Int32 PRetGroupCount )
        {
            return NexMotion_API.NMC_DeviceGetGroupAxisCount( mDeviceId, mGroupIndex , ref PRetGroupCount );
        }

        public Int32 NMC_GroupEnable()
        {
            return NexMotion_API.NMC_GroupEnable(mDeviceId, mGroupIndex);
        }

        public Int32 NMC_GroupDisable()
        {
            return NexMotion_API.NMC_GroupDisable(mDeviceId, mGroupIndex);
        }

        public Int32 NMC_GroupResetState()
        {
            return NexMotion_API.NMC_GroupResetState(mDeviceId, mGroupIndex);
        }

        public Int32 NMC_GroupHalt()
        {
            return NexMotion_API.NMC_GroupHalt(mDeviceId, mGroupIndex);
        }

        public Int32 NMC_GroupStop( )
        {
            return NexMotion_API.NMC_GroupStop(mDeviceId, mGroupIndex);
        }
        
        public Int32 NMC_GroupJogAcs(Int32 GroupAxisIndex, Int32 Dir, ref Double PAcsMaxVel  )
        {
            return NexMotion_API.NMC_GroupJogAcs(mDeviceId, mGroupIndex, GroupAxisIndex, Dir, ref PAcsMaxVel );
        }

        public Int32 NMC_GroupJogCartFrame(Int32 CartAxis, Int32 Dir, ref Double PMaxVel)
        {
            return NexMotion_API.NMC_GroupJogTcpFrame(mDeviceId, mGroupIndex, CartAxis, Dir, ref PMaxVel);
        }

        public Int32 NMC_GroupSetVelRatio( Double Percentage )
        {
            return NexMotion_API.NMC_GroupSetVelRatio(mDeviceId, mGroupIndex, Percentage);
        }
        
        public Int32 NMC_GroupGetVelRatio( ref Double PRetPercentage )
        {
            return NexMotion_API.NMC_GroupGetVelRatio(mDeviceId, mGroupIndex, ref PRetPercentage);
        }

        public Int32 NMC_GroupPtpAcs( Int32 GroupAxisIndex, Double AcsPos, ref Double PAcsMaxVel )
        {
            return NexMotion_API.NMC_GroupPtpAcs(mDeviceId, mGroupIndex, GroupAxisIndex, AcsPos, ref PAcsMaxVel);
        }

        public Int32 NMC_GroupPtpAcsAll( Int32 GroupAxesIdxMask, ref Pos_T PAcsPos )
        {
            return NexMotion_API.NMC_GroupPtpAcsAll(mDeviceId, mGroupIndex, GroupAxesIdxMask, ref PAcsPos);
        }       

        public Int32 NMC_GroupPtpCart( Int32 CartAxis, Double CartPos )
        {
            return NexMotion_API.NMC_GroupPtpCart(mDeviceId, mGroupIndex, CartAxis, CartPos);
        }        

        public Int32 NMC_GroupPtpCartAll( Int32 CartAxesMask, ref Pos_T PTargetPos )
        {
            return NexMotion_API.NMC_GroupPtpCartAll(mDeviceId, mGroupIndex, CartAxesMask, ref PTargetPos);
        }

        public Int32 NMC_GroupLine( Int32 CartAxisMask, ref Pos_T PCartPos, ref Double PMaxVel )
        {
            return NexMotion_API.NMC_GroupLine(mDeviceId, mGroupIndex, CartAxisMask, ref PCartPos, ref PMaxVel);
        }

        public Int32 NMC_GroupCircR( Int32 CartAxisMask, ref Pos_T PCartPos, ref Xyz_T PNormalVector, Double Radius, Int32 CW_CCW, ref Double PMaxVel )
        {
            return NexMotion_API.NMC_GroupCircR(mDeviceId, mGroupIndex, CartAxisMask, ref PCartPos, ref PNormalVector, Radius, CW_CCW, ref PMaxVel);
        }
        
        public Int32 NMC_GroupCircC( Int32 CartAxisMask, ref Pos_T PCartPos, Int32 CenOfsMask, ref Xyz_T PCenOfs, Int32 CW_CCW, ref Double PMaxVel )
        {
            return NexMotion_API.NMC_GroupCircC(mDeviceId, mGroupIndex, CartAxisMask, ref PCartPos, CenOfsMask, ref PCenOfs, CW_CCW, ref PMaxVel);
        }
        
        public Int32 NMC_GroupCircB( Int32 CartAxisMask, ref Pos_T PCartPos, Int32 BorPosMask, ref Xyz_T PBorPoint, ref Double PMaxVel )
        {
            return NexMotion_API.NMC_GroupCircB(mDeviceId, mGroupIndex, CartAxisMask, ref PCartPos, BorPosMask, ref PBorPoint, ref PMaxVel);
        }
    }

}
