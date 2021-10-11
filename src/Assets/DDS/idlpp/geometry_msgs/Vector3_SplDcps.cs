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
            #region __Vector3_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Vector3_
            {
                public double x_;
                public double y_;
                public double z_;
            }
            #endregion

            #region __Vector3_Marshaler
            public sealed class __Vector3_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Vector3_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Vector3_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Vector3_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Vector3_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Vector3_ from, System.IntPtr to)
                {
                    __Vector3_ nativeImg = new __Vector3_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Vector3_ from, ref __Vector3_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.z_ = from.z_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Vector3_ nativeImg = (__Vector3_) Marshal.PtrToStructure(from, typeof(__Vector3_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Vector3_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Vector3_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Vector3_ to)
                {
                    __Vector3_ nativeImg = (__Vector3_) Marshal.PtrToStructure(from, typeof(__Vector3_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Vector3_ to)
                {
                    __Vector3_ nativeImg = (__Vector3_) Marshal.PtrToStructure(from, typeof(__Vector3_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Vector3_ from, ref geometry_msgs.msg.dds_.Vector3_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Vector3_();
                    }
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.z_ = from.z_;
                }

            }
            #endregion

        }

    }

}

