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
            namespace PointField_Constants
            {
            }

            #region __PointField_
            [StructLayout(LayoutKind.Sequential)]
            public struct __PointField_
            {
                public IntPtr name_;
                public uint offset_;
                public byte datatype_;
                public uint count_;
            }
            #endregion

            #region __PointField_Marshaler
            public sealed class __PointField_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.PointField_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::PointField_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.PointField_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.PointField_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.PointField_ from, System.IntPtr to)
                {
                    __PointField_ nativeImg = new __PointField_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.PointField_ from, ref __PointField_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.name_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.name_, from.name_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.offset_ = from.offset_;
                    to.datatype_ = from.datatype_;
                    to.count_ = from.count_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __PointField_ nativeImg = (__PointField_) Marshal.PtrToStructure(from, typeof(__PointField_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.PointField_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.PointField_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.PointField_ to)
                {
                    __PointField_ nativeImg = (__PointField_) Marshal.PtrToStructure(from, typeof(__PointField_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.PointField_ to)
                {
                    __PointField_ nativeImg = (__PointField_) Marshal.PtrToStructure(from, typeof(__PointField_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __PointField_ from, ref sensor_msgs.msg.dds_.PointField_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.PointField_();
                    }
                    to.name_ = ReadString(from.name_);
                    to.offset_ = from.offset_;
                    to.datatype_ = from.datatype_;
                    to.count_ = from.count_;
                }

            }
            #endregion

        }

    }

}

