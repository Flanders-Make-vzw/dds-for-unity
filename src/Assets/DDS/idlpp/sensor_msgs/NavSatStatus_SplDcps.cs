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
            namespace NavSatStatus_Constants
            {
            }

            #region __NavSatStatus_
            [StructLayout(LayoutKind.Sequential)]
            public struct __NavSatStatus_
            {
                public byte status_;
                public ushort service_;
            }
            #endregion

            #region __NavSatStatus_Marshaler
            public sealed class __NavSatStatus_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.NavSatStatus_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::NavSatStatus_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.NavSatStatus_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.NavSatStatus_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.NavSatStatus_ from, System.IntPtr to)
                {
                    __NavSatStatus_ nativeImg = new __NavSatStatus_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.NavSatStatus_ from, ref __NavSatStatus_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.status_ = from.status_;
                    to.service_ = from.service_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __NavSatStatus_ nativeImg = (__NavSatStatus_) Marshal.PtrToStructure(from, typeof(__NavSatStatus_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.NavSatStatus_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.NavSatStatus_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.NavSatStatus_ to)
                {
                    __NavSatStatus_ nativeImg = (__NavSatStatus_) Marshal.PtrToStructure(from, typeof(__NavSatStatus_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.NavSatStatus_ to)
                {
                    __NavSatStatus_ nativeImg = (__NavSatStatus_) Marshal.PtrToStructure(from, typeof(__NavSatStatus_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __NavSatStatus_ from, ref sensor_msgs.msg.dds_.NavSatStatus_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.NavSatStatus_();
                    }
                    to.status_ = from.status_;
                    to.service_ = from.service_;
                }

            }
            #endregion

        }

    }

}

