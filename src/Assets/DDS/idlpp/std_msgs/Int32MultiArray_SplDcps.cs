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
            #region __Int32MultiArray_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Int32MultiArray_
            {
                public std_msgs.msg.dds_.__MultiArrayLayout_ layout_;
                public IntPtr data_;
            }
            #endregion

            #region __Int32MultiArray_Marshaler
            public sealed class __Int32MultiArray_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<std_msgs.msg.dds_.Int32MultiArray_>
            {
                public static readonly string fullyScopedName = "std_msgs::msg::dds_::Int32MultiArray_";
                private std_msgs.msg.dds_.__MultiArrayLayout_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(int));

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(std_msgs.msg.dds_.__MultiArrayLayout_)) as std_msgs.msg.dds_.__MultiArrayLayout_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new std_msgs.msg.dds_.__MultiArrayLayout_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(std_msgs.msg.dds_.__MultiArrayLayout_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    std_msgs.msg.dds_.Int32MultiArray_ fromData = tmpGCHandle.Target as std_msgs.msg.dds_.Int32MultiArray_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Int32MultiArray_ from, System.IntPtr to)
                {
                    __Int32MultiArray_ nativeImg = new __Int32MultiArray_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, std_msgs.msg.dds_.Int32MultiArray_ from, ref __Int32MultiArray_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.layout_, ref to.layout_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.data_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.data_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "data_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.data_ = attr1Seq0Buf;
                    Marshal.Copy(from.data_, 0, attr1Seq0Buf, attr1Seq0Length);
                    to.data_ = attr1Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Int32MultiArray_ nativeImg = (__Int32MultiArray_) Marshal.PtrToStructure(from, typeof(__Int32MultiArray_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    std_msgs.msg.dds_.Int32MultiArray_ toObj = tmpGCHandleTo.Target as std_msgs.msg.dds_.Int32MultiArray_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Int32MultiArray_ to)
                {
                    __Int32MultiArray_ nativeImg = (__Int32MultiArray_) Marshal.PtrToStructure(from, typeof(__Int32MultiArray_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref std_msgs.msg.dds_.Int32MultiArray_ to)
                {
                    __Int32MultiArray_ nativeImg = (__Int32MultiArray_) Marshal.PtrToStructure(from, typeof(__Int32MultiArray_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Int32MultiArray_ from, ref std_msgs.msg.dds_.Int32MultiArray_ to)
                {
                    if (to == null) {
                        to = new std_msgs.msg.dds_.Int32MultiArray_();
                    }
                    std_msgs.msg.dds_.__MultiArrayLayout_Marshaler.CopyOut(ref from.layout_, ref to.layout_);
                    IntPtr attr1Seq0Buf = from.data_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.data_ == null || to.data_.Length != attr1Seq0Length) {
                        to.data_ = new int[attr1Seq0Length];
                    }
                    if(attr1Seq0Length > 0) Marshal.Copy(attr1Seq0Buf, to.data_, 0, attr1Seq0Length);
                }

            }
            #endregion

        }

    }

}

