using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Wrench_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Wrench_
            {
                public geometry_msgs.msg.dds_.Vector3_ force_ = new geometry_msgs.msg.dds_.Vector3_();
                public geometry_msgs.msg.dds_.Vector3_ torque_ = new geometry_msgs.msg.dds_.Vector3_();
            };
            #endregion

        }

    }

}

