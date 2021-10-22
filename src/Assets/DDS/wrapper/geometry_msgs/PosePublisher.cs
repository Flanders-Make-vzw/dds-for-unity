/* 
 Copyright 2020 Edward Hage

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;

using UnityEngine;
using geometry_msgs.msg.dds_;

namespace geometry_msgs
{
    public class PosePublisher
    {
        private Pose_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private Pose_TypeSupport msgTS = new Pose_TypeSupport();
        private ReturnCode status;
        private Pose_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public PosePublisher(string topicname)
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
            DataWriter = dwriter as Pose_DataWriter;

            msgInstance = new Pose_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public TopicQos gettopicqos() { return mgr.gettopicqos(); }
        public PublisherQos getpublisherqos() { return mgr.getpublisherqos(); }
        public SubscriberQos getsubscriberqos() { return mgr.getsubscriberqos(); }
        public DataWriterQos getdatawriterqos() { return mgr.getdatawriterqos(); }
        public DataReaderQos getdatareaderqos() { return mgr.getdatareaderqos(); }

        public void Publish(Pose_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(Vector3 positionvector, Quaternion quaternion)
        {
            msgInstance.position_.x_ = positionvector.x;
            msgInstance.position_.y_ = positionvector.y;
            msgInstance.position_.z_ = positionvector.z;
            msgInstance.orientation_.w_ = quaternion.w;
            msgInstance.orientation_.x_ = quaternion.x;
            msgInstance.orientation_.y_ = quaternion.y;
            msgInstance.orientation_.z_ = quaternion.z;
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

