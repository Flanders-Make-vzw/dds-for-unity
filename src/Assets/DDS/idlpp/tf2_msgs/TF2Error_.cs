using DDS;
using System.Runtime.InteropServices;

namespace tf2_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace TF2Error_Constants
            {
                public struct NO_ERROR_ { public static readonly byte value = (byte) 0; }

                public struct LOOKUP_ERROR_ { public static readonly byte value = (byte) 1; }

                public struct CONNECTIVITY_ERROR_ { public static readonly byte value = (byte) 2; }

                public struct EXTRAPOLATION_ERROR_ { public static readonly byte value = (byte) 3; }

                public struct INVALID_ARGUMENT_ERROR_ { public static readonly byte value = (byte) 4; }

                public struct TIMEOUT_ERROR_ { public static readonly byte value = (byte) 5; }

                public struct TRANSFORM_ERROR_ { public static readonly byte value = (byte) 6; }

            }

            #region TF2Error_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TF2Error_
            {
                public byte error_;
                public string error_string_ = string.Empty;
            };
            #endregion

        }

    }

}

