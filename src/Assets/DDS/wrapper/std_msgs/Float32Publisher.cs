using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;

using std_msgs.msg.dds_;

namespace std_msgs 
{
    public class Float32Publisher
    {
        private Float32_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private Float32_TypeSupport msgTS = new Float32_TypeSupport();
        private ReturnCode status;
        private Float32_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public Float32Publisher(string topicname)
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
            DataWriter = dwriter as Float32_DataWriter;

            msgInstance = new Float32_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(Float32_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(float message)
        {
            msgInstance.data_ = message;
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

