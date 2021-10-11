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
            #region __Joy_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Joy_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr axes_;
                public IntPtr buttons_;
            }
            #endregion

            #region __Joy_Marshaler
            public sealed class __Joy_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.Joy_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::Joy_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(float));
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(int));

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
                    sensor_msgs.msg.dds_.Joy_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.Joy_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Joy_ from, System.IntPtr to)
                {
                    __Joy_ nativeImg = new __Joy_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.Joy_ from, ref __Joy_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.axes_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.axes_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "axes_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.axes_ = attr1Seq0Buf;
                    Marshal.Copy(from.axes_, 0, attr1Seq0Buf, attr1Seq0Length);
                    to.axes_ = attr1Seq0Buf;
                    if (from.buttons_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.buttons_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "buttons_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.buttons_ = attr2Seq0Buf;
                    Marshal.Copy(from.buttons_, 0, attr2Seq0Buf, attr2Seq0Length);
                    to.buttons_ = attr2Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Joy_ nativeImg = (__Joy_) Marshal.PtrToStructure(from, typeof(__Joy_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.Joy_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.Joy_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Joy_ to)
                {
                    __Joy_ nativeImg = (__Joy_) Marshal.PtrToStructure(from, typeof(__Joy_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.Joy_ to)
                {
                    __Joy_ nativeImg = (__Joy_) Marshal.PtrToStructure(from, typeof(__Joy_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Joy_ from, ref sensor_msgs.msg.dds_.Joy_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.Joy_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    IntPtr attr1Seq0Buf = from.axes_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.axes_ == null || to.axes_.Length != attr1Seq0Length) {
                        to.axes_ = new float[attr1Seq0Length];
                    }
                    if(attr1Seq0Length > 0) Marshal.Copy(attr1Seq0Buf, to.axes_, 0, attr1Seq0Length);
                    IntPtr attr2Seq0Buf = from.buttons_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.buttons_ == null || to.buttons_.Length != attr2Seq0Length) {
                        to.buttons_ = new int[attr2Seq0Length];
                    }
                    if(attr2Seq0Length > 0) Marshal.Copy(attr2Seq0Buf, to.buttons_, 0, attr2Seq0Length);
                }

            }
            #endregion

        }

    }

}

