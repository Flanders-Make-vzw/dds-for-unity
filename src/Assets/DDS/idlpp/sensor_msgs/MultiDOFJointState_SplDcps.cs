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
            #region __MultiDOFJointState_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MultiDOFJointState_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr joint_names_;
                public IntPtr transforms_;
                public IntPtr twist_;
                public IntPtr wrench_;
            }
            #endregion

            #region __MultiDOFJointState_Marshaler
            public sealed class __MultiDOFJointState_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.MultiDOFJointState_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::MultiDOFJointState_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(IntPtr));
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Transform_));
                private geometry_msgs.msg.dds_.__Transform_Marshaler attr2Marshaler;
                private IntPtr attr3Col0Type = IntPtr.Zero;
                private static readonly int attr3Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Twist_));
                private geometry_msgs.msg.dds_.__Twist_Marshaler attr3Marshaler;
                private IntPtr attr4Col0Type = IntPtr.Zero;
                private static readonly int attr4Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Wrench_));
                private geometry_msgs.msg.dds_.__Wrench_Marshaler attr4Marshaler;

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
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Transform_)) as geometry_msgs.msg.dds_.__Transform_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new geometry_msgs.msg.dds_.__Transform_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Transform_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Twist_)) as geometry_msgs.msg.dds_.__Twist_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new geometry_msgs.msg.dds_.__Twist_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Twist_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr4Marshaler == null) {
                        attr4Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Wrench_)) as geometry_msgs.msg.dds_.__Wrench_Marshaler;
                        if (attr4Marshaler == null) {
                            attr4Marshaler = new geometry_msgs.msg.dds_.__Wrench_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Wrench_), attr4Marshaler);
                            attr4Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.MultiDOFJointState_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.MultiDOFJointState_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.MultiDOFJointState_ from, System.IntPtr to)
                {
                    __MultiDOFJointState_ nativeImg = new __MultiDOFJointState_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.MultiDOFJointState_ from, ref __MultiDOFJointState_ to)
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
                    if (from.transforms_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.transforms_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "transforms_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.transforms_ = attr2Seq0Buf;
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.transforms_[i0], attr2Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                    if (from.twist_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr3Seq0Length = from.twist_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr3Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "twist_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr3Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Col0Type, attr3Seq0Length);
                    if (attr3Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.twist_ = attr3Seq0Buf;
                    for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.twist_[i0], attr3Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr3Seq0Buf = new IntPtr(attr3Seq0Buf.ToInt64() + attr3Col0Size);
                    }
                    if (from.wrench_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr4Seq0Length = from.wrench_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr4Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "wrench_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr4Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr4Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr4Col0Type, attr4Seq0Length);
                    if (attr4Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.wrench_ = attr4Seq0Buf;
                    for (int i0 = 0; i0 < attr4Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr4Marshaler.CopyIn(typePtr, from.wrench_[i0], attr4Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr4Seq0Buf = new IntPtr(attr4Seq0Buf.ToInt64() + attr4Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MultiDOFJointState_ nativeImg = (__MultiDOFJointState_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointState_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.MultiDOFJointState_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.MultiDOFJointState_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.MultiDOFJointState_ to)
                {
                    __MultiDOFJointState_ nativeImg = (__MultiDOFJointState_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointState_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.MultiDOFJointState_ to)
                {
                    __MultiDOFJointState_ nativeImg = (__MultiDOFJointState_) Marshal.PtrToStructure(from, typeof(__MultiDOFJointState_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MultiDOFJointState_ from, ref sensor_msgs.msg.dds_.MultiDOFJointState_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.MultiDOFJointState_();
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
                    IntPtr attr2Seq0Buf = from.transforms_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.transforms_ == null || to.transforms_.Length != attr2Seq0Length) {
                        geometry_msgs.msg.dds_.Transform_[] target = new geometry_msgs.msg.dds_.Transform_[attr2Seq0Length];
                        initObjectSeq(to.transforms_, target);
                        to.transforms_ = target;
                    }
                    for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Transform_Marshaler.StaticCopyOut(attr2Seq0Buf, ref to.transforms_[i0]);
                        attr2Seq0Buf = new IntPtr(attr2Seq0Buf.ToInt64() + attr2Col0Size);
                    }
                    IntPtr attr3Seq0Buf = from.twist_;
                    int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
                    if (to.twist_ == null || to.twist_.Length != attr3Seq0Length) {
                        geometry_msgs.msg.dds_.Twist_[] target = new geometry_msgs.msg.dds_.Twist_[attr3Seq0Length];
                        initObjectSeq(to.twist_, target);
                        to.twist_ = target;
                    }
                    for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Twist_Marshaler.StaticCopyOut(attr3Seq0Buf, ref to.twist_[i0]);
                        attr3Seq0Buf = new IntPtr(attr3Seq0Buf.ToInt64() + attr3Col0Size);
                    }
                    IntPtr attr4Seq0Buf = from.wrench_;
                    int attr4Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr4Seq0Buf);
                    if (to.wrench_ == null || to.wrench_.Length != attr4Seq0Length) {
                        geometry_msgs.msg.dds_.Wrench_[] target = new geometry_msgs.msg.dds_.Wrench_[attr4Seq0Length];
                        initObjectSeq(to.wrench_, target);
                        to.wrench_ = target;
                    }
                    for (int i0 = 0; i0 < attr4Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Wrench_Marshaler.StaticCopyOut(attr4Seq0Buf, ref to.wrench_[i0]);
                        attr4Seq0Buf = new IntPtr(attr4Seq0Buf.ToInt64() + attr4Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

