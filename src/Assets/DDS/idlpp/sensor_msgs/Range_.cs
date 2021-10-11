using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace Range_Constants
            {
                public struct ULTRASOUND_ { public static readonly byte value = (byte) 0; }

                public struct INFRARED_ { public static readonly byte value = (byte) 1; }

            }

            #region Range_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Range_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public byte radiation_type_;
                public float field_of_view_;
                public float min_range_;
                public float max_range_;
                public float range_;
            };
            #endregion

        }

    }

}

