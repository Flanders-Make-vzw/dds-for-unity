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
            #region __Imu_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Imu_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public geometry_msgs.msg.dds_.__Quaternion_ orientation_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] orientation_covariance_;
                public geometry_msgs.msg.dds_.__Vector3_ angular_velocity_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] angular_velocity_covariance_;
                public geometry_msgs.msg.dds_.__Vector3_ linear_acceleration_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] linear_acceleration_covariance_;
            }
            #endregion

            #region __Imu_Marshaler
            public sealed class __Imu_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.Imu_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::Imu_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Quaternion_Marshaler attr1Marshaler;
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private geometry_msgs.msg.dds_.__Vector3_Marshaler attr3Marshaler;
                private IntPtr attr4Col0Type = IntPtr.Zero;
                private static readonly int attr4Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private geometry_msgs.msg.dds_.__Vector3_Marshaler attr5Marshaler;
                private IntPtr attr6Col0Type = IntPtr.Zero;
                private static readonly int attr6Col0Size = 1 * Marshal.SizeOf(typeof(double));

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Quaternion_)) as geometry_msgs.msg.dds_.__Quaternion_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Quaternion_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Quaternion_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Vector3_)) as geometry_msgs.msg.dds_.__Vector3_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new geometry_msgs.msg.dds_.__Vector3_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Vector3_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr5Marshaler == null) {
                        attr5Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Vector3_)) as geometry_msgs.msg.dds_.__Vector3_Marshaler;
                        if (attr5Marshaler == null) {
                            attr5Marshaler = new geometry_msgs.msg.dds_.__Vector3_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Vector3_), attr5Marshaler);
                            attr5Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.Imu_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.Imu_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Imu_ from, System.IntPtr to)
                {
                    __Imu_ nativeImg = new __Imu_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Imu_ from, ref __Imu_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.orientation_, ref to.orientation_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.orientation_covariance_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.orientation_covariance_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.orientation_covariance_ = new double[9];
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "orientation_covariance_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.orientation_covariance_, 0, to.orientation_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.angular_velocity_, ref to.angular_velocity_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.angular_velocity_covariance_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.angular_velocity_covariance_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.angular_velocity_covariance_ = new double[9];
                    if (attr4Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "angular_velocity_covariance_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr4Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.angular_velocity_covariance_, 0, to.angular_velocity_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    {
                        V_COPYIN_RESULT result = attr5Marshaler.CopyIn(typePtr, from.linear_acceleration_, ref to.linear_acceleration_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.linear_acceleration_covariance_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.linear_acceleration_covariance_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.linear_acceleration_covariance_ = new double[9];
                    if (attr6Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "linear_acceleration_covariance_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr6Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.linear_acceleration_covariance_, 0, to.linear_acceleration_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Imu_ nativeImg = (__Imu_) Marshal.PtrToStructure(from, typeof(__Imu_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.Imu_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.Imu_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Imu_ to)
                {
                    __Imu_ nativeImg = (__Imu_) Marshal.PtrToStructure(from, typeof(__Imu_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Imu_ to)
                {
                    __Imu_ nativeImg = (__Imu_) Marshal.PtrToStructure(from, typeof(__Imu_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Imu_ from, ref sensor_msgs.msg.dds_.Imu_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.Imu_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    geometry_msgs.msg.dds_.__Quaternion_Marshaler.CopyOut(ref from.orientation_, ref to.orientation_);
                    if (to.orientation_covariance_ == null || to.orientation_covariance_.GetLength(0) != 9) {
                        to.orientation_covariance_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.orientation_covariance_, 0, to.orientation_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.angular_velocity_, ref to.angular_velocity_);
                    if (to.angular_velocity_covariance_ == null || to.angular_velocity_covariance_.GetLength(0) != 9) {
                        to.angular_velocity_covariance_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.angular_velocity_covariance_, 0, to.angular_velocity_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.linear_acceleration_, ref to.linear_acceleration_);
                    if (to.linear_acceleration_covariance_ == null || to.linear_acceleration_covariance_.GetLength(0) != 9) {
                        to.linear_acceleration_covariance_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.linear_acceleration_covariance_, 0, to.linear_acceleration_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                }

            }
            #endregion

        }

    }

}

