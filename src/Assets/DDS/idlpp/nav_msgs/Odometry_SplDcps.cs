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
            #region __Odometry_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Odometry_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr child_frame_id_;
                public geometry_msgs.msg.dds_.__PoseWithCovariance_ pose_;
                public geometry_msgs.msg.dds_.__TwistWithCovariance_ twist_;
            }
            #endregion

            #region __Odometry_Marshaler
            public sealed class __Odometry_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.msg.dds_.Odometry_>
            {
                public static readonly string fullyScopedName = "nav_msgs::msg::dds_::Odometry_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__PoseWithCovariance_Marshaler attr2Marshaler;
                private geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler attr3Marshaler;

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
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__PoseWithCovariance_)) as geometry_msgs.msg.dds_.__PoseWithCovariance_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new geometry_msgs.msg.dds_.__PoseWithCovariance_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__PoseWithCovariance_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__TwistWithCovariance_)) as geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__TwistWithCovariance_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.msg.dds_.Odometry_ fromData = tmpGCHandle.Target as nav_msgs.msg.dds_.Odometry_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.Odometry_ from, System.IntPtr to)
                {
                    __Odometry_ nativeImg = new __Odometry_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.Odometry_ from, ref __Odometry_ to)
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
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.pose_, ref to.pose_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.twist_, ref to.twist_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Odometry_ nativeImg = (__Odometry_) Marshal.PtrToStructure(from, typeof(__Odometry_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.msg.dds_.Odometry_ toObj = tmpGCHandleTo.Target as nav_msgs.msg.dds_.Odometry_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.Odometry_ to)
                {
                    __Odometry_ nativeImg = (__Odometry_) Marshal.PtrToStructure(from, typeof(__Odometry_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.Odometry_ to)
                {
                    __Odometry_ nativeImg = (__Odometry_) Marshal.PtrToStructure(from, typeof(__Odometry_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Odometry_ from, ref nav_msgs.msg.dds_.Odometry_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.msg.dds_.Odometry_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.child_frame_id_ = ReadString(from.child_frame_id_);
                    geometry_msgs.msg.dds_.__PoseWithCovariance_Marshaler.CopyOut(ref from.pose_, ref to.pose_);
                    geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler.CopyOut(ref from.twist_, ref to.twist_);
                }

            }
            #endregion

        }

    }

}

