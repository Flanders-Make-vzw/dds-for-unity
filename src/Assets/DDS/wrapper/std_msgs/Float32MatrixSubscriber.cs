﻿/* 
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
using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;
using DDSAPIHelper;
using System.IO;

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class Float32MatrixSubscriber
    {
        private DDSEntityManager mgr;
        private Float32MultiArray_TypeSupport msgTS = new Float32MultiArray_TypeSupport();
        private ReturnCode status;
        public Float32MultiArray_[] msgSeq = null;
        public Float32MultiArray_ lastmessage = new Float32MultiArray_();
        private DDS.SampleInfo[] infoSeq = null;
        private Float32MultiArray_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public Float32MatrixSubscriber(string topicname) {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as Float32MultiArray_DataReader; 
        }

        public Float32MultiArray_ GetMessage()
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

        public float[,] GetMatrix()
        {
            GetMessage(); // this gets: lastmessage
            uint n = lastmessage.layout_.dim_[0].size_;
            uint m = lastmessage.layout_.dim_[1].size_;
            float[,] matrix = new float[n, m];
            for (uint i=0; i<n; i++)
            {
                for (uint j=0; i<m; j++)
                {
                    matrix[i, j] = lastmessage.data_[lastmessage.layout_.data_offset_ + lastmessage.layout_.dim_[1].stride_ * i + j];
                }
            }

            return matrix;
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
