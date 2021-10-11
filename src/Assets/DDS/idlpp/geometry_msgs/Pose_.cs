using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Pose_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Pose_
            {
                public geometry_msgs.msg.dds_.Point_ position_ = new geometry_msgs.msg.dds_.Point_();
                public geometry_msgs.msg.dds_.Quaternion_ orientation_ = new geometry_msgs.msg.dds_.Quaternion_();
            };
            #endregion

        }

    }

}

