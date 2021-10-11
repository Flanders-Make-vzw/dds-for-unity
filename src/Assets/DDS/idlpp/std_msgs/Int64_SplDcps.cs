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
            #region __Int64_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Int64_
            {
                public long data_;
            }
            #endregion

            #region __Int64_Marshaler
            public sealed class __Int64_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.Int64_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::Int64_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.Int64_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.Int64_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Int64_ from, System.IntPtr to)
                {
                    __Int64_ nativeImg = new __Int64_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Int64_ from, ref __Int64_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.data_ = from.data_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Int64_ nativeImg = (__Int64_) Marshal.PtrToStructure(from, typeof(__Int64_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.Int64_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.Int64_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Int64_ to)
                {
                    __Int64_ nativeImg = (__Int64_) Marshal.PtrToStructure(from, typeof(__Int64_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Int64_ to)
                {
                    __Int64_ nativeImg = (__Int64_) Marshal.PtrToStructure(from, typeof(__Int64_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Int64_ from, ref std_msgs.msg.dds_.Int64_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.Int64_();
                    }
                    to.data_ = from.data_;
                }

            }
            #endregion

        }

    }

}

