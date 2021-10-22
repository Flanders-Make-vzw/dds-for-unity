/* 
 Copyright 2021 Edward Hage

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
using UnityEngine.Events;
using DDS;
using DDSAPIHelper;

using std_msgs.msg.dds_;

namespace std_msgs
{
    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public class BoolSubscriberFunc
    {
        private BoolEvent BoolEvent;
        private Queue<Bool_> BoolQueue = new Queue<Bool_>();
        private object _queueLock = new object();

        private DDSEntityManager mgr;
        private Bool_TypeSupport msgTS = new Bool_TypeSupport();
        private ReturnCode status;

        private IDataReader dreader;
        public string topicname;
        private BoolListener Listener;

        public BoolSubscriberFunc(string topicname)
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

            Listener = new BoolListener();
            Listener.MsgDR = dreader as Bool_DataReader;
            Listener.SetQueue(BoolQueue, _queueLock);
            Listener.terminated = false;

            status = Listener.MsgDR.SetListener(Listener, StatusKind.DataAvailable);
            ErrorHandler.checkStatus(status, "DataReader.SetListener");
        }

        public void AddEvent(BoolEvent callbackfunction)
        {
            BoolEvent = callbackfunction;
        }

        public void InvokeEventOnDataAvailable()
        {
            if (BoolQueue.Count == 0) return;

            lock (_queueLock)
            {
                foreach (var msg in BoolQueue)
                {
                    BoolEvent.Invoke(msg.data_);
                }
                BoolQueue.Clear();
            }
        }

        public void Cleanup()
        {
            mgr.getSubscriber().DeleteDataReader(Listener.MsgDR);
            mgr.deleteSubscriber();
            mgr.deleteTopic();
            mgr.deleteParticipant();
        }
    }

    public class BoolListener : IDataReaderListener
    {
        ReturnCode status = ReturnCode.Error;
        public bool terminated = false;
        private List<IEnumerator> CallbackFunctions = new List<IEnumerator>();
        public Bool_DataReader MsgDR { get; set; }

        private Queue<Bool_> BoolQueue;
        private object _queueLock;

        public void SetQueue(Queue<Bool_> q, object ob)
        {
            BoolQueue = q;
            _queueLock = ob;
        }

        #region IDataReaderListener Members
        public void OnDataAvailable(IDataReader entityInterface)
        {
            Bool_[] msgList = null;
            SampleInfo[] infoSeq = null;

            status = MsgDR.Take(ref msgList, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");

            if (status == ReturnCode.Ok)
            {
                if (msgList != null && msgList.Length > 0)
                {
                    for (int i = 0; i < msgList.Length; i++)
                    {
                        if (infoSeq[i].ValidData)
                        {
                            var msg = msgList[i];
                            lock (_queueLock)
                            {
                                BoolQueue.Enqueue(msg);
                            }
                        }
                    }
                    status = MsgDR.ReturnLoan(ref msgList, ref infoSeq);
                    ErrorHandler.checkStatus(status, "DataReader.ReturnLoan");
                }
            }
        }

        public void OnLivelinessChanged(IDataReader entityInterface, LivelinessChangedStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnlivelinessChanged] triggered");
        }

        public void OnRequestedDeadlineMissed(IDataReader entityInterface, RequestedDeadlineMissedStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnRequestedDeadlineMissed] : triggered");
            Debug.Log("=== [ListenerDataListener::OnRequestedDeadlineMissed] : stopping");
            terminated = true;
        }

        public void OnRequestedIncompatibleQos(IDataReader entityInterface, RequestedIncompatibleQosStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnRequestedIncompatibleQos] : triggered");
        }

        public void OnSampleLost(IDataReader entityInterface, SampleLostStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnRequestedIncompatibleQos] : triggered");
        }

        public void OnSampleRejected(IDataReader entityInterface, SampleRejectedStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnSampleRejected] : triggered");
        }

        public void OnSubscriptionMatched(IDataReader entityInterface, SubscriptionMatchedStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnSubscriptionMatched] : triggered");
        }
        #endregion
    }
}

