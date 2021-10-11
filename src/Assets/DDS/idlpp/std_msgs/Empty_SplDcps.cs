using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __Empty_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Empty_
            {
                public byte structure_needs_at_least_one_member_;
            }
            #endregion

            #region __Empty_Marshaler
            public sealed class __Empty_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.Empty_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::Empty_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.Empty_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.Empty_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Empty_ from, System.IntPtr to)
                {
                    __Empty_ nativeImg = new __Empty_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Empty_ from, ref __Empty_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.structure_needs_at_least_one_member_ = from.structure_needs_at_least_one_member_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Empty_ nativeImg = (__Empty_) Marshal.PtrToStructure(from, typeof(__Empty_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.Empty_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.Empty_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Empty_ to)
                {
                    __Empty_ nativeImg = (__Empty_) Marshal.PtrToStructure(from, typeof(__Empty_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Empty_ to)
                {
                    __Empty_ nativeImg = (__Empty_) Marshal.PtrToStructure(from, typeof(__Empty_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Empty_ from, ref std_msgs.msg.dds_.Empty_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.Empty_();
                    }
                    to.structure_needs_at_least_one_member_ = from.structure_needs_at_least_one_member_;
                }

            }
            #endregion

        }

    }

}

