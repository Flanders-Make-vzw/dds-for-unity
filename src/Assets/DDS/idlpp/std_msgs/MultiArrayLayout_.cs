using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiArrayLayout_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MultiArrayLayout_
            {
                public std_msgs.msg.dds_.MultiArrayDimension_[] dim_ = new std_msgs.msg.dds_.MultiArrayDimension_[0];
                public uint data_offset_;
            };
            #endregion

        }

    }

}

