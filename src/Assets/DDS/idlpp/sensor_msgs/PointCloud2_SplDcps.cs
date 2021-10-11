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
            #region __PointCloud2_
            [StructLayout(LayoutKind.Sequential)]
            public struct __PointCloud2_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public uint height_;
                public uint width_;
                public IntPtr fields_;
                public byte is_bigendian_;
                public uint point_step_;
                public uint row_step_;
                public IntPtr data_;
                public byte is_dense_;
            }
            #endregion

            #region __PointCloud2_Marshaler
            public sealed class __PointCloud2_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.PointCloud2_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::PointCloud2_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr3Col0Type = IntPtr.Zero;
                private static readonly int attr3Col0Size = 1 * Marshal.SizeOf(typeof(sensor_msgs.msg.dds_.__PointField_));
                private sensor_msgs.msg.dds_.__PointField_Marshaler attr3Marshaler;
                private IntPtr attr7Col0Type = IntPtr.Zero;
                private static readonly int attr7Col0Size = 1 * Marshal.SizeOf(typeof(byte));

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
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.msg.dds_.__PointField_)) as sensor_msgs.msg.dds_.__PointField_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new sensor_msgs.msg.dds_.__PointField_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.msg.dds_.__PointField_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.PointCloud2_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.PointCloud2_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.PointCloud2_ from, System.IntPtr to)
                {
                    __PointCloud2_ nativeImg = new __PointCloud2_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.PointCloud2_ from, ref __PointCloud2_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    if (from.fields_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr3Seq0Length = from.fields_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr3Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "fields_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr3Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Col0Type, attr3Seq0Length);
                    if (attr3Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.fields_ = attr3Seq0Buf;
                    for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.fields_[i0], attr3Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr3Seq0Buf = new IntPtr(attr3Seq0Buf.ToInt64() + attr3Col0Size);
                    }
                    to.is_bigendian_ = from.is_bigendian_ ? (byte) 1 : (byte) 0;
                    to.point_step_ = from.point_step_;
                    to.row_step_ = from.row_step_;
                    if (from.data_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr7Seq0Length = from.data_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr7Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "data_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr7Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr7Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr7Col0Type, attr7Seq0Length);
                    if (attr7Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.data_ = attr7Seq0Buf;
                    Marshal.Copy(from.data_, 0, attr7Seq0Buf, attr7Seq0Length);
                    to.data_ = attr7Seq0Buf;
                    to.is_dense_ = from.is_dense_ ? (byte) 1 : (byte) 0;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __PointCloud2_ nativeImg = (__PointCloud2_) Marshal.PtrToStructure(from, typeof(__PointCloud2_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.PointCloud2_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.PointCloud2_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.PointCloud2_ to)
                {
                    __PointCloud2_ nativeImg = (__PointCloud2_) Marshal.PtrToStructure(from, typeof(__PointCloud2_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.PointCloud2_ to)
                {
                    __PointCloud2_ nativeImg = (__PointCloud2_) Marshal.PtrToStructure(from, typeof(__PointCloud2_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __PointCloud2_ from, ref sensor_msgs.msg.dds_.PointCloud2_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.PointCloud2_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    IntPtr attr3Seq0Buf = from.fields_;
                    int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
                    if (to.fields_ == null || to.fields_.Length != attr3Seq0Length) {
                        sensor_msgs.msg.dds_.PointField_[] target = new sensor_msgs.msg.dds_.PointField_[attr3Seq0Length];
                        initObjectSeq(to.fields_, target);
                        to.fields_ = target;
                    }
                    for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                        sensor_msgs.msg.dds_.__PointField_Marshaler.StaticCopyOut(attr3Seq0Buf, ref to.fields_[i0]);
                        attr3Seq0Buf = new IntPtr(attr3Seq0Buf.ToInt64() + attr3Col0Size);
                    }
                    to.is_bigendian_ = from.is_bigendian_ != 0 ? true : false;
                    to.point_step_ = from.point_step_;
                    to.row_step_ = from.row_step_;
                    IntPtr attr7Seq0Buf = from.data_;
                    int attr7Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr7Seq0Buf);
                    if (to.data_ == null || to.data_.Length != attr7Seq0Length) {
                        to.data_ = new byte[attr7Seq0Length];
                    }
                    if(attr7Seq0Length > 0) Marshal.Copy(attr7Seq0Buf, to.data_, 0, attr7Seq0Length);
                    to.is_dense_ = from.is_dense_ != 0 ? true : false;
                }

            }
            #endregion

        }

    }

}

