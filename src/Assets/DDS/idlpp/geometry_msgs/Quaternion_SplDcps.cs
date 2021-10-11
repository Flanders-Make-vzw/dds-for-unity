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
            #region __Quaternion_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Quaternion_
            {
                public double x_;
                public double y_;
                public double z_;
                public double w_;
            }
            #endregion

            #region __Quaternion_Marshaler
            public sealed class __Quaternion_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Quaternion_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Quaternion_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Quaternion_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Quaternion_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Quaternion_ from, System.IntPtr to)
                {
                    __Quaternion_ nativeImg = new __Quaternion_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Quaternion_ from, ref __Quaternion_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.z_ = from.z_;
                    to.w_ = from.w_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Quaternion_ nativeImg = (__Quaternion_) Marshal.PtrToStructure(from, typeof(__Quaternion_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Quaternion_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Quaternion_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Quaternion_ to)
                {
                    __Quaternion_ nativeImg = (__Quaternion_) Marshal.PtrToStructure(from, typeof(__Quaternion_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Quaternion_ to)
                {
                    __Quaternion_ nativeImg = (__Quaternion_) Marshal.PtrToStructure(from, typeof(__Quaternion_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Quaternion_ from, ref geometry_msgs.msg.dds_.Quaternion_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Quaternion_();
                    }
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.z_ = from.z_;
                    to.w_ = from.w_;
                }

            }
            #endregion

        }

    }

}

