using DDS;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiArrayDimension_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class MultiArrayDimension_
            {
                public string label_ = string.Empty;
                public uint size_;
                public uint stride_;
            };
            #endregion

        }

    }

}

