using DDS; 
using DDSAPIHelper;
using sensor_msgs.msg.dds_;
// weet niet of deze publisher nodig is , dataformaat ook bekend bij PointCloud2Publisher
namespace sensor_msgs
{
    public class PointFieldPublisher
    {
        private PointField_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private PointField_TypeSupport msgTS = new PointField_TypeSupport();
        private ReturnCode status;
        private PointField_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public PointFieldPublisher(string topicname)
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
            DataWriter = dwriter as PointField_DataWriter;

            msgInstance = new PointField_();
            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(PointField_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
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

