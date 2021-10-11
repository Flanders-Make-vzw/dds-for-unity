using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region __SetPen_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __SetPen_Request_
            {
                public byte r_;
                public byte g_;
                public byte b_;
                public byte width_;
                public byte off_;
            }
            #endregion

            #region __SetPen_Request_Marshaler
            public sealed class __SetPen_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<turtlesim.srv.dds_.SetPen_Request_>
            {
                public static readonly string fullyScopedName = "turtlesim::srv::dds_::SetPen_Request_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    turtlesim.srv.dds_.SetPen_Request_ fromData = tmpGCHandle.Target as turtlesim.srv.dds_.SetPen_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.SetPen_Request_ from, System.IntPtr to)
                {
                    __SetPen_Request_ nativeImg = new __SetPen_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.SetPen_Request_ from, ref __SetPen_Request_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.r_ = from.r_;
                    to.g_ = from.g_;
                    to.b_ = from.b_;
                    to.width_ = from.width_;
                    to.off_ = from.off_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __SetPen_Request_ nativeImg = (__SetPen_Request_) Marshal.PtrToStructure(from, typeof(__SetPen_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    turtlesim.srv.dds_.SetPen_Request_ toObj = tmpGCHandleTo.Target as turtlesim.srv.dds_.SetPen_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref turtlesim.srv.dds_.SetPen_Request_ to)
                {
                    __SetPen_Request_ nativeImg = (__SetPen_Request_) Marshal.PtrToStructure(from, typeof(__SetPen_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref turtlesim.srv.dds_.SetPen_Request_ to)
                {
                    __SetPen_Request_ nativeImg = (__SetPen_Request_) Marshal.PtrToStructure(from, typeof(__SetPen_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __SetPen_Request_ from, ref turtlesim.srv.dds_.SetPen_Request_ to)
                {
                    if (to == null) {
                        to = new turtlesim.srv.dds_.SetPen_Request_();
                    }
                    to.r_ = from.r_;
                    to.g_ = from.g_;
                    to.b_ = from.b_;
                    to.width_ = from.width_;
                    to.off_ = from.off_;
                }

            }
            #endregion

            #region __SetPen_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __SetPen_Response_
            {
                public byte structure_needs_at_least_one_member_;
            }
            #endregion

            #region __SetPen_Response_Marshaler
            public sealed class __SetPen_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<turtlesim.srv.dds_.SetPen_Response_>
            {
                public static readonly string fullyScopedName = "turtlesim::srv::dds_::SetPen_Response_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    turtlesim.srv.dds_.SetPen_Response_ fromData = tmpGCHandle.Target as turtlesim.srv.dds_.SetPen_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.SetPen_Response_ from, System.IntPtr to)
                {
                    __SetPen_Response_ nativeImg = new __SetPen_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.SetPen_Response_ from, ref __SetPen_Response_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.structure_needs_at_least_one_member_ = from.structure_needs_at_least_one_member_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __SetPen_Response_ nativeImg = (__SetPen_Response_) Marshal.PtrToStructure(from, typeof(__SetPen_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    turtlesim.srv.dds_.SetPen_Response_ toObj = tmpGCHandleTo.Target as turtlesim.srv.dds_.SetPen_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref turtlesim.srv.dds_.SetPen_Response_ to)
                {
                    __SetPen_Response_ nativeImg = (__SetPen_Response_) Marshal.PtrToStructure(from, typeof(__SetPen_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref turtlesim.srv.dds_.SetPen_Response_ to)
                {
                    __SetPen_Response_ nativeImg = (__SetPen_Response_) Marshal.PtrToStructure(from, typeof(__SetPen_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __SetPen_Response_ from, ref turtlesim.srv.dds_.SetPen_Response_ to)
                {
                    if (to == null) {
                        to = new turtlesim.srv.dds_.SetPen_Response_();
                    }
                    to.structure_needs_at_least_one_member_ = from.structure_needs_at_least_one_member_;
                }

            }
            #endregion

            #region __Sample_SetPen_Request_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_SetPen_Request_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.__SetPen_Request_ request_;
            }
            #endregion

            #region __Sample_SetPen_Request_Marshaler
            public sealed class __Sample_SetPen_Request_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<turtlesim.srv.dds_.Sample_SetPen_Request_>
            {
                public static readonly string fullyScopedName = "turtlesim::srv::dds_::Sample_SetPen_Request_";
                private turtlesim.srv.dds_.__SetPen_Request_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(turtlesim.srv.dds_.__SetPen_Request_)) as turtlesim.srv.dds_.__SetPen_Request_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new turtlesim.srv.dds_.__SetPen_Request_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(turtlesim.srv.dds_.__SetPen_Request_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    turtlesim.srv.dds_.Sample_SetPen_Request_ fromData = tmpGCHandle.Target as turtlesim.srv.dds_.Sample_SetPen_Request_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.Sample_SetPen_Request_ from, System.IntPtr to)
                {
                    __Sample_SetPen_Request_ nativeImg = new __Sample_SetPen_Request_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.Sample_SetPen_Request_ from, ref __Sample_SetPen_Request_ to)
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
                    __Sample_SetPen_Request_ nativeImg = (__Sample_SetPen_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetPen_Request_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    turtlesim.srv.dds_.Sample_SetPen_Request_ toObj = tmpGCHandleTo.Target as turtlesim.srv.dds_.Sample_SetPen_Request_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref turtlesim.srv.dds_.Sample_SetPen_Request_ to)
                {
                    __Sample_SetPen_Request_ nativeImg = (__Sample_SetPen_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetPen_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref turtlesim.srv.dds_.Sample_SetPen_Request_ to)
                {
                    __Sample_SetPen_Request_ nativeImg = (__Sample_SetPen_Request_) Marshal.PtrToStructure(from, typeof(__Sample_SetPen_Request_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_SetPen_Request_ from, ref turtlesim.srv.dds_.Sample_SetPen_Request_ to)
                {
                    if (to == null) {
                        to = new turtlesim.srv.dds_.Sample_SetPen_Request_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    turtlesim.srv.dds_.__SetPen_Request_Marshaler.CopyOut(ref from.request_, ref to.request_);
                }

            }
            #endregion

            #region __Sample_SetPen_Response_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Sample_SetPen_Response_
            {
                public ulong client_guid_0_;
                public ulong client_guid_1_;
                public long sequence_number_;
                public turtlesim.srv.dds_.__SetPen_Response_ response_;
            }
            #endregion

            #region __Sample_SetPen_Response_Marshaler
            public sealed class __Sample_SetPen_Response_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<turtlesim.srv.dds_.Sample_SetPen_Response_>
            {
                public static readonly string fullyScopedName = "turtlesim::srv::dds_::Sample_SetPen_Response_";
                private turtlesim.srv.dds_.__SetPen_Response_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(turtlesim.srv.dds_.__SetPen_Response_)) as turtlesim.srv.dds_.__SetPen_Response_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new turtlesim.srv.dds_.__SetPen_Response_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(turtlesim.srv.dds_.__SetPen_Response_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    turtlesim.srv.dds_.Sample_SetPen_Response_ fromData = tmpGCHandle.Target as turtlesim.srv.dds_.Sample_SetPen_Response_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.Sample_SetPen_Response_ from, System.IntPtr to)
                {
                    __Sample_SetPen_Response_ nativeImg = new __Sample_SetPen_Response_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.srv.dds_.Sample_SetPen_Response_ from, ref __Sample_SetPen_Response_ to)
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
                    __Sample_SetPen_Response_ nativeImg = (__Sample_SetPen_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetPen_Response_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    turtlesim.srv.dds_.Sample_SetPen_Response_ toObj = tmpGCHandleTo.Target as turtlesim.srv.dds_.Sample_SetPen_Response_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref turtlesim.srv.dds_.Sample_SetPen_Response_ to)
                {
                    __Sample_SetPen_Response_ nativeImg = (__Sample_SetPen_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetPen_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref turtlesim.srv.dds_.Sample_SetPen_Response_ to)
                {
                    __Sample_SetPen_Response_ nativeImg = (__Sample_SetPen_Response_) Marshal.PtrToStructure(from, typeof(__Sample_SetPen_Response_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Sample_SetPen_Response_ from, ref turtlesim.srv.dds_.Sample_SetPen_Response_ to)
                {
                    if (to == null) {
                        to = new turtlesim.srv.dds_.Sample_SetPen_Response_();
                    }
                    to.client_guid_0_ = from.client_guid_0_;
                    to.client_guid_1_ = from.client_guid_1_;
                    to.sequence_number_ = from.sequence_number_;
                    turtlesim.srv.dds_.__SetPen_Response_Marshaler.CopyOut(ref from.response_, ref to.response_);
                }

            }
            #endregion

        }

    }

}

