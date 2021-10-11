using DDS;
using DDS.OpenSplice;

namespace std_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region IByteMultiArray_DataReader
            public interface IByteMultiArray_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref ByteMultiArray_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref ByteMultiArray_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref ByteMultiArray_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref ByteMultiArray_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    ByteMultiArray_ instance);
            }
            #endregion

            #region IByteMultiArray_DataWriter
            public interface IByteMultiArray_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    ByteMultiArray_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    ByteMultiArray_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    ByteMultiArray_ instanceData);

                ReturnCode Write(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    ByteMultiArray_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    ByteMultiArray_ instanceData);

                ReturnCode WriteDispose(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    ByteMultiArray_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    ByteMultiArray_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref ByteMultiArray_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    ByteMultiArray_ instanceData);
            }
            #endregion

        }

    }

}

