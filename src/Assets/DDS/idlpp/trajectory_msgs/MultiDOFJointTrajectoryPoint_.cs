using DDS;
using System.Runtime.InteropServices;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiDOFJointTrajectoryPoint_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MultiDOFJointTrajectoryPoint_
            {
                public geometry_msgs.msg.dds_.Transform_[] transforms_ = new geometry_msgs.msg.dds_.Transform_[0];
                public geometry_msgs.msg.dds_.Twist_[] velocities_ = new geometry_msgs.msg.dds_.Twist_[0];
                public geometry_msgs.msg.dds_.Twist_[] accelerations_ = new geometry_msgs.msg.dds_.Twist_[0];
                public builtin_interfaces.msg.dds_.Duration_ time_from_start_ = new builtin_interfaces.msg.dds_.Duration_();
            };
            #endregion

        }

    }

}

