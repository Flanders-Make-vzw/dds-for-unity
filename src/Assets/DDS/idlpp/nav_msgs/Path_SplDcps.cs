using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace nav_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __Path_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Path_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr poses_;
            }
            #endregion

            #region __Path_Marshaler
            public sealed class __Path_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.msg.dds_.Path_>
            {
                public static readonly string fullyScopedName = "nav_msgs::msg::dds_::Path_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr1Col0Type = IntPtr.Zero;
                private static readonly int attr1Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__PoseStamped_));
                private geometry_msgs.msg.dds_.__PoseStamped_Marshaler attr1Marshaler;

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__PoseStamped_)) as geometry_msgs.msg.dds_.__PoseStamped_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new geometry_msgs.msg.dds_.__PoseStamped_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__PoseStamped_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.msg.dds_.Path_ fromData = tmpGCHandle.Target as nav_msgs.msg.dds_.Path_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.Path_ from, System.IntPtr to)
                {
                    __Path_ nativeImg = new __Path_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.Path_ from, ref __Path_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.poses_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr1Seq0Length = from.poses_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr1Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "poses_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr1Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Col0Type, attr1Seq0Length);
                    if (attr1Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.poses_ = attr1Seq0Buf;
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.poses_[i0], attr1Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Path_ nativeImg = (__Path_) Marshal.PtrToStructure(from, typeof(__Path_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.msg.dds_.Path_ toObj = tmpGCHandleTo.Target as nav_msgs.msg.dds_.Path_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.Path_ to)
                {
                    __Path_ nativeImg = (__Path_) Marshal.PtrToStructure(from, typeof(__Path_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.Path_ to)
                {
                    __Path_ nativeImg = (__Path_) Marshal.PtrToStructure(from, typeof(__Path_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Path_ from, ref nav_msgs.msg.dds_.Path_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.msg.dds_.Path_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    IntPtr attr1Seq0Buf = from.poses_;
                    int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
                    if (to.poses_ == null || to.poses_.Length != attr1Seq0Length) {
                        geometry_msgs.msg.dds_.PoseStamped_[] target = new geometry_msgs.msg.dds_.PoseStamped_[attr1Seq0Length];
                        initObjectSeq(to.poses_, target);
                        to.poses_ = target;
                    }
                    for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__PoseStamped_Marshaler.StaticCopyOut(attr1Seq0Buf, ref to.poses_[i0]);
                        attr1Seq0Buf = new IntPtr(attr1Seq0Buf.ToInt64() + attr1Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

