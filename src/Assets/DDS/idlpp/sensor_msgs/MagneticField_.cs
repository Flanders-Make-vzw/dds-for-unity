using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MagneticField_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MagneticField_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Vector3_ magnetic_field_ = new geometry_msgs.msg.dds_.Vector3_();
                public double[] magnetic_field_covariance_ = new double[9];
            };
            #endregion

        }

    }

}

