//public class TwistSubscriber : MonoBehaviour
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
    public class TwistSubscriber
    {
        private DDSEntityManager mgr;
        private Twist_TypeSupport msgTS = new Twist_TypeSupport();
        private ReturnCode status;

        public Twist_[] msgSeq = null;
        public Twist_ lastmessage = new Twist_();
        private DDS.SampleInfo[] infoSeq = null;
        private Twist_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public TwistSubscriber(string topicname)
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
            DataReader = dreader as Twist_DataReader;
        }

        public Twist_ GetMessage()
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

        public (Vector3, Vector3) GetTwist()
        {
            GetMessage();
            // this writes lastmessage
            Vector3 linear = new Vector3
            {
                x = (float)lastmessage.linear_.x_,
                y = (float)lastmessage.linear_.y_,
                z = (float)lastmessage.linear_.z_
            };
            Vector3 angular = new Vector3
            {
                x = (float)lastmessage.angular_.x_,
                y = (float)lastmessage.angular_.y_,
                z = (float)lastmessage.angular_.z_
            };
            return (linear, angular);
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
