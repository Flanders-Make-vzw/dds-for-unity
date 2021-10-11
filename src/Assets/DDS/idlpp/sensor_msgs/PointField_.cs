using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace PointField_Constants
            {
                public struct INT8_ { public static readonly byte value = (byte) 1; }

                public struct UINT8_ { public static readonly byte value = (byte) 2; }

                public struct INT16_ { public static readonly byte value = (byte) 3; }

                public struct UINT16_ { public static readonly byte value = (byte) 4; }

                public struct INT32_ { public static readonly byte value = (byte) 5; }

                public struct UINT32_ { public static readonly byte value = (byte) 6; }

                public struct FLOAT32_ { public static readonly byte value = (byte) 7; }

                public struct FLOAT64_ { public static readonly byte value = (byte) 8; }

            }

            #region PointField_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PointField_
            {
                public string name_ = string.Empty;
                public uint offset_;
                public byte datatype_;
                public uint count_;
            };
            #endregion

        }

    }

}

