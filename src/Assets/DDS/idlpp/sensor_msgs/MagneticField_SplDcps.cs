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
            #region __MagneticField_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MagneticField_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public geometry_msgs.msg.dds_.__Vector3_ magnetic_field_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] magnetic_field_covariance_;
            }
            #endregion

            #region __MagneticField_Marshaler
            public sealed class __MagneticField_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.MagneticField_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::MagneticField_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Vector3_Marshaler attr1Marshaler;
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(double));

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Vector3_)) as geometry_msgs.msg.dds_.__Vector3_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Vector3_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Vector3_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.MagneticField_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.MagneticField_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.MagneticField_ from, System.IntPtr to)
                {
                    __MagneticField_ nativeImg = new __MagneticField_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.MagneticField_ from, ref __MagneticField_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.magnetic_field_, ref to.magnetic_field_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.magnetic_field_covariance_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.magnetic_field_covariance_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.magnetic_field_covariance_ = new double[9];
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "magnetic_field_covariance_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.magnetic_field_covariance_, 0, to.magnetic_field_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MagneticField_ nativeImg = (__MagneticField_) Marshal.PtrToStructure(from, typeof(__MagneticField_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.MagneticField_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.MagneticField_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.MagneticField_ to)
                {
                    __MagneticField_ nativeImg = (__MagneticField_) Marshal.PtrToStructure(from, typeof(__MagneticField_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.MagneticField_ to)
                {
                    __MagneticField_ nativeImg = (__MagneticField_) Marshal.PtrToStructure(from, typeof(__MagneticField_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MagneticField_ from, ref sensor_msgs.msg.dds_.MagneticField_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.MagneticField_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.magnetic_field_, ref to.magnetic_field_);
                    if (to.magnetic_field_covariance_ == null || to.magnetic_field_covariance_.GetLength(0) != 9) {
                        to.magnetic_field_covariance_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.magnetic_field_covariance_, 0, to.magnetic_field_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                }

            }
            #endregion

        }

    }

}

