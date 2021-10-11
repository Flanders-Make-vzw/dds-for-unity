using DDS;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region GetPlan_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class GetPlan_Request_
            {
                public geometry_msgs.msg.dds_.PoseStamped_ start_ = new geometry_msgs.msg.dds_.PoseStamped_();
                public geometry_msgs.msg.dds_.PoseStamped_ goal_ = new geometry_msgs.msg.dds_.PoseStamped_();
                public float tolerance_;
            };
            #endregion

            #region GetPlan_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class GetPlan_Response_
            {
                public nav_msgs.msg.dds_.Path_ plan_ = new nav_msgs.msg.dds_.Path_();
            };
            #endregion

            #region Sample_GetPlan_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_GetPlan_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.GetPlan_Request_ request_ = new nav_msgs.srv.dds_.GetPlan_Request_();
            };
            #endregion

            #region Sample_GetPlan_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_GetPlan_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.GetPlan_Response_ response_ = new nav_msgs.srv.dds_.GetPlan_Response_();
            };
            #endregion

        }

    }

}

