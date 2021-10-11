using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region GetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class GetMap_Request_
            {
                public byte structure_needs_at_least_one_member_;
            };
            #endregion

            #region GetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class GetMap_Response_
            {
                public nav_msgs.msg.dds_.OccupancyGrid_ map_ = new nav_msgs.msg.dds_.OccupancyGrid_();
            };
            #endregion

            #region Sample_GetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_GetMap_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.GetMap_Request_ request_ = new nav_msgs.srv.dds_.GetMap_Request_();
            };
            #endregion

            #region Sample_GetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_GetMap_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.GetMap_Response_ response_ = new nav_msgs.srv.dds_.GetMap_Response_();
            };
            #endregion

        }

    }

}

