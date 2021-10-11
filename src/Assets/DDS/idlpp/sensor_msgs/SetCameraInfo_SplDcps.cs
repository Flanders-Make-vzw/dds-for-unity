using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region __SetCameraInfo_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __SetCameraInfo_Request_
            {
                public sensor_msgs.msg.dds_.__CameraInfo_ camera_info_;
            }
            #endregion

            #region __SetCameraInfo_Request_Marshaler
            public sealed class __SetCameraInfo_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.srv.dds_.SetCameraInfo_Request_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::srv::dds_::SetCameraInfo_Request_";
                private sensor_msgs.msg.dds_.__CameraInfo_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.msg.dds_.__CameraInfo_)) as sensor_msgs.msg.dds_.__CameraInfo_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new sensor_msgs.msg.dds_.__CameraInfo_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.msg.dds_.__CameraInfo_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.srv.dds_.SetCameraInfo_Request_ fromData = tmpGCHandle.Target as sensor_msgs.srv.dds_.SetCameraInfo_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.SetCameraInfo_Request_ from, System.IntPtr to)
                {
                    __SetCameraInfo_Request_ nativeImg = new __SetCameraInfo_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.SetCameraInfo_Request_ from, ref __SetCameraInfo_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.camera_info_, ref to.camera_info_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __SetCameraInfo_Request_ nativeImg = (__SetCameraInfo_Request_) Marshal.PtrToStructure(from, typeof(__SetCameraInfo_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.srv.dds_.SetCameraInfo_Request_ toObj = tmpGCHandleTo.Target as sensor_msgs.srv.dds_.SetCameraInfo_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.SetCameraInfo_Request_ to)
                {
                    __SetCameraInfo_Request_ nativeImg = (__SetCameraInfo_Request_) Marshal.PtrToStructure(from, typeof(__SetCameraInfo_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.SetCameraInfo_Request_ to)
                {
                    __SetCameraInfo_Request_ nativeImg = (__SetCameraInfo_Request_) Marshal.PtrToStructure(from, typeof(__SetCameraInfo_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __SetCameraInfo_Request_ from, ref sensor_msgs.srv.dds_.SetCameraInfo_Request_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.srv.dds_.SetCameraInfo_Request_();
                    }
                    sensor_msgs.msg.dds_.__CameraInfo_Marshaler.CopyOut(ref from.camera_info_, ref to.camera_info_);
                }

            }
            #endregion

            #region __SetCameraInfo_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __SetCameraInfo_Response_
            {
                public byte success_;
                public IntPtr status_message_;
            }
            #endregion

            #region __SetCameraInfo_Response_Marshaler
            public sealed class __SetCameraInfo_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.srv.dds_.SetCameraInfo_Response_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::srv::dds_::SetCameraInfo_Response_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.srv.dds_.SetCameraInfo_Response_ fromData = tmpGCHandle.Target as sensor_msgs.srv.dds_.SetCameraInfo_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.SetCameraInfo_Response_ from, System.IntPtr to)
                {
                    __SetCameraInfo_Response_ nativeImg = new __SetCameraInfo_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.SetCameraInfo_Response_ from, ref __SetCameraInfo_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.success_ = from.success_ ? (byte) 1 : (byte) 0;
                    if (from.status_message_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.status_message_, from.status_message_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __SetCameraInfo_Response_ nativeImg = (__SetCameraInfo_Response_) Marshal.PtrToStructure(from, typeof(__SetCameraInfo_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.srv.dds_.SetCameraInfo_Response_ toObj = tmpGCHandleTo.Target as sensor_msgs.srv.dds_.SetCameraInfo_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.SetCameraInfo_Response_ to)
                {
                    __SetCameraInfo_Response_ nativeImg = (__SetCameraInfo_Response_) Marshal.PtrToStructure(from, typeof(__SetCameraInfo_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.SetCameraInfo_Response_ to)
                {
                    __SetCameraInfo_Response_ nativeImg = (__SetCameraInfo_Response_) Marshal.PtrToStructure(from, typeof(__SetCameraInfo_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __SetCameraInfo_Response_ from, ref sensor_msgs.srv.dds_.SetCameraInfo_Response_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.srv.dds_.SetCameraInfo_Response_();
                    }
                    to.success_ = from.success_ != 0 ? true : false;
                    to.status_message_ = ReadString(from.status_message_);
                }

            }
            #endregion

            #region __Sample_SetCameraInfo_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_SetCameraInfo_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public sensor_msgs.srv.dds_.__SetCameraInfo_Request_ request_;
            }
            #endregion

            #region __Sample_SetCameraInfo_Request_Marshaler
            public sealed class __Sample_SetCameraInfo_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::srv::dds_::Sample_SetCameraInfo_Request_";
                private sensor_msgs.srv.dds_.__SetCameraInfo_Request_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.srv.dds_.__SetCameraInfo_Request_)) as sensor_msgs.srv.dds_.__SetCameraInfo_Request_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new sensor_msgs.srv.dds_.__SetCameraInfo_Request_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.srv.dds_.__SetCameraInfo_Request_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ fromData = tmpGCHandle.Target as sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ from, System.IntPtr to)
                {
                    __Sample_SetCameraInfo_Request_ nativeImg = new __Sample_SetCameraInfo_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ from, ref __Sample_SetCameraInfo_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.request_, ref to.request_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Sample_SetCameraInfo_Request_ nativeImg = (__Sample_SetCameraInfo_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetCameraInfo_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ toObj = tmpGCHandleTo.Target as sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ to)
                {
                    __Sample_SetCameraInfo_Request_ nativeImg = (__Sample_SetCameraInfo_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetCameraInfo_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ to)
                {
                    __Sample_SetCameraInfo_Request_ nativeImg = (__Sample_SetCameraInfo_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetCameraInfo_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_SetCameraInfo_Request_ from, ref sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.srv.dds_.Sample_SetCameraInfo_Request_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    sensor_msgs.srv.dds_.__SetCameraInfo_Request_Marshaler.CopyOut(ref from.request_, ref to.request_);
                }

            }
            #endregion

            #region __Sample_SetCameraInfo_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_SetCameraInfo_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public sensor_msgs.srv.dds_.__SetCameraInfo_Response_ response_;
            }
            #endregion

            #region __Sample_SetCameraInfo_Response_Marshaler
            public sealed class __Sample_SetCameraInfo_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::srv::dds_::Sample_SetCameraInfo_Response_";
                private sensor_msgs.srv.dds_.__SetCameraInfo_Response_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.srv.dds_.__SetCameraInfo_Response_)) as sensor_msgs.srv.dds_.__SetCameraInfo_Response_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new sensor_msgs.srv.dds_.__SetCameraInfo_Response_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.srv.dds_.__SetCameraInfo_Response_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ fromData = tmpGCHandle.Target as sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ from, System.IntPtr to)
                {
                    __Sample_SetCameraInfo_Response_ nativeImg = new __Sample_SetCameraInfo_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ from, ref __Sample_SetCameraInfo_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.response_, ref to.response_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Sample_SetCameraInfo_Response_ nativeImg = (__Sample_SetCameraInfo_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetCameraInfo_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ toObj = tmpGCHandleTo.Target as sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ to)
                {
                    __Sample_SetCameraInfo_Response_ nativeImg = (__Sample_SetCameraInfo_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetCameraInfo_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ to)
                {
                    __Sample_SetCameraInfo_Response_ nativeImg = (__Sample_SetCameraInfo_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetCameraInfo_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_SetCameraInfo_Response_ from, ref sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.srv.dds_.Sample_SetCameraInfo_Response_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    sensor_msgs.srv.dds_.__SetCameraInfo_Response_Marshaler.CopyOut(ref from.response_, ref to.response_);
                }

            }
            #endregion

        }

    }

}

