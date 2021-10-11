using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region TeleportRelative_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TeleportRelative_Request_
            {
                public float linear_;
                public float angular_;
            };
            #endregion

            #region TeleportRelative_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TeleportRelative_Response_
            {
                public byte structure_needs_at_least_one_member_;
            };
            #endregion

            #region Sample_TeleportRelative_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_TeleportRelative_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.TeleportRelative_Request_ request_ = new turtlesim.srv.dds_.TeleportRelative_Request_();
            };
            #endregion

            #region Sample_TeleportRelative_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_TeleportRelative_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.TeleportRelative_Response_ response_ = new turtlesim.srv.dds_.TeleportRelative_Response_();
            };
            #endregion

        }

    }

}

