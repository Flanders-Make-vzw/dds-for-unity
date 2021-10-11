using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region LaserScan_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class LaserScan_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public float angle_min_;
                public float angle_max_;
                public float angle_increment_;
                public float time_increment_;
                public float scan_time_;
                public float range_min_;
                public float range_max_;
                public float[] ranges_ = new float[0];
                public float[] intensities_ = new float[0];
            };
            #endregion

        }

    }

}

