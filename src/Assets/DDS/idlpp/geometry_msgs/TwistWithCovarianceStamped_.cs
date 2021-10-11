using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region TwistWithCovarianceStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TwistWithCovarianceStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.TwistWithCovariance_ twist_ = new geometry_msgs.msg.dds_.TwistWithCovariance_();
            };
            #endregion

        }

    }

}

