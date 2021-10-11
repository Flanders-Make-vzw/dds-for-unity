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

using sensor_msgs.msg.dds_;
using builtin_interfaces.msg.dds_;

namespace sensor_msgs 
{
    public class ImagePublisher
    {
        private Image_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS"); //ROS_BE = best effort QoS for topic = werkt niet
        private Image_TypeSupport msgTS = new Image_TypeSupport();
        private ReturnCode status;
        private Image_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public ImagePublisher(string topicname)
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
            DataWriter = dwriter as Image_DataWriter;

            msgInstance = new Image_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(Image_ message)
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

