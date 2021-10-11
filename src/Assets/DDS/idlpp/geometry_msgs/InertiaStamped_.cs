using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region InertiaStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class InertiaStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Inertia_ inertia_ = new geometry_msgs.msg.dds_.Inertia_();
            };
            #endregion

        }

    }

}

