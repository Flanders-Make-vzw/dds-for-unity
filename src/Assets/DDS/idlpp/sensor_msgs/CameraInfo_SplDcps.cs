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
            #region __CameraInfo_
            [StructLayout(LayoutKind.Sequential)]
            public struct __CameraInfo_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public uint height_;
                public uint width_;
                public IntPtr distortion_model_;
                public IntPtr d_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] k_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=9)]
                public double[] r_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]
                public double[] p_;
                public uint binning_x_;
                public uint binning_y_;
                public sensor_msgs.msg.dds_.__RegionOfInterest_ roi_;
            }
            #endregion

            #region __CameraInfo_Marshaler
            public sealed class __CameraInfo_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.CameraInfo_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::CameraInfo_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr4Col0Type = IntPtr.Zero;
                private static readonly int attr4Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr5Col0Type = IntPtr.Zero;
                private static readonly int attr5Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr6Col0Type = IntPtr.Zero;
                private static readonly int attr6Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr7Col0Type = IntPtr.Zero;
                private static readonly int attr7Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private sensor_msgs.msg.dds_.__RegionOfInterest_Marshaler attr10Marshaler;

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
                    if (attr10Marshaler == null) {
                        attr10Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.msg.dds_.__RegionOfInterest_)) as sensor_msgs.msg.dds_.__RegionOfInterest_Marshaler;
                        if (attr10Marshaler == null) {
                            attr10Marshaler = new sensor_msgs.msg.dds_.__RegionOfInterest_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.msg.dds_.__RegionOfInterest_), attr10Marshaler);
                            attr10Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.CameraInfo_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.CameraInfo_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.CameraInfo_ from, System.IntPtr to)
                {
                    __CameraInfo_ nativeImg = new __CameraInfo_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.CameraInfo_ from, ref __CameraInfo_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    if (from.distortion_model_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.distortion_model_, from.distortion_model_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    if (from.d_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr4Seq0Length = from.d_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr4Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "d_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr4Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr4Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr4Col0Type, attr4Seq0Length);
                    if (attr4Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.d_ = attr4Seq0Buf;
                    Marshal.Copy(from.d_, 0, attr4Seq0Buf, attr4Seq0Length);
                    to.d_ = attr4Seq0Buf;
                    if (from.k_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.k_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.k_ = new double[9];
                    if (attr5Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "k_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr5Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.k_, 0, to.k_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    if (from.r_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.r_.GetLength(0) != 9) return V_COPYIN_RESULT.INVALID;
                    to.r_ = new double[9];
                    if (attr6Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "r_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr6Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.r_, 0, to.r_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    if (from.p_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.p_.GetLength(0) != 12) return V_COPYIN_RESULT.INVALID;
                    to.p_ = new double[12];
                    if (attr7Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "p_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr7Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.p_, 0, to.p_, 0, (12 * Marshal.SizeOf(typeof(double))));
                    to.binning_x_ = from.binning_x_;
                    to.binning_y_ = from.binning_y_;
                    {
                        V_COPYIN_RESULT result = attr10Marshaler.CopyIn(typePtr, from.roi_, ref to.roi_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __CameraInfo_ nativeImg = (__CameraInfo_) Marshal.PtrToStructure(from, typeof(__CameraInfo_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.CameraInfo_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.CameraInfo_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.CameraInfo_ to)
                {
                    __CameraInfo_ nativeImg = (__CameraInfo_) Marshal.PtrToStructure(from, typeof(__CameraInfo_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.CameraInfo_ to)
                {
                    __CameraInfo_ nativeImg = (__CameraInfo_) Marshal.PtrToStructure(from, typeof(__CameraInfo_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __CameraInfo_ from, ref sensor_msgs.msg.dds_.CameraInfo_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.CameraInfo_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    to.distortion_model_ = ReadString(from.distortion_model_);
                    IntPtr attr4Seq0Buf = from.d_;
                    int attr4Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr4Seq0Buf);
                    if (to.d_ == null || to.d_.Length != attr4Seq0Length) {
                        to.d_ = new double[attr4Seq0Length];
                    }
                    if(attr4Seq0Length > 0) Marshal.Copy(attr4Seq0Buf, to.d_, 0, attr4Seq0Length);
                    if (to.k_ == null || to.k_.GetLength(0) != 9) {
                        to.k_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.k_, 0, to.k_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    if (to.r_ == null || to.r_.GetLength(0) != 9) {
                        to.r_ = new double[9];
                    }
                    System.Buffer.BlockCopy(from.r_, 0, to.r_, 0, (9 * Marshal.SizeOf(typeof(double))));
                    if (to.p_ == null || to.p_.GetLength(0) != 12) {
                        to.p_ = new double[12];
                    }
                    System.Buffer.BlockCopy(from.p_, 0, to.p_, 0, (12 * Marshal.SizeOf(typeof(double))));
                    to.binning_x_ = from.binning_x_;
                    to.binning_y_ = from.binning_y_;
                    sensor_msgs.msg.dds_.__RegionOfInterest_Marshaler.CopyOut(ref from.roi_, ref to.roi_);
                }

            }
            #endregion

        }

    }

}

