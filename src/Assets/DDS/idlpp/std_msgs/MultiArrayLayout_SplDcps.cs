using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __MultiArrayLayout_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MultiArrayLayout_
            {
                public IntPtr dim_;
                public uint data_offset_;
            }
            #endregion

            #region __MultiArrayLayout_Marshaler
            public sealed class __MultiArrayLayout_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.MultiArrayLayout_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::MultiArrayLayout_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(std_msgs.msg.dds_.__MultiArrayDimension_));
                private std_msgs.msg.dds_.__MultiArrayDimension_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(std_msgs.msg.dds_.__MultiArrayDimension_)) as std_msgs.msg.dds_.__MultiArrayDimension_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new std_msgs.msg.dds_.__MultiArrayDimension_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(std_msgs.msg.dds_.__MultiArrayDimension_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.MultiArrayLayout_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.MultiArrayLayout_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.MultiArrayLayout_ from, System.IntPtr to)
                {
                    __MultiArrayLayout_ nativeImg = new __MultiArrayLayout_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.MultiArrayLayout_ from, ref __MultiArrayLayout_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.dim_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr0Seq0Length = from.dim_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr0Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "dim_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr0Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr0Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr0Col0Type, attr0Seq0Length);
                    if (attr0Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.dim_ = attr0Seq0Buf;
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.dim_[i0], attr0Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                    to.data_offset_ = from.data_offset_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MultiArrayLayout_ nativeImg = (__MultiArrayLayout_) Marshal.PtrToStructure(from, typeof(__MultiArrayLayout_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.MultiArrayLayout_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.MultiArrayLayout_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.MultiArrayLayout_ to)
                {
                    __MultiArrayLayout_ nativeImg = (__MultiArrayLayout_) Marshal.PtrToStructure(from, typeof(__MultiArrayLayout_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.MultiArrayLayout_ to)
                {
                    __MultiArrayLayout_ nativeImg = (__MultiArrayLayout_) Marshal.PtrToStructure(from, typeof(__MultiArrayLayout_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MultiArrayLayout_ from, ref std_msgs.msg.dds_.MultiArrayLayout_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.MultiArrayLayout_();
                    }
                    IntPtr attr0Seq0Buf = from.dim_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.dim_ == null || to.dim_.Length != attr0Seq0Length) {
                        std_msgs.msg.dds_.MultiArrayDimension_[] target = new std_msgs.msg.dds_.MultiArrayDimension_[attr0Seq0Length];
                        initObjectSeq(to.dim_, target);
                        to.dim_ = target;
                    }
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        std_msgs.msg.dds_.__MultiArrayDimension_Marshaler.StaticCopyOut(attr0Seq0Buf, ref to.dim_[i0]);
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                    to.data_offset_ = from.data_offset_;
                }

            }
            #endregion

        }

    }

}

