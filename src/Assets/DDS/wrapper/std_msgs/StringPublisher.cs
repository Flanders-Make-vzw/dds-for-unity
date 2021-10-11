using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;

using DDSAPIHelper;
using System.IO;

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class StringPublisher
    {
        private String_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private String_TypeSupport msgTS = new String_TypeSupport();
        private ReturnCode status;
        private String_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public StringPublisher(string topicname)
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
            DataWriter = dwriter as String_DataWriter;

            msgInstance = new String_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(String_ message)
        {
            status = DataWriter.Write(message, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");
        }

        public void Publish(string message)
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

