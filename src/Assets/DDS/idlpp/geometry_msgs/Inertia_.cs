using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Inertia_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Inertia_
            {
                public double m_;
                public geometry_msgs.msg.dds_.Vector3_ com_ = new geometry_msgs.msg.dds_.Vector3_();
                public double ixx_;
                public double ixy_;
                public double ixz_;
                public double iyy_;
                public double iyz_;
                public double izz_;
            };
            #endregion

        }

    }

}

