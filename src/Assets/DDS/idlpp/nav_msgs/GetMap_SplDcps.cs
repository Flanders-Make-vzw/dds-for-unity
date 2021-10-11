using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace srv
    {
        namespace dds_
        {
            #region __GetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __GetMap_Request_
            {
                public byte structure_needs_at_least_one_member_;
            }
            #endregion

            #region __GetMap_Request_Marshaler
            public sealed class __GetMap_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.GetMap_Request_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::GetMap_Request_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.GetMap_Request_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.GetMap_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetMap_Request_ from, System.IntPtr to)
                {
                    __GetMap_Request_ nativeImg = new __GetMap_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetMap_Request_ from, ref __GetMap_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.structure_needs_at_least_one_member_ = from.structure_needs_at_least_one_member_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __GetMap_Request_ nativeImg = (__GetMap_Request_) Marshal.PtrToStructure(from, typeof(__GetMap_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.GetMap_Request_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.GetMap_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetMap_Request_ to)
                {
                    __GetMap_Request_ nativeImg = (__GetMap_Request_) Marshal.PtrToStructure(from, typeof(__GetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetMap_Request_ to)
                {
                    __GetMap_Request_ nativeImg = (__GetMap_Request_) Marshal.PtrToStructure(from, typeof(__GetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __GetMap_Request_ from, ref nav_msgs.srv.dds_.GetMap_Request_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.GetMap_Request_();
                    }
                    to.structure_needs_at_least_one_member_ = from.structure_needs_at_least_one_member_;
                }

            }
            #endregion

            #region __GetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __GetMap_Response_
            {
                public nav_msgs.msg.dds_.__OccupancyGrid_ map_;
            }
            #endregion

            #region __GetMap_Response_Marshaler
            public sealed class __GetMap_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.GetMap_Response_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::GetMap_Response_";
                private nav_msgs.msg.dds_.__OccupancyGrid_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.msg.dds_.__OccupancyGrid_)) as nav_msgs.msg.dds_.__OccupancyGrid_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new nav_msgs.msg.dds_.__OccupancyGrid_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.msg.dds_.__OccupancyGrid_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.GetMap_Response_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.GetMap_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetMap_Response_ from, System.IntPtr to)
                {
                    __GetMap_Response_ nativeImg = new __GetMap_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetMap_Response_ from, ref __GetMap_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.map_, ref to.map_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __GetMap_Response_ nativeImg = (__GetMap_Response_) Marshal.PtrToStructure(from, typeof(__GetMap_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.GetMap_Response_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.GetMap_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetMap_Response_ to)
                {
                    __GetMap_Response_ nativeImg = (__GetMap_Response_) Marshal.PtrToStructure(from, typeof(__GetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetMap_Response_ to)
                {
                    __GetMap_Response_ nativeImg = (__GetMap_Response_) Marshal.PtrToStructure(from, typeof(__GetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __GetMap_Response_ from, ref nav_msgs.srv.dds_.GetMap_Response_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.GetMap_Response_();
                    }
                    nav_msgs.msg.dds_.__OccupancyGrid_Marshaler.CopyOut(ref from.map_, ref to.map_);
                }

            }
            #endregion

            #region __Sample_GetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_GetMap_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.__GetMap_Request_ request_;
            }
            #endregion

            #region __Sample_GetMap_Request_Marshaler
            public sealed class __Sample_GetMap_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.Sample_GetMap_Request_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::Sample_GetMap_Request_";
                private nav_msgs.srv.dds_.__GetMap_Request_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.srv.dds_.__GetMap_Request_)) as nav_msgs.srv.dds_.__GetMap_Request_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new nav_msgs.srv.dds_.__GetMap_Request_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.srv.dds_.__GetMap_Request_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.Sample_GetMap_Request_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.Sample_GetMap_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetMap_Request_ from, System.IntPtr to)
                {
                    __Sample_GetMap_Request_ nativeImg = new __Sample_GetMap_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetMap_Request_ from, ref __Sample_GetMap_Request_ to)
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
                    __Sample_GetMap_Request_ nativeImg = (__Sample_GetMap_Request_) Marshal.PtrToStructure(from, typeof(__Sample_GetMap_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.Sample_GetMap_Request_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.Sample_GetMap_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetMap_Request_ to)
                {
                    __Sample_GetMap_Request_ nativeImg = (__Sample_GetMap_Request_) Marshal.PtrToStructure(from, typeof(__Sample_GetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetMap_Request_ to)
                {
                    __Sample_GetMap_Request_ nativeImg = (__Sample_GetMap_Request_) Marshal.PtrToStructure(from, typeof(__Sample_GetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_GetMap_Request_ from, ref nav_msgs.srv.dds_.Sample_GetMap_Request_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.Sample_GetMap_Request_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    nav_msgs.srv.dds_.__GetMap_Request_Marshaler.CopyOut(ref from.request_, ref to.request_);
                }

            }
            #endregion

            #region __Sample_GetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_GetMap_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.__GetMap_Response_ response_;
            }
            #endregion

            #region __Sample_GetMap_Response_Marshaler
            public sealed class __Sample_GetMap_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.Sample_GetMap_Response_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::Sample_GetMap_Response_";
                private nav_msgs.srv.dds_.__GetMap_Response_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.srv.dds_.__GetMap_Response_)) as nav_msgs.srv.dds_.__GetMap_Response_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new nav_msgs.srv.dds_.__GetMap_Response_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.srv.dds_.__GetMap_Response_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.Sample_GetMap_Response_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.Sample_GetMap_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetMap_Response_ from, System.IntPtr to)
                {
                    __Sample_GetMap_Response_ nativeImg = new __Sample_GetMap_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetMap_Response_ from, ref __Sample_GetMap_Response_ to)
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
                    __Sample_GetMap_Response_ nativeImg = (__Sample_GetMap_Response_) Marshal.PtrToStructure(from, typeof(__Sample_GetMap_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.Sample_GetMap_Response_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.Sample_GetMap_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetMap_Response_ to)
                {
                    __Sample_GetMap_Response_ nativeImg = (__Sample_GetMap_Response_) Marshal.PtrToStructure(from, typeof(__Sample_GetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetMap_Response_ to)
                {
                    __Sample_GetMap_Response_ nativeImg = (__Sample_GetMap_Response_) Marshal.PtrToStructure(from, typeof(__Sample_GetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_GetMap_Response_ from, ref nav_msgs.srv.dds_.Sample_GetMap_Response_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.Sample_GetMap_Response_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    nav_msgs.srv.dds_.__GetMap_Response_Marshaler.CopyOut(ref from.response_, ref to.response_);
                }

            }
            #endregion

        }

    }

}

