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
            #region __Pose_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Pose_
            {
                public geometry_msgs.msg.dds_.__Point_ position_;
                public geometry_msgs.msg.dds_.__Quaternion_ orientation_;
            }
            #endregion

            #region __Pose_Marshaler
            public sealed class __Pose_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Pose_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Pose_";
                private geometry_msgs.msg.dds_.__Point_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Quaternion_Marshaler attr1Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Point_)) as geometry_msgs.msg.dds_.__Point_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__Point_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Point_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Quaternion_)) as geometry_msgs.msg.dds_.__Quaternion_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Quaternion_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Quaternion_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Pose_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Pose_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Pose_ from, System.IntPtr to)
                {
                    __Pose_ nativeImg = new __Pose_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Pose_ from, ref __Pose_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.position_, ref to.position_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.orientation_, ref to.orientation_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Pose_ nativeImg = (__Pose_) Marshal.PtrToStructure(from, typeof(__Pose_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Pose_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Pose_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Pose_ to)
                {
                    __Pose_ nativeImg = (__Pose_) Marshal.PtrToStructure(from, typeof(__Pose_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Pose_ to)
                {
                    __Pose_ nativeImg = (__Pose_) Marshal.PtrToStructure(from, typeof(__Pose_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Pose_ from, ref geometry_msgs.msg.dds_.Pose_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Pose_();
                    }
                    geometry_msgs.msg.dds_.__Point_Marshaler.CopyOut(ref from.position_, ref to.position_);
                    geometry_msgs.msg.dds_.__Quaternion_Marshaler.CopyOut(ref from.orientation_, ref to.orientation_);
                }

            }
            #endregion

        }

    }

}

