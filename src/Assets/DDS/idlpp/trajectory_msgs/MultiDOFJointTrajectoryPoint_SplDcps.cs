using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __MultiDOFJointTrajectoryPoint_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MultiDOFJointTrajectoryPoint_
            {
                public IntPtr transforms_;
                public IntPtr velocities_;
                public IntPtr accelerations_;
                public builtin_interfaces.msg.dds_.__Duration_ time_from_start_;
            }
            #endregion

            #region __MultiDOFJointTrajectoryPoint_Marshaler
            public sealed class __MultiDOFJointTrajectoryPoint_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_>
            {
                public static readonly string fullyScopedName = "trajectory_msgs::msg::dds_::MultiDOFJointTrajectoryPoint_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Transform_));
                private geometry_msgs.msg.dds_.__Transform_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Twist_));
                private geometry_msgs.msg.dds_.__Twist_Marshaler attr1Marshaler;
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Twist_));
                private geometry_msgs.msg.dds_.__Twist_Marshaler attr2Marshaler;
                private builtin_interfaces.msg.dds_.__Duration_Marshaler attr3Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Transform_)) as geometry_msgs.msg.dds_.__Transform_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__Transform_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Transform_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Twist_)) as geometry_msgs.msg.dds_.__Twist_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Twist_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Twist_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr2Marshaler == null) {
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Twist_)) as geometry_msgs.msg.dds_.__Twist_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new geometry_msgs.msg.dds_.__Twist_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Twist_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(builtin_interfaces.msg.dds_.__Duration_)) as builtin_interfaces.msg.dds_.__Duration_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new builtin_interfaces.msg.dds_.__Duration_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(builtin_interfaces.msg.dds_.__Duration_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ fromData = tmpGCHandle.Target as trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ from, System.IntPtr to)
                {
                    __MultiDOFJointTrajectoryPoint_ nativeImg = new __MultiDOFJointTrajectoryPoint_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ from, ref __MultiDOFJointTrajectoryPoint_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.transforms_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr0Seq0Length = from.transforms_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr0Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "transforms_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr0Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr0Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr0Col0Type, attr0Seq0Length);
                    if (attr0Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.transforms_ = attr0Seq0Buf;
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.transforms_[i0], attr0Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                    if (from.velocities_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.velocities_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "velocities_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.velocities_ = attr1Seq0Buf;
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.velocities_[i0], attr1Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    if (from.accelerations_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.accelerations_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "accelerations_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.accelerations_ = attr2Seq0Buf;
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.accelerations_[i0], attr2Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                    {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.time_from_start_, ref to.time_from_start_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MultiDOFJointTrajectoryPoint_ nativeImg = (__MultiDOFJointTrajectoryPoint_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointTrajectoryPoint_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ toObj = tmpGCHandleTo.Target as trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ to)
                {
                    __MultiDOFJointTrajectoryPoint_ nativeImg = (__MultiDOFJointTrajectoryPoint_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointTrajectoryPoint_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ to)
                {
                    __MultiDOFJointTrajectoryPoint_ nativeImg = (__MultiDOFJointTrajectoryPoint_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointTrajectoryPoint_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MultiDOFJointTrajectoryPoint_ from, ref trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_ to)
                {
                    if (to == null) {
                        to = new trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_();
                    }
                    IntPtr attr0Seq0Buf = from.transforms_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.transforms_ == null || to.transforms_.Length != attr0Seq0Length) {
                        geometry_msgs.msg.dds_.Transform_[] target = new geometry_msgs.msg.dds_.Transform_[attr0Seq0Length];
                        initObjectSeq(to.transforms_, target);
                        to.transforms_ = target;
                    }
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Transform_Marshaler.StaticCopyOut(attr0Seq0Buf, ref to.transforms_[i0]);
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                    IntPtr attr1Seq0Buf = from.velocities_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.velocities_ == null || to.velocities_.Length != attr1Seq0Length) {
                        geometry_msgs.msg.dds_.Twist_[] target = new geometry_msgs.msg.dds_.Twist_[attr1Seq0Length];
                        initObjectSeq(to.velocities_, target);
                        to.velocities_ = target;
                    }
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Twist_Marshaler.StaticCopyOut(attr1Seq0Buf, ref to.velocities_[i0]);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    IntPtr attr2Seq0Buf = from.accelerations_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.accelerations_ == null || to.accelerations_.Length != attr2Seq0Length) {
                        geometry_msgs.msg.dds_.Twist_[] target = new geometry_msgs.msg.dds_.Twist_[attr2Seq0Length];
                        initObjectSeq(to.accelerations_, target);
                        to.accelerations_ = target;
                    }
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Twist_Marshaler.StaticCopyOut(attr2Seq0Buf, ref to.accelerations_[i0]);
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                    builtin_interfaces.msg.dds_.__Duration_Marshaler.CopyOut(ref from.time_from_start_, ref to.time_from_start_);
                }

            }
            #endregion

        }

    }

}

