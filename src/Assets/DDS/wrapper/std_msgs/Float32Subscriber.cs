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
    public class Float32Subscriber
    {
        private DDSEntityManager mgr;
        private Float32_TypeSupport msgTS = new Float32_TypeSupport();
        private ReturnCode status;

        public Float32_[] msgSeq = null;
        public Float32_ lastmessage = new Float32_();
        private DDS.SampleInfo[] infoSeq = null;
        private Float32_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public Float32Subscriber(string topicname) {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as Float32_DataReader; 
        }

        public Float32_ GetMessage()
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

        public float GetFloat()
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
