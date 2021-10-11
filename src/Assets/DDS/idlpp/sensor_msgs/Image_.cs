using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region Image_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Image_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public uint height_;
                public uint width_;
                public string encoding_ = string.Empty;
                public byte is_bigendian_;
                public uint step_;
                public byte[] data_ = new byte[0];
            };
            #endregion

        }

    }

}

