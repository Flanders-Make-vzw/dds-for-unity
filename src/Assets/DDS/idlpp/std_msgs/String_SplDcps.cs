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
            #region __String_
            [StructLayout(LayoutKind.Sequential)]
            public struct __String_
            {
                public IntPtr data_;
            }
            #endregion

            #region __String_Marshaler
            public sealed class __String_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.String_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::String_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.String_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.String_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.String_ from, System.IntPtr to)
                {
                    __String_ nativeImg = new __String_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.String_ from, ref __String_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.data_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.data_, from.data_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __String_ nativeImg = (__String_) Marshal.PtrToStructure(from, typeof(__String_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.String_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.String_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.String_ to)
                {
                    __String_ nativeImg = (__String_) Marshal.PtrToStructure(from, typeof(__String_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.String_ to)
                {
                    __String_ nativeImg = (__String_) Marshal.PtrToStructure(from, typeof(__String_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __String_ from, ref std_msgs.msg.dds_.String_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.String_();
                    }
                    to.data_ = ReadString(from.data_);
                }

            }
            #endregion

        }

    }

}

