/* 
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
using System.Collections.Generic;
using DDS;

using DDSAPIHelper;

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class Int32ArrayPublisher
    {
        private Int32MultiArray_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private Int32MultiArray_TypeSupport msgTS = new Int32MultiArray_TypeSupport();
        private ReturnCode status;
        private Int32MultiArray_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public Int32ArrayPublisher(string topicname)
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
            DataWriter = dwriter as Int32MultiArray_DataWriter;

            msgInstance = new Int32MultiArray_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(int[] message)
        {
            List<MultiArrayDimension_> dims = new List<MultiArrayDimension_>();
            //List<int> el = new List<int>();

            MultiArrayDimension_ dim1 = new MultiArrayDimension_
            {
                label_ = "",
                size_ = (uint)message.Length,
                stride_ = (uint)message.Length
            };
            dims.Add(dim1);
            msgInstance.layout_.dim_ = dims.ToArray();
            msgInstance.layout_.data_offset_ = 0;
            msgInstance.data_ = message;

            Publish(msgInstance);
        }

        public void Publish(Int32MultiArray_ msg)
        {
            status = DataWriter.Write(msg, handle);
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

