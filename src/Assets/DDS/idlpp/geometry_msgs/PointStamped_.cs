using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PointStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PointStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Point_ point_ = new geometry_msgs.msg.dds_.Point_();
            };
            #endregion

        }

    }

}

