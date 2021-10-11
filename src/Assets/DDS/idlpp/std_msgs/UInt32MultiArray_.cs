using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region UInt32MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class UInt32MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public uint[] data_ = new uint[0];
            };
            #endregion

        }

    }

}

