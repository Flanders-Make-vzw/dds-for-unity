using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PointCloud2_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PointCloud2_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public uint height_;
                public uint width_;
                public sensor_msgs.msg.dds_.PointField_[] fields_ = new sensor_msgs.msg.dds_.PointField_[0];
                public bool is_bigendian_;
                public uint point_step_;
                public uint row_step_;
                public byte[] data_ = new byte[0];
                public bool is_dense_;
            };
            #endregion

        }

    }

}

