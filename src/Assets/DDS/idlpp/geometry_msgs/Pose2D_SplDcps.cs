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
            #region __Pose2D_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Pose2D_
            {
                public double x_;
                public double y_;
                public double theta_;
            }
            #endregion

            #region __Pose2D_Marshaler
            public sealed class __Pose2D_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Pose2D_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Pose2D_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Pose2D_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Pose2D_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Pose2D_ from, System.IntPtr to)
                {
                    __Pose2D_ nativeImg = new __Pose2D_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Pose2D_ from, ref __Pose2D_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.theta_ = from.theta_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Pose2D_ nativeImg = (__Pose2D_) Marshal.PtrToStructure(from, typeof(__Pose2D_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Pose2D_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Pose2D_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Pose2D_ to)
                {
                    __Pose2D_ nativeImg = (__Pose2D_) Marshal.PtrToStructure(from, typeof(__Pose2D_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Pose2D_ to)
                {
                    __Pose2D_ nativeImg = (__Pose2D_) Marshal.PtrToStructure(from, typeof(__Pose2D_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Pose2D_ from, ref geometry_msgs.msg.dds_.Pose2D_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Pose2D_();
                    }
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.theta_ = from.theta_;
                }

            }
            #endregion

        }

    }

}

