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
            #region __GetPlan_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __GetPlan_Request_
            {
                public geometry_msgs.msg.dds_.__PoseStamped_ start_;
                public geometry_msgs.msg.dds_.__PoseStamped_ goal_;
                public float tolerance_;
            }
            #endregion

            #region __GetPlan_Request_Marshaler
            public sealed class __GetPlan_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.GetPlan_Request_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::GetPlan_Request_";
                private geometry_msgs.msg.dds_.__PoseStamped_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__PoseStamped_Marshaler attr1Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__PoseStamped_)) as geometry_msgs.msg.dds_.__PoseStamped_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__PoseStamped_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__PoseStamped_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__PoseStamped_)) as geometry_msgs.msg.dds_.__PoseStamped_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__PoseStamped_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__PoseStamped_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.GetPlan_Request_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.GetPlan_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetPlan_Request_ from, System.IntPtr to)
                {
                    __GetPlan_Request_ nativeImg = new __GetPlan_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetPlan_Request_ from, ref __GetPlan_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.start_, ref to.start_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.goal_, ref to.goal_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.tolerance_ = from.tolerance_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __GetPlan_Request_ nativeImg = (__GetPlan_Request_) Marshal.PtrToStructure(from, typeof(__GetPlan_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.GetPlan_Request_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.GetPlan_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetPlan_Request_ to)
                {
                    __GetPlan_Request_ nativeImg = (__GetPlan_Request_) Marshal.PtrToStructure(from, typeof(__GetPlan_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetPlan_Request_ to)
                {
                    __GetPlan_Request_ nativeImg = (__GetPlan_Request_) Marshal.PtrToStructure(from, typeof(__GetPlan_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __GetPlan_Request_ from, ref nav_msgs.srv.dds_.GetPlan_Request_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.GetPlan_Request_();
                    }
                    geometry_msgs.msg.dds_.__PoseStamped_Marshaler.CopyOut(ref from.start_, ref to.start_);
                    geometry_msgs.msg.dds_.__PoseStamped_Marshaler.CopyOut(ref from.goal_, ref to.goal_);
                    to.tolerance_ = from.tolerance_;
                }

            }
            #endregion

            #region __GetPlan_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __GetPlan_Response_
            {
                public nav_msgs.msg.dds_.__Path_ plan_;
            }
            #endregion

            #region __GetPlan_Response_Marshaler
            public sealed class __GetPlan_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.GetPlan_Response_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::GetPlan_Response_";
                private nav_msgs.msg.dds_.__Path_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.msg.dds_.__Path_)) as nav_msgs.msg.dds_.__Path_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new nav_msgs.msg.dds_.__Path_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.msg.dds_.__Path_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.GetPlan_Response_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.GetPlan_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetPlan_Response_ from, System.IntPtr to)
                {
                    __GetPlan_Response_ nativeImg = new __GetPlan_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.GetPlan_Response_ from, ref __GetPlan_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.plan_, ref to.plan_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __GetPlan_Response_ nativeImg = (__GetPlan_Response_) Marshal.PtrToStructure(from, typeof(__GetPlan_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.GetPlan_Response_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.GetPlan_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetPlan_Response_ to)
                {
                    __GetPlan_Response_ nativeImg = (__GetPlan_Response_) Marshal.PtrToStructure(from, typeof(__GetPlan_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.GetPlan_Response_ to)
                {
                    __GetPlan_Response_ nativeImg = (__GetPlan_Response_) Marshal.PtrToStructure(from, typeof(__GetPlan_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __GetPlan_Response_ from, ref nav_msgs.srv.dds_.GetPlan_Response_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.GetPlan_Response_();
                    }
                    nav_msgs.msg.dds_.__Path_Marshaler.CopyOut(ref from.plan_, ref to.plan_);
                }

            }
            #endregion

            #region __Sample_GetPlan_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_GetPlan_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.__GetPlan_Request_ request_;
            }
            #endregion

            #region __Sample_GetPlan_Request_Marshaler
            public sealed class __Sample_GetPlan_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.Sample_GetPlan_Request_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::Sample_GetPlan_Request_";
                private nav_msgs.srv.dds_.__GetPlan_Request_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.srv.dds_.__GetPlan_Request_)) as nav_msgs.srv.dds_.__GetPlan_Request_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new nav_msgs.srv.dds_.__GetPlan_Request_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.srv.dds_.__GetPlan_Request_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.Sample_GetPlan_Request_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.Sample_GetPlan_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetPlan_Request_ from, System.IntPtr to)
                {
                    __Sample_GetPlan_Request_ nativeImg = new __Sample_GetPlan_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetPlan_Request_ from, ref __Sample_GetPlan_Request_ to)
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
                    __Sample_GetPlan_Request_ nativeImg = (__Sample_GetPlan_Request_) Marshal.PtrToStructure(from, typeof(__Sample_GetPlan_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.Sample_GetPlan_Request_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.Sample_GetPlan_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetPlan_Request_ to)
                {
                    __Sample_GetPlan_Request_ nativeImg = (__Sample_GetPlan_Request_) Marshal.PtrToStructure(from, typeof(__Sample_GetPlan_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetPlan_Request_ to)
                {
                    __Sample_GetPlan_Request_ nativeImg = (__Sample_GetPlan_Request_) Marshal.PtrToStructure(from, typeof(__Sample_GetPlan_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_GetPlan_Request_ from, ref nav_msgs.srv.dds_.Sample_GetPlan_Request_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.Sample_GetPlan_Request_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    nav_msgs.srv.dds_.__GetPlan_Request_Marshaler.CopyOut(ref from.request_, ref to.request_);
                }

            }
            #endregion

            #region __Sample_GetPlan_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_GetPlan_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public nav_msgs.srv.dds_.__GetPlan_Response_ response_;
            }
            #endregion

            #region __Sample_GetPlan_Response_Marshaler
            public sealed class __Sample_GetPlan_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.srv.dds_.Sample_GetPlan_Response_>
            {
                public static readonly string fullyScopedName = "nav_msgs::srv::dds_::Sample_GetPlan_Response_";
                private nav_msgs.srv.dds_.__GetPlan_Response_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.srv.dds_.__GetPlan_Response_)) as nav_msgs.srv.dds_.__GetPlan_Response_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new nav_msgs.srv.dds_.__GetPlan_Response_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.srv.dds_.__GetPlan_Response_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.srv.dds_.Sample_GetPlan_Response_ fromData = tmpGCHandle.Target as nav_msgs.srv.dds_.Sample_GetPlan_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetPlan_Response_ from, System.IntPtr to)
                {
                    __Sample_GetPlan_Response_ nativeImg = new __Sample_GetPlan_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.srv.dds_.Sample_GetPlan_Response_ from, ref __Sample_GetPlan_Response_ to)
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
                    __Sample_GetPlan_Response_ nativeImg = (__Sample_GetPlan_Response_) Marshal.PtrToStructure(from, typeof(__Sample_GetPlan_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.srv.dds_.Sample_GetPlan_Response_ toObj = tmpGCHandleTo.Target as nav_msgs.srv.dds_.Sample_GetPlan_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetPlan_Response_ to)
                {
                    __Sample_GetPlan_Response_ nativeImg = (__Sample_GetPlan_Response_) Marshal.PtrToStructure(from, typeof(__Sample_GetPlan_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.srv.dds_.Sample_GetPlan_Response_ to)
                {
                    __Sample_GetPlan_Response_ nativeImg = (__Sample_GetPlan_Response_) Marshal.PtrToStructure(from, typeof(__Sample_GetPlan_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_GetPlan_Response_ from, ref nav_msgs.srv.dds_.Sample_GetPlan_Response_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.srv.dds_.Sample_GetPlan_Response_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    nav_msgs.srv.dds_.__GetPlan_Response_Marshaler.CopyOut(ref from.response_, ref to.response_);
                }

            }
            #endregion

        }

    }

}

