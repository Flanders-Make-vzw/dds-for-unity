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
            #region __CompressedImage_
            [StructLayout(LayoutKind.Sequential)]
            public struct __CompressedImage_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr format_;
                public IntPtr data_;
            }
            #endregion

            #region __CompressedImage_Marshaler
            public sealed class __CompressedImage_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.CompressedImage_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::CompressedImage_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(byte));

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
                    sensor_msgs.msg.dds_.CompressedImage_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.CompressedImage_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.CompressedImage_ from, System.IntPtr to)
                {
                    __CompressedImage_ nativeImg = new __CompressedImage_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.CompressedImage_ from, ref __CompressedImage_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.format_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.format_, from.format_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    if (from.data_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.data_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "data_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.data_ = attr2Seq0Buf;
                    Marshal.Copy(from.data_, 0, attr2Seq0Buf, attr2Seq0Length);
                    to.data_ = attr2Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __CompressedImage_ nativeImg = (__CompressedImage_) Marshal.PtrToStructure(from, typeof(__CompressedImage_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.CompressedImage_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.CompressedImage_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.CompressedImage_ to)
                {
                    __CompressedImage_ nativeImg = (__CompressedImage_) Marshal.PtrToStructure(from, typeof(__CompressedImage_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.CompressedImage_ to)
                {
                    __CompressedImage_ nativeImg = (__CompressedImage_) Marshal.PtrToStructure(from, typeof(__CompressedImage_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __CompressedImage_ from, ref sensor_msgs.msg.dds_.CompressedImage_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.CompressedImage_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.format_ = ReadString(from.format_);
                    IntPtr attr2Seq0Buf = from.data_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.data_ == null || to.data_.Length != attr2Seq0Length) {
                        to.data_ = new byte[attr2Seq0Length];
                    }
                    if(attr2Seq0Length > 0) Marshal.Copy(attr2Seq0Buf, to.data_, 0, attr2Seq0Length);
                }

            }
            #endregion

        }

    }

}

