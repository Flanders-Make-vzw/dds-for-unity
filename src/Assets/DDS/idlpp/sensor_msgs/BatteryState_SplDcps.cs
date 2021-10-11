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
            namespace BatteryState_Constants
            {
            }

            #region __BatteryState_
            [StructLayout(LayoutKind.Sequential)]
            public struct __BatteryState_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public float voltage_;
                public float temperature_;
                public float current_;
                public float charge_;
                public float capacity_;
                public float design_capacity_;
                public float percentage_;
                public byte power_supply_status_;
                public byte power_supply_health_;
                public byte power_supply_technology_;
                public byte present_;
                public IntPtr cell_voltage_;
                public IntPtr cell_temperature_;
                public IntPtr location_;
                public IntPtr serial_number_;
            }
            #endregion

            #region __BatteryState_Marshaler
            public sealed class __BatteryState_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.BatteryState_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::BatteryState_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr12Col0Type = IntPtr.Zero;
                private static readonly int attr12Col0Size = 1 * Marshal.SizeOf(typeof(float));
                private IntPtr attr13Col0Type = IntPtr.Zero;
                private static readonly int attr13Col0Size = 1 * Marshal.SizeOf(typeof(float));

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
                    sensor_msgs.msg.dds_.BatteryState_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.BatteryState_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.BatteryState_ from, System.IntPtr to)
                {
                    __BatteryState_ nativeImg = new __BatteryState_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.BatteryState_ from, ref __BatteryState_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.voltage_ = from.voltage_;
                    to.temperature_ = from.temperature_;
                    to.current_ = from.current_;
                    to.charge_ = from.charge_;
                    to.capacity_ = from.capacity_;
                    to.design_capacity_ = from.design_capacity_;
                    to.percentage_ = from.percentage_;
                    to.power_supply_status_ = from.power_supply_status_;
                    to.power_supply_health_ = from.power_supply_health_;
                    to.power_supply_technology_ = from.power_supply_technology_;
                    to.present_ = from.present_ ? (byte) 1 : (byte) 0;
                    if (from.cell_voltage_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr12Seq0Length = from.cell_voltage_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr12Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "cell_voltage_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr12Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr12Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr12Col0Type, attr12Seq0Length);
                    if (attr12Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.cell_voltage_ = attr12Seq0Buf;
                    Marshal.Copy(from.cell_voltage_, 0, attr12Seq0Buf, attr12Seq0Length);
                    to.cell_voltage_ = attr12Seq0Buf;
                    if (from.cell_temperature_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr13Seq0Length = from.cell_temperature_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr13Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "cell_temperature_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr13Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr13Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr13Col0Type, attr13Seq0Length);
                    if (attr13Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.cell_temperature_ = attr13Seq0Buf;
                    Marshal.Copy(from.cell_temperature_, 0, attr13Seq0Buf, attr13Seq0Length);
                    to.cell_temperature_ = attr13Seq0Buf;
                    if (from.location_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.location_, from.location_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    if (from.serial_number_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.serial_number_, from.serial_number_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __BatteryState_ nativeImg = (__BatteryState_) Marshal.PtrToStructure(from, typeof(__BatteryState_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.BatteryState_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.BatteryState_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.BatteryState_ to)
                {
                    __BatteryState_ nativeImg = (__BatteryState_) Marshal.PtrToStructure(from, typeof(__BatteryState_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.BatteryState_ to)
                {
                    __BatteryState_ nativeImg = (__BatteryState_) Marshal.PtrToStructure(from, typeof(__BatteryState_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __BatteryState_ from, ref sensor_msgs.msg.dds_.BatteryState_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.BatteryState_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.voltage_ = from.voltage_;
                    to.temperature_ = from.temperature_;
                    to.current_ = from.current_;
                    to.charge_ = from.charge_;
                    to.capacity_ = from.capacity_;
                    to.design_capacity_ = from.design_capacity_;
                    to.percentage_ = from.percentage_;
                    to.power_supply_status_ = from.power_supply_status_;
                    to.power_supply_health_ = from.power_supply_health_;
                    to.power_supply_technology_ = from.power_supply_technology_;
                    to.present_ = from.present_ != 0 ? true : false;
                    IntPtr attr12Seq0Buf = from.cell_voltage_;
                    int attr12Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr12Seq0Buf);
                    if (to.cell_voltage_ == null || to.cell_voltage_.Length != attr12Seq0Length) {
                        to.cell_voltage_ = new float[attr12Seq0Length];
                    }
                    if(attr12Seq0Length > 0) Marshal.Copy(attr12Seq0Buf, to.cell_voltage_, 0, attr12Seq0Length);
                    IntPtr attr13Seq0Buf = from.cell_temperature_;
                    int attr13Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr13Seq0Buf);
                    if (to.cell_temperature_ == null || to.cell_temperature_.Length != attr13Seq0Length) {
                        to.cell_temperature_ = new float[attr13Seq0Length];
                    }
                    if(attr13Seq0Length > 0) Marshal.Copy(attr13Seq0Buf, to.cell_temperature_, 0, attr13Seq0Length);
                    to.location_ = ReadString(from.location_);
                    to.serial_number_ = ReadString(from.serial_number_);
                }

            }
            #endregion

        }

    }

}

