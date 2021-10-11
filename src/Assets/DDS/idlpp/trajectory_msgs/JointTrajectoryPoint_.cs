using DDS;
using System.Runtime.InteropServices;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region JointTrajectoryPoint_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class JointTrajectoryPoint_
            {
                public double[] positions_ = new double[0];
                public double[] velocities_ = new double[0];
                public double[] accelerations_ = new double[0];
                public double[] effort_ = new double[0];
                public builtin_interfaces.msg.dds_.Duration_ time_from_start_ = new builtin_interfaces.msg.dds_.Duration_();
            };
            #endregion

        }

    }

}

