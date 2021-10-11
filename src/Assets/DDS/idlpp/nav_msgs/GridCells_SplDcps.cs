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
            #region __GridCells_
            [StructLayout(LayoutKind.Sequential)]
            public struct __GridCells_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public float cell_width_;
                public float cell_height_;
                public IntPtr cells_;
            }
            #endregion

            #region __GridCells_Marshaler
            public sealed class __GridCells_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.msg.dds_.GridCells_>
            {
                public static readonly string fullyScopedName = "nav_msgs::msg::dds_::GridCells_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private IntPtr attr3Col0Type = IntPtr.Zero;
                private static readonly int attr3Col0Size = 1 * Marshal.SizeOf(typeof(geometry_msgs.msg.dds_.__Point_));
                private geometry_msgs.msg.dds_.__Point_Marshaler attr3Marshaler;

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
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(geometry_msgs.msg.dds_.__Point_)) as geometry_msgs.msg.dds_.__Point_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new geometry_msgs.msg.dds_.__Point_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(geometry_msgs.msg.dds_.__Point_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.msg.dds_.GridCells_ fromData = tmpGCHandle.Target as nav_msgs.msg.dds_.GridCells_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.GridCells_ from, System.IntPtr to)
                {
                    __GridCells_ nativeImg = new __GridCells_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.GridCells_ from, ref __GridCells_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    to.cell_width_ = from.cell_width_;
                    to.cell_height_ = from.cell_height_;
                    if (from.cells_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr3Seq0Length = from.cells_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr3Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "cells_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr3Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Col0Type, attr3Seq0Length);
                    if (attr3Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.cells_ = attr3Seq0Buf;
                    for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.cells_[i0], attr3Seq0Buf);
                        if (result != V_COPYIN_RESULT.OK) return result;
                        attr3Seq0Buf = new IntPtr(attr3Seq0Buf.ToInt64() + attr3Col0Size);
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __GridCells_ nativeImg = (__GridCells_) Marshal.PtrToStructure(from, typeof(__GridCells_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.msg.dds_.GridCells_ toObj = tmpGCHandleTo.Target as nav_msgs.msg.dds_.GridCells_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.GridCells_ to)
                {
                    __GridCells_ nativeImg = (__GridCells_) Marshal.PtrToStructure(from, typeof(__GridCells_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.GridCells_ to)
                {
                    __GridCells_ nativeImg = (__GridCells_) Marshal.PtrToStructure(from, typeof(__GridCells_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __GridCells_ from, ref nav_msgs.msg.dds_.GridCells_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.msg.dds_.GridCells_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.cell_width_ = from.cell_width_;
                    to.cell_height_ = from.cell_height_;
                    IntPtr attr3Seq0Buf = from.cells_;
                    int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
                    if (to.cells_ == null || to.cells_.Length != attr3Seq0Length) {
                        geometry_msgs.msg.dds_.Point_[] target = new geometry_msgs.msg.dds_.Point_[attr3Seq0Length];
                        initObjectSeq(to.cells_, target);
                        to.cells_ = target;
                    }
                    for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                        geometry_msgs.msg.dds_.__Point_Marshaler.StaticCopyOut(attr3Seq0Buf, ref to.cells_[i0]);
                        attr3Seq0Buf = new IntPtr(attr3Seq0Buf.ToInt64() + attr3Col0Size);
                    }
                }

            }
            #endregion

        }

    }

}

