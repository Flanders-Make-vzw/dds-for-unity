using DDS;
using System.Runtime.InteropServices;

namespace planner_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MotionPlanResponse_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MotionPlanResponse_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string plan_id_ = string.Empty;
                public trajectory_msgs.msg.dds_.JointTrajectory_ start_trajectory_ = new trajectory_msgs.msg.dds_.JointTrajectory_();
                public trajectory_msgs.msg.dds_.JointTrajectory_ path_trajectory_ = new trajectory_msgs.msg.dds_.JointTrajectory_();
            };
            #endregion

        }

    }

}

