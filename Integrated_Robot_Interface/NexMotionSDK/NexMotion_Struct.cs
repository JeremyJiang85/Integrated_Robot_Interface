using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NEXCOMROBOT.MCAT
{

    public  enum PaCat_T : Int32
    {
        PACAT_AXIS = 0
      , PACAT_GROUP
      , PACAT_GROUP_AXIS
      , PACAT_SYSTEM
      , PACAT_HAL_WIN32
      ///////////////////////////    
      , MAX_PACAT
    }

    public enum NexMotionDataValueType : Int32
    {
        DATA_TYPE_I32 = 0,
        DATA_TYPE_F64 = 1,
        DATA_TYPE_U32 =2,
        DATA_TYPE_I16 = 3,
        DATA_TYPE_U16 = 4,
        DATA_TYPE_I8  = 5,
        DATA_TYPE_U8  = 6,
        MAX_DATA_TYPE = 7,
    }


    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct NexMotionDataValue
    {
        [FieldOffset(0)]
        public Int32 i32;

        [FieldOffset(0)]
        public ulong u64;

        [FieldOffset(0)]
        public Double f64;

        [FieldOffset(0)]
        public UInt32 u32;

        [FieldOffset(0)]
        public Int16 i16;

        [FieldOffset(0)]
        public UInt16 u16;

        [FieldOffset(0)]
        public sbyte  i8;

        [FieldOffset(0)]
        public byte u8;


    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Pos_T
    {
        public void initializ()
        {
            //explicitly initialize the array
            pos = new Double[NexMotion_Define.MAX_POS_SIZE];

            for(int idx = 0; idx <NexMotion_Define.MAX_POS_SIZE ; idx++ )
            {
                pos[idx] = 0.0;
            }
        }

        // For Cartesian space(MCS,PCS) : X, Y, Z, A, B, C, U, V
        // For Axis space(ACS): Axis 0 ~ 7
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NexMotion_Define.MAX_POS_SIZE)]
       public Double [] pos; 
    }


    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Xyz_T
    {
        public void initializ()
        {
            //explicitly initialize the array
            pos = new Double[NexMotion_Define.MAX_XYZ_SIZE];

            for(int idx = 0; idx <NexMotion_Define.MAX_XYZ_SIZE ; idx++ )
            {
                pos[idx] = 0.0;
            }
        }

        // For Cartesian space(MCS,PCS) : X, Y, Z,
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NexMotion_Define.MAX_XYZ_SIZE)]
        public Double []  pos;
    } 


}
