using DDS;
using System.Runtime.InteropServices;

namespace tf2_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region TFMessage_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TFMessage_
            {
                public geometry_msgs.msg.dds_.TransformStamped_[] transforms_ = new geometry_msgs.msg.dds_.TransformStamped_[0];
            };
            #endregion

        }

    }

}

