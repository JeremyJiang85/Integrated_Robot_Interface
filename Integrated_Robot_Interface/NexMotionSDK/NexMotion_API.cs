using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NEXCOMROBOT.MCAT
{
    public class NexMotion_API
    {
        
        // public static extern Int32 NMC_SetIniPath( _opt_null_ const char *PIniPath ); 
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_SetIniPath", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_SetIniPath( string PIniPath );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GetErrorDescription", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NMC_GetErrorDescription(Int32 ErrorCode, StringBuilder PRetErrorDesc, UInt32 StringSize);


        #region Device

        // public static extern Int32 NMC_DeviceShutdown( Int32 DevID );
        [DllImport( MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceResetStateAll", CallingConvention = CallingConvention.StdCall )]
        public static extern Int32 NMC_DeviceResetStateAll( Int32 DevID );


        // public static extern Int32 NMC_DeviceOpenUp( Int32 DevType, Int32 DevIndex, Int32 *PRetDevID );
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceOpenUp", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceOpenUp( Int32 DevType, Int32 DevIndex, ref Int32 PRetDevID );

        // public static extern Int32 NMC_DeviceShutdown( Int32 DevID );
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceShutdown", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceShutdown( Int32 DevID );

        // public static extern Int32 NMC_DeviceStart( Int32 DevID );
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceStart", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceStart( Int32 DevID );

        // public static extern Int32 NMC_DeviceStop( Int32 DevID );
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceStop", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceStop( Int32 DevID );

        // public static extern Int32 NMC_DeviceGetState( Int32 DevID, Int32 *PRetDeviceState );
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceGetState", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceGetState( Int32 DevID,  ref Int32 PRetDeviceState );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceHaltAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceHaltAll( Int32 DevID );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceStopAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceStopAll( Int32 DevID );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceEnableAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceEnableAll( Int32 DevID );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceDisableAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceDisableAll( Int32 DevID );

        [DllImport( MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceGetGroupCount", CallingConvention = CallingConvention.StdCall )]
        public static extern Int32 NMC_DeviceGetGroupCount( Int32 DevID , ref Int32 PRetGroupCount );

        [DllImport( MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceGetGroupAxisCount", CallingConvention = CallingConvention.StdCall )]
        public static extern Int32 NMC_DeviceGetGroupAxisCount( Int32 DevID, Int32 GroupIdx , ref Int32 PRetGroupCount );

        #endregion

        #region motion parameter format
        //UInt32 FNTYPE NMC_GetParamCount(PaCat_T Cat);
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GetParamCount", CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 NMC_GetParamCount(PaCat_T Cat);


        // public static extern Int32 NMC_EnumParam(PaCat_T Cat, UInt32 ParamCountIndex, Int32* PRetParamNum, char* PPRetParamName, UInt32 NameSize, UInt32* PRetMaxSubIndex);
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_EnumParam", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_EnumParam(PaCat_T Cat, UInt32 ParamCountIndex,ref Int32 PRetParamNum, StringBuilder PPRetParamName,UInt32 NameSize, ref UInt32 PRetMaxSubIndex );


        // public static extern Int32 NMC_EnumSubParam(PaCat_T Cat, UInt32 ParamCountIndex, UInt32 SubIndex, char* PRetSubParamName, UInt32 NameSize, UInt32* PRetDataType, UInt32* PRetFlag);
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_EnumSubParam", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_EnumSubParam(PaCat_T Cat, UInt32 ParamCountIndex, UInt32 SubIndex, StringBuilder PRetSubParamName, UInt32 NameSize, ref NexMotionDataValueType PRetDataType, ref UInt32 PRetFlag);

        // public static extern Int32 NMC_GetRange(PaCat_T Cat, Int32 ParaNum, Int32 SubIndex, Int32 DataTypeOfRet, void* PRetDefaultValue, void* PRetMinValue, void* PRetMaxValue);
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GetRange", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GetRange(PaCat_T Cat, Int32 ParaNum, Int32 SubIndex, NexMotionDataValueType DataTypeOfRet, ref NexMotionDataValue PRetDefaultValue, ref NexMotionDataValue PRetMinValue, ref NexMotionDataValue PRetMaxValue);

        #endregion

        #region Axis

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_DeviceGetAxisCount", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_DeviceGetAxisCount( Int32 DevID, ref Int32 PRetAxisCount );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisSetParamI32", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisSetParamI32( Int32 DevID, Int32 AxisIndex, Int32 ParamNum, Int32 SubIndex, Int32 ParaValueI32 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetParamI32", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetParamI32( Int32 DevID, Int32 AxisIndex, Int32 ParamNum, Int32 SubIndex, ref Int32 PRetParaValueI32 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisSetParamF64", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisSetParamF64( Int32 DevID, Int32 AxisIndex, Int32 ParamNum, Int32 SubIndex, Double ParaValueF64 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetParamF64", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetParamF64( Int32 DevID, Int32 AxisIndex, Int32 ParamNum, Int32 SubIndex, ref Double PRetParaValueF64 );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisEnable( Int32 DevID, Int32 AxisIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisDisable", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisDisable( Int32 DevID, Int32 AxisIndex );




        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetStatus", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetStatus( Int32 DevID, Int32 AxisIndex, ref Int32 PRetAxisStatus );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetState", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetState( Int32 DevID, Int32 AxisIndex, ref Int32 PRetAxisState );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisResetState", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisResetState( Int32 DevID, Int32 AxisIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisResetDriveAlm", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisResetDriveAlm( Int32 DevID, Int32 AxisIndex ); 


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetCommandPos", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetCommandPos( Int32 DevID, Int32 AxisIndex, ref Double PRetCmdPos );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetActualPos", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetActualPos( Int32 DevID, Int32 AxisIndex, ref Double PRetActPos );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetCommandVel", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetCommandVel( Int32 DevID, Int32 AxisIndex, ref Double PRetCmdVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetActualVel", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetActualVel( Int32 DevID, Int32 AxisIndex, ref Double PRetActVel );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisSetVelRatio", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisSetVelRatio( Int32 DevID, Int32 AxisIndex, Double Percentage );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetVelRatio", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetVelRatio( Int32 DevID, Int32 AxisIndex, ref Double PPercentage );

        [DllImport( MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisSetHomePos", CallingConvention = CallingConvention.StdCall )]
        public static extern Int32 NMC_AxisSetHomePos( Int32 DevID, Int32 AxisIndex, Double HomePos );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisHomeDrive", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisHomeDrive( Int32 DevID, Int32 AxisIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisPtp", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisPtp( Int32 DevID, Int32 AxisIndex, Double TargetPos, ref Double PMaxVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisJog", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisJog( Int32 DevID, Int32 AxisIndex, Int32 Dir, ref Double PMaxVel );



        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisHalt", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisHalt( Int32 DevID, Int32 AxisIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisStop", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisStop( Int32 DevID, Int32 AxisIndex );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisHaltAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisHaltAll(Int32 DevID);


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisStopAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisStopAll(Int32 DevID);


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisVelOverride", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisVelOverride( Int32 DevID, Int32 AxisIndex, Double TargetVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisAccOverride", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisAccOverride( Int32 DevID, Int32 AxisIndex, Double TargetAcc );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisDecOverride", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisDecOverride( Int32 DevID, Int32 AxisIndex, Double TargetDec );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_AxisGetMotionBuffSpace", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_AxisGetMotionBuffSpace(  Int32 DevID, Int32 AxisIndex, ref Int32 PRetFreeSpace );
        #endregion

        #region Group

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupSetParamI32", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupSetParamI32( Int32 DevID, Int32 GroupIndex, Int32 ParamNum, Int32 SubIndex, Int32 ParaValueI32 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetParamI32", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetParamI32( Int32 DevID, Int32 GroupIndex, Int32 ParamNum, Int32 SubIndex, ref Int32 PRetParaValueI32 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupSetParamF64", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupSetParamF64( Int32 DevID, Int32 GroupIndex, Int32 ParamNum, Int32 SubIndex, Double ParaValueF64 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetParamF64", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetParamF64( Int32 DevID, Int32 GroupIndex, Int32 ParamNum, Int32 SubIndex, ref Double PRetParaValueF64 );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupAxSetParamI32", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupAxSetParamI32( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, Int32 ParaValueI32 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupAxGetParamI32", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupAxGetParamI32( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, ref Int32 PRetParaValueI32 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupAxSetParamF64", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupAxSetParamF64( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, Double ParaValueF64 );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupAxGetParamF64", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupAxGetParamF64( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex, Int32 ParamNum, Int32 SubIndex, ref Double PRetParaValueF64 );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupEnable( Int32 DevID, Int32 GroupIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupDisable", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupDisable( Int32 DevID, Int32 GroupIndex );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetStatus", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetStatus( Int32 DevID, Int32 GroupIndex, ref Int32 PRetStatusInBit );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetState", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetState( Int32 DevID, Int32 GroupIndex, ref Int32 PRetState );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupResetState", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupResetState( Int32 DevID, Int32 GroupIndex );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupResetDriveAlm", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupResetDriveAlm( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupResetDriveAlmAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupResetDriveAlmAll( Int32 DevID, Int32 GroupIndex );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupSetVelRatio", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupSetVelRatio( Int32 DevID, Int32 GroupIndex, Double Percentage ); 

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetVelRatio", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetVelRatio( Int32 DevID, Int32 GroupIndex, ref Double PRetPercentage );



        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupPtpAcs", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupPtpAcs( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex, Double AcsPos, ref Double PAcsMaxVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupPtpAcsAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupPtpAcsAll( Int32 DevID, Int32 GroupIndex, Int32 GroupAxesIdxMask, ref Pos_T PAcsPos ); 


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupPtpCart", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupPtpCart( Int32 DevID, Int32 GroupIndex, Int32 CartAxis, Double CartPos );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupPtpCartAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupPtpCartAll( Int32 DevID, Int32 GroupIndex, Int32 CartAxesMask, ref Pos_T PTargetPos ); 


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupJogAcs", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupJogAcs( Int32 DevID, Int32 GroupIndex, Int32 GroupAxisIndex, Int32 Dir, ref Double PAcsMaxVel  ); 


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupHalt", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupHalt( Int32 DevID, Int32 GroupIndex );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupStop", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupStop( Int32 DevID, Int32 GroupIndex );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupHaltAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupHaltAll(Int32 DevID);


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupStopAll", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupStopAll(Int32 DevID);


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetMotionBuffSpace", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetMotionBuffSpace( Int32 DevID, Int32 GroupIndex, ref Int32 PRetFreeSpace );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetCommandPosAcs", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetCommandPosAcs( Int32 DevID, Int32 GroupIndex, ref Pos_T PRetCmdPosAcs );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetActualPosAcs", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetActualPosAcs( Int32 DevID, Int32 GroupIndex, ref Pos_T PRetActPosAcs );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetCommandPosPcs", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetCommandPosPcs( Int32 DevID, Int32 GroupIndex, ref Pos_T PRetCmdPosPCS );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetActualPosPcs", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetActualPosPcs( Int32 DevID, Int32 GroupIndex, ref Pos_T PRetActPosPCS );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetCommandPos", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetCommandPos( Int32 DevID, Int32 GroupIndex, Int32 CoordSys, ref Pos_T PRetCmdPos );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupGetActualPos", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupGetActualPos( Int32 DevID, Int32 GroupIndex, Int32 CoordSys, ref Pos_T PRetActPos );

        [DllImport( MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupSetHomePos", CallingConvention = CallingConvention.StdCall )]
        public static extern Int32 NMC_GroupSetHomePos( Int32 DevID, Int32 GroupIndex, Int32 GroupAxesIdxMask, ref Pos_T PHomePosAcs );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupAxesHomeDrive", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupAxesHomeDrive(Int32 DevID, Int32 GroupIndex, Int32 GroupAxesIdxMask);

        // 2D cartesian space (MCS,PCS) interpolation
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupLineXY", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupLineXY( Int32 DevID, Int32 GroupIndex, ref Double PX, ref Double PY, ref Double PMaxVel );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupCirc2R", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupCirc2R( Int32 DevID, Int32 GroupIndex, ref Double PEX, ref Double PEY, Double Radius, Int32 CW_CCW, ref Double PMaxVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupCirc2C", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupCirc2C( Int32 DevID, Int32 GroupIndex, ref Double PEX, ref Double PEY, ref Double PCXOffset, ref Double PCYOffset, Int32 CW_CCW, ref Double PMaxVel );


        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupCirc2B", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupCirc2B( Int32 DevID, Int32 GroupIndex, ref Double PEX, ref Double PEY, ref Double PBX, ref Double PBY, ref Double PMaxVel );


        // High cartesian space (MCS,PCS) interpolation
        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupLine", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupLine(  Int32 DevID, Int32 GroupIndex, Int32 CartAxisMask, ref Pos_T PCartPos, ref Double PMaxVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupCircR", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupCircR( Int32 DevID, Int32 GroupIndex, Int32 CartAxisMask, ref Pos_T PCartPos, ref Xyz_T PNormalVector, Double Radius, Int32 CW_CCW, ref Double PMaxVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupCircC", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupCircC( Int32 DevID, Int32 GroupIndex, Int32 CartAxisMask, ref Pos_T PCartPos, Int32 CenOfsMask, ref Xyz_T PCenOfs, Int32 CW_CCW, ref Double PMaxVel );

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GroupCircB", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GroupCircB( Int32 DevID, Int32 GroupIndex, Int32 CartAxisMask, ref Pos_T PCartPos, Int32 BorPosMask, ref Xyz_T PBorPoint, ref Double PMaxVel );

        #endregion

        #region IO

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GetInputMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GetInputMemorySize ( Int32 DevID, ref UInt32 PRetSizeByte ); 

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_GetOutputMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_GetOutputMemorySize( Int32 DevID, ref UInt32 PRetSizeByte ); 

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_ReadInputMemory", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_ReadInputMemory( Int32 DevID, UInt32 OffsetByte, UInt32 SizeByte,  ref NexMotionDataValue PRetValues ); 

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_ReadOutputMemory", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_ReadOutputMemory( Int32 DevID, UInt32 OffsetByte, UInt32 SizeByte, ref NexMotionDataValue PRetValues ); 

        [DllImport(MCATConfig.NEXMOTION_PATH, EntryPoint = "NMC_WriteOutputMemory", CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NMC_WriteOutputMemory( Int32 DevID, UInt32 OffsetByte, UInt32 SizeByte, ref NexMotionDataValue PValues );

        #endregion
    }
}
