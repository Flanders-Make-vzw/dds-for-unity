using DDS;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region SetPen_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class SetPen_Request_
            {
                public byte r_;
                public byte g_;
                public byte b_;
                public byte width_;
                public byte off_;
            };
            #endregion

            #region SetPen_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class SetPen_Response_
            {
                public byte structure_needs_at_least_one_member_;
            };
            #endregion

            #region Sample_SetPen_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_SetPen_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.SetPen_Request_ request_ = new turtlesim.srv.dds_.SetPen_Request_();
            };
            #endregion

            #region Sample_SetPen_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_SetPen_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.SetPen_Response_ response_ = new turtlesim.srv.dds_.SetPen_Response_();
            };
            #endregion

        }

    }

}

