using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Int8MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Int8MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public byte[] data_ = new byte[0];
            };
            #endregion

        }

    }

}

