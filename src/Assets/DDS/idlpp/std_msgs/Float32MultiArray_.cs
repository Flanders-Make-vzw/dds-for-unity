using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Float32MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Float32MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public float[] data_ = new float[0];
            };
            #endregion

        }

    }

}

