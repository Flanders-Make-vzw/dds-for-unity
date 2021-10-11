using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region GridCells_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class GridCells_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public float cell_width_;
                public float cell_height_;
                public geometry_msgs.msg.dds_.Point_[] cells_ = new geometry_msgs.msg.dds_.Point_[0];
            };
            #endregion

        }

    }

}

