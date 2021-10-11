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
            #region __MultiArrayDimension_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MultiArrayDimension_
            {
                public IntPtr label_;
                public uint size_;
                public uint stride_;
            }
            #endregion

            #region __MultiArrayDimension_Marshaler
            public sealed class __MultiArrayDimension_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.MultiArrayDimension_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::MultiArrayDimension_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.MultiArrayDimension_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.MultiArrayDimension_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.MultiArrayDimension_ from, System.IntPtr to)
                {
                    __MultiArrayDimension_ nativeImg = new __MultiArrayDimension_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.MultiArrayDimension_ from, ref __MultiArrayDimension_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.label_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.label_, from.label_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.size_ = from.size_;
                    to.stride_ = from.stride_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MultiArrayDimension_ nativeImg = (__MultiArrayDimension_) Marshal.PtrToStructure(from, typeof(__MultiArrayDimension_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.MultiArrayDimension_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.MultiArrayDimension_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.MultiArrayDimension_ to)
                {
                    __MultiArrayDimension_ nativeImg = (__MultiArrayDimension_) Marshal.PtrToStructure(from, typeof(__MultiArrayDimension_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.MultiArrayDimension_ to)
                {
                    __MultiArrayDimension_ nativeImg = (__MultiArrayDimension_) Marshal.PtrToStructure(from, typeof(__MultiArrayDimension_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MultiArrayDimension_ from, ref std_msgs.msg.dds_.MultiArrayDimension_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.MultiArrayDimension_();
                    }
                    to.label_ = ReadString(from.label_);
                    to.size_ = from.size_;
                    to.stride_ = from.stride_;
                }

            }
            #endregion

        }

    }

}

