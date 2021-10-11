using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Illuminance_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Illuminance_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public double illuminance_;
                public double variance_;
            };
            #endregion

        }

    }

}

