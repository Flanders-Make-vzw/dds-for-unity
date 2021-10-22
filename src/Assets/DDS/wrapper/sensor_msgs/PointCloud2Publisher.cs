/* 
 Copyright 2019 Edward Hage

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

//deze klopt niet en moet nog goed worden gemaakt, eerst oefenen in ROS
namespace sensor_msgs
{
    public class PointCloud2Publisher
    {
        private PointCloud2_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private PointCloud2_TypeSupport msgTS = new PointCloud2_TypeSupport();
        private ReturnCode status;
        private PointCloud2_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public PointCloud2Publisher(string topicname)
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
            DataWriter = dwriter as PointCloud2_DataWriter;

            msgInstance = new PointCloud2_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(PointCloud2_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        /*public void Publish(List<string> joint_names, List<double> positions)
        {
            Time_ t = ros_helper.RosHelper.GetUnixTimestamp();
            msgInstance.header_.frame_id_ = "";
            msgInstance.header_.stamp_ = t;
            msgInstance.name_ = joint_names.ToArray();
            msgInstance.position_ = positions.ToArray();
            Publish(msgInstance);
        }*/

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
