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
using DDSAPIHelper;

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class Int32ArraySubscriber
    {
        private DDSEntityManager mgr;
        private Int32MultiArray_TypeSupport msgTS = new Int32MultiArray_TypeSupport();
        private ReturnCode status;
        public Int32MultiArray_[] msgSeq = null;
        public Int32MultiArray_ lastmessage = new Int32MultiArray_();
        private DDS.SampleInfo[] infoSeq = null;
        private Int32MultiArray_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public Int32ArraySubscriber(string topicname)
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
            DataReader = dreader as Int32MultiArray_DataReader;
        }

        public Int32MultiArray_ GetMessage()
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

        public int[] GetArray()
        {
            GetMessage(); // this gets: lastmessage
            if (lastmessage.layout_.dim_.Length == 0)
            {
                return new int[0];
            }
            else
            {
                uint n = lastmessage.layout_.dim_[0].size_;
                int[] matrix = new int[n];
                for (uint i = 0; i < n; i++)
                {
                    matrix[i] = lastmessage.data_[lastmessage.layout_.data_offset_ + i];
                }
                return matrix;
            }
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
