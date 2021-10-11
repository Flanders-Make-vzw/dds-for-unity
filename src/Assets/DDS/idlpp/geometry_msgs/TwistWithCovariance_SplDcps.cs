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
            #region __TwistWithCovariance_
            [StructLayout(LayoutKind.Sequential)]
            public struct __TwistWithCovariance_
            {
                public geometry_msgs.msg.dds_.__Twist_ twist_;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst=36)]
                public double[] covariance_;
            }
            #endregion

            #region __TwistWithCovariance_Marshaler
            public sealed class __TwistWithCovariance_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.TwistWithCovariance_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::TwistWithCovariance_";
                private geometry_msgs.msg.dds_.__Twist_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(double));

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Twist_)) as geometry_msgs.msg.dds_.__Twist_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__Twist_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Twist_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.TwistWithCovariance_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.TwistWithCovariance_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.TwistWithCovariance_ from, System.IntPtr to)
                {
                    __TwistWithCovariance_ nativeImg = new __TwistWithCovariance_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.TwistWithCovariance_ from, ref __TwistWithCovariance_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.twist_, ref to.twist_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.covariance_ == null) return V_COPYIN_RESULT.INVALID;
                    if (from.covariance_.GetLength(0) != 36) return V_COPYIN_RESULT.INVALID;
                    to.covariance_ = new double[36];
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "covariance_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    System.Buffer.BlockCopy(from.covariance_, 0, to.covariance_, 0, (36 * Marshal.SizeOf(typeof(double))));
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __TwistWithCovariance_ nativeImg = (__TwistWithCovariance_) Marshal.PtrToStructure(from, typeof(__TwistWithCovariance_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.TwistWithCovariance_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.TwistWithCovariance_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.TwistWithCovariance_ to)
                {
                    __TwistWithCovariance_ nativeImg = (__TwistWithCovariance_) Marshal.PtrToStructure(from, typeof(__TwistWithCovariance_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.TwistWithCovariance_ to)
                {
                    __TwistWithCovariance_ nativeImg = (__TwistWithCovariance_) Marshal.PtrToStructure(from, typeof(__TwistWithCovariance_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __TwistWithCovariance_ from, ref geometry_msgs.msg.dds_.TwistWithCovariance_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.TwistWithCovariance_();
                    }
                    geometry_msgs.msg.dds_.__Twist_Marshaler.CopyOut(ref from.twist_, ref to.twist_);
                    if (to.covariance_ == null || to.covariance_.GetLength(0) != 36) {
                        to.covariance_ = new double[36];
                    }
                    System.Buffer.BlockCopy(from.covariance_, 0, to.covariance_, 0, (36 * Marshal.SizeOf(typeof(double))));
                }

            }
            #endregion

        }

    }

}

