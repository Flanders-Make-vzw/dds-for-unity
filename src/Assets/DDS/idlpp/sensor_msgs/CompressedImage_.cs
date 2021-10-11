using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region CompressedImage_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class CompressedImage_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string format_ = string.Empty;
                public byte[] data_ = new byte[0];
            };
            #endregion

        }

    }

}

