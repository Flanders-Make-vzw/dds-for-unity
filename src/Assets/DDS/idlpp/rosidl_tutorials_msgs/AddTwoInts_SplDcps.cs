using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace rosidl_tutorials_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region __AddTwoInts_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __AddTwoInts_Request_
            {
                public byte a_;
                public byte b_;
            }
            #endregion

            #region __AddTwoInts_Request_Marshaler
            public sealed class __AddTwoInts_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_>
            {
                public static readonly string fullyScopedName = "rosidl_tutorials_msgs::srv::dds_::AddTwoInts_Request_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ fromData = tmpGCHandle.Target as rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ from, System.IntPtr to)
                {
                    __AddTwoInts_Request_ nativeImg = new __AddTwoInts_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ from, ref __AddTwoInts_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.a_ = from.a_;
                    to.b_ = from.b_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __AddTwoInts_Request_ nativeImg = (__AddTwoInts_Request_) Marshal.PtrToStructure(from, typeof(__AddTwoInts_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ toObj = tmpGCHandleTo.Target as rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ to)
                {
                    __AddTwoInts_Request_ nativeImg = (__AddTwoInts_Request_) Marshal.PtrToStructure(from, typeof(__AddTwoInts_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ to)
                {
                    __AddTwoInts_Request_ nativeImg = (__AddTwoInts_Request_) Marshal.PtrToStructure(from, typeof(__AddTwoInts_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __AddTwoInts_Request_ from, ref rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_ to)
                {
                    if (to == null) {
                        to = new rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Request_();
                    }
                    to.a_ = from.a_;
                    to.b_ = from.b_;
                }

            }
            #endregion

            #region __AddTwoInts_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __AddTwoInts_Response_
            {
                public byte sum_;
            }
            #endregion

            #region __AddTwoInts_Response_Marshaler
            public sealed class __AddTwoInts_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_>
            {
                public static readonly string fullyScopedName = "rosidl_tutorials_msgs::srv::dds_::AddTwoInts_Response_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ fromData = tmpGCHandle.Target as rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ from, System.IntPtr to)
                {
                    __AddTwoInts_Response_ nativeImg = new __AddTwoInts_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ from, ref __AddTwoInts_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.sum_ = from.sum_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __AddTwoInts_Response_ nativeImg = (__AddTwoInts_Response_) Marshal.PtrToStructure(from, typeof(__AddTwoInts_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ toObj = tmpGCHandleTo.Target as rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ to)
                {
                    __AddTwoInts_Response_ nativeImg = (__AddTwoInts_Response_) Marshal.PtrToStructure(from, typeof(__AddTwoInts_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ to)
                {
                    __AddTwoInts_Response_ nativeImg = (__AddTwoInts_Response_) Marshal.PtrToStructure(from, typeof(__AddTwoInts_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __AddTwoInts_Response_ from, ref rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_ to)
                {
                    if (to == null) {
                        to = new rosidl_tutorials_msgs.srv.dds_.AddTwoInts_Response_();
                    }
                    to.sum_ = from.sum_;
                }

            }
            #endregion

            #region __Sample_AddTwoInts_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_AddTwoInts_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_ request_;
            }
            #endregion

            #region __Sample_AddTwoInts_Request_Marshaler
            public sealed class __Sample_AddTwoInts_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_>
            {
                public static readonly string fullyScopedName = "rosidl_tutorials_msgs::srv::dds_::Sample_AddTwoInts_Request_";
                private rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_)) as rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ fromData = tmpGCHandle.Target as rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ from, System.IntPtr to)
                {
                    __Sample_AddTwoInts_Request_ nativeImg = new __Sample_AddTwoInts_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ from, ref __Sample_AddTwoInts_Request_ to)
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
                    __Sample_AddTwoInts_Request_ nativeImg = (__Sample_AddTwoInts_Request_) Marshal.PtrToStructure(from, typeof(__Sample_AddTwoInts_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ toObj = tmpGCHandleTo.Target as rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ to)
                {
                    __Sample_AddTwoInts_Request_ nativeImg = (__Sample_AddTwoInts_Request_) Marshal.PtrToStructure(from, typeof(__Sample_AddTwoInts_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ to)
                {
                    __Sample_AddTwoInts_Request_ nativeImg = (__Sample_AddTwoInts_Request_) Marshal.PtrToStructure(from, typeof(__Sample_AddTwoInts_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_AddTwoInts_Request_ from, ref rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_ to)
                {
                    if (to == null) {
                        to = new rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Request_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Request_Marshaler.CopyOut(ref from.request_, ref to.request_);
                }

            }
            #endregion

            #region __Sample_AddTwoInts_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_AddTwoInts_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_ response_;
            }
            #endregion

            #region __Sample_AddTwoInts_Response_Marshaler
            public sealed class __Sample_AddTwoInts_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_>
            {
                public static readonly string fullyScopedName = "rosidl_tutorials_msgs::srv::dds_::Sample_AddTwoInts_Response_";
                private rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_)) as rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ fromData = tmpGCHandle.Target as rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ from, System.IntPtr to)
                {
                    __Sample_AddTwoInts_Response_ nativeImg = new __Sample_AddTwoInts_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ from, ref __Sample_AddTwoInts_Response_ to)
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
                    __Sample_AddTwoInts_Response_ nativeImg = (__Sample_AddTwoInts_Response_) Marshal.PtrToStructure(from, typeof(__Sample_AddTwoInts_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ toObj = tmpGCHandleTo.Target as rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ to)
                {
                    __Sample_AddTwoInts_Response_ nativeImg = (__Sample_AddTwoInts_Response_) Marshal.PtrToStructure(from, typeof(__Sample_AddTwoInts_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ to)
                {
                    __Sample_AddTwoInts_Response_ nativeImg = (__Sample_AddTwoInts_Response_) Marshal.PtrToStructure(from, typeof(__Sample_AddTwoInts_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_AddTwoInts_Response_ from, ref rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_ to)
                {
                    if (to == null) {
                        to = new rosidl_tutorials_msgs.srv.dds_.Sample_AddTwoInts_Response_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    rosidl_tutorials_msgs.srv.dds_.__AddTwoInts_Response_Marshaler.CopyOut(ref from.response_, ref to.response_);
                }

            }
            #endregion

        }

    }

}

