using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace NavSatFix_Constants
            {
                public struct COVARIANCE_TYPE_UNKNOWN_ { public static readonly byte value = (byte) 0; }

                public struct COVARIANCE_TYPE_APPROXIMATED_ { public static readonly byte value = (byte) 1; }

                public struct COVARIANCE_TYPE_DIAGONAL_KNOWN_ { public static readonly byte value = (byte) 2; }

                public struct COVARIANCE_TYPE_KNOWN_ { public static readonly byte value = (byte) 3; }

            }

            #region NavSatFix_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class NavSatFix_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public sensor_msgs.msg.dds_.NavSatStatus_ status_ = new sensor_msgs.msg.dds_.NavSatStatus_();
                public double latitude_;
                public double longitude_;
                public double altitude_;
                public double[] position_covariance_ = new double[9];
                public byte position_covariance_type_;
            };
            #endregion

        }

    }

}

