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
            #region __InertiaStamped_
            [StructLayout(LayoutKind.Sequential)]
            public struct __InertiaStamped_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public geometry_msgs.msg.dds_.__Inertia_ inertia_;
            }
            #endregion

            #region __InertiaStamped_Marshaler
            public sealed class __InertiaStamped_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.InertiaStamped_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::InertiaStamped_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private geometry_msgs.msg.dds_.__Inertia_Marshaler attr1Marshaler;

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Inertia_)) as geometry_msgs.msg.dds_.__Inertia_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__Inertia_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Inertia_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.InertiaStamped_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.InertiaStamped_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.InertiaStamped_ from, System.IntPtr to)
                {
                    __InertiaStamped_ nativeImg = new __InertiaStamped_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.InertiaStamped_ from, ref __InertiaStamped_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.inertia_, ref to.inertia_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __InertiaStamped_ nativeImg = (__InertiaStamped_) Marshal.PtrToStructure(from, typeof(__InertiaStamped_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.InertiaStamped_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.InertiaStamped_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.InertiaStamped_ to)
                {
                    __InertiaStamped_ nativeImg = (__InertiaStamped_) Marshal.PtrToStructure(from, typeof(__InertiaStamped_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.InertiaStamped_ to)
                {
                    __InertiaStamped_ nativeImg = (__InertiaStamped_) Marshal.PtrToStructure(from, typeof(__InertiaStamped_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __InertiaStamped_ from, ref geometry_msgs.msg.dds_.InertiaStamped_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.InertiaStamped_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    geometry_msgs.msg.dds_.__Inertia_Marshaler.CopyOut(ref from.inertia_, ref to.inertia_);
                }

            }
            #endregion

        }

    }

}

