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
            #region __LaserScan_
            [StructLayout(LayoutKind.Sequential)]
            public struct __LaserScan_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public float angle_min_;
                public float angle_max_;
                public float angle_increment_;
                public float time_increment_;
                public float scan_time_;
                public float range_min_;
                public float range_max_;
                public IntPtr ranges_;
                public IntPtr intensities_;
            }
            #endregion

            #region __LaserScan_Marshaler
            public sealed class __LaserScan_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.LaserScan_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::LaserScan_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr8Col0Type = IntPtr.Zero;
                private static readonly int attr8Col0Size = 1 * Marshal.SizeOf(typeof(float));
                private IntPtr attr9Col0Type = IntPtr.Zero;
                private static readonly int attr9Col0Size = 1 * Marshal.SizeOf(typeof(float));

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
                    sensor_msgs.msg.dds_.LaserScan_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.LaserScan_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.LaserScan_ from, System.IntPtr to)
                {
                    __LaserScan_ nativeImg = new __LaserScan_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.LaserScan_ from, ref __LaserScan_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.angle_min_ = from.angle_min_;
                    to.angle_max_ = from.angle_max_;
                    to.angle_increment_ = from.angle_increment_;
                    to.time_increment_ = from.time_increment_;
                    to.scan_time_ = from.scan_time_;
                    to.range_min_ = from.range_min_;
                    to.range_max_ = from.range_max_;
                    if (from.ranges_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr8Seq0Length = from.ranges_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr8Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "ranges_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr8Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr8Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr8Col0Type, attr8Seq0Length);
                    if (attr8Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.ranges_ = attr8Seq0Buf;
                    Marshal.Copy(from.ranges_, 0, attr8Seq0Buf, attr8Seq0Length);
                    to.ranges_ = attr8Seq0Buf;
                    if (from.intensities_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr9Seq0Length = from.intensities_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr9Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "intensities_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr9Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr9Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr9Col0Type, attr9Seq0Length);
                    if (attr9Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.intensities_ = attr9Seq0Buf;
                    Marshal.Copy(from.intensities_, 0, attr9Seq0Buf, attr9Seq0Length);
                    to.intensities_ = attr9Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __LaserScan_ nativeImg = (__LaserScan_) Marshal.PtrToStructure(from, typeof(__LaserScan_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.LaserScan_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.LaserScan_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.LaserScan_ to)
                {
                    __LaserScan_ nativeImg = (__LaserScan_) Marshal.PtrToStructure(from, typeof(__LaserScan_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.LaserScan_ to)
                {
                    __LaserScan_ nativeImg = (__LaserScan_) Marshal.PtrToStructure(from, typeof(__LaserScan_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __LaserScan_ from, ref sensor_msgs.msg.dds_.LaserScan_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.LaserScan_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.angle_min_ = from.angle_min_;
                    to.angle_max_ = from.angle_max_;
                    to.angle_increment_ = from.angle_increment_;
                    to.time_increment_ = from.time_increment_;
                    to.scan_time_ = from.scan_time_;
                    to.range_min_ = from.range_min_;
                    to.range_max_ = from.range_max_;
                    IntPtr attr8Seq0Buf = from.ranges_;
                    int attr8Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr8Seq0Buf);
                    if (to.ranges_ == null || to.ranges_.Length != attr8Seq0Length) {
                        to.ranges_ = new float[attr8Seq0Length];
                    }
                    if(attr8Seq0Length > 0) Marshal.Copy(attr8Seq0Buf, to.ranges_, 0, attr8Seq0Length);
                    IntPtr attr9Seq0Buf = from.intensities_;
                    int attr9Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr9Seq0Buf);
                    if (to.intensities_ == null || to.intensities_.Length != attr9Seq0Length) {
                        to.intensities_ = new float[attr9Seq0Length];
                    }
                    if(attr9Seq0Length > 0) Marshal.Copy(attr9Seq0Buf, to.intensities_, 0, attr9Seq0Length);
                }

            }
            #endregion

        }

    }

}

