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
using UnityEngine;
using DDS;  // aware: DDS.Time and UnityEngine.Time
using DDS.OpenSplice;
using DDSAPIHelper;

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class StringListener2 : IDataReaderListener
    {
        ReturnCode status = ReturnCode.Error;
        public bool terminated = false; // deze is verplicht !
        private List<IEnumerator> CallbackFunctions = new List<IEnumerator>();
        public String_DataReader MsgDR { get; set; }

        private Queue<String_> StringQueue;
        private object _queueLock;

        public void SetQueue(Queue<String_> q, object ob)
        {
            StringQueue = q;
            _queueLock = ob;
        }

        #region IDataReaderListener Members
        public void OnDataAvailable(IDataReader entityInterface)
        {
            String_[] msgList = null;
            SampleInfo[] infoSeq = null;

            status = MsgDR.Take(ref msgList, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");

            //Debug.Log("    StatusDIRECT AFTER: " + status.ToString());
            if (msgList != null && msgList.Length > 0)
            {
                Debug.Log("=== [ListenerDataListener::OnDataAvailable] - msgList.Length : {0}"  +  msgList.Length.ToString());
                foreach (String_ msg in msgList)
                {
                    //Debug.Log("    --- message received ---");
                    //Debug.Log("    data  : " + msg.data_);
                    lock (_queueLock)
                    {
                        StringQueue.Enqueue(msg);
                    }
                }
                foreach (SampleInfo spl in infoSeq)
                {
                    /*Debug.Log("  sampleinfo valid: " + spl.ValidData.ToString());
                    Debug.Log("  sampleinfo source-time: " + spl.SourceTimestamp.ToDatetime().ToString());
                    Debug.Log("  sampleinfo reception-time: " + spl.ReceptionTimestamp.ToDatetime().ToString());*/
                }
                status = MsgDR.ReturnLoan(ref msgList, ref infoSeq);
                //Debug.Log("    Status: " + status.ToString());
                ErrorHandler.checkStatus(status, "DataReader.ReturnLoan");
            }
            // now somehow use the callbackfuncstions in CallbackFunctions --> met queue
        }

        public void OnLivelinessChanged(IDataReader entityInterface, LivelinessChangedStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnlivelinessChanged] triggered");
        }

        public void OnRequestedDeadlineMissed(IDataReader entityInterface, RequestedDeadlineMissedStatus status)
        {
            Debug.Log("=== [ListenerDataListener::OnRequestedDeadlineMissed] : triggered");
            Debug.Log("=== [ListenerDataListener::OnRequestedDeadlineMissed] : stopping");
            terminated = true; // edward deze moet op true worden gezet
            // unblock the waitset in Subscriber main loop
            //guardCond.SetTriggerValue(true);
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
