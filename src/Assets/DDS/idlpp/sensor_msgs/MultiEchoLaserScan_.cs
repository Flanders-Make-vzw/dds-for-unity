using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiEchoLaserScan_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MultiEchoLaserScan_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public float angle_min_;
                public float angle_max_;
                public float angle_increment_;
                public float time_increment_;
                public float scan_time_;
                public float range_min_;
                public float range_max_;
                public sensor_msgs.msg.dds_.LaserEcho_[] ranges_ = new sensor_msgs.msg.dds_.LaserEcho_[0];
                public sensor_msgs.msg.dds_.LaserEcho_[] intensities_ = new sensor_msgs.msg.dds_.LaserEcho_[0];
            };
            #endregion

        }

    }

}

