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
            #region __Image_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Image_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public uint height_;
                public uint width_;
                public IntPtr encoding_;
                public byte is_bigendian_;
                public uint step_;
                public IntPtr data_;
            }
            #endregion

            #region __Image_Marshaler
            public sealed class __Image_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.Image_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::Image_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr6Col0Type = IntPtr.Zero;
                private static readonly int attr6Col0Size = 1 * Marshal.SizeOf(typeof(byte));

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
                    sensor_msgs.msg.dds_.Image_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.Image_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Image_ from, System.IntPtr to)
                {
                    __Image_ nativeImg = new __Image_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Image_ from, ref __Image_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    if (from.encoding_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.encoding_, from.encoding_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.is_bigendian_ = from.is_bigendian_;
                    to.step_ = from.step_;
                    if (from.data_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr6Seq0Length = from.data_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr6Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "data_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr6Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr6Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr6Col0Type, attr6Seq0Length);
                    if (attr6Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.data_ = attr6Seq0Buf;
                    Marshal.Copy(from.data_, 0, attr6Seq0Buf, attr6Seq0Length);
                    to.data_ = attr6Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Image_ nativeImg = (__Image_) Marshal.PtrToStructure(from, typeof(__Image_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.Image_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.Image_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Image_ to)
                {
                    __Image_ nativeImg = (__Image_) Marshal.PtrToStructure(from, typeof(__Image_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Image_ to)
                {
                    __Image_ nativeImg = (__Image_) Marshal.PtrToStructure(from, typeof(__Image_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Image_ from, ref sensor_msgs.msg.dds_.Image_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.Image_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    to.encoding_ = ReadString(from.encoding_);
                    to.is_bigendian_ = from.is_bigendian_;
                    to.step_ = from.step_;
                    IntPtr attr6Seq0Buf = from.data_;
                    int attr6Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr6Seq0Buf);
                    if (to.data_ == null || to.data_.Length != attr6Seq0Length) {
                        to.data_ = new byte[attr6Seq0Length];
                    }
                    if(attr6Seq0Length > 0) Marshal.Copy(attr6Seq0Buf, to.data_, 0, attr6Seq0Length);
                }

            }
            #endregion

        }

    }

}

