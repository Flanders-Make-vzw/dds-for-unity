using DDS;
using System.Runtime.InteropServices;

namespace builtin_interfaces
{
    namespace msg
    {
        namespace dds_
        {
            #region Duration_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Duration_
            {
                public int sec_;
                public uint nanosec_;
            };
            #endregion

        }

    }

}

