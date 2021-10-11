using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region SetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class SetMap_Request_
            {
                public nav_msgs.msg.dds_.OccupancyGrid_ map_ = new nav_msgs.msg.dds_.OccupancyGrid_();
                public geometry_msgs.msg.dds_.PoseWithCovarianceStamped_ initial_pose_ = new geometry_msgs.msg.dds_.PoseWithCovarianceStamped_();
            };
            #endregion

            #region SetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class SetMap_Response_
            {
                public bool success_;
            };
            #endregion

            #region Sample_SetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_SetMap_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.SetMap_Request_ request_ = new nav_msgs.srv.dds_.SetMap_Request_();
            };
            #endregion

            #region Sample_SetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_SetMap_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.SetMap_Response_ response_ = new nav_msgs.srv.dds_.SetMap_Response_();
            };
            #endregion

        }

    }

}

