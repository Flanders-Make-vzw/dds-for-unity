using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __MapMetaData_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MapMetaData_
            {
                public builtin_interfaces.msg.dds_.__Time_ map_load_time_;
                public float resolution_;
                public uint width_;
                public uint height_;
                public geometry_msgs.msg.dds_.__Pose_ origin_;
            }
            #endregion

            #region __MapMetaData_Marshaler
            public sealed class __MapMetaData_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.msg.dds_.MapMetaData_>
            {
                public static readonly string fullyScopedName = "nav_msgs::msg::dds_::MapMetaData_";
                private builtin_interfaces.msg.dds_.__Time_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Pose_Marshaler attr4Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(builtin_interfaces.msg.dds_.__Time_)) as builtin_interfaces.msg.dds_.__Time_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new builtin_interfaces.msg.dds_.__Time_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(builtin_interfaces.msg.dds_.__Time_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr4Marshaler == null) {
                        attr4Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Pose_)) as geometry_msgs.msg.dds_.__Pose_Marshaler;
                        if (attr4Marshaler == null) {
                            attr4Marshaler = new geometry_msgs.msg.dds_.__Pose_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Pose_), attr4Marshaler);
                            attr4Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.msg.dds_.MapMetaData_ fromData = tmpGCHandle.Target as nav_msgs.msg.dds_.MapMetaData_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.MapMetaData_ from, System.IntPtr to)
                {
                    __MapMetaData_ nativeImg = new __MapMetaData_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.MapMetaData_ from, ref __MapMetaData_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.map_load_time_, ref to.map_load_time_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.resolution_ = from.resolution_;
                    to.width_ = from.width_;
                    to.height_ = from.height_;
                    {
                        V_COPYIN_RESULT result = attr4Marshaler.CopyIn(typePtr, from.origin_, ref to.origin_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MapMetaData_ nativeImg = (__MapMetaData_) Marshal.PtrToStructure(from, typeof(__MapMetaData_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.msg.dds_.MapMetaData_ toObj = tmpGCHandleTo.Target as nav_msgs.msg.dds_.MapMetaData_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.MapMetaData_ to)
                {
                    __MapMetaData_ nativeImg = (__MapMetaData_) Marshal.PtrToStructure(from, typeof(__MapMetaData_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.MapMetaData_ to)
                {
                    __MapMetaData_ nativeImg = (__MapMetaData_) Marshal.PtrToStructure(from, typeof(__MapMetaData_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MapMetaData_ from, ref nav_msgs.msg.dds_.MapMetaData_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.msg.dds_.MapMetaData_();
                    }
                    builtin_interfaces.msg.dds_.__Time_Marshaler.CopyOut(ref from.map_load_time_, ref to.map_load_time_);
                    to.resolution_ = from.resolution_;
                    to.width_ = from.width_;
                    to.height_ = from.height_;
                    geometry_msgs.msg.dds_.__Pose_Marshaler.CopyOut(ref from.origin_, ref to.origin_);
                }

            }
            #endregion

        }

    }

}

