using DDS;
using DDS.OpenSplice;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region IHeader_DataReader
            public interface IHeader_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref Header_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref Header_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref Header_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref Header_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    Header_ instance);
            }
            #endregion

            #region IHeader_DataWriter
            public interface IHeader_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    Header_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    Header_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    Header_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    Header_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    Header_ instanceData);

                ReturnCode Write(
                    Header_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    Header_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    Header_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    Header_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    Header_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    Header_ instanceData);

                ReturnCode WriteDispose(
                    Header_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    Header_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    Header_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref Header_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    Header_ instanceData);
            }
            #endregion

        }

    }

}

