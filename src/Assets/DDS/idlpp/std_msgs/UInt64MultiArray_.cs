using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region UInt64MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class UInt64MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public ulong[] data_ = new ulong[0];
            };
            #endregion

        }

    }

}

