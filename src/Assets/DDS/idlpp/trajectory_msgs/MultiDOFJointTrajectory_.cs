using DDS;
using System.Runtime.InteropServices;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiDOFJointTrajectory_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MultiDOFJointTrajectory_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string[] joint_names_ = new string[0];
                public trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_[] points_ = new trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_[0];
            };
            #endregion

        }

    }

}

