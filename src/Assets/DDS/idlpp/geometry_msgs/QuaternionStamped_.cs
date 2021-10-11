using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region QuaternionStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class QuaternionStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Quaternion_ quaternion_ = new geometry_msgs.msg.dds_.Quaternion_();
            };
            #endregion

        }

    }

}

