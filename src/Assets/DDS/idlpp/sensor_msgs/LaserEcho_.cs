using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region LaserEcho_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class LaserEcho_
            {
                public float[] echoes_ = new float[0];
            };
            #endregion

        }

    }

}

