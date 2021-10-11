using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Joy_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Joy_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public float[] axes_ = new float[0];
                public int[] buttons_ = new int[0];
            };
            #endregion

        }

    }

}

