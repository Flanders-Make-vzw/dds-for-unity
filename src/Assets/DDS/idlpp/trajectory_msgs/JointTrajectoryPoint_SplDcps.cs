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
            #region __JointTrajectoryPoint_
            [StructLayout(LayoutKind.Sequential)]
            public struct __JointTrajectoryPoint_
            {
                public IntPtr positions_;
                public IntPtr velocities_;
                public IntPtr accelerations_;
                public IntPtr effort_;
                public builtin_interfaces.msg.dds_.__Duration_ time_from_start_;
            }
            #endregion

            #region __JointTrajectoryPoint_Marshaler
            public sealed class __JointTrajectoryPoint_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<trajectory_msgs.msg.dds_.JointTrajectoryPoint_>
            {
                public static readonly string fullyScopedName = "trajectory_msgs::msg::dds_::JointTrajectoryPoint_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr3Col0Type = IntPtr.Zero;
                private static readonly int attr3Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private builtin_interfaces.msg.dds_.__Duration_Marshaler attr4Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr4Marshaler == null) {
                        attr4Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(builtin_interfaces.msg.dds_.__Duration_)) as builtin_interfaces.msg.dds_.__Duration_Marshaler;
                        if (attr4Marshaler == null) {
                            attr4Marshaler = new builtin_interfaces.msg.dds_.__Duration_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(builtin_interfaces.msg.dds_.__Duration_), attr4Marshaler);
                            attr4Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    trajectory_msgs.msg.dds_.JointTrajectoryPoint_ fromData = tmpGCHandle.Target as trajectory_msgs.msg.dds_.JointTrajectoryPoint_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, trajectory_msgs.msg.dds_.JointTrajectoryPoint_ from, System.IntPtr to)
                {
                    __JointTrajectoryPoint_ nativeImg = new __JointTrajectoryPoint_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, trajectory_msgs.msg.dds_.JointTrajectoryPoint_ from, ref __JointTrajectoryPoint_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.positions_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr0Seq0Length = from.positions_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr0Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "positions_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr0Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr0Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr0Col0Type, attr0Seq0Length);
                    if (attr0Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.positions_ = attr0Seq0Buf;
                    Marshal.Copy(from.positions_, 0, attr0Seq0Buf, attr0Seq0Length);
                    to.positions_ = attr0Seq0Buf;
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
                    Marshal.Copy(from.velocities_, 0, attr1Seq0Buf, attr1Seq0Length);
                    to.velocities_ = attr1Seq0Buf;
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
                    Marshal.Copy(from.accelerations_, 0, attr2Seq0Buf, attr2Seq0Length);
                    to.accelerations_ = attr2Seq0Buf;
                    if (from.effort_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr3Seq0Length = from.effort_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr3Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "effort_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr3Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Col0Type, attr3Seq0Length);
                    if (attr3Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.effort_ = attr3Seq0Buf;
                    Marshal.Copy(from.effort_, 0, attr3Seq0Buf, attr3Seq0Length);
                    to.effort_ = attr3Seq0Buf;
                    {
                        V_COPYIN_RESULT result = attr4Marshaler.CopyIn(typePtr, from.time_from_start_, ref to.time_from_start_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __JointTrajectoryPoint_ nativeImg = (__JointTrajectoryPoint_) Marshal.PtrToStructure(from, typeof(__JointTrajectoryPoint_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    trajectory_msgs.msg.dds_.JointTrajectoryPoint_ toObj = tmpGCHandleTo.Target as trajectory_msgs.msg.dds_.JointTrajectoryPoint_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref trajectory_msgs.msg.dds_.JointTrajectoryPoint_ to)
                {
                    __JointTrajectoryPoint_ nativeImg = (__JointTrajectoryPoint_) Marshal.PtrToStructure(from, typeof(__JointTrajectoryPoint_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref trajectory_msgs.msg.dds_.JointTrajectoryPoint_ to)
                {
                    __JointTrajectoryPoint_ nativeImg = (__JointTrajectoryPoint_) Marshal.PtrToStructure(from, typeof(__JointTrajectoryPoint_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __JointTrajectoryPoint_ from, ref trajectory_msgs.msg.dds_.JointTrajectoryPoint_ to)
                {
                    if (to == null) {
                        to = new trajectory_msgs.msg.dds_.JointTrajectoryPoint_();
                    }
                    IntPtr attr0Seq0Buf = from.positions_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.positions_ == null || to.positions_.Length != attr0Seq0Length) {
                        to.positions_ = new double[attr0Seq0Length];
                    }
                    if(attr0Seq0Length > 0) Marshal.Copy(attr0Seq0Buf, to.positions_, 0, attr0Seq0Length);
                    IntPtr attr1Seq0Buf = from.velocities_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.velocities_ == null || to.velocities_.Length != attr1Seq0Length) {
                        to.velocities_ = new double[attr1Seq0Length];
                    }
                    if(attr1Seq0Length > 0) Marshal.Copy(attr1Seq0Buf, to.velocities_, 0, attr1Seq0Length);
                    IntPtr attr2Seq0Buf = from.accelerations_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.accelerations_ == null || to.accelerations_.Length != attr2Seq0Length) {
                        to.accelerations_ = new double[attr2Seq0Length];
                    }
                    if(attr2Seq0Length > 0) Marshal.Copy(attr2Seq0Buf, to.accelerations_, 0, attr2Seq0Length);
                    IntPtr attr3Seq0Buf = from.effort_;
                    int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
                    if (to.effort_ == null || to.effort_.Length != attr3Seq0Length) {
                        to.effort_ = new double[attr3Seq0Length];
                    }
                    if(attr3Seq0Length > 0) Marshal.Copy(attr3Seq0Buf, to.effort_, 0, attr3Seq0Length);
                    builtin_interfaces.msg.dds_.__Duration_Marshaler.CopyOut(ref from.time_from_start_, ref to.time_from_start_);
                }

            }
            #endregion

        }

    }

}

