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
            #region __MultiDOFJointTrajectory_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MultiDOFJointTrajectory_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr joint_names_;
                public IntPtr points_;
            }
            #endregion

            #region __MultiDOFJointTrajectory_Marshaler
            public sealed class __MultiDOFJointTrajectory_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_>
            {
                public static readonly string fullyScopedName = "trajectory_msgs::msg::dds_::MultiDOFJointTrajectory_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(IntPtr));
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_));
                private trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_Marshaler attr2Marshaler;

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
                    if (attr2Marshaler == null) {
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_)) as trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ fromData = tmpGCHandle.Target as trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ from, System.IntPtr to)
                {
                    __MultiDOFJointTrajectory_ nativeImg = new __MultiDOFJointTrajectory_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ from, ref __MultiDOFJointTrajectory_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.joint_names_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.joint_names_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "joint_names_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.joint_names_ = attr1Seq0Buf;
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        if (from.joint_names_[i0] == null) return V_COPYIN_RESULT.INVALID;
                        // Unbounded string: bounds check not required...
                        IntPtr stringElementPtr = IntPtr.Zero;
                        if (!Write(c.getBase(typePtr), ref stringElementPtr, from.joint_names_[i0])) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                        Marshal.WriteIntPtr(attr1Seq0Buf, stringElementPtr);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    if (from.points_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.points_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "points_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.points_ = attr2Seq0Buf;
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.points_[i0], attr2Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MultiDOFJointTrajectory_ nativeImg = (__MultiDOFJointTrajectory_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointTrajectory_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ toObj = tmpGCHandleTo.Target as trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ to)
                {
                    __MultiDOFJointTrajectory_ nativeImg = (__MultiDOFJointTrajectory_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointTrajectory_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ to)
                {
                    __MultiDOFJointTrajectory_ nativeImg = (__MultiDOFJointTrajectory_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointTrajectory_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MultiDOFJointTrajectory_ from, ref trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_ to)
                {
                    if (to == null) {
                        to = new trajectory_msgs.msg.dds_.MultiDOFJointTrajectory_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    IntPtr attr1Seq0Buf = from.joint_names_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.joint_names_ == null || to.joint_names_.Length != attr1Seq0Length) {
                        string[] target = new string[attr1Seq0Length];
                        initObjectSeq(to.joint_names_, target);
                        to.joint_names_ = target;
                    }
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        IntPtr stringElementPtr = Marshal.ReadIntPtr(attr1Seq0Buf);
                        to.joint_names_[i0] = ReadString(stringElementPtr);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    IntPtr attr2Seq0Buf = from.points_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.points_ == null || to.points_.Length != attr2Seq0Length) {
                        trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_[] target = new trajectory_msgs.msg.dds_.MultiDOFJointTrajectoryPoint_[attr2Seq0Length];
                        initObjectSeq(to.points_, target);
                        to.points_ = target;
                    }
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        trajectory_msgs.msg.dds_.__MultiDOFJointTrajectoryPoint_Marshaler.StaticCopyOut(attr2Seq0Buf, ref to.points_[i0]);
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

