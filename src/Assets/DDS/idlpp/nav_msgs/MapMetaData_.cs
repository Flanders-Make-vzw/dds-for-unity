using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MapMetaData_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MapMetaData_
            {
                public builtin_interfaces.msg.dds_.Time_ map_load_time_ = new builtin_interfaces.msg.dds_.Time_();
                public float resolution_;
                public uint width_;
                public uint height_;
                public geometry_msgs.msg.dds_.Pose_ origin_ = new geometry_msgs.msg.dds_.Pose_();
            };
            #endregion

        }

    }

}

