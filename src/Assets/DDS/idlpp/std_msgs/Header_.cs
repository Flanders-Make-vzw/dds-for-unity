using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Header_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Header_
            {
                public builtin_interfaces.msg.dds_.Time_ stamp_ = new builtin_interfaces.msg.dds_.Time_();
                public string frame_id_ = string.Empty;
            };
            #endregion

        }

    }

}

