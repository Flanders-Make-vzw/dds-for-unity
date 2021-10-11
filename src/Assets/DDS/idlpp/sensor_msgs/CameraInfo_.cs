using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region CameraInfo_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class CameraInfo_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public uint height_;
                public uint width_;
                public string distortion_model_ = string.Empty;
                public double[] d_ = new double[0];
                public double[] k_ = new double[9];
                public double[] r_ = new double[9];
                public double[] p_ = new double[12];
                public uint binning_x_;
                public uint binning_y_;
                public sensor_msgs.msg.dds_.RegionOfInterest_ roi_ = new sensor_msgs.msg.dds_.RegionOfInterest_();
            };
            #endregion

        }

    }

}

