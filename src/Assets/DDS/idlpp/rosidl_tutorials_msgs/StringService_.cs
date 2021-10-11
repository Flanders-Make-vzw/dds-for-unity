using DDS;
using System.Runtime.InteropServices;

namespace rosidl_tutorials_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region StringService_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class StringService_Request_
            {
                public string instring_ = string.Empty;
            };
            #endregion

            #region StringService_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class StringService_Response_
            {
                public string outstring_ = string.Empty;
            };
            #endregion

            #region Sample_StringService_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_StringService_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.StringService_Request_ request_ = new rosidl_tutorials_msgs.srv.dds_.StringService_Request_();
            };
            #endregion

            #region Sample_StringService_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_StringService_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.StringService_Response_ response_ = new rosidl_tutorials_msgs.srv.dds_.StringService_Response_();
            };
            #endregion

        }

    }

}

