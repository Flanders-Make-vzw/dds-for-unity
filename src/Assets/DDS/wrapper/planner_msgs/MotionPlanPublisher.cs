using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using UnityEngine;
using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;

using planner_msgs.msg.dds_;
using nav_msgs.msg.dds_;

namespace planner_msgs
{
    public class MotionPlanPublisher
    {

        private MotionPlanRequest_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private MotionPlanRequest_TypeSupport msgTS = new MotionPlanRequest_TypeSupport();
        private ReturnCode status;
        private MotionPlanRequest_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;
        public string frame_id = null;

        public MotionPlanPublisher(string topicname, string frame_id)
        {
            this.topicname = topicname;
            this.frame_id = frame_id;

            mgr.createParticipant("");
            mgr.setAutoDispose(false);

            mgr.registerType(msgTS);
            mgr.createTopic(this.topicname);
            mgr.createPublisher();
            mgr.createWriter();

            status = ReturnCode.Error;

            dwriter = mgr.getWriter();
            DataWriter = dwriter as MotionPlanRequest_DataWriter;

            msgInstance = new MotionPlanRequest_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(MotionPlanRequest_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(string plan_id, Path_ path)
        {
            msgInstance.plan_id_ = plan_id;
            msgInstance.path_ = path;
            msgInstance.header_.frame_id_ = frame_id;
            msgInstance.header_.stamp_ = ros_helper.RosHelper.GetUnixTimestamp();
            Publish(msgInstance);
        }

        public void Cleanup()
        {
            status = DataWriter.UnregisterInstance(msgInstance, handle);
            mgr.getPublisher().DeleteDataWriter(DataWriter);
            mgr.deletePublisher();
            mgr.deleteTopic();
            mgr.deleteParticipant();
        }
    }
}
