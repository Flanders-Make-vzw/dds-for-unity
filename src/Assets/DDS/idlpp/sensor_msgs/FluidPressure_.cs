using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region FluidPressure_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class FluidPressure_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public double fluid_pressure_;
                public double variance_;
            };
            #endregion

        }

    }

}

