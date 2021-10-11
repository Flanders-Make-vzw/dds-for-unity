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
            #region __ChannelFloat32_
            [StructLayout(LayoutKind.Sequential)]
            public struct __ChannelFloat32_
            {
                public IntPtr name_;
                public IntPtr values_;
            }
            #endregion

            #region __ChannelFloat32_Marshaler
            public sealed class __ChannelFloat32_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.ChannelFloat32_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::ChannelFloat32_";
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(float));

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.ChannelFloat32_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.ChannelFloat32_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.ChannelFloat32_ from, System.IntPtr to)
                {
                    __ChannelFloat32_ nativeImg = new __ChannelFloat32_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.ChannelFloat32_ from, ref __ChannelFloat32_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.name_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.name_, from.name_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    if (from.values_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.values_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "values_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.values_ = attr1Seq0Buf;
                    Marshal.Copy(from.values_, 0, attr1Seq0Buf, attr1Seq0Length);
                    to.values_ = attr1Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __ChannelFloat32_ nativeImg = (__ChannelFloat32_) Marshal.PtrToStructure(from, typeof(__ChannelFloat32_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.ChannelFloat32_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.ChannelFloat32_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.ChannelFloat32_ to)
                {
                    __ChannelFloat32_ nativeImg = (__ChannelFloat32_) Marshal.PtrToStructure(from, typeof(__ChannelFloat32_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.ChannelFloat32_ to)
                {
                    __ChannelFloat32_ nativeImg = (__ChannelFloat32_) Marshal.PtrToStructure(from, typeof(__ChannelFloat32_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __ChannelFloat32_ from, ref sensor_msgs.msg.dds_.ChannelFloat32_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.ChannelFloat32_();
                    }
                    to.name_ = ReadString(from.name_);
                    IntPtr attr1Seq0Buf = from.values_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.values_ == null || to.values_.Length != attr1Seq0Length) {
                        to.values_ = new float[attr1Seq0Length];
                    }
                    if(attr1Seq0Length > 0) Marshal.Copy(attr1Seq0Buf, to.values_, 0, attr1Seq0Length);
                }

            }
            #endregion

        }

    }

}

