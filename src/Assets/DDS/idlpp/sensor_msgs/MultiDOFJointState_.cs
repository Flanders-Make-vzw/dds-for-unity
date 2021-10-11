using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiDOFJointState_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MultiDOFJointState_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string[] joint_names_ = new string[0];
                public geometry_msgs.msg.dds_.Transform_[] transforms_ = new geometry_msgs.msg.dds_.Transform_[0];
                public geometry_msgs.msg.dds_.Twist_[] twist_ = new geometry_msgs.msg.dds_.Twist_[0];
                public geometry_msgs.msg.dds_.Wrench_[] wrench_ = new geometry_msgs.msg.dds_.Wrench_[0];
            };
            #endregion

        }

    }

}

