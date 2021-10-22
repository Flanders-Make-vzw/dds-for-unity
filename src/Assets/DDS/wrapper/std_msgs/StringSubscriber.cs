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

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class StringSubscriber
    {
        private DDSEntityManager mgr;
        private String_TypeSupport msgTS = new String_TypeSupport();
        private ReturnCode status;

        public String_[] msgSeq = null;
        public String_ lastmessage = new String_();
        private DDS.SampleInfo[] infoSeq = null;
        private String_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public StringSubscriber(string topicname) {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as String_DataReader; 
        }

        public String_ GetMessage()
        {
            status = DataReader.Take(ref msgSeq, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");
            if (status == ReturnCode.NoData)
            {
                return new String_();
            }
            if (status == ReturnCode.Ok)
            {
                if (msgSeq.Length > 0)
                {
                    if (infoSeq[msgSeq.Length - 1].ValidData)
                    {
                        lastmessage = msgSeq[msgSeq.Length - 1];
                    }
                }
            }
            status = DataReader.ReturnLoan(ref msgSeq, ref infoSeq);
            ErrorHandler.checkStatus(status, "DataReader.ReturnLoan");
            return lastmessage;
        }

        public string GetString()
        {
            return GetMessage().data_;
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
