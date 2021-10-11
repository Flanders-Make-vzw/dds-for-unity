using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Accel_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Accel_
            {
                public geometry_msgs.msg.dds_.Vector3_ linear_ = new geometry_msgs.msg.dds_.Vector3_();
                public geometry_msgs.msg.dds_.Vector3_ angular_ = new geometry_msgs.msg.dds_.Vector3_();
            };
            #endregion

        }

    }

}

