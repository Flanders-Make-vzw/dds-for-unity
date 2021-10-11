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
            #region __JoyFeedbackArray_
            [StructLayout(LayoutKind.Sequential)]
            public struct __JoyFeedbackArray_
            {
                public IntPtr array_;
            }
            #endregion

            #region __JoyFeedbackArray_Marshaler
            public sealed class __JoyFeedbackArray_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.JoyFeedbackArray_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::JoyFeedbackArray_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(sensor_msgs.msg.dds_.__JoyFeedback_));
                private sensor_msgs.msg.dds_.__JoyFeedback_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(sensor_msgs.msg.dds_.__JoyFeedback_)) as sensor_msgs.msg.dds_.__JoyFeedback_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new sensor_msgs.msg.dds_.__JoyFeedback_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(sensor_msgs.msg.dds_.__JoyFeedback_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.JoyFeedbackArray_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.JoyFeedbackArray_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.JoyFeedbackArray_ from, System.IntPtr to)
                {
                    __JoyFeedbackArray_ nativeImg = new __JoyFeedbackArray_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.JoyFeedbackArray_ from, ref __JoyFeedbackArray_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.array_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr0Seq0Length = from.array_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr0Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "array_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr0Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr0Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr0Col0Type, attr0Seq0Length);
                    if (attr0Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.array_ = attr0Seq0Buf;
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.array_[i0], attr0Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __JoyFeedbackArray_ nativeImg = (__JoyFeedbackArray_) Marshal.PtrToStructure(from, typeof(__JoyFeedbackArray_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.JoyFeedbackArray_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.JoyFeedbackArray_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.JoyFeedbackArray_ to)
                {
                    __JoyFeedbackArray_ nativeImg = (__JoyFeedbackArray_) Marshal.PtrToStructure(from, typeof(__JoyFeedbackArray_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.JoyFeedbackArray_ to)
                {
                    __JoyFeedbackArray_ nativeImg = (__JoyFeedbackArray_) Marshal.PtrToStructure(from, typeof(__JoyFeedbackArray_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __JoyFeedbackArray_ from, ref sensor_msgs.msg.dds_.JoyFeedbackArray_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.JoyFeedbackArray_();
                    }
                    IntPtr attr0Seq0Buf = from.array_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.array_ == null || to.array_.Length != attr0Seq0Length) {
                        sensor_msgs.msg.dds_.JoyFeedback_[] target = new sensor_msgs.msg.dds_.JoyFeedback_[attr0Seq0Length];
                        initObjectSeq(to.array_, target);
                        to.array_ = target;
                    }
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        sensor_msgs.msg.dds_.__JoyFeedback_Marshaler.StaticCopyOut(attr0Seq0Buf, ref to.array_[i0]);
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

