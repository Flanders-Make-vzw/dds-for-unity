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
            #region __Point32_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Point32_
            {
                public float x_;
                public float y_;
                public float z_;
            }
            #endregion

            #region __Point32_Marshaler
            public sealed class __Point32_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Point32_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Point32_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Point32_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Point32_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Point32_ from, System.IntPtr to)
                {
                    __Point32_ nativeImg = new __Point32_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Point32_ from, ref __Point32_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.x_ = from.x_;
                    to.y_ = from.y_;
                    to.z_ = from.z_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Point32_ nativeImg = (__Point32_) Marshal.PtrToStructure(from, typeof(__Point32_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Point32_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Point32_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Point32_ to)
                {
                    __Point32_ nativeImg = (__Point32_) Marshal.PtrToStructure(from, typeof(__Point32_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Point32_ to)
                {
                    __Point32_ nativeImg = (__Point32_) Marshal.PtrToStructure(from, typeof(__Point32_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Point32_ from, ref geometry_msgs.msg.dds_.Point32_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Point32_();
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

