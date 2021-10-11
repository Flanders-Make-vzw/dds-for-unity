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
            #region __ColorRGBA_
            [StructLayout(LayoutKind.Sequential)]
            public struct __ColorRGBA_
            {
                public float r_;
                public float g_;
                public float b_;
                public float a_;
            }
            #endregion

            #region __ColorRGBA_Marshaler
            public sealed class __ColorRGBA_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.ColorRGBA_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::ColorRGBA_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.ColorRGBA_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.ColorRGBA_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.ColorRGBA_ from, System.IntPtr to)
                {
                    __ColorRGBA_ nativeImg = new __ColorRGBA_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.ColorRGBA_ from, ref __ColorRGBA_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.r_ = from.r_;
                    to.g_ = from.g_;
                    to.b_ = from.b_;
                    to.a_ = from.a_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __ColorRGBA_ nativeImg = (__ColorRGBA_) Marshal.PtrToStructure(from, typeof(__ColorRGBA_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.ColorRGBA_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.ColorRGBA_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.ColorRGBA_ to)
                {
                    __ColorRGBA_ nativeImg = (__ColorRGBA_) Marshal.PtrToStructure(from, typeof(__ColorRGBA_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.ColorRGBA_ to)
                {
                    __ColorRGBA_ nativeImg = (__ColorRGBA_) Marshal.PtrToStructure(from, typeof(__ColorRGBA_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __ColorRGBA_ from, ref std_msgs.msg.dds_.ColorRGBA_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.ColorRGBA_();
                    }
                    to.r_ = from.r_;
                    to.g_ = from.g_;
                    to.b_ = from.b_;
                    to.a_ = from.a_;
                }

            }
            #endregion

        }

    }

}

