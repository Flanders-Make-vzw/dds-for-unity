using DDS;
using System.Runtime.InteropServices;

namespace rosidl_tutorials_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region AddTwoFloats_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AddTwoFloats_Request_
            {
                public double a_;
                public double b_;
            };
            #endregion

            #region AddTwoFloats_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class AddTwoFloats_Response_
            {
                public double sum_;
            };
            #endregion

            #region Sample_AddTwoFloats_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_AddTwoFloats_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.AddTwoFloats_Request_ request_ = new rosidl_tutorials_msgs.srv.dds_.AddTwoFloats_Request_();
            };
            #endregion

            #region Sample_AddTwoFloats_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_AddTwoFloats_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.AddTwoFloats_Response_ response_ = new rosidl_tutorials_msgs.srv.dds_.AddTwoFloats_Response_();
            };
            #endregion

        }

    }

}

