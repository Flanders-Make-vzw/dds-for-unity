using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Odometry_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Odometry_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string child_frame_id_ = string.Empty;
                public geometry_msgs.msg.dds_.PoseWithCovariance_ pose_ = new geometry_msgs.msg.dds_.PoseWithCovariance_();
                public geometry_msgs.msg.dds_.TwistWithCovariance_ twist_ = new geometry_msgs.msg.dds_.TwistWithCovariance_();
            };
            #endregion

        }

    }

}

