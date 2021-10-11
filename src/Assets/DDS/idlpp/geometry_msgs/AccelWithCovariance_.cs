using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region AccelWithCovariance_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AccelWithCovariance_
            {
                public geometry_msgs.msg.dds_.Accel_ accel_ = new geometry_msgs.msg.dds_.Accel_();
                public double[] covariance_ = new double[36];
            };
            #endregion

        }

    }

}

