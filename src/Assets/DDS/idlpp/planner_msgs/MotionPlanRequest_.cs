using DDS;
using System.Runtime.InteropServices;

namespace planner_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MotionPlanRequest_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MotionPlanRequest_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string plan_id_ = string.Empty;
                public nav_msgs.msg.dds_.Path_ path_ = new nav_msgs.msg.dds_.Path_();
            };
            #endregion

        }

    }

}

