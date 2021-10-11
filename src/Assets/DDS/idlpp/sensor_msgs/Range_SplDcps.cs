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
            namespace Range_Constants
            {
            }

            #region __Range_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Range_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public byte radiation_type_;
                public float field_of_view_;
                public float min_range_;
                public float max_range_;
                public float range_;
            }
            #endregion

            #region __Range_Marshaler
            public sealed class __Range_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.Range_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::Range_";
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
                    sensor_msgs.msg.dds_.Range_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.Range_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Range_ from, System.IntPtr to)
                {
                    __Range_ nativeImg = new __Range_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Range_ from, ref __Range_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.radiation_type_ = from.radiation_type_;
                    to.field_of_view_ = from.field_of_view_;
                    to.min_range_ = from.min_range_;
                    to.max_range_ = from.max_range_;
                    to.range_ = from.range_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Range_ nativeImg = (__Range_) Marshal.PtrToStructure(from, typeof(__Range_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.Range_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.Range_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Range_ to)
                {
                    __Range_ nativeImg = (__Range_) Marshal.PtrToStructure(from, typeof(__Range_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Range_ to)
                {
                    __Range_ nativeImg = (__Range_) Marshal.PtrToStructure(from, typeof(__Range_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Range_ from, ref sensor_msgs.msg.dds_.Range_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.Range_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.radiation_type_ = from.radiation_type_;
                    to.field_of_view_ = from.field_of_view_;
                    to.min_range_ = from.min_range_;
                    to.max_range_ = from.max_range_;
                    to.range_ = from.range_;
                }

            }
            #endregion

        }

    }

}

