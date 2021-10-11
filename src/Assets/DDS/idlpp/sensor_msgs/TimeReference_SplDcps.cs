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
            #region __TimeReference_
            [StructLayout(LayoutKind.Sequential)]
            public struct __TimeReference_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public builtin_interfaces.msg.dds_.__Time_ time_ref_;
                public IntPtr source_;
            }
            #endregion

            #region __TimeReference_Marshaler
            public sealed class __TimeReference_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.TimeReference_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::TimeReference_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private builtin_interfaces.msg.dds_.__Time_Marshaler attr1Marshaler;

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
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(builtin_interfaces.msg.dds_.__Time_)) as builtin_interfaces.msg.dds_.__Time_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new builtin_interfaces.msg.dds_.__Time_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(builtin_interfaces.msg.dds_.__Time_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.TimeReference_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.TimeReference_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.TimeReference_ from, System.IntPtr to)
                {
                    __TimeReference_ nativeImg = new __TimeReference_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.TimeReference_ from, ref __TimeReference_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.time_ref_, ref to.time_ref_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.source_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.source_, from.source_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __TimeReference_ nativeImg = (__TimeReference_) Marshal.PtrToStructure(from, typeof(__TimeReference_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.TimeReference_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.TimeReference_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.TimeReference_ to)
                {
                    __TimeReference_ nativeImg = (__TimeReference_) Marshal.PtrToStructure(from, typeof(__TimeReference_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.TimeReference_ to)
                {
                    __TimeReference_ nativeImg = (__TimeReference_) Marshal.PtrToStructure(from, typeof(__TimeReference_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __TimeReference_ from, ref sensor_msgs.msg.dds_.TimeReference_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.TimeReference_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    builtin_interfaces.msg.dds_.__Time_Marshaler.CopyOut(ref from.time_ref_, ref to.time_ref_);
                    to.source_ = ReadString(from.source_);
                }

            }
            #endregion

        }

    }

}

