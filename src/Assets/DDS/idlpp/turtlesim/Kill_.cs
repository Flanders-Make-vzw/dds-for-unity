using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region Kill_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Kill_Request_
            {
                public string name_ = string.Empty;
            };
            #endregion

            #region Kill_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Kill_Response_
            {
                public byte structure_needs_at_least_one_member_;
            };
            #endregion

            #region Sample_Kill_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_Kill_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.Kill_Request_ request_ = new turtlesim.srv.dds_.Kill_Request_();
            };
            #endregion

            #region Sample_Kill_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_Kill_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.Kill_Response_ response_ = new turtlesim.srv.dds_.Kill_Response_();
            };
            #endregion

        }

    }

}

