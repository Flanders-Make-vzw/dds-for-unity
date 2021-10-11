using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region WrenchStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class WrenchStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Wrench_ wrench_ = new geometry_msgs.msg.dds_.Wrench_();
            };
            #endregion

        }

    }

}

