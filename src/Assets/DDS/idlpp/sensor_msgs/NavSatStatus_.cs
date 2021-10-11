using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace NavSatStatus_Constants
            {
                public struct STATUS_NO_FIX_ { public static readonly byte value = (byte) 255; }

                public struct STATUS_FIX_ { public static readonly byte value = (byte) 0; }

                public struct STATUS_SBAS_FIX_ { public static readonly byte value = (byte) 1; }

                public struct STATUS_GBAS_FIX_ { public static readonly byte value = (byte) 2; }

                public struct SERVICE_GPS_ { public static readonly ushort value = (ushort) 1; }

                public struct SERVICE_GLONASS_ { public static readonly ushort value = (ushort) 2; }

                public struct SERVICE_COMPASS_ { public static readonly ushort value = (ushort) 4; }

                public struct SERVICE_GALILEO_ { public static readonly ushort value = (ushort) 8; }

            }

            #region NavSatStatus_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class NavSatStatus_
            {
                public byte status_;
                public ushort service_;
            };
            #endregion

        }

    }

}

