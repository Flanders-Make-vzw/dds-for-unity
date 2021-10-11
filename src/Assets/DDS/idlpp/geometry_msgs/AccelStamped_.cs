using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region AccelStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AccelStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Accel_ accel_ = new geometry_msgs.msg.dds_.Accel_();
            };
            #endregion

        }

    }

}

