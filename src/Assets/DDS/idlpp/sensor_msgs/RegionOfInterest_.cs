using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region RegionOfInterest_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class RegionOfInterest_
            {
                public uint x_offset_;
                public uint y_offset_;
                public uint height_;
                public uint width_;
                public bool do_rectify_;
            };
            #endregion

        }

    }

}

