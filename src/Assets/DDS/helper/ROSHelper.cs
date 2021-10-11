using System;

using DDSAPIHelper;
using builtin_interfaces.msg.dds_;

namespace ros_helper 
{
    public class RosHelper
    {
        
        public static Time_ GetUnixTimestamp()
        {
            double unixTimestamp = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            int sec = (int)unixTimestamp;
            uint nsec = (uint) ((unixTimestamp - sec) * 1e9);
            Time_ t = new Time_
            {
                sec_ = sec,
                nanosec_ = nsec
            };
            return t;
        }

    }
}

