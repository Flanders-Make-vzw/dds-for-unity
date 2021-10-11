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
            #region __Header_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Header_
            {
                public builtin_interfaces.msg.dds_.__Time_ stamp_;
                public IntPtr frame_id_;
            }
            #endregion

            #region __Header_Marshaler
            public sealed class __Header_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.Header_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::Header_";
                private builtin_interfaces.msg.dds_.__Time_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(builtin_interfaces.msg.dds_.__Time_)) as builtin_interfaces.msg.dds_.__Time_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new builtin_interfaces.msg.dds_.__Time_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(builtin_interfaces.msg.dds_.__Time_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.Header_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.Header_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Header_ from, System.IntPtr to)
                {
                    __Header_ nativeImg = new __Header_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Header_ from, ref __Header_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.stamp_, ref to.stamp_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.frame_id_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.frame_id_, from.frame_id_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Header_ nativeImg = (__Header_) Marshal.PtrToStructure(from, typeof(__Header_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.Header_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.Header_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Header_ to)
                {
                    __Header_ nativeImg = (__Header_) Marshal.PtrToStructure(from, typeof(__Header_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Header_ to)
                {
                    __Header_ nativeImg = (__Header_) Marshal.PtrToStructure(from, typeof(__Header_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Header_ from, ref std_msgs.msg.dds_.Header_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.Header_();
                    }
                    builtin_interfaces.msg.dds_.__Time_Marshaler.CopyOut(ref from.stamp_, ref to.stamp_);
                    to.frame_id_ = ReadString(from.frame_id_);
                }

            }
            #endregion

        }

    }

}

