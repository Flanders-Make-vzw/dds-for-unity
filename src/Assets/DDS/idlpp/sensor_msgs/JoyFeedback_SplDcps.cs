using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace JoyFeedback_Constants
            {
            }

            #region __JoyFeedback_
            [StructLayout(LayoutKind.Sequential)]
            public struct __JoyFeedback_
            {
                public byte type_;
                public byte id_;
                public float intensity_;
            }
            #endregion

            #region __JoyFeedback_Marshaler
            public sealed class __JoyFeedback_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.JoyFeedback_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::JoyFeedback_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.JoyFeedback_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.JoyFeedback_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.JoyFeedback_ from, System.IntPtr to)
                {
                    __JoyFeedback_ nativeImg = new __JoyFeedback_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.JoyFeedback_ from, ref __JoyFeedback_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.type_ = from.type_;
                    to.id_ = from.id_;
                    to.intensity_ = from.intensity_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __JoyFeedback_ nativeImg = (__JoyFeedback_) Marshal.PtrToStructure(from, typeof(__JoyFeedback_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.JoyFeedback_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.JoyFeedback_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.JoyFeedback_ to)
                {
                    __JoyFeedback_ nativeImg = (__JoyFeedback_) Marshal.PtrToStructure(from, typeof(__JoyFeedback_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.JoyFeedback_ to)
                {
                    __JoyFeedback_ nativeImg = (__JoyFeedback_) Marshal.PtrToStructure(from, typeof(__JoyFeedback_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __JoyFeedback_ from, ref sensor_msgs.msg.dds_.JoyFeedback_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.JoyFeedback_();
                    }
                    to.type_ = from.type_;
                    to.id_ = from.id_;
                    to.intensity_ = from.intensity_;
                }

            }
            #endregion

        }

    }

}

