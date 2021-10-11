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

using sensor_msgs.msg.dds_;
using builtin_interfaces.msg.dds_;

namespace sensor_msgs 
{
    public class JointStatePublisher
    {
        private JointState_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private JointState_TypeSupport msgTS = new JointState_TypeSupport();
        private ReturnCode status;
        private JointState_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public JointStatePublisher(string topicname)
        {
            this.topicname = topicname;

            mgr.createParticipant("");
            mgr.setAutoDispose(false);

            mgr.registerType(msgTS);
            mgr.createTopic(this.topicname);
            mgr.createPublisher();
            mgr.createWriter();

            status = ReturnCode.Error;

            dwriter = mgr.getWriter();
            DataWriter = dwriter as JointState_DataWriter;

            msgInstance = new JointState_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(JointState_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(List<string> joint_names, List<double> positions)
        {
            Time_ t = ros_helper.RosHelper.GetUnixTimestamp();
            msgInstance.header_.frame_id_ = "";
            msgInstance.header_.stamp_ = t;
            msgInstance.name_ = joint_names.ToArray();
            msgInstance.position_ = positions.ToArray();
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

