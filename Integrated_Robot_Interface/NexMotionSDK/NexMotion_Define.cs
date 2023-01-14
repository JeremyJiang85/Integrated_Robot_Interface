using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public static class NexMotion_Define
    {
        //
        // Device type
        //
        public const int DEV_TYPE_SIMULATION = (0);
        public const int DEV_TYPE_ETHERCAT   = (1);

        //
        // Device state
        //
        public const int DEV_STATE_INIT      = (1);
        public const int DEV_STATE_READY     = (2);
        public const int DEV_STATE_ERROR     = (3);
        public const int DEV_STATE_OPERATION = (4);

        //
        // Group state
        //
        public const int  GROUP_STATE_DISABLE       =   (0);
        public const int  GROUP_STATE_STAND_STILL   =   (1);
        public const int  GROUP_STATE_STOPPED       =   (2);
        public const int  GROUP_STATE_STOPPING      =   (3);
        public const int  GROUP_STATE_MOVING        =   (4);
        public const int  GROUP_STATE_HOMING        =   (5);
        public const int  GROUP_STATE_ERROR         =   (6);

        //
        // Axis state
        //
        public const int  AXIS_STATE_DISABLE            =   (0);
        public const int  AXIS_STATE_STAND_STILL        =   (1);
        public const int  AXIS_STATE_HOMING             =   (2);
        public const int  AXIS_STATE_DISCRETE_MOTION    =   (3);
        public const int  AXIS_STATE_CONTINUOUS_MOTION  =   (4);
        public const int  AXIS_STATE_STOPPING           =   (5);
        public const int  AXIS_STATE_STOPPED            =   (6);
        public const int  AXIS_STATE_WAIT_SYNC          =   (7);
        public const int  AXIS_STATE_GROUP_MOTION       =   (8);
        public const int  AXIS_STATE_ERROR              =   (10);

        //
        // NexMotion parameter flag
        //
        public const uint PA_ACCESS_RW = (0);         // Can be access at all state. 
        public const uint PA_ACCESS_STATE_0_RO  = (1 <<  1); // State 0 ,bit 0 (Initialed) 當 bit 0 ON, state 0 read only 
        public const uint PA_ACCESS_STATE_1_RO  = (1 <<  2); // State 1 ,bit 1 (Configed)  當 bit 1 ON, state 1 read only 
        public const uint PA_ACCESS_STATE_2_RO  = (1 <<  3); // State 2 ,bit 2 (Operation) 當 bit 2 ON, state 2 read only 
        public const uint PA_ACCESS_STATE_3_RO  = (1 <<  4); // State 3 ,bit 3 (Not defined) 當 bit 3 ON, state 3 read only
                                                             // Bit 8: 用來標示啟動前是否必須被設定過
        public const uint PA_CONFIG_MUST        = (1 <<  8); // 標示本參數為必須被設定的參數
        public const uint PA_UI_LOCKED          = (1 << 10); // 標示UI是否鎖定不讓使用者修改之參數


        public const uint PA_OPERATION_RO = (PA_ACCESS_STATE_2_RO | PA_ACCESS_STATE_3_RO);  // State = 2, 3


        //NexMotion Type
        public const int MAX_POS_SIZE          = (6);
        public const int MAX_XYZ_SIZE          = (3);
        public const int MAX_COORD_TRANS_PARAM = (6);

    }
}
