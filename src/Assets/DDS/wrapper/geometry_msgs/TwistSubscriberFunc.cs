/* 
 Copyright 2020 Edward Hage

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
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using DDS;
using DDSAPIHelper;

using geometry_msgs.msg.dds_;

namespace geometry_msgs
{
    [System.Serializable]
    public class TwistEvent : UnityEvent<(Vector3, Vector3)> { }

    public class TwistSubscriberFunc
    {
        private TwistEvent TwistEvent;
        private Queue<Twist_> TwistQueue = new Queue<Twist_>();
        private object _queueLock = new object();

        private DDSEntityManager mgr;
        private Twist_TypeSupport msgTS = new Twist_TypeSupport();
        private ReturnCode status;

        private IDataReader dreader;
        public string topicname;
        private TwistListener Listener;

        public TwistSubscriberFunc(string topicname)
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

            Listener = new TwistListener();
            Listener.MsgDR = dreader as Twist_DataReader;
            Listener.SetQueue(TwistQueue, _queueLock);
            Listener.terminated = false;

            status = Listener.MsgDR.SetListener(Listener, StatusKind.DataAvailable);
            ErrorHandler.checkStatus(status, "DataReader.SetListener");
        }

        private (Vector3, Vector3) ConvertTwist(Twist_ msg)
        {
            Vector3 linear = new Vector3
            {
                x = (float)msg.linear_.x_,
                y = (float)msg.linear_.y_,
                z = (float)msg.linear_.z_
            };
            Vector3 angular = new Vector3
            {
                x = (float)msg.angular_.x_,
                y = (float)msg.angular_.y_,
                z = (float)msg.angular_.z_
            };
            return (linear, angular);
        }

        public void AddEvent(TwistEvent callbackfunction)
        {
            TwistEvent = callbackfunction;
        }

        public void InvokeEventOnDataAvailable()
        {
            if (TwistQueue.Count == 0) return;

            lock (_queueLock)
            {
                foreach (var msg in TwistQueue)
                {
                    TwistEvent.Invoke(ConvertTwist(msg));
                }
                TwistQueue.Clear();
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

    public class TwistListener : IDataReaderListener
    {
        ReturnCode status = ReturnCode.Error;
        public bool terminated = false;
        private List<IEnumerator> CallbackFunctions = new List<IEnumerator>();
        public Twist_DataReader MsgDR { get; set; }

        private Queue<Twist_> TwistQueue;
        private object _queueLock;

        public void SetQueue(Queue<Twist_> q, object ob)
        {
            TwistQueue = q;
            _queueLock = ob;
        }

        #region IDataReaderListener Members
        public void OnDataAvailable(IDataReader entityInterface)
        {
            Twist_[] msgList = null;
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
                                TwistQueue.Enqueue(msg);
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

