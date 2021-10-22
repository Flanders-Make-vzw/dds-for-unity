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
    public class Float32MatrixPublisher
    {
        private Float32MultiArray_ msgInstance;
        private DDSEntityManager mgr = new DDSEntityManager("ROS");
        private Float32MultiArray_TypeSupport msgTS = new Float32MultiArray_TypeSupport();
        private ReturnCode status;
        private Float32MultiArray_DataWriter DataWriter;
        private IDataWriter dwriter;
        private InstanceHandle handle;
        public string topicname = null;

        public Float32MatrixPublisher(string topicname)
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
            DataWriter = dwriter as Float32MultiArray_DataWriter;

            msgInstance = new Float32MultiArray_();

            handle = DataWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");
        }

        public void Publish(float[,] message)
        {
            List<MultiArrayDimension_> dims = new List<MultiArrayDimension_>();
            List<float> el = new List<float>();

            MultiArrayDimension_ dim1 = new MultiArrayDimension_
            {
                label_ = "height",
                size_ = (uint)message.GetLength(0),
                stride_ = (uint)message.Length
            };
            MultiArrayDimension_ dim2 = new MultiArrayDimension_
            {
                label_ = "width",
                size_ = (uint)message.GetLength(1),
                stride_ = (uint)message.GetLength(1)
            };
            dims.Add(dim1);
            dims.Add(dim2);

            for (int i=0; i< dim1.size_; i++)
            {
                for (uint j=0; j < dim2.size_; j++)
                {
                    el.Add(message[i, j]);
                }
            }
            msgInstance.layout_.dim_ = dims.ToArray();
            msgInstance.layout_.data_offset_ = 0;
            msgInstance.data_ = el.ToArray();

            Publish(msgInstance);
        }

        public void Publish(Float32MultiArray_ msg)
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

