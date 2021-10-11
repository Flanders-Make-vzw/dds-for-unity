using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region JoyFeedbackArray_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class JoyFeedbackArray_
            {
                public sensor_msgs.msg.dds_.JoyFeedback_[] array_ = new sensor_msgs.msg.dds_.JoyFeedback_[0];
            };
            #endregion

        }

    }

}

