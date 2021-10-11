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
            #region __UInt32_
            [StructLayout(LayoutKind.Sequential)]
            public struct __UInt32_
            {
                public uint data_;
            }
            #endregion

            #region __UInt32_Marshaler
            public sealed class __UInt32_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.UInt32_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::UInt32_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.UInt32_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.UInt32_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.UInt32_ from, System.IntPtr to)
                {
                    __UInt32_ nativeImg = new __UInt32_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.UInt32_ from, ref __UInt32_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.data_ = from.data_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __UInt32_ nativeImg = (__UInt32_) Marshal.PtrToStructure(from, typeof(__UInt32_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.UInt32_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.UInt32_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.UInt32_ to)
                {
                    __UInt32_ nativeImg = (__UInt32_) Marshal.PtrToStructure(from, typeof(__UInt32_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.UInt32_ to)
                {
                    __UInt32_ nativeImg = (__UInt32_) Marshal.PtrToStructure(from, typeof(__UInt32_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __UInt32_ from, ref std_msgs.msg.dds_.UInt32_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.UInt32_();
                    }
                    to.data_ = from.data_;
                }

            }
            #endregion

        }

    }

}

