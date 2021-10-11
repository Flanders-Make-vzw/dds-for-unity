using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace builtin_interfaces
{
    namespace msg
    {
        namespace dds_
        {
            #region __Duration_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Duration_
            {
                public int sec_;
                public uint nanosec_;
            }
            #endregion

            #region __Duration_Marshaler
            public sealed class __Duration_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<builtin_interfaces.msg.dds_.Duration_>
            {
                public static readonly string fullyScopedName = "builtin_interfaces::msg::dds_::Duration_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    builtin_interfaces.msg.dds_.Duration_ fromData = tmpGCHandle.Target as builtin_interfaces.msg.dds_.Duration_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, builtin_interfaces.msg.dds_.Duration_ from, System.IntPtr to)
                {
                    __Duration_ nativeImg = new __Duration_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, builtin_interfaces.msg.dds_.Duration_ from, ref __Duration_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.sec_ = from.sec_;
                    to.nanosec_ = from.nanosec_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Duration_ nativeImg = (__Duration_) Marshal.PtrToStructure(from, typeof(__Duration_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    builtin_interfaces.msg.dds_.Duration_ toObj = tmpGCHandleTo.Target as builtin_interfaces.msg.dds_.Duration_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref builtin_interfaces.msg.dds_.Duration_ to)
                {
                    __Duration_ nativeImg = (__Duration_) Marshal.PtrToStructure(from, typeof(__Duration_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref builtin_interfaces.msg.dds_.Duration_ to)
                {
                    __Duration_ nativeImg = (__Duration_) Marshal.PtrToStructure(from, typeof(__Duration_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Duration_ from, ref builtin_interfaces.msg.dds_.Duration_ to)
                {
                    if (to == null) {
                        to = new builtin_interfaces.msg.dds_.Duration_();
                    }
                    to.sec_ = from.sec_;
                    to.nanosec_ = from.nanosec_;
                }

            }
            #endregion

        }

    }

}

