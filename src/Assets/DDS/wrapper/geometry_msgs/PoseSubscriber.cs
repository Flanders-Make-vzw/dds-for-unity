using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;
using DDSAPIHelper;
using System.IO;

using UnityEngine;
using geometry_msgs.msg.dds_;

namespace geometry_msgs
{
    public class PoseSubscriber
    {
        private DDSEntityManager mgr;
        private Pose_TypeSupport msgTS = new Pose_TypeSupport();
        private ReturnCode status;

        public Pose_[] msgSeq = null;
        public Pose_ lastmessage = new Pose_();
        private DDS.SampleInfo[] infoSeq = null;
        private Pose_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public PoseSubscriber(string topicname) {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as Pose_DataReader; 
        }

        public Pose_ GetMessage()
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
                x = (float)lastmessage.position_.x_,
                y = (float)lastmessage.position_.y_,
                z = (float)lastmessage.position_.z_
            };
            Quaternion quaternion = new Quaternion
            {
                w = (float)lastmessage.orientation_.w_,
                x = (float)lastmessage.orientation_.x_,
                y = (float)lastmessage.orientation_.y_,
                z = (float)lastmessage.orientation_.z_
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
