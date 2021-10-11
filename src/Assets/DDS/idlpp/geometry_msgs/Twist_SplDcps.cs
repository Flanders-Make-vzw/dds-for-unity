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
            #region __Twist_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Twist_
            {
                public geometry_msgs.msg.dds_.__Vector3_ linear_;
                public geometry_msgs.msg.dds_.__Vector3_ angular_;
            }
            #endregion

            #region __Twist_Marshaler
            public sealed class __Twist_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Twist_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Twist_";
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
                    geometry_msgs.msg.dds_.Twist_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Twist_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Twist_ from, System.IntPtr to)
                {
                    __Twist_ nativeImg = new __Twist_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Twist_ from, ref __Twist_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.linear_, ref to.linear_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.angular_, ref to.angular_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Twist_ nativeImg = (__Twist_) Marshal.PtrToStructure(from, typeof(__Twist_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Twist_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Twist_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Twist_ to)
                {
                    __Twist_ nativeImg = (__Twist_) Marshal.PtrToStructure(from, typeof(__Twist_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Twist_ to)
                {
                    __Twist_ nativeImg = (__Twist_) Marshal.PtrToStructure(from, typeof(__Twist_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Twist_ from, ref geometry_msgs.msg.dds_.Twist_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Twist_();
                    }
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.linear_, ref to.linear_);
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.angular_, ref to.angular_);
                }

            }
            #endregion

        }

    }

}

