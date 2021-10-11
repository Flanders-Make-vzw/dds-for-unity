using DDS;
using DDS.OpenSplice;

namespace tf2_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region ITFMessage_DataReader
            public interface ITFMessage_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref TFMessage_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref TFMessage_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref TFMessage_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref TFMessage_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    TFMessage_ instance);
            }
            #endregion

            #region ITFMessage_DataWriter
            public interface ITFMessage_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    TFMessage_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    TFMessage_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    TFMessage_ instanceData);

                ReturnCode Write(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    TFMessage_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    TFMessage_ instanceData);

                ReturnCode WriteDispose(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    TFMessage_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    TFMessage_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref TFMessage_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    TFMessage_ instanceData);
            }
            #endregion

        }

    }

}

