using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region ChannelFloat32_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class ChannelFloat32_
            {
                public string name_ = string.Empty;
                public float[] values_ = new float[0];
            };
            #endregion

        }

    }

}

