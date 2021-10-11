using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region SetCameraInfo_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class SetCameraInfo_Request_
            {
                public sensor_msgs.msg.dds_.CameraInfo_ camera_info_ = new sensor_msgs.msg.dds_.CameraInfo_();
            };
            #endregion

            #region SetCameraInfo_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class SetCameraInfo_Response_
            {
                public bool success_;
                public string status_message_ = string.Empty;
            };
            #endregion

            #region Sample_SetCameraInfo_Request_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_SetCameraInfo_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public sensor_msgs.srv.dds_.SetCameraInfo_Request_ request_ = new sensor_msgs.srv.dds_.SetCameraInfo_Request_();
            };
            #endregion

            #region Sample_SetCameraInfo_Response_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class Sample_SetCameraInfo_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public sensor_msgs.srv.dds_.SetCameraInfo_Response_ response_ = new sensor_msgs.srv.dds_.SetCameraInfo_Response_();
            };
            #endregion

        }

    }

}

