using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;
using UnityEngine;
using geometry_msgs.msg.dds_;

namespace geometry_msgs
{
    public class Pose2DPublisher
    {
        private Pose2D_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private Pose2D_TypeSupport msgTS = new Pose2D_TypeSupport();
        private ReturnCode status;
        private Pose2D_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public Pose2DPublisher(string topicname)
        {
            this.topicname = topicname;

            mgr.createParticipant("");
            mgr.setAutoDispose(false);

            mgr.registerType(msgTS);
            mgr.createTopic(this.topicname);
            mgr.createPublisher();
            mgr.createWriter();

            status = ReturnCode.Error;

            dwriter = mgr.getWriter();
            DataWriter = dwriter as Pose2D_DataWriter;

            msgInstance = new Pose2D_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(Pose2D_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(double x, double y, double theta)
        {
            msgInstance.x_ = x;
            msgInstance.y_ = y;
            msgInstance.theta_ = theta;
            Publish(msgInstance);
        }

        public void Cleanup()
        {
            status = DataWriter.UnregisterInstance(msgInstance, handle);
            mgr.getPublisher().DeleteDataWriter(DataWriter);
            mgr.deletePublisher();
            mgr.deleteTopic();
            mgr.deleteParticipant();
        }
    }
}

