using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Imu_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Imu_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Quaternion_ orientation_ = new geometry_msgs.msg.dds_.Quaternion_();
                public double[] orientation_covariance_ = new double[9];
                public geometry_msgs.msg.dds_.Vector3_ angular_velocity_ = new geometry_msgs.msg.dds_.Vector3_();
                public double[] angular_velocity_covariance_ = new double[9];
                public geometry_msgs.msg.dds_.Vector3_ linear_acceleration_ = new geometry_msgs.msg.dds_.Vector3_();
                public double[] linear_acceleration_covariance_ = new double[9];
            };
            #endregion

        }

    }

}

