using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace tf2_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __TFMessage_
            [StructLayout(LayoutKind.Sequential)]
            public struct __TFMessage_
            {
                public IntPtr transforms_;
            }
            #endregion

            #region __TFMessage_Marshaler
            public sealed class __TFMessage_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<tf2_msgs.msg.dds_.TFMessage_>
            {
                public static readonly string fullyScopedName = "tf2_msgs::msg::dds_::TFMessage_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__TransformStamped_));
                private geometry_msgs.msg.dds_.__TransformStamped_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__TransformStamped_)) as geometry_msgs.msg.dds_.__TransformStamped_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__TransformStamped_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__TransformStamped_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    tf2_msgs.msg.dds_.TFMessage_ fromData = tmpGCHandle.Target as tf2_msgs.msg.dds_.TFMessage_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, tf2_msgs.msg.dds_.TFMessage_ from, System.IntPtr to)
                {
                    __TFMessage_ nativeImg = new __TFMessage_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, tf2_msgs.msg.dds_.TFMessage_ from, ref __TFMessage_ to)
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
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __TFMessage_ nativeImg = (__TFMessage_) Marshal.PtrToStructure(from, typeof(__TFMessage_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    tf2_msgs.msg.dds_.TFMessage_ toObj = tmpGCHandleTo.Target as tf2_msgs.msg.dds_.TFMessage_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref tf2_msgs.msg.dds_.TFMessage_ to)
                {
                    __TFMessage_ nativeImg = (__TFMessage_) Marshal.PtrToStructure(from, typeof(__TFMessage_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref tf2_msgs.msg.dds_.TFMessage_ to)
                {
                    __TFMessage_ nativeImg = (__TFMessage_) Marshal.PtrToStructure(from, typeof(__TFMessage_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __TFMessage_ from, ref tf2_msgs.msg.dds_.TFMessage_ to)
                {
                    if (to == null) {
                        to = new tf2_msgs.msg.dds_.TFMessage_();
                    }
                    IntPtr attr0Seq0Buf = from.transforms_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.transforms_ == null || to.transforms_.Length != attr0Seq0Length) {
                        geometry_msgs.msg.dds_.TransformStamped_[] target = new geometry_msgs.msg.dds_.TransformStamped_[attr0Seq0Length];
                        initObjectSeq(to.transforms_, target);
                        to.transforms_ = target;
                    }
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__TransformStamped_Marshaler.StaticCopyOut(attr0Seq0Buf, ref to.transforms_[i0]);
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

