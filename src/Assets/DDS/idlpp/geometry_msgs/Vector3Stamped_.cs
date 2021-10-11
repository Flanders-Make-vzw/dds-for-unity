using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Vector3Stamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Vector3Stamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Vector3_ vector_ = new geometry_msgs.msg.dds_.Vector3_();
            };
            #endregion

        }

    }

}

