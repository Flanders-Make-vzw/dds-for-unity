using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region RelativeHumidity_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class RelativeHumidity_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public double relative_humidity_;
                public double variance_;
            };
            #endregion

        }

    }

}

