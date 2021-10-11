using DDS;
using DDS.OpenSplice;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region IMultiDOFJointTrajectory_DataReader
            public interface IMultiDOFJointTrajectory_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref MultiDOFJointTrajectory_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref MultiDOFJointTrajectory_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref MultiDOFJointTrajectory_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    MultiDOFJointTrajectory_ instance);
            }
            #endregion

            #region IMultiDOFJointTrajectory_DataWriter
            public interface IMultiDOFJointTrajectory_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    MultiDOFJointTrajectory_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    MultiDOFJointTrajectory_ instanceData);

                ReturnCode Write(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    MultiDOFJointTrajectory_ instanceData);

                ReturnCode WriteDispose(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    MultiDOFJointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref MultiDOFJointTrajectory_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    MultiDOFJointTrajectory_ instanceData);
            }
            #endregion

        }

    }

}

