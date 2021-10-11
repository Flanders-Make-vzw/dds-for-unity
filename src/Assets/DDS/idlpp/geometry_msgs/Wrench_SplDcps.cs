using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __Wrench_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Wrench_
            {
                public geometry_msgs.msg.dds_.__Vector3_ force_;
                public geometry_msgs.msg.dds_.__Vector3_ torque_;
            }
            #endregion

            #region __Wrench_Marshaler
            public sealed class __Wrench_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Wrench_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Wrench_";
                private geometry_msgs.msg.dds_.__Vector3_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Vector3_Marshaler attr1Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Vector3_)) as geometry_msgs.msg.dds_.__Vector3_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__Vector3_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Vector3_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Vector3_)) as geometry_msgs.msg.dds_.__Vector3_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Vector3_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Vector3_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Wrench_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Wrench_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Wrench_ from, System.IntPtr to)
                {
                    __Wrench_ nativeImg = new __Wrench_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Wrench_ from, ref __Wrench_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.force_, ref to.force_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.torque_, ref to.torque_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Wrench_ nativeImg = (__Wrench_) Marshal.PtrToStructure(from, typeof(__Wrench_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Wrench_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Wrench_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Wrench_ to)
                {
                    __Wrench_ nativeImg = (__Wrench_) Marshal.PtrToStructure(from, typeof(__Wrench_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Wrench_ to)
                {
                    __Wrench_ nativeImg = (__Wrench_) Marshal.PtrToStructure(from, typeof(__Wrench_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Wrench_ from, ref geometry_msgs.msg.dds_.Wrench_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Wrench_();
                    }
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.force_, ref to.force_);
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.torque_, ref to.torque_);
                }

            }
            #endregion

        }

    }

}

