using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region TransformStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TransformStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string child_frame_id_ = string.Empty;
                public geometry_msgs.msg.dds_.Transform_ transform_ = new geometry_msgs.msg.dds_.Transform_();
            };
            #endregion

        }

    }

}

