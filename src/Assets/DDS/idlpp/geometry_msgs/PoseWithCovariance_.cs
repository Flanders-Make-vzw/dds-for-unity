using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PoseWithCovariance_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PoseWithCovariance_
            {
                public geometry_msgs.msg.dds_.Pose_ pose_ = new geometry_msgs.msg.dds_.Pose_();
                public double[] covariance_ = new double[36];
            };
            #endregion

        }

    }

}

