using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region TeleportAbsolute_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TeleportAbsolute_Request_
            {
                public float x_;
                public float y_;
                public float theta_;
            };
            #endregion

            #region TeleportAbsolute_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class TeleportAbsolute_Response_
            {
                public byte structure_needs_at_least_one_member_;
            };
            #endregion

            #region Sample_TeleportAbsolute_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_TeleportAbsolute_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.TeleportAbsolute_Request_ request_ = new turtlesim.srv.dds_.TeleportAbsolute_Request_();
            };
            #endregion

            #region Sample_TeleportAbsolute_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_TeleportAbsolute_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.TeleportAbsolute_Response_ response_ = new turtlesim.srv.dds_.TeleportAbsolute_Response_();
            };
            #endregion

        }

    }

}

