using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region AccelWithCovarianceStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AccelWithCovarianceStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.AccelWithCovariance_ accel_ = new geometry_msgs.msg.dds_.AccelWithCovariance_();
            };
            #endregion

        }

    }

}

