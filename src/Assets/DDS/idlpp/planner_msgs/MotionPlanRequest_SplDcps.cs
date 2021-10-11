using DDS;
using DDS.OpenSplice.CustomMarshalers;
using DDS.OpenSplice.Database;
using DDS.OpenSplice.Kernel;
using System;
using System.Runtime.InteropServices;

namespace planner_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region __MotionPlanRequest_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MotionPlanRequest_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr plan_id_;
                public nav_msgs.msg.dds_.__Path_ path_;
            }
            #endregion

            #region __MotionPlanRequest_Marshaler
            public sealed class __MotionPlanRequest_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<planner_msgs.msg.dds_.MotionPlanRequest_>
            {
                public static readonly string fullyScopedName = "planner_msgs::msg::dds_::MotionPlanRequest_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private nav_msgs.msg.dds_.__Path_Marshaler attr2Marshaler;

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
                    if (attr2Marshaler == null) {
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(nav_msgs.msg.dds_.__Path_)) as nav_msgs.msg.dds_.__Path_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new nav_msgs.msg.dds_.__Path_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(nav_msgs.msg.dds_.__Path_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    planner_msgs.msg.dds_.MotionPlanRequest_ fromData = tmpGCHandle.Target as planner_msgs.msg.dds_.MotionPlanRequest_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, planner_msgs.msg.dds_.MotionPlanRequest_ from, System.IntPtr to)
                {
                    __MotionPlanRequest_ nativeImg = new __MotionPlanRequest_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, planner_msgs.msg.dds_.MotionPlanRequest_ from, ref __MotionPlanRequest_ to)
                {
                    if (from == null) return V_COPYIN_RESULT.INVALID;
                    {
                        V_COPYIN_RESULT result = attr0Marshaler.CopyIn(typePtr, from.header_, ref to.header_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    if (from.plan_id_ == null) return V_COPYIN_RESULT.INVALID;
                    // Unbounded string: bounds check not required...
                    if (!Write(c.getBase(typePtr), ref to.plan_id_, from.plan_id_)) return V_COPYIN_RESULT.OUT_OF_MEMORY;
                    {
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.path_, ref to.path_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MotionPlanRequest_ nativeImg = (__MotionPlanRequest_) Marshal.PtrToStructure(from, typeof(__MotionPlanRequest_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    planner_msgs.msg.dds_.MotionPlanRequest_ toObj = tmpGCHandleTo.Target as planner_msgs.msg.dds_.MotionPlanRequest_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref planner_msgs.msg.dds_.MotionPlanRequest_ to)
                {
                    __MotionPlanRequest_ nativeImg = (__MotionPlanRequest_) Marshal.PtrToStructure(from, typeof(__MotionPlanRequest_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref planner_msgs.msg.dds_.MotionPlanRequest_ to)
                {
                    __MotionPlanRequest_ nativeImg = (__MotionPlanRequest_) Marshal.PtrToStructure(from, typeof(__MotionPlanRequest_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MotionPlanRequest_ from, ref planner_msgs.msg.dds_.MotionPlanRequest_ to)
                {
                    if (to == null) {
                        to = new planner_msgs.msg.dds_.MotionPlanRequest_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.plan_id_ = ReadString(from.plan_id_);
                    nav_msgs.msg.dds_.__Path_Marshaler.CopyOut(ref from.path_, ref to.path_);
                }

            }
            #endregion

        }

    }

}

