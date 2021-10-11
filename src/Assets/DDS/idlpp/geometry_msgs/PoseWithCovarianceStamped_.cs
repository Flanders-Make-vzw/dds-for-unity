using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PoseWithCovarianceStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PoseWithCovarianceStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.PoseWithCovariance_ pose_ = new geometry_msgs.msg.dds_.PoseWithCovariance_();
            };
            #endregion

        }

    }

}

