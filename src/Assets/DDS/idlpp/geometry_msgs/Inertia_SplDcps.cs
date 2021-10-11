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
            #region __Inertia_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Inertia_
            {
                public double m_;
                public geometry_msgs.msg.dds_.__Vector3_ com_;
                public double ixx_;
                public double ixy_;
                public double ixz_;
                public double iyy_;
                public double iyz_;
                public double izz_;
            }
            #endregion

            #region __Inertia_Marshaler
            public sealed class __Inertia_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Inertia_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Inertia_";
                private geometry_msgs.msg.dds_.__Vector3_Marshaler attr1Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr1Marshaler == null) {
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Vector3_)) as geometry_msgs.msg.dds_.__Vector3_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Vector3_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Vector3_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Inertia_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Inertia_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Inertia_ from, System.IntPtr to)
                {
                    __Inertia_ nativeImg = new __Inertia_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Inertia_ from, ref __Inertia_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    to.m_ = from.m_;
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.com_, ref to.com_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.ixx_ = from.ixx_;
                    to.ixy_ = from.ixy_;
                    to.ixz_ = from.ixz_;
                    to.iyy_ = from.iyy_;
                    to.iyz_ = from.iyz_;
                    to.izz_ = from.izz_;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Inertia_ nativeImg = (__Inertia_) Marshal.PtrToStructure(from, typeof(__Inertia_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Inertia_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Inertia_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Inertia_ to)
                {
                    __Inertia_ nativeImg = (__Inertia_) Marshal.PtrToStructure(from, typeof(__Inertia_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Inertia_ to)
                {
                    __Inertia_ nativeImg = (__Inertia_) Marshal.PtrToStructure(from, typeof(__Inertia_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Inertia_ from, ref geometry_msgs.msg.dds_.Inertia_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Inertia_();
                    }
                    to.m_ = from.m_;
                    geometry_msgs.msg.dds_.__Vector3_Marshaler.CopyOut(ref from.com_, ref to.com_);
                    to.ixx_ = from.ixx_;
                    to.ixy_ = from.ixy_;
                    to.ixz_ = from.ixz_;
                    to.iyy_ = from.iyy_;
                    to.iyz_ = from.iyz_;
                    to.izz_ = from.izz_;
                }

            }
            #endregion

        }

    }

}

