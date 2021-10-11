using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace JoyFeedback_Constants
            {
                public struct TYPE_LED_ { public static readonly byte value = (byte) 0; }

                public struct TYPE_RUMBLE_ { public static readonly byte value = (byte) 1; }

                public struct TYPE_BUZZER_ { public static readonly byte value = (byte) 2; }

            }

            #region JoyFeedback_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class JoyFeedback_
            {
                public byte type_;
                public byte id_;
                public float intensity_;
            };
            #endregion

        }

    }

}

