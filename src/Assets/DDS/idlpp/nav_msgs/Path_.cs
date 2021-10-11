using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Path_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Path_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.PoseStamped_[] poses_ = new geometry_msgs.msg.dds_.PoseStamped_[0];
            };
            #endregion

        }

    }

}

