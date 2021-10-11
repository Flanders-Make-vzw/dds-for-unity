using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region OccupancyGrid_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class OccupancyGrid_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public nav_msgs.msg.dds_.MapMetaData_ info_ = new nav_msgs.msg.dds_.MapMetaData_();
                public byte[] data_ = new byte[0];
            };
            #endregion

        }

    }

}

