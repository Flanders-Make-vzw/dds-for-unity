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
            #region __SetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __SetMap_Request_
            {
                public nav_msgs.msg.dds_.__OccupancyGrid_ map_;
                public geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_ initial_pose_;
            }
            #endregion

            #region __SetMap_Request_Marshaler
            public sealed class __SetMap_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.SetMap_Request_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::SetMap_Request_";
                private nav_msgs.msg.dds_.__OccupancyGrid_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_Marshaler attr1Marshaler;

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
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_)) as geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.SetMap_Request_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.SetMap_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.SetMap_Request_ from, System.IntPtr to)
                {
                    __SetMap_Request_ nativeImg = new __SetMap_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.SetMap_Request_ from, ref __SetMap_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.map_, ref to.map_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.initial_pose_, ref to.initial_pose_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __SetMap_Request_ nativeImg = (__SetMap_Request_) Marshal.PtrToStructure(from, typeof(__SetMap_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.SetMap_Request_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.SetMap_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.SetMap_Request_ to)
                {
                    __SetMap_Request_ nativeImg = (__SetMap_Request_) Marshal.PtrToStructure(from, typeof(__SetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.SetMap_Request_ to)
                {
                    __SetMap_Request_ nativeImg = (__SetMap_Request_) Marshal.PtrToStructure(from, typeof(__SetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __SetMap_Request_ from, ref nav_msgs.srv.dds_.SetMap_Request_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.SetMap_Request_();
                    }
                    nav_msgs.msg.dds_.__OccupancyGrid_Marshaler.CopyOut(ref from.map_, ref to.map_);
                    geometry_msgs.msg.dds_.__PoseWithCovarianceStamped_Marshaler.CopyOut(ref from.initial_pose_, ref to.initial_pose_);
                }

            }
            #endregion

            #region __SetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __SetMap_Response_
            {
                public byte success_;
            }
            #endregion

            #region __SetMap_Response_Marshaler
            public sealed class __SetMap_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.SetMap_Response_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::SetMap_Response_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.SetMap_Response_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.SetMap_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.SetMap_Response_ from, System.IntPtr to)
                {
                    __SetMap_Response_ nativeImg = new __SetMap_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.SetMap_Response_ from, ref __SetMap_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.success_ = from.success_ ? (byte) 1 : (byte) 0;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __SetMap_Response_ nativeImg = (__SetMap_Response_) Marshal.PtrToStructure(from, typeof(__SetMap_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.SetMap_Response_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.SetMap_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.SetMap_Response_ to)
                {
                    __SetMap_Response_ nativeImg = (__SetMap_Response_) Marshal.PtrToStructure(from, typeof(__SetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.SetMap_Response_ to)
                {
                    __SetMap_Response_ nativeImg = (__SetMap_Response_) Marshal.PtrToStructure(from, typeof(__SetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __SetMap_Response_ from, ref nav_msgs.srv.dds_.SetMap_Response_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.SetMap_Response_();
                    }
                    to.success_ = from.success_ != 0 ? true : false;
                }

            }
            #endregion

            #region __Sample_SetMap_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_SetMap_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.__SetMap_Request_ request_;
            }
            #endregion

            #region __Sample_SetMap_Request_Marshaler
            public sealed class __Sample_SetMap_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.Sample_SetMap_Request_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::Sample_SetMap_Request_";
                private nav_msgs.srv.dds_.__SetMap_Request_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.srv.dds_.__SetMap_Request_)) as nav_msgs.srv.dds_.__SetMap_Request_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new nav_msgs.srv.dds_.__SetMap_Request_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.srv.dds_.__SetMap_Request_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.Sample_SetMap_Request_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.Sample_SetMap_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_SetMap_Request_ from, System.IntPtr to)
                {
                    __Sample_SetMap_Request_ nativeImg = new __Sample_SetMap_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_SetMap_Request_ from, ref __Sample_SetMap_Request_ to)
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
                    __Sample_SetMap_Request_ nativeImg = (__Sample_SetMap_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetMap_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.Sample_SetMap_Request_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.Sample_SetMap_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_SetMap_Request_ to)
                {
                    __Sample_SetMap_Request_ nativeImg = (__Sample_SetMap_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_SetMap_Request_ to)
                {
                    __Sample_SetMap_Request_ nativeImg = (__Sample_SetMap_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetMap_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_SetMap_Request_ from, ref nav_msgs.srv.dds_.Sample_SetMap_Request_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.Sample_SetMap_Request_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    nav_msgs.srv.dds_.__SetMap_Request_Marshaler.CopyOut(ref from.request_, ref to.request_);
                }

            }
            #endregion

            #region __Sample_SetMap_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_SetMap_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.__SetMap_Response_ response_;
            }
            #endregion

            #region __Sample_SetMap_Response_Marshaler
            public sealed class __Sample_SetMap_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.Sample_SetMap_Response_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::Sample_SetMap_Response_";
                private nav_msgs.srv.dds_.__SetMap_Response_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.srv.dds_.__SetMap_Response_)) as nav_msgs.srv.dds_.__SetMap_Response_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new nav_msgs.srv.dds_.__SetMap_Response_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.srv.dds_.__SetMap_Response_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.Sample_SetMap_Response_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.Sample_SetMap_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_SetMap_Response_ from, System.IntPtr to)
                {
                    __Sample_SetMap_Response_ nativeImg = new __Sample_SetMap_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_SetMap_Response_ from, ref __Sample_SetMap_Response_ to)
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
                    __Sample_SetMap_Response_ nativeImg = (__Sample_SetMap_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetMap_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.Sample_SetMap_Response_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.Sample_SetMap_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_SetMap_Response_ to)
                {
                    __Sample_SetMap_Response_ nativeImg = (__Sample_SetMap_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_SetMap_Response_ to)
                {
                    __Sample_SetMap_Response_ nativeImg = (__Sample_SetMap_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetMap_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_SetMap_Response_ from, ref nav_msgs.srv.dds_.Sample_SetMap_Response_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.Sample_SetMap_Response_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    nav_msgs.srv.dds_.__SetMap_Response_Marshaler.CopyOut(ref from.response_, ref to.response_);
                }

            }
            #endregion

        }

    }

}

