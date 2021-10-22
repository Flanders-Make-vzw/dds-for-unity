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

using geometry_msgs.msg.dds_;

namespace geometry_msgs
{
    public class PoseStampedSubscriber
    {
        private DDSEntityManager mgr;
        private PoseStamped_TypeSupport msgTS = new PoseStamped_TypeSupport();
        private ReturnCode status;

        public PoseStamped_[] msgSeq = null;
        public PoseStamped_ lastmessage = new PoseStamped_();
        private DDS.SampleInfo[] infoSeq = null;
        private PoseStamped_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public PoseStampedSubscriber(string topicname) {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as PoseStamped_DataReader; 
        }

        public PoseStamped_ GetMessage()
        {
            status = DataReader.Take(ref msgSeq, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");
            // this is effective a polling action of all the missed messages, only interested in the last
            if (msgSeq.Length > 0)
            {
                if (infoSeq[msgSeq.Length - 1].ValidData)
                {
                    lastmessage = msgSeq[msgSeq.Length - 1];
                }
            }
            status = DataReader.ReturnLoan(ref msgSeq, ref infoSeq);
            ErrorHandler.checkStatus(status, "DataReader.ReturnLoan");
            return lastmessage;
        }

        public (Vector3, Quaternion) GetPosQuaternion ()
        {
            GetMessage();
            // this writes lastmessage
            Vector3 positionvector = new Vector3
            {
                x = (float)lastmessage.pose_.position_.x_,
                y = (float)lastmessage.pose_.position_.y_,
                z = (float)lastmessage.pose_.position_.z_
            };
            Quaternion quaternion = new Quaternion
            {
                w = (float)lastmessage.pose_.orientation_.w_,
                x = (float)lastmessage.pose_.orientation_.x_,
                y = (float)lastmessage.pose_.orientation_.y_,
                z = (float)lastmessage.pose_.orientation_.z_
            };
            return (positionvector, quaternion);
        }

        public void Cleanup()
        {
            mgr.getSubscriber().DeleteDataReader(DataReader);
            mgr.deleteSubscriber();
            mgr.deleteTopic();
            mgr.deleteParticipant();
        }
    }
}
