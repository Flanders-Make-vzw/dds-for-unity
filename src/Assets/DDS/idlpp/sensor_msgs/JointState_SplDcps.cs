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
            #region __JointState_
            [StructLayout(LayoutKind.Sequential)]
            public struct __JointState_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr name_;
                public IntPtr position_;
                public IntPtr velocity_;
                public IntPtr effort_;
            }
            #endregion

            #region __JointState_Marshaler
            public sealed class __JointState_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.JointState_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::JointState_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(IntPtr));
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr3Col0Type = IntPtr.Zero;
                private static readonly int attr3Col0Size = 1 * Marshal.SizeOf(typeof(double));
                private IntPtr attr4Col0Type = IntPtr.Zero;
                private static readonly int attr4Col0Size = 1 * Marshal.SizeOf(typeof(double));

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
                    sensor_msgs.msg.dds_.JointState_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.JointState_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.JointState_ from, System.IntPtr to)
                {
                    __JointState_ nativeImg = new __JointState_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.JointState_ from, ref __JointState_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.name_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.name_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "name_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.name_ = attr1Seq0Buf;
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        if (from.name_[i0] == null) return V_COPYIN_RESULT.INVALID;
                        // Unbounded string: bounds check not required...
                        IntPtr stringElementPtr = IntPtr.Zero;
                        if (!Write(c.getBase(typePtr), ref stringElementPtr, from.name_[i0])) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                        Marshal.WriteIntPtr(attr1Seq0Buf, stringElementPtr);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    if (from.position_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.position_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "position_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.position_ = attr2Seq0Buf;
                    Marshal.Copy(from.position_, 0, attr2Seq0Buf, attr2Seq0Length);
                    to.position_ = attr2Seq0Buf;
                    if (from.velocity_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr3Seq0Length = from.velocity_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr3Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "velocity_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr3Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Col0Type, attr3Seq0Length);
                    if (attr3Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.velocity_ = attr3Seq0Buf;
                    Marshal.Copy(from.velocity_, 0, attr3Seq0Buf, attr3Seq0Length);
                    to.velocity_ = attr3Seq0Buf;
                    if (from.effort_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr4Seq0Length = from.effort_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr4Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "effort_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr4Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr4Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr4Col0Type, attr4Seq0Length);
                    if (attr4Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.effort_ = attr4Seq0Buf;
                    Marshal.Copy(from.effort_, 0, attr4Seq0Buf, attr4Seq0Length);
                    to.effort_ = attr4Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __JointState_ nativeImg = (__JointState_) Marshal.PtrToStructure(from, typeof(__JointState_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.JointState_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.JointState_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.JointState_ to)
                {
                    __JointState_ nativeImg = (__JointState_) Marshal.PtrToStructure(from, typeof(__JointState_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.JointState_ to)
                {
                    __JointState_ nativeImg = (__JointState_) Marshal.PtrToStructure(from, typeof(__JointState_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __JointState_ from, ref sensor_msgs.msg.dds_.JointState_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.JointState_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    IntPtr attr1Seq0Buf = from.name_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.name_ == null || to.name_.Length != attr1Seq0Length) {
                        string[] target = new string[attr1Seq0Length];
                        initObjectSeq(to.name_, target);
                        to.name_ = target;
                    }
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        IntPtr stringElementPtr = Marshal.ReadIntPtr(attr1Seq0Buf);
                        to.name_[i0] = ReadString(stringElementPtr);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    IntPtr attr2Seq0Buf = from.position_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.position_ == null || to.position_.Length != attr2Seq0Length) {
                        to.position_ = new double[attr2Seq0Length];
                    }
                    if(attr2Seq0Length > 0) Marshal.Copy(attr2Seq0Buf, to.position_, 0, attr2Seq0Length);
                    IntPtr attr3Seq0Buf = from.velocity_;
                    int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
                    if (to.velocity_ == null || to.velocity_.Length != attr3Seq0Length) {
                        to.velocity_ = new double[attr3Seq0Length];
                    }
                    if(attr3Seq0Length > 0) Marshal.Copy(attr3Seq0Buf, to.velocity_, 0, attr3Seq0Length);
                    IntPtr attr4Seq0Buf = from.effort_;
                    int attr4Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr4Seq0Buf);
                    if (to.effort_ == null || to.effort_.Length != attr4Seq0Length) {
                        to.effort_ = new double[attr4Seq0Length];
                    }
                    if(attr4Seq0Length > 0) Marshal.Copy(attr4Seq0Buf, to.effort_, 0, attr4Seq0Length);
                }

            }
            #endregion

        }

    }

}

