using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace msg
    {
        namespace dds_
        {
            #region __Pose_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Pose_
            {
                public float x_;
                public float y_;
                public float theta_;
                public float linear_velocity_;
                public float angular_velocity_;
            }
            #endregion

            #region __Pose_Marshaler
            public sealed class __Pose_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<turtlesim.msg.dds_.Pose_>
            {
                public static readonly string fullyScopedName = "turtlesim::msg::dds_::Pose_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    turtlesim.msg.dds_.Pose_ fromData = tmpGCHandle.Target as turtlesim.msg.dds_.Pose_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.msg.dds_.Pose_ from, System.IntPtr to)
                {
                    __Pose_ nativeImg = new __Pose_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.msg.dds_.Pose_ from, ref __Pose_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.theta_ = from.theta_;
                    to.linear_velocity_ = from.linear_velocity_;
                    to.angular_velocity_ = from.angular_velocity_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Pose_ nativeImg = (__Pose_) Marshal.PtrToStructure(from, typeof(__Pose_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    turtlesim.msg.dds_.Pose_ toObj = tmpGCHandleTo.Target as turtlesim.msg.dds_.Pose_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref turtlesim.msg.dds_.Pose_ to)
                {
                    __Pose_ nativeImg = (__Pose_) Marshal.PtrToStructure(from, typeof(__Pose_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref turtlesim.msg.dds_.Pose_ to)
                {
                    __Pose_ nativeImg = (__Pose_) Marshal.PtrToStructure(from, typeof(__Pose_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Pose_ from, ref turtlesim.msg.dds_.Pose_ to)
                {
                    if (to == null) {
                        to = new turtlesim.msg.dds_.Pose_();
                    }
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.theta_ = from.theta_;
                    to.linear_velocity_ = from.linear_velocity_;
                    to.angular_velocity_ = from.angular_velocity_;
                }

            }
            #endregion

        }

    }

}

