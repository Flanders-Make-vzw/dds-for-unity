using DDS;
using System.Runtime.InteropServices;

namespace rosidl_tutorials_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region AddTwoInts_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AddTwoInts_Request_
            {
                public byte a_;
                public byte b_;
            };
            #endregion

            #region AddTwoInts_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AddTwoInts_Response_
            {
                public byte sum_;
            };
            #endregion

            #region Sample_AddTwoInts_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_AddTwoInts_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ request_ = new rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_();
            };
            #endregion

            #region Sample_AddTwoInts_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_AddTwoInts_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ response_ = new rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_();
            };
            #endregion

        }

    }

}

