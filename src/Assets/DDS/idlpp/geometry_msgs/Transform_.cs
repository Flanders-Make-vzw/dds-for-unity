using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Transform_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Transform_
            {
                public geometry_msgs.msg.dds_.Vector3_ translation_ = new geometry_msgs.msg.dds_.Vector3_();
                public geometry_msgs.msg.dds_.Quaternion_ rotation_ = new geometry_msgs.msg.dds_.Quaternion_();
            };
            #endregion

        }

    }

}

