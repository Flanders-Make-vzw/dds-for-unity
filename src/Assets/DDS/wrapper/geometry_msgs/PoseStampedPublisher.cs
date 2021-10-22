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
//using builtin_interfaces.msg.dds_;

namespace geometry_msgs
{
    public class PoseStampedPublisher
    {
        private PoseStamped_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private PoseStamped_TypeSupport msgTS = new PoseStamped_TypeSupport();
        private ReturnCode status;
        private PoseStamped_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;
        public string frame_id = null;

        public PoseStampedPublisher(string topicname, string frame_id)
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
            DataWriter = dwriter as PoseStamped_DataWriter;

            msgInstance = new PoseStamped_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(PoseStamped_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(Pose_ message)
        {
            msgInstance.pose_ = message;
            msgInstance.header_.frame_id_ = frame_id;
            msgInstance.header_.stamp_ = ros_helper.RosHelper.GetUnixTimestamp();
            Publish(msgInstance);
        }

        public void Publish(Vector3 positionvector, Quaternion quaternion)
        {
            msgInstance.pose_.position_.x_ = positionvector.x;
            msgInstance.pose_.position_.y_ = positionvector.y;
            msgInstance.pose_.position_.z_ = positionvector.z;
            msgInstance.pose_.orientation_.w_ = quaternion.w;
            msgInstance.pose_.orientation_.x_ = quaternion.x;
            msgInstance.pose_.orientation_.y_ = quaternion.y;
            msgInstance.pose_.orientation_.z_ = quaternion.z;
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

