using DDS;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region PolygonStamped_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class PolygonStamped_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public geometry_msgs.msg.dds_.Polygon_ polygon_ = new geometry_msgs.msg.dds_.Polygon_();
            };
            #endregion

        }

    }

}

