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
            #region __Temperature_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Temperature_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public double temperature_;
                public double variance_;
            }
            #endregion

            #region __Temperature_Marshaler
            public sealed class __Temperature_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.Temperature_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::Temperature_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(std_msgs.msg.dds_.__Header_)) as std_msgs.msg.dds_.__Header_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new std_msgs.msg.dds_.__Header_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(std_msgs.msg.dds_.__Header_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.Temperature_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.Temperature_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Temperature_ from, System.IntPtr to)
                {
                    __Temperature_ nativeImg = new __Temperature_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Temperature_ from, ref __Temperature_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.temperature_ = from.temperature_;
                    to.variance_ = from.variance_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Temperature_ nativeImg = (__Temperature_) Marshal.PtrToStructure(from, typeof(__Temperature_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.Temperature_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.Temperature_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Temperature_ to)
                {
                    __Temperature_ nativeImg = (__Temperature_) Marshal.PtrToStructure(from, typeof(__Temperature_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Temperature_ to)
                {
                    __Temperature_ nativeImg = (__Temperature_) Marshal.PtrToStructure(from, typeof(__Temperature_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Temperature_ from, ref sensor_msgs.msg.dds_.Temperature_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.Temperature_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.temperature_ = from.temperature_;
                    to.variance_ = from.variance_;
                }

            }
            #endregion

        }

    }

}

