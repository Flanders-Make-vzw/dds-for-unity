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
using System.Collections.Generic;
using DDS;  // aware: DDS.Time and UnityEngine.Time

using DDSAPIHelper;

using planner_msgs.msg.dds_;

namespace planner_msgs
{
    public class MotionPlanResponseSubscriber
    {
        private DDSEntityManager mgr;
        private MotionPlanResponse_TypeSupport msgTS = new MotionPlanResponse_TypeSupport();
        private ReturnCode status;

        public MotionPlanResponse_[] msgSeq = null;
        public MotionPlanResponse_ lastmessage = new MotionPlanResponse_();
        private DDS.SampleInfo[] infoSeq = null;
        private MotionPlanResponse_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public MotionPlanResponseSubscriber(string topicname)
        {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as MotionPlanResponse_DataReader;
        }

        public MotionPlanResponse_[] GetMessages() // get all valid messages, not only the last
        {
            status = DataReader.Take(ref msgSeq, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");
            // this is effective a polling action of all the missed messages, interested in all messages
            status = DataReader.ReturnLoan(ref msgSeq, ref infoSeq);
            ErrorHandler.checkStatus(status, "DataReader.ReturnLoan");
            List<MotionPlanResponse_> newSeq = new List<MotionPlanResponse_>();
            for (int i=0; i< msgSeq.Length; i++)
            {
                if (infoSeq[i].ValidData)
                {
                    newSeq.Add( msgSeq[i] );
                }
            }
            return newSeq.ToArray();
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
