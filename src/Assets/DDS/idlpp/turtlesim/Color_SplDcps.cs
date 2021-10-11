using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace turtlesim
{
    namespace msg
    {
        namespace dds_
        {
            #region __Color_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Color_
            {
                public byte r_;
                public byte g_;
                public byte b_;
            }
            #endregion

            #region __Color_Marshaler
            public sealed class __Color_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<turtlesim.msg.dds_.Color_>
            {
                public static readonly string fullyScopedName = "turtlesim::msg::dds_::Color_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    turtlesim.msg.dds_.Color_ fromData = tmpGCHandle.Target as turtlesim.msg.dds_.Color_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.msg.dds_.Color_ from, System.IntPtr to)
                {
                    __Color_ nativeImg = new __Color_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, turtlesim.msg.dds_.Color_ from, ref __Color_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.r_ = from.r_;
                    to.g_ = from.g_;
                    to.b_ = from.b_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Color_ nativeImg = (__Color_) Marshal.PtrToStructure(from, typeof(__Color_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    turtlesim.msg.dds_.Color_ toObj = tmpGCHandleTo.Target as turtlesim.msg.dds_.Color_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref turtlesim.msg.dds_.Color_ to)
                {
                    __Color_ nativeImg = (__Color_) Marshal.PtrToStructure(from, typeof(__Color_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref turtlesim.msg.dds_.Color_ to)
                {
                    __Color_ nativeImg = (__Color_) Marshal.PtrToStructure(from, typeof(__Color_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Color_ from, ref turtlesim.msg.dds_.Color_ to)
                {
                    if (to == null) {
                        to = new turtlesim.msg.dds_.Color_();
                    }
                    to.r_ = from.r_;
                    to.g_ = from.g_;
                    to.b_ = from.b_;
                }

            }
            #endregion

        }

    }

}

