using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region UInt16MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class UInt16MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public ushort[] data_ = new ushort[0];
            };
            #endregion

        }

    }

}

