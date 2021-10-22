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
using DDS;
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;

using trajectory_msgs.msg.dds_;
using std_msgs.msg.dds_;

namespace trajectory_msgs 
{
    public class JointTrajectorySubscriber
    {
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private JointTrajectory_TypeSupport msgTS = new JointTrajectory_TypeSupport();
        private ReturnCode status;

        public JointTrajectory_[] msgSeq = null;
        public JointTrajectory_ lastmessage = new JointTrajectory_();
        private DDS.SampleInfo[] infoSeq = null;
        private JointTrajectory_DataReader DataReader;
        private IDataReader dreader;
        
        public string topicname = null;

        public JointTrajectorySubscriber(string topicname)
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
            DataReader = dreader as JointTrajectory_DataReader;
        }

        public JointTrajectory_ GetMessage()
        {
            status = DataReader.Take(ref msgSeq, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");
            // this is effective a polling action of all the missed messages, only interested in the last
            lastmessage = new JointTrajectory_(); 
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

        public void Cleanup()
        {
            mgr.getSubscriber().DeleteDataReader(DataReader);
            mgr.deleteSubscriber();
            mgr.deleteTopic();
            mgr.deleteParticipant();
        }
    }
}

