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
            #region __MotionPlanResponse_
            [StructLayout(LayoutKind.Sequential)]
            public struct __MotionPlanResponse_
            {
                public std_msgs.msg.dds_.__Header_ header_;
                public IntPtr plan_id_;
                public trajectory_msgs.msg.dds_.__JointTrajectory_ start_trajectory_;
                public trajectory_msgs.msg.dds_.__JointTrajectory_ path_trajectory_;
            }
            #endregion

            #region __MotionPlanResponse_Marshaler
            public sealed class __MotionPlanResponse_Marshaler : DDS.OpenSplice.CustomMarshalers.FooDatabaseMarshaler<planner_msgs.msg.dds_.MotionPlanResponse_>
            {
                public static readonly string fullyScopedName = "planner_msgs::msg::dds_::MotionPlanResponse_";
                private std_msgs.msg.dds_.__Header_Marshaler attr0Marshaler;
                private trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler attr2Marshaler;
                private trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler attr3Marshaler;

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
                        attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(trajectory_msgs.msg.dds_.__JointTrajectory_)) as trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler;
                        if (attr2Marshaler == null) {
                            attr2Marshaler = new trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(trajectory_msgs.msg.dds_.__JointTrajectory_), attr2Marshaler);
                            attr2Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                    if (attr3Marshaler == null) {
                        attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(trajectory_msgs.msg.dds_.__JointTrajectory_)) as trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler;
                        if (attr3Marshaler == null) {
                            attr3Marshaler = new trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler();
                            DatabaseMarshaler.Add(participant, typeof(trajectory_msgs.msg.dds_.__JointTrajectory_), attr3Marshaler);
                            attr3Marshaler.InitEmbeddedMarshalers(participant);
                        }
                    }
                }

                public override V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, System.IntPtr from, System.IntPtr to)
                {
                    GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
                    planner_msgs.msg.dds_.MotionPlanResponse_ fromData = tmpGCHandle.Target as planner_msgs.msg.dds_.MotionPlanResponse_;
                    return CopyIn(typePtr, fromData, to);
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, planner_msgs.msg.dds_.MotionPlanResponse_ from, System.IntPtr to)
                {
                    __MotionPlanResponse_ nativeImg = new __MotionPlanResponse_();
                    V_COPYIN_RESULT result = CopyIn(typePtr, from, ref nativeImg);
                    if (result == V_COPYIN_RESULT.OK)
                    {
                        Marshal.StructureToPtr(nativeImg, to, false);
                    }
                    return result;
                }

                public V_COPYIN_RESULT CopyIn(System.IntPtr typePtr, planner_msgs.msg.dds_.MotionPlanResponse_ from, ref __MotionPlanResponse_ to)
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
                        V_COPYIN_RESULT result = attr2Marshaler.CopyIn(typePtr, from.start_trajectory_, ref to.start_trajectory_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    {
                        V_COPYIN_RESULT result = attr3Marshaler.CopyIn(typePtr, from.path_trajectory_, ref to.path_trajectory_);
                        if (result != V_COPYIN_RESULT.OK) return result;
                    }
                    return V_COPYIN_RESULT.OK;
                }

                public override void CopyOut(System.IntPtr from, System.IntPtr to)
                {
                    __MotionPlanResponse_ nativeImg = (__MotionPlanResponse_) Marshal.PtrToStructure(from, typeof(__MotionPlanResponse_));
                    GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
                    planner_msgs.msg.dds_.MotionPlanResponse_ toObj = tmpGCHandleTo.Target as planner_msgs.msg.dds_.MotionPlanResponse_;
                    CopyOut(ref nativeImg, ref toObj);
                    tmpGCHandleTo.Target = toObj;
                }

                public override void CopyOut(System.IntPtr from, ref planner_msgs.msg.dds_.MotionPlanResponse_ to)
                {
                    __MotionPlanResponse_ nativeImg = (__MotionPlanResponse_) Marshal.PtrToStructure(from, typeof(__MotionPlanResponse_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void StaticCopyOut(System.IntPtr from, ref planner_msgs.msg.dds_.MotionPlanResponse_ to)
                {
                    __MotionPlanResponse_ nativeImg = (__MotionPlanResponse_) Marshal.PtrToStructure(from, typeof(__MotionPlanResponse_));
                    CopyOut(ref nativeImg, ref to);
                }

                public static void CopyOut(ref __MotionPlanResponse_ from, ref planner_msgs.msg.dds_.MotionPlanResponse_ to)
                {
                    if (to == null) {
                        to = new planner_msgs.msg.dds_.MotionPlanResponse_();
                    }
                    std_msgs.msg.dds_.__Header_Marshaler.CopyOut(ref from.header_, ref to.header_);
                    to.plan_id_ = ReadString(from.plan_id_);
                    trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler.CopyOut(ref from.start_trajectory_, ref to.start_trajectory_);
                    trajectory_msgs.msg.dds_.__JointTrajectory_Marshaler.CopyOut(ref from.path_trajectory_, ref to.path_trajectory_);
                }

            }
            #endregion

        }

    }

}

