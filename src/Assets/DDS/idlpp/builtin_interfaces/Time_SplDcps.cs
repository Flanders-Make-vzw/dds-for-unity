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
            #region __Time_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Time_
            {
                public int sec_;
                public uint nanosec_;
            }
            #endregion

            #region __Time_Marshaler
            public sealed class __Time_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<builtin_interfaces.msg.dds_.Time_>
            {
                public static readonly string fullyScopedName = "builtin_interfaces::msg::dds_::Time_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    builtin_interfaces.msg.dds_.Time_ fromData = tmpGCHandle.Target as builtin_interfaces.msg.dds_.Time_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, builtin_interfaces.msg.dds_.Time_ from, System.IntPtr to)
                {
                    __Time_ nativeImg = new __Time_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, builtin_interfaces.msg.dds_.Time_ from, ref __Time_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.sec_ = from.sec_;
                    to.nanosec_ = from.nanosec_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Time_ nativeImg = (__Time_) Marshal.PtrToStructure(from, typeof(__Time_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    builtin_interfaces.msg.dds_.Time_ toObj = tmpGCHandleTo.Target as builtin_interfaces.msg.dds_.Time_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref builtin_interfaces.msg.dds_.Time_ to)
                {
                    __Time_ nativeImg = (__Time_) Marshal.PtrToStructure(from, typeof(__Time_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref builtin_interfaces.msg.dds_.Time_ to)
                {
                    __Time_ nativeImg = (__Time_) Marshal.PtrToStructure(from, typeof(__Time_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Time_ from, ref builtin_interfaces.msg.dds_.Time_ to)
                {
                    if (to == null) {
                        to = new builtin_interfaces.msg.dds_.Time_();
                    }
                    to.sec_ = from.sec_;
                    to.nanosec_ = from.nanosec_;
                }

            }
            #endregion

        }

    }

}

