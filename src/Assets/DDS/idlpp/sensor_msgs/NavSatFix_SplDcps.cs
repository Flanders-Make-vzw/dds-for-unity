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
            namespace NavSatFix_Constants
            {
            }

            #region __NavSatFix_
            [StructLayout(LayoutKind.Sequential)]
            public struct __NavSatFix_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public sensor_msgs.msg.dds_.__NavSatStatus_ status_;
                public double latitude_;
                public double longitude_;
                public double altitude_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] position_covariance_;
                public byte position_covariance_type_;
            }
            #endregion

            #region __NavSatFix_Marshaler
            public sealed class __NavSatFix_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.NavSatFix_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::NavSatFix_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private sensor_msgs.msg.dds_.__NavSatStatus_Marshaler attr1Marshaler;
                private IntPtr attr5Col0Type = IntPtr.Zero;
                private static readonly int attr5Col0Size = 1 * Marshal.SizeOf(typeof(double));

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.msg.dds_.__NavSatStatus_)) as sensor_msgs.msg.dds_.__NavSatStatus_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new sensor_msgs.msg.dds_.__NavSatStatus_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.msg.dds_.__NavSatStatus_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.NavSatFix_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.NavSatFix_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.NavSatFix_ from, System.IntPtr to)
                {
                    __NavSatFix_ nativeImg = new __NavSatFix_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.NavSatFix_ from, ref __NavSatFix_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.status_, ref to.status_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.latitude_ = from.latitude_;
                    to.longitude_ = from.longitude_;
                    to.altitude_ = from.altitude_;
                    if (from.position_covariance_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.position_covariance_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.position_covariance_ = new double[9];
                    if (attr5Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "position_covariance_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr5Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.position_covariance_, 0, to.position_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    to.position_covariance_type_ = from.position_covariance_type_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __NavSatFix_ nativeImg = (__NavSatFix_) Marshal.PtrToStructure(from, typeof(__NavSatFix_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.NavSatFix_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.NavSatFix_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.NavSatFix_ to)
                {
                    __NavSatFix_ nativeImg = (__NavSatFix_) Marshal.PtrToStructure(from, typeof(__NavSatFix_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.NavSatFix_ to)
                {
                    __NavSatFix_ nativeImg = (__NavSatFix_) Marshal.PtrToStructure(from, typeof(__NavSatFix_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __NavSatFix_ from, ref sensor_msgs.msg.dds_.NavSatFix_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.NavSatFix_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    sensor_msgs.msg.dds_.__NavSatStatus_Marshaler.CopyOut(ref from.status_, ref to.status_);
                    to.latitude_ = from.latitude_;
                    to.longitude_ = from.longitude_;
                    to.altitude_ = from.altitude_;
                    if (to.position_covariance_ == null || to.position_covariance_.GetLength(0) != 9) {
                        to.position_covariance_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.position_covariance_, 0, to.position_covariance_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    to.position_covariance_type_ = from.position_covariance_type_;
                }

            }
            #endregion

        }

    }

}

