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
            #region __Bool_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Bool_
            {
                public byte data_;
            }
            #endregion

            #region __Bool_Marshaler
            public sealed class __Bool_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.Bool_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::Bool_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.Bool_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.Bool_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Bool_ from, System.IntPtr to)
                {
                    __Bool_ nativeImg = new __Bool_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Bool_ from, ref __Bool_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.data_ = from.data_ ? (byte) 1 : (byte) 0;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Bool_ nativeImg = (__Bool_) Marshal.PtrToStructure(from, typeof(__Bool_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.Bool_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.Bool_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Bool_ to)
                {
                    __Bool_ nativeImg = (__Bool_) Marshal.PtrToStructure(from, typeof(__Bool_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Bool_ to)
                {
                    __Bool_ nativeImg = (__Bool_) Marshal.PtrToStructure(from, typeof(__Bool_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Bool_ from, ref std_msgs.msg.dds_.Bool_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.Bool_();
                    }
                    to.data_ = from.data_ != 0 ? true : false;
                }

            }
            #endregion

        }

    }

}

