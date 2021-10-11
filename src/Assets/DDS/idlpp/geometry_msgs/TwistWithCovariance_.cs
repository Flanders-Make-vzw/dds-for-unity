using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region TwistWithCovariance_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TwistWithCovariance_
            {
                public geometry_msgs.msg.dds_.Twist_ twist_ = new geometry_msgs.msg.dds_.Twist_();
                public double[] covariance_ = new double[36];
            };
            #endregion

        }

    }

}

