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

namespace sensor_msgs
{
    public class LaserScanPublisher
    {
        private LaserScan_ msgInstance = new LaserScan_();
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private LaserScan_TypeSupport msgTS = new LaserScan_TypeSupport();
        private ReturnCode status;
        private LaserScan_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        
        public LaserScanPublisher(string topicname)
        {
            Init(topicname);
        }

        public LaserScanPublisher(string topicname, string frame_id, float angle_min, float angle_max, float angle_increment, float time_increment, float scan_time, float range_min, float range_max)
        {
            Init(topicname);
            AddDeviceInformation(frame_id, angle_min, angle_max, angle_increment, time_increment, scan_time, range_min, range_max);
        }

        private void Init(string topicname)
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
            DataWriter = dwriter as LaserScan_DataWriter;

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void AddDeviceInformation(string frame_id, float angle_min, float angle_max, float angle_increment, float time_increment, float scan_time, float range_min, float range_max)
        {
            msgInstance.header_.frame_id_ = frame_id;
            msgInstance.angle_min_ = angle_min;
            msgInstance.angle_max_ = angle_max;
            msgInstance.angle_increment_ = angle_increment;
            msgInstance.time_increment_ = time_increment;
            msgInstance.scan_time_ = scan_time;
            msgInstance.range_min_ = range_min;
            msgInstance.range_max_ = range_max;
        }

        public void Publish(LaserScan_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(List<float> ranges, List<float> intensities)
        {
            Time_ t = ros_helper.RosHelper.GetUnixTimestamp();
            msgInstance.header_.stamp_ = t;
            msgInstance.ranges_ = ranges.ToArray();
            msgInstance.intensities_ = intensities.ToArray();
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

