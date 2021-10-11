using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Temperature_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Temperature_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public double temperature_;
                public double variance_;
            };
            #endregion

        }

    }

}

