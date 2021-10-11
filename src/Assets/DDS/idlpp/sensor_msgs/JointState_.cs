using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region JointState_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class JointState_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public string[] name_ = new string[0];
                public double[] position_ = new double[0];
                public double[] velocity_ = new double[0];
                public double[] effort_ = new double[0];
            };
            #endregion

        }

    }

}

