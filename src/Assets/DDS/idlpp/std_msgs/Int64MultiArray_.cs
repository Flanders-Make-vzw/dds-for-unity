using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Int64MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Int64MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public long[] data_ = new long[0];
            };
            #endregion

        }

    }

}

