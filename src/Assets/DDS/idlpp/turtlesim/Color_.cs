using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace msg
    {
        namespace dds_
        {
            #region Color_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Color_
            {
                public byte r_;
                public byte g_;
                public byte b_;
            };
            #endregion

        }

    }

}

