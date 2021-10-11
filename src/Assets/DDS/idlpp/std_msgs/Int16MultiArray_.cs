using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Int16MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Int16MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public short[] data_ = new short[0];
            };
            #endregion

        }

    }

}

