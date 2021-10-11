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
            #region __RelativeHumidity_
            [StructLayout(LayoutKind.Sequential)]
            public struct __RelativeHumidity_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public double relative_humidity_;
                public double variance_;
            }
            #endregion

            #region __RelativeHumidity_Marshaler
            public sealed class __RelativeHumidity_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.RelativeHumidity_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::RelativeHumidity_";
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
                    sensor_msgs.msg.dds_.RelativeHumidity_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.RelativeHumidity_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.RelativeHumidity_ from, System.IntPtr to)
                {
                    __RelativeHumidity_ nativeImg = new __RelativeHumidity_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.RelativeHumidity_ from, ref __RelativeHumidity_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.relative_humidity_ = from.relative_humidity_;
                    to.variance_ = from.variance_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __RelativeHumidity_ nativeImg = (__RelativeHumidity_) Marshal.PtrToStructure(from, typeof(__RelativeHumidity_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.RelativeHumidity_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.RelativeHumidity_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.RelativeHumidity_ to)
                {
                    __RelativeHumidity_ nativeImg = (__RelativeHumidity_) Marshal.PtrToStructure(from, typeof(__RelativeHumidity_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.RelativeHumidity_ to)
                {
                    __RelativeHumidity_ nativeImg = (__RelativeHumidity_) Marshal.PtrToStructure(from, typeof(__RelativeHumidity_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __RelativeHumidity_ from, ref sensor_msgs.msg.dds_.RelativeHumidity_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.RelativeHumidity_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.relative_humidity_ = from.relative_humidity_;
                    to.variance_ = from.variance_;
                }

            }
            #endregion

        }

    }

}

