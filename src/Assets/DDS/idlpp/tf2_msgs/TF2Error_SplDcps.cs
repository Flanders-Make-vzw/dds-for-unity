using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace tf2_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace TF2Error_Constants
            {
            }

            #region __TF2Error_
            [StructLayout(LayoutKind.Sequential)]
            public struct __TF2Error_
            {
                public byte error_;
                public IntPtr error_string_;
            }
            #endregion

            #region __TF2Error_Marshaler
            public sealed class __TF2Error_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<tf2_msgs.msg.dds_.TF2Error_>
            {
                public static readonly string fullyScopedName = "tf2_msgs::msg::dds_::TF2Error_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    tf2_msgs.msg.dds_.TF2Error_ fromData = tmpGCHandle.Target as tf2_msgs.msg.dds_.TF2Error_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, tf2_msgs.msg.dds_.TF2Error_ from, System.IntPtr to)
                {
                    __TF2Error_ nativeImg = new __TF2Error_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, tf2_msgs.msg.dds_.TF2Error_ from, ref __TF2Error_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.error_ = from.error_;
                    if (from.error_string_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.error_string_, from.error_string_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __TF2Error_ nativeImg = (__TF2Error_) Marshal.PtrToStructure(from, typeof(__TF2Error_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    tf2_msgs.msg.dds_.TF2Error_ toObj = tmpGCHandleTo.Target as tf2_msgs.msg.dds_.TF2Error_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref tf2_msgs.msg.dds_.TF2Error_ to)
                {
                    __TF2Error_ nativeImg = (__TF2Error_) Marshal.PtrToStructure(from, typeof(__TF2Error_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref tf2_msgs.msg.dds_.TF2Error_ to)
                {
                    __TF2Error_ nativeImg = (__TF2Error_) Marshal.PtrToStructure(from, typeof(__TF2Error_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __TF2Error_ from, ref tf2_msgs.msg.dds_.TF2Error_ to)
                {
                    if (to == null) {
                        to = new tf2_msgs.msg.dds_.TF2Error_();
                    }
                    to.error_ = from.error_;
                    to.error_string_ = ReadString(from.error_string_);
                }

            }
            #endregion

        }

    }

}

