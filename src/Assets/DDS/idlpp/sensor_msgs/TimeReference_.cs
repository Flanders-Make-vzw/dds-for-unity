using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region TimeReference_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TimeReference_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public builtin_interfaces.msg.dds_.Time_ time_ref_ = new builtin_interfaces.msg.dds_.Time_();
                public string source_ = string.Empty;
            };
            #endregion

        }

    }

}

