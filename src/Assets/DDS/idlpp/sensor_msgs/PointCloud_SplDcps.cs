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
            #region __PointCloud_
            [StructLayout(LayoutKind.Sequential)]
            public struct __PointCloud_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr points_;
                public IntPtr channels_;
            }
            #endregion

            #region __PointCloud_Marshaler
            public sealed class __PointCloud_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.PointCloud_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::PointCloud_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Point32_));
                private geometry_msgs.msg.dds_.__Point32_Marshaler attr1Marshaler;
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(sensor_msgs.msg.dds_.__ChannelFloat32_));
                private sensor_msgs.msg.dds_.__ChannelFloat32_Marshaler attr2Marshaler;

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Point32_)) as geometry_msgs.msg.dds_.__Point32_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Point32_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Point32_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr2Marshaler == null) {
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.msg.dds_.__ChannelFloat32_)) as sensor_msgs.msg.dds_.__ChannelFloat32_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new sensor_msgs.msg.dds_.__ChannelFloat32_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.msg.dds_.__ChannelFloat32_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.PointCloud_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.PointCloud_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.PointCloud_ from, System.IntPtr to)
                {
                    __PointCloud_ nativeImg = new __PointCloud_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.PointCloud_ from, ref __PointCloud_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.points_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.points_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "points_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.points_ = attr1Seq0Buf;
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.points_[i0], attr1Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    if (from.channels_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.channels_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "channels_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.channels_ = attr2Seq0Buf;
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.channels_[i0], attr2Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __PointCloud_ nativeImg = (__PointCloud_) Marshal.PtrToStructure(from, typeof(__PointCloud_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.PointCloud_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.PointCloud_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.PointCloud_ to)
                {
                    __PointCloud_ nativeImg = (__PointCloud_) Marshal.PtrToStructure(from, typeof(__PointCloud_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.PointCloud_ to)
                {
                    __PointCloud_ nativeImg = (__PointCloud_) Marshal.PtrToStructure(from, typeof(__PointCloud_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __PointCloud_ from, ref sensor_msgs.msg.dds_.PointCloud_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.PointCloud_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    IntPtr attr1Seq0Buf = from.points_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.points_ == null || to.points_.Length != attr1Seq0Length) {
                        geometry_msgs.msg.dds_.Point32_[] target = new geometry_msgs.msg.dds_.Point32_[attr1Seq0Length];
                        initObjectSeq(to.points_, target);
                        to.points_ = target;
                    }
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Point32_Marshaler.StaticCopyOut(attr1Seq0Buf, ref to.points_[i0]);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    IntPtr attr2Seq0Buf = from.channels_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.channels_ == null || to.channels_.Length != attr2Seq0Length) {
                        sensor_msgs.msg.dds_.ChannelFloat32_[] target = new sensor_msgs.msg.dds_.ChannelFloat32_[attr2Seq0Length];
                        initObjectSeq(to.channels_, target);
                        to.channels_ = target;
                    }
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        sensor_msgs.msg.dds_.__ChannelFloat32_Marshaler.StaticCopyOut(attr2Seq0Buf, ref to.channels_[i0]);
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

