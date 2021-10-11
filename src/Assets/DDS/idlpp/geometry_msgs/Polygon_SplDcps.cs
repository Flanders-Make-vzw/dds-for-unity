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
            #region __Polygon_
            [StructLayout(LayoutKind.Sequential)]
            public struct __Polygon_
            {
                public IntPtr points_;
            }
            #endregion

            #region __Polygon_Marshaler
            public sealed class __Polygon_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<geometry_msgs.msg.dds_.Polygon_>
            {
                public static readonly string fullyScopedName = "geometry_msgs::msg::dds_::Polygon_";
                private IntPtr attr0Col0Type = IntPtr.Zero;
                private static readonly int attr0Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Point32_));
                private geometry_msgs.msg.dds_.__Point32_Marshaler attr0Marshaler;

                public override void InitEmbeddedMarshalers(IDomainParticipant participant)
                {
                    if (attr0Marshaler == null) {
                        attr0Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Point32_)) as geometry_msgs.msg.dds_.__Point32_Marshaler;
                        if (attr0Marshaler == null) {
                            attr0Marshaler = new geometry_msgs.msg.dds_.__Point32_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Point32_), attr0Marshaler);
                            attr0Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    geometry_msgs.msg.dds_.Polygon_ fromData = tmpGCHandle.Target as geometry_msgs.msg.dds_.Polygon_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Polygon_ from, System.IntPtr to)
                {
                    __Polygon_ nativeImg = new __Polygon_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, geometry_msgs.msg.dds_.Polygon_ from, ref __Polygon_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    if (from.points_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr0Seq0Length = from.points_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr0Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "points_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr0Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr0Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr0Col0Type, attr0Seq0Length);
                    if (attr0Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.points_ = attr0Seq0Buf;
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.points_[i0], attr0Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __Polygon_ nativeImg = (__Polygon_) Marshal.PtrToStructure(from, typeof(__Polygon_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    geometry_msgs.msg.dds_.Polygon_ toObj = tmpGCHandleTo.Target as geometry_msgs.msg.dds_.Polygon_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Polygon_ to)
                {
                    __Polygon_ nativeImg = (__Polygon_) Marshal.PtrToStructure(from, typeof(__Polygon_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref geometry_msgs.msg.dds_.Polygon_ to)
                {
                    __Polygon_ nativeImg = (__Polygon_) Marshal.PtrToStructure(from, typeof(__Polygon_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __Polygon_ from, ref geometry_msgs.msg.dds_.Polygon_ to)
                {
                    if (to == null) {
                        to = new geometry_msgs.msg.dds_.Polygon_();
                    }
                    IntPtr attr0Seq0Buf = from.points_;
                    int attr0Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr0Seq0Buf);
                    if (to.points_ == null || to.points_.Length != attr0Seq0Length) {
                        geometry_msgs.msg.dds_.Point32_[] target = new geometry_msgs.msg.dds_.Point32_[attr0Seq0Length];
                        initObjectSeq(to.points_, target);
                        to.points_ = target;
                    }
                    for (int i0 = 0; i0 < attr0Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Point32_Marshaler.StaticCopyOut(attr0Seq0Buf, ref to.points_[i0]);
                        attr0Seq0Buf = new IntPtr(attr0Seq0Buf.ToInt64() + attr0Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

