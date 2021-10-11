using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace geometry_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __TwistWithCovarianceStamped_
            [StructLayout(LayoutKind.Sequential)]
            public struct __TwistWithCovarianceStamped_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public geometry_msgs.msg.dds_.__TwistWithCovariance_ twist_;
            }
            #endregion

            #region __TwistWithCovarianceStamped_Marshaler
            public sealed class __TwistWithCovarianceStamped_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.TwistWithCovarianceStamped_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::TwistWithCovarianceStamped_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler attr1Marshaler;

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
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__TwistWithCovariance_)) as geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__TwistWithCovariance_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.TwistWithCovarianceStamped_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ from, System.IntPtr to)
                {
                    __TwistWithCovarianceStamped_ nativeImg = new __TwistWithCovarianceStamped_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ from, ref __TwistWithCovarianceStamped_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.twist_, ref to.twist_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __TwistWithCovarianceStamped_ nativeImg = (__TwistWithCovarianceStamped_) Marshal.PtrToStructure(from, typeof(__TwistWithCovarianceStamped_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.TwistWithCovarianceStamped_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ to)
                {
                    __TwistWithCovarianceStamped_ nativeImg = (__TwistWithCovarianceStamped_) Marshal.PtrToStructure(from, typeof(__TwistWithCovarianceStamped_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ to)
                {
                    __TwistWithCovarianceStamped_ nativeImg = (__TwistWithCovarianceStamped_) Marshal.PtrToStructure(from, typeof(__TwistWithCovarianceStamped_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __TwistWithCovarianceStamped_ from, ref geometry_msgs.msg.dds_.TwistWithCovarianceStamped_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.TwistWithCovarianceStamped_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    geometry_msgs.msg.dds_.__TwistWithCovariance_Marshaler.CopyOut(ref from.twist_, ref to.twist_);
                }

            }
            #endregion

        }

    }

}

