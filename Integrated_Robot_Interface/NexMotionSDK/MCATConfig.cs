using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NEXCOMROBOT.MCAT
{
    public static class MCATConfig
    {
#if PLATFORM_X86 || PLATFORM_X86_DEBUG || PLATFORM_X86_RELEASE
        public const string NEXMOTION_PATH = "NexMotion.dll";
#else
        public const string NEXMOTION_PATH = "NexMotion.dll";
#endif    
    }
}
