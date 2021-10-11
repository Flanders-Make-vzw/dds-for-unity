using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PoseArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PoseArray_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Pose_[] poses_ = new geometry_msgs.msg.dds_.Pose_[0];
            };
            #endregion

        }

    }

}

