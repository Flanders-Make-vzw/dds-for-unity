using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region Spawn_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Spawn_Request_
            {
                public float x_;
                public float y_;
                public float theta_;
                public string name_ = string.Empty;
            };
            #endregion

            #region Spawn_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Spawn_Response_
            {
                public string name_ = string.Empty;
            };
            #endregion

            #region Sample_Spawn_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_Spawn_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.Spawn_Request_ request_ = new turtlesim.srv.dds_.Spawn_Request_();
            };
            #endregion

            #region Sample_Spawn_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_Spawn_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.Spawn_Response_ response_ = new turtlesim.srv.dds_.Spawn_Response_();
            };
            #endregion

        }

    }

}

