using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace msg
    {
        namespace dds_
        {
            #region Pose_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Pose_
            {
                public float x_;
                public float y_;
                public float theta_;
                public float linear_velocity_;
                public float angular_velocity_;
            };
            #endregion

        }

    }

}

