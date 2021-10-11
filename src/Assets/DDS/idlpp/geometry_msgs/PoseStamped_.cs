using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PoseStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PoseStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Pose_ pose_ = new geometry_msgs.msg.dds_.Pose_();
            };
            #endregion

        }

    }

}

