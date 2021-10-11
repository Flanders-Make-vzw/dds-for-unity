using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Float64MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Float64MultiArray_
            {
                public std_msgs.msg.dds_.MultiArrayLayout_ layout_ = new std_msgs.msg.dds_.MultiArrayLayout_();
                public double[] data_ = new double[0];
            };
            #endregion

        }

    }

}

