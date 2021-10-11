using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PointCloud_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PointCloud_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Point32_[] points_ = new geometry_msgs.msg.dds_.Point32_[0];
                public sensor_msgs.msg.dds_.ChannelFloat32_[] channels_ = new sensor_msgs.msg.dds_.ChannelFloat32_[0];
            };
            #endregion

        }

    }

}

