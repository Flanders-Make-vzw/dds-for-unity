using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Int32MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Int32MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public int[] data_ = new int[0];
            };
            #endregion

        }

    }

}

