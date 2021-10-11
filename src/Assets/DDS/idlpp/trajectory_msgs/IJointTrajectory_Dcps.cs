using DDS;
using DDS.OpenSplice;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region IJointTrajectory_DataReader
            public interface IJointTrajectory_DataReader : DDS.IDataReader
            {
                ReturnCode Read(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Read(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Read(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Read(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode Take(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples);

                ReturnCode Take(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode Take(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode ReadWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition);

                ReturnCode TakeWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    IReadCondition readCondition);

                ReturnCode ReadNextSample(
                    ref JointTrajectory_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode TakeNextSample(
                    ref JointTrajectory_ dataValue,
                    ref SampleInfo sampleInfo);

                ReturnCode ReadInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode ReadNextInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode TakeNextInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle);

                ReturnCode TakeNextInstance(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates);

                ReturnCode ReadNextInstanceWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReadNextInstanceWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode TakeNextInstanceWithCondition(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle,
                    IReadCondition readCondition);

                ReturnCode ReturnLoan(
                    ref JointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos);

                ReturnCode GetKeyValue(
                    ref JointTrajectory_ key,
                    InstanceHandle handle);

                InstanceHandle LookupInstance(
                    JointTrajectory_ instance);
            }
            #endregion

            #region IJointTrajectory_DataWriter
            public interface IJointTrajectory_DataWriter : DDS.IDataWriter
            {
                InstanceHandle RegisterInstance(
                    JointTrajectory_ instanceData);

                InstanceHandle RegisterInstanceWithTimestamp(
                    JointTrajectory_ instanceData,
                    Time sourceTimestamp);

                ReturnCode UnregisterInstance(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode UnregisterInstanceWithTimestamp(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Write(
                    JointTrajectory_ instanceData);

                ReturnCode Write(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteWithTimestamp(
                    JointTrajectory_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteWithTimestamp(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode Dispose(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode DisposeWithTimestamp(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode WriteDispose(
                    JointTrajectory_ instanceData);

                ReturnCode WriteDispose(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle);

                ReturnCode WriteDisposeWithTimestamp(
                    JointTrajectory_ instanceData,
                    Time sourceTimestamp);

                ReturnCode WriteDisposeWithTimestamp(
                    JointTrajectory_ instanceData,
                    InstanceHandle instanceHandle,
                    Time sourceTimestamp);

                ReturnCode GetKeyValue(
                    ref JointTrajectory_ key,
                    InstanceHandle instanceHandle);

                InstanceHandle LookupInstance(
                    JointTrajectory_ instanceData);
            }
            #endregion

        }

    }

}

