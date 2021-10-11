using DDS;
using System.Runtime.InteropServices;

namespace builtin_interfaces
{
    namespace msg
    {
        namespace dds_
        {
            #region Time_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Time_
            {
                public int sec_;
                public uint nanosec_;
            };
            #endregion

        }

    }

}

