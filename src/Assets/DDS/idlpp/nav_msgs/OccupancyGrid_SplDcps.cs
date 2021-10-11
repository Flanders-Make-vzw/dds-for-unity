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
            #region __OccupancyGrid_
            [StructLayout(LayoutKind.Sequential)]
            public struct __OccupancyGrid_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public nav_msgs.msg.dds_.__MapMetaData_ info_;
                public IntPtr data_;
            }
            #endregion

            #region __OccupancyGrid_Marshaler
            public sealed class __OccupancyGrid_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<nav_msgs.msg.dds_.OccupancyGrid_>
            {
                public static readonly string fullyScopedName = "nav_msgs::msg::dds_::OccupancyGrid_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private nav_msgs.msg.dds_.__MapMetaData_Marshaler attr1Marshaler;
                private IntPtr attr2Col0Type = IntPtr.Zero;
                private static readonly int attr2Col0Size = 1 * Marshal.SizeOf(typeof(byte));

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
                        attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.msg.dds_.__MapMetaData_)) as nav_msgs.msg.dds_.__MapMetaData_Marshaler;
                        if (attr1Marshaler == null) {
                            attr1Marshaler = new nav_msgs.msg.dds_.__MapMetaData_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.msg.dds_.__MapMetaData_), attr1Marshaler);
                            attr1Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    nav_msgs.msg.dds_.OccupancyGrid_ fromData = tmpGCHandle.Target as nav_msgs.msg.dds_.OccupancyGrid_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.OccupancyGrid_ from, System.IntPtr to)
                {
                    __OccupancyGrid_ nativeImg = new __OccupancyGrid_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, nav_msgs.msg.dds_.OccupancyGrid_ from, ref __OccupancyGrid_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr1Marshaler.CopyIn(typePtr, from.info_, ref to.info_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.data_ == null) return V_COPYIN_RESULT.INVALID;
                    int attr2Seq0Length = from.data_.Length;
                    // Unbounded sequence: bounds check not required...
                    if (attr2Col0Type == IntPtr.Zero) {
                        IntPtr memberOwnerType = DDS.OpenSplice.Database.c.resolve(c.getBase(typePtr), fullyScopedName);
                        IntPtr specifier = DDS.OpenSplice.Database.c.metaResolveSpecifier(memberOwnerType, "data_");
                        IntPtr specifierType = DDS.OpenSplice.Database.c.specifierType(specifier);
                        attr2Col0Type = DDS.OpenSplice.Database.c.typeActualType(specifierType);
                    }
                    IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Col0Type, attr2Seq0Length);
                    if (attr2Seq0Buf == IntPtr.Zero) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    to.data_ = attr2Seq0Buf;
                    Marshal.Copy(from.data_, 0, attr2Seq0Buf, attr2Seq0Length);
                    to.data_ = attr2Seq0Buf;
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __OccupancyGrid_ nativeImg = (__OccupancyGrid_) Marshal.PtrToStructure(from, typeof(__OccupancyGrid_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    nav_msgs.msg.dds_.OccupancyGrid_ toObj = tmpGCHandleTo.Target as nav_msgs.msg.dds_.OccupancyGrid_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.OccupancyGrid_ to)
                {
                    __OccupancyGrid_ nativeImg = (__OccupancyGrid_) Marshal.PtrToStructure(from, typeof(__OccupancyGrid_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref nav_msgs.msg.dds_.OccupancyGrid_ to)
                {
                    __OccupancyGrid_ nativeImg = (__OccupancyGrid_) Marshal.PtrToStructure(from, typeof(__OccupancyGrid_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __OccupancyGrid_ from, ref nav_msgs.msg.dds_.OccupancyGrid_ to)
                {
                    if (to == null) {
                        to = new nav_msgs.msg.dds_.OccupancyGrid_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    nav_msgs.msg.dds_.__MapMetaData_Marshaler.CopyOut(ref from.info_, ref to.info_);
                    IntPtr attr2Seq0Buf = from.data_;
                    int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
                    if (to.data_ == null || to.data_.Length != attr2Seq0Length) {
                        to.data_ = new byte[attr2Seq0Length];
                    }
                    if(attr2Seq0Length > 0) Marshal.Copy(attr2Seq0Buf, to.data_, 0, attr2Seq0Length);
                }

            }
            #endregion

        }

    }

}

