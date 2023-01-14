using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXCOMROBOT.MCAT
{
    public class NexMotion_ErrCode
    {
        public const int NMCERR_SUCCESS = (0); // Success, no error.
       /* -----------------------------------------------------------------------------
       * NexMotion Library error.
       * -----------------------------------------------------------------------------*/
        public const int NMCERR_SYSTEM_CALL_ERROR = (-1); // System API (Win32 API) return error.
        public const int NMCERR_LIBRARY_NOT_INITIAL = (-2); // Library is not initial. miss NMC_InitialLibrary() 
        public const int NMCERR_DRIVER_NOT_FOUND = (-3);   // "DevID" is invalid. Device does not be created. Device delete already.
        public const int NMCERR_SLAVE_PROCESS_STILL_OPEN = (-4);
        public const int NMCERR_SLAVE_PROCESS_NO_PERMISSION = (-5);
        public const int NMCERR_LOAD_FILE = (-6);
        public const int NMCERR_LOAD_FILE_SECTION = (-7);
        public const int NMCERR_LOAD_FILE_READ_BLOCK = (-8);
        public const int NMCERR_API_PARAMETER_INVALID = (-9);
        public const int NMCERR_LOAD_LIB = (-10); // Load external library failed.
        public const int NMCERR_TIMEOUT = (-11); // API timeout.
        public const int NMCERR_LOAD_DEVICE_NETWORK_FAILED = (-12); // Load EtherCAT network file failed..
        public const int NMCERR_LIB_NOT_FOUND = (-13);  // External library not found.

        /* -----------------------------------------------------------------------------
        _* Realtime system error.
         * -----------------------------------------------------------------------------*/
        public const int NMCERR_RT_BASE = ( -     10000          );
        public const int NMCERR_RT_SYSTEM_CALL_ERROR = ( - 1 + NMCERR_RT_BASE );
        public const int NMCERR_RT_ACM_SERVER_COMMUNICATION_TIMEOUT = ( - 2 + NMCERR_RT_BASE );
        public const int NMCERR_RT_SYSTEM_CYCLE_TIME = ( - 3 + NMCERR_RT_BASE );
        public const int NMCERR_RT_TIMEPORBE_ID = ( - 4 + NMCERR_RT_BASE );
        public const int NMCERR_RT_STATE_DENY = ( - 5 + NMCERR_RT_BASE );

        /* -----------------------------------------------------------------------------
        _* Realtime system error.
        * -----------------------------------------------------------------------------*/
        public const int NMCERR_UI_BASE = (-1000000);
        public const int NMCERR_UI_SYSTEM_NO_DEVICE_FAILED = (-1 + NMCERR_UI_BASE);
    }
}
