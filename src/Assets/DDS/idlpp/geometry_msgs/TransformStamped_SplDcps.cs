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
            #region __TransformStamped_
            [StructLayout(LayoutKind.Sequential)]
            public struct __TransformStamped_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr child_frame_id_;
                public geometry_msgs.msg.dds_.__Transform_ transform_;
            }
            #endregion

            #region __TransformStamped_Marshaler
            public sealed class __TransformStamped_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.TransformStamped_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::TransformStamped_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Transform_Marshaler attr2Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(std_msgs.msg.dds_.__Header_)) as std_msgs.msg.dds_.__Header_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new std_msgs.msg.dds_.__Header_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(std_msgs.msg.dds_.__Header_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr2Marshaler == null) {
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Transform_)) as geometry_msgs.msg.dds_.__Transform_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new geometry_msgs.msg.dds_.__Transform_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Transform_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.TransformStamped_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.TransformStamped_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.TransformStamped_ from, System.IntPtr to)
                {
                    __TransformStamped_ nativeImg = new __TransformStamped_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.TransformStamped_ from, ref __TransformStamped_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.child_frame_id_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.child_frame_id_, from.child_frame_id_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    {
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.transform_, ref to.transform_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __TransformStamped_ nativeImg = (__TransformStamped_) Marshal.PtrToStructure(from, typeof(__TransformStamped_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.TransformStamped_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.TransformStamped_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.TransformStamped_ to)
                {
                    __TransformStamped_ nativeImg = (__TransformStamped_) Marshal.PtrToStructure(from, typeof(__TransformStamped_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.TransformStamped_ to)
                {
                    __TransformStamped_ nativeImg = (__TransformStamped_) Marshal.PtrToStructure(from, typeof(__TransformStamped_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __TransformStamped_ from, ref geometry_msgs.msg.dds_.TransformStamped_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.TransformStamped_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.child_frame_id_ = ReadString(from.child_frame_id_);
                    geometry_msgs.msg.dds_.__Transform_Marshaler.CopyOut(ref from.transform_, ref to.transform_);
                }

            }
            #endregion

        }

    }

}

