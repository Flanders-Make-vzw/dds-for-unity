using DDS;
using DDS.OpenSplice;

namespace turtlesim
{
    namespace srv
    {
        namespace dds_
        {
            #region ITeleportAbsolute_Request_DataReader
            public interface ITeleportAbsolute_Request_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref TeleportAbsolute_Request_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref TeleportAbsolute_Request_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref TeleportAbsolute_Request_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    TeleportAbsolute_Request_ instance);
            }
            #endregion

            #region ITeleportAbsolute_Request_DataWriter
            public interface ITeleportAbsolute_Request_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    TeleportAbsolute_Request_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    TeleportAbsolute_Request_ instanceData);

                ReturnCode Write(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    TeleportAbsolute_Request_ instanceData);

                ReturnCode WriteDispose(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref TeleportAbsolute_Request_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    TeleportAbsolute_Request_ instanceData);
            }
            #endregion

            #region ITeleportAbsolute_Response_DataReader
            public interface ITeleportAbsolute_Response_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref TeleportAbsolute_Response_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref TeleportAbsolute_Response_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref TeleportAbsolute_Response_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    TeleportAbsolute_Response_ instance);
            }
            #endregion

            #region ITeleportAbsolute_Response_DataWriter
            public interface ITeleportAbsolute_Response_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    TeleportAbsolute_Response_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    TeleportAbsolute_Response_ instanceData);

                ReturnCode Write(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    TeleportAbsolute_Response_ instanceData);

                ReturnCode WriteDispose(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref TeleportAbsolute_Response_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    TeleportAbsolute_Response_ instanceData);
            }
            #endregion

            #region ISample_TeleportAbsolute_Request_DataReader
            public interface ISample_TeleportAbsolute_Request_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref Sample_TeleportAbsolute_Request_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref Sample_TeleportAbsolute_Request_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref Sample_TeleportAbsolute_Request_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref Sample_TeleportAbsolute_Request_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    Sample_TeleportAbsolute_Request_ instance);
            }
            #endregion

            #region ISample_TeleportAbsolute_Request_DataWriter
            public interface ISample_TeleportAbsolute_Request_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    Sample_TeleportAbsolute_Request_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    Sample_TeleportAbsolute_Request_ instanceData);

                ReturnCode Write(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    Sample_TeleportAbsolute_Request_ instanceData);

                ReturnCode WriteDispose(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    Sample_TeleportAbsolute_Request_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref Sample_TeleportAbsolute_Request_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    Sample_TeleportAbsolute_Request_ instanceData);
            }
            #endregion

            #region ISample_TeleportAbsolute_Response_DataReader
            public interface ISample_TeleportAbsolute_Response_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref Sample_TeleportAbsolute_Response_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref Sample_TeleportAbsolute_Response_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref Sample_TeleportAbsolute_Response_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref Sample_TeleportAbsolute_Response_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    Sample_TeleportAbsolute_Response_ instance);
            }
            #endregion

            #region ISample_TeleportAbsolute_Response_DataWriter
            public interface ISample_TeleportAbsolute_Response_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    Sample_TeleportAbsolute_Response_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    Sample_TeleportAbsolute_Response_ instanceData);

                ReturnCode Write(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    Sample_TeleportAbsolute_Response_ instanceData);

                ReturnCode WriteDispose(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    Sample_TeleportAbsolute_Response_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref Sample_TeleportAbsolute_Response_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    Sample_TeleportAbsolute_Response_ instanceData);
            }
            #endregion

        }

    }

}

