using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;

using trajectory_msgs.msg.dds_;
using std_msgs.msg.dds_;
//using builtin_interfaces.msg.dds_;

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
            lastmessage = new JointTrajectory_(); //added zodat oude data niet 
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

