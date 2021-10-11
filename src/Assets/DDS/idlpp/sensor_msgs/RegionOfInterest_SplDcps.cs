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
            #region __RegionOfInterest_
            [StructLayout(LayoutKind.Sequential)]
            public struct __RegionOfInterest_
            {
                public uint x_offset_;
                public uint y_offset_;
                public uint height_;
                public uint width_;
                public byte do_rectify_;
            }
            #endregion

            #region __RegionOfInterest_Marshaler
            public sealed class __RegionOfInterest_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<sensor_msgs.msg.dds_.RegionOfInterest_>
            {
                public static readonly string fullyScopedName = "sensor_msgs::msg::dds_::RegionOfInterest_";

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    sensor_msgs.msg.dds_.RegionOfInterest_ fromData = tmpGCHandle.Target as sensor_msgs.msg.dds_.RegionOfInterest_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.RegionOfInterest_ from, System.IntPtr to)
                {
                    __RegionOfInterest_ nativeImg = new __RegionOfInterest_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, sensor_msgs.msg.dds_.RegionOfInterest_ from, ref __RegionOfInterest_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.x_offset_ = from.x_offset_;
                    to.y_offset_ = from.y_offset_;
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    to.do_rectify_ = from.do_rectify_ ? (byte) 1 : (byte) 0;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __RegionOfInterest_ nativeImg = (__RegionOfInterest_) Marshal.PtrToStructure(from, typeof(__RegionOfInterest_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    sensor_msgs.msg.dds_.RegionOfInterest_ toObj = tmpGCHandleTo.Target as sensor_msgs.msg.dds_.RegionOfInterest_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.RegionOfInterest_ to)
                {
                    __RegionOfInterest_ nativeImg = (__RegionOfInterest_) Marshal.PtrToStructure(from, typeof(__RegionOfInterest_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref sensor_msgs.msg.dds_.RegionOfInterest_ to)
                {
                    __RegionOfInterest_ nativeImg = (__RegionOfInterest_) Marshal.PtrToStructure(from, typeof(__RegionOfInterest_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __RegionOfInterest_ from, ref sensor_msgs.msg.dds_.RegionOfInterest_ to)
                {
                    if (to == null) {
                        to = new sensor_msgs.msg.dds_.RegionOfInterest_();
                    }
                    to.x_offset_ = from.x_offset_;
                    to.y_offset_ = from.y_offset_;
                    to.height_ = from.height_;
                    to.width_ = from.width_;
                    to.do_rectify_ = from.do_rectify_ != 0 ? true : false;
                }

            }
            #endregion

        }

    }

}

