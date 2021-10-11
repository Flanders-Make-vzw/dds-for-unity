using DDS;
using DDS.OpenSplice;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region IMultiDOFJointTrajectoryPoint_DataReader
            public interface IMultiDOFJointTrajectoryPoint_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref MultiDOFJointTrajectoryPoint_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref MultiDOFJointTrajectoryPoint_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref MultiDOFJointTrajectoryPoint_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref MultiDOFJointTrajectoryPoint_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    MultiDOFJointTrajectoryPoint_ instance);
            }
            #endregion

            #region IMultiDOFJointTrajectoryPoint_DataWriter
            public interface IMultiDOFJointTrajectoryPoint_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    MultiDOFJointTrajectoryPoint_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    MultiDOFJointTrajectoryPoint_ instanceData);

                ReturnCode Write(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    MultiDOFJointTrajectoryPoint_ instanceData);

                ReturnCode WriteDispose(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    MultiDOFJointTrajectoryPoint_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref MultiDOFJointTrajectoryPoint_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    MultiDOFJointTrajectoryPoint_ instanceData);
            }
            #endregion

        }

    }

}

