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
            #region __LaserEcho_
            [StructLayout(LayoutKind.Sequential)]
            public struct __LaserEcho_
            {
                public IntPtr echoes_;
            }
            #endregion

            #region __LaserEcho_Marshaler
            public sealed class __LaserEcho_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.LaserEcho_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::LaserEcho_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(float));

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.LaserEcho_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.LaserEcho_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.LaserEcho_ from, System.IntPtr to)
                {
                    __LaserEcho_ nativeImg = new __LaserEcho_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.LaserEcho_ from, ref __LaserEcho_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.echoes_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr0Seq0Length = from.echoes_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr0Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "echoes_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr0Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr0Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr0Col0Type, attr0Seq0Length);
                    if (attr0Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.echoes_ = attr0Seq0Buf;
                    Marshal.Copy(from.echoes_, 0, attr0Seq0Buf, attr0Seq0Length);
                    to.echoes_ = attr0Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __LaserEcho_ nativeImg = (__LaserEcho_) Marshal.PtrToStructure(from, typeof(__LaserEcho_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.LaserEcho_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.LaserEcho_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.LaserEcho_ to)
                {
                    __LaserEcho_ nativeImg = (__LaserEcho_) Marshal.PtrToStructure(from, typeof(__LaserEcho_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.LaserEcho_ to)
                {
                    __LaserEcho_ nativeImg = (__LaserEcho_) Marshal.PtrToStructure(from, typeof(__LaserEcho_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __LaserEcho_ from, ref sensor_msgs.msg.dds_.LaserEcho_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.LaserEcho_();
                    }
                    IntPtr attr0Seq0Buf = from.echoes_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.echoes_ == null || to.echoes_.Length != attr0Seq0Length) {
                        to.echoes_ = new float[attr0Seq0Length];
                    }
                    if(attr0Seq0Length > 0) Marshal.Copy(attr0Seq0Buf, to.echoes_, 0, attr0Seq0Length);
                }

            }
            #endregion

        }

    }

}

