using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DDS;
using DDS.OpenSplice;
using DDS.OpenSplice.CustomMarshalers;

namespace trajectory_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiDOFJointTrajectory_DataReader
            public class MultiDOFJointTrajectory_DataReader : DDS.OpenSplice.FooDataReader<MultiDOFJointTrajectory_, __MultiDOFJointTrajectory_Marshaler>, 
                                                 IMultiDOFJointTrajectory_DataReader
            {
                public MultiDOFJointTrajectory_DataReader(DatabaseMarshaler marshaler)
                    : base(marshaler) { }

                public ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos)
                {
                    return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
                }

                public ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples)
                {
                    return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                        ViewStateKind.Any, InstanceStateKind.Any);
                }

                public ReturnCode Read(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates)
                {
                    return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                        viewStates, instanceStates);
                }

                public override ReturnCode Read(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        SampleStateKind sampleStates,
                        ViewStateKind viewStates,
                        InstanceStateKind instanceStates)
                {
                    ReturnCode result =
                        base.Read(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                sampleStates,
                                viewStates,
                                instanceStates);
                    return result;
                }

                public ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos)
                {
                    return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
                }

                public ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples)
                {
                    return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                        ViewStateKind.Any, InstanceStateKind.Any);
                }

                public ReturnCode Take(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates)
                {
                    return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                        viewStates, instanceStates);
                }

                public override ReturnCode Take(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        SampleStateKind sampleStates,
                        ViewStateKind viewStates,
                        InstanceStateKind instanceStates)
                {
                    ReturnCode result =
                        base.Take(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                sampleStates,
                                viewStates,
                                instanceStates);
                    return result;
                }

                public ReturnCode ReadWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition)
                {
                    return ReadWithCondition(ref dataValues, ref sampleInfos,
                        Length.Unlimited, readCondition);
                }

                public override ReturnCode ReadWithCondition(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        IReadCondition readCondition)
                {
                    ReturnCode result =
                        base.ReadWithCondition(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                readCondition);
                    return result;
                }

                public ReturnCode TakeWithCondition(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition)
                {
                    return TakeWithCondition(ref dataValues, ref sampleInfos,
                        Length.Unlimited, readCondition);
                }

                public override ReturnCode TakeWithCondition(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        IReadCondition readCondition)
                {
                    ReturnCode result =
                        base.TakeWithCondition(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                readCondition);
                    return result;
                }

                public override ReturnCode ReadNextSample(
                        ref MultiDOFJointTrajectory_ dataValue,
                        ref SampleInfo sampleInfo)
                {
                    ReturnCode result =
                        base.ReadNextSample(
                                ref dataValue,
                                ref sampleInfo);
                    return result;
                }

                public override ReturnCode TakeNextSample(
                        ref MultiDOFJointTrajectory_ dataValue,
                        ref SampleInfo sampleInfo)
                {
                    ReturnCode result =
                        base.TakeNextSample(
                                ref dataValue,
                                ref sampleInfo);
                    return result;
                }

                public ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode ReadInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode ReadInstance(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        InstanceHandle instanceHandle,
                        SampleStateKind sampleStates,
                        ViewStateKind viewStates,
                        InstanceStateKind instanceStates)
                {
                    ReturnCode result =
                        base.ReadInstance(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                instanceHandle,
                                sampleStates,
                                viewStates,
                                instanceStates);
                    return result;
                }

                public ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode TakeInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode TakeInstance(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        InstanceHandle instanceHandle,
                        SampleStateKind sampleStates,
                        ViewStateKind viewStates,
                        InstanceStateKind instanceStates)
                {
                    ReturnCode result =
                        base.TakeInstance(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                instanceHandle,
                                sampleStates,
                                viewStates,
                                instanceStates);
                    return result;
                }

                public ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode ReadNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode ReadNextInstance(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        InstanceHandle instanceHandle,
                        SampleStateKind sampleStates,
                        ViewStateKind viewStates,
                        InstanceStateKind instanceStates)
                {
                    ReturnCode result =
                        base.ReadNextInstance(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                instanceHandle,
                                sampleStates,
                                viewStates,
                                instanceStates);
                    return result;
                }

                public ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode TakeNextInstance(
                    ref MultiDOFJointTrajectory_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode TakeNextInstance(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        InstanceHandle instanceHandle,
                        SampleStateKind sampleStates,
                        ViewStateKind viewStates,
                        InstanceStateKind instanceStates)
                {
                    ReturnCode result =
                        base.TakeNextInstance(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                instanceHandle,
                                sampleStates,
                                viewStates,
                                instanceStates);
                    return result;
                }

                public ReturnCode ReadNextInstanceWithCondition(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        InstanceHandle instanceHandle,
                        IReadCondition readCondition)
                {
                    return ReadNextInstanceWithCondition(
                        ref dataValues,
                        ref sampleInfos,
                        Length.Unlimited,
                        instanceHandle,
                        readCondition);
                }

                public override ReturnCode ReadNextInstanceWithCondition(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        InstanceHandle instanceHandle,
                        IReadCondition readCondition)
                {
                    ReturnCode result =
                        base.ReadNextInstanceWithCondition(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                instanceHandle,
                                readCondition);
                    return result;
                }

                public ReturnCode TakeNextInstanceWithCondition(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        InstanceHandle instanceHandle,
                        IReadCondition readCondition)
                {
                    return TakeNextInstanceWithCondition(
                        ref dataValues,
                        ref sampleInfos,
                        Length.Unlimited,
                        instanceHandle,
                        readCondition);
                }

                public override ReturnCode TakeNextInstanceWithCondition(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos,
                        int maxSamples,
                        InstanceHandle instanceHandle,
                        IReadCondition readCondition)
                {
                    ReturnCode result =
                        base.TakeNextInstanceWithCondition(
                                ref dataValues,
                                ref sampleInfos,
                                maxSamples,
                                instanceHandle,
                                readCondition);

                    return result;
                }

                public override ReturnCode ReturnLoan(
                        ref MultiDOFJointTrajectory_[] dataValues,
                        ref SampleInfo[] sampleInfos)
                {
                    ReturnCode result =
                        base.ReturnLoan(
                                ref dataValues,
                                ref sampleInfos);

                    return result;
                }

                public override ReturnCode GetKeyValue(
                        ref MultiDOFJointTrajectory_ key,
                        InstanceHandle handle)
                {
                    ReturnCode result = base.GetKeyValue(
                                ref key,
                                handle);
                    return result;
                }

                public override InstanceHandle LookupInstance(
                        MultiDOFJointTrajectory_ instance)
                {
                    return
                        base.LookupInstance(
                                instance);
                }

            }
            #endregion
            
            #region MultiDOFJointTrajectory_DataWriter
            public class MultiDOFJointTrajectory_DataWriter : DDS.OpenSplice.FooDataWriter<MultiDOFJointTrajectory_, __MultiDOFJointTrajectory_Marshaler>, 
                                                 IMultiDOFJointTrajectory_DataWriter
            {
                public MultiDOFJointTrajectory_DataWriter(DatabaseMarshaler marshaler)
                    : base(marshaler) { }

                public InstanceHandle RegisterInstance(
                        MultiDOFJointTrajectory_ instanceData)
                {
                    return base.RegisterInstance(
                            instanceData,
                            Time.Current);
                }

                public InstanceHandle RegisterInstanceWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.RegisterInstance(
                            instanceData,
                            sourceTimestamp);
                }

                public ReturnCode UnregisterInstance(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.UnregisterInstance(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode UnregisterInstanceWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.UnregisterInstance(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode Write(MultiDOFJointTrajectory_ instanceData)
                {
                    return base.Write(
                            instanceData,
                            InstanceHandle.Nil,
                            Time.Current);
                }

                public ReturnCode Write(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.Write(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode WriteWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.Write(
                            instanceData,
                            InstanceHandle.Nil,
                            sourceTimestamp);
                }

                public ReturnCode WriteWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.Write(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode Dispose(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.Dispose(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode DisposeWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.Dispose(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode WriteDispose(
                        MultiDOFJointTrajectory_ instanceData)
                {
                    return base.WriteDispose(
                            instanceData,
                            InstanceHandle.Nil,
                            Time.Current);
                }

                public ReturnCode WriteDispose(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.WriteDispose(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode WriteDisposeWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.WriteDispose(
                            instanceData,
                            InstanceHandle.Nil,
                            sourceTimestamp);
                }

                public ReturnCode WriteDisposeWithTimestamp(
                        MultiDOFJointTrajectory_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.WriteDispose(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public override ReturnCode GetKeyValue(
                        ref MultiDOFJointTrajectory_ key,
                        InstanceHandle instanceHandle)
                {
                    return base.GetKeyValue(ref key, instanceHandle);
                }

                public override InstanceHandle LookupInstance(
                    MultiDOFJointTrajectory_ instanceData)
                {
                    return base.LookupInstance(instanceData);
                }
            }
            #endregion

            #region MultiDOFJointTrajectory_TypeSupport
            public class MultiDOFJointTrajectory_TypeSupport : DDS.OpenSplice.TypeSupport
            {
                private static readonly string[] metaDescriptor = {"<MetaData version=\"1.0.0\"><Module name=\"geometry_msgs\"><Module name=\"msg\"><Module name=\"dds_\">",
"<Struct name=\"Vector3_\"><Member name=\"x_\"><Double/></Member><Member name=\"y_\"><Double/></Member>",
"<Member name=\"z_\"><Double/></Member></Struct><Struct name=\"Quaternion_\"><Member name=\"x_\"><Double/>",
"</Member><Member name=\"y_\"><Double/></Member><Member name=\"z_\"><Double/></Member><Member name=\"w_\">",
"<Double/></Member></Struct><Struct name=\"Twist_\"><Member name=\"linear_\"><Type name=\"Vector3_\"/>",
"</Member><Member name=\"angular_\"><Type name=\"Vector3_\"/></Member></Struct><Struct name=\"Transform_\">",
"<Member name=\"translation_\"><Type name=\"Vector3_\"/></Member><Member name=\"rotation_\"><Type name=\"Quaternion_\"/>",
"</Member></Struct></Module></Module></Module><Module name=\"builtin_interfaces\"><Module name=\"msg\">",
"<Module name=\"dds_\"><Struct name=\"Time_\"><Member name=\"sec_\"><Long/></Member><Member name=\"nanosec_\">",
"<ULong/></Member></Struct><Struct name=\"Duration_\"><Member name=\"sec_\"><Long/></Member><Member name=\"nanosec_\">",
"<ULong/></Member></Struct></Module></Module></Module><Module name=\"trajectory_msgs\"><Module name=\"msg\">",
"<Module name=\"dds_\"><Struct name=\"MultiDOFJointTrajectoryPoint_\"><Member name=\"transforms_\"><Sequence>",
"<Type name=\"::geometry_msgs::msg::dds_::Transform_\"/></Sequence></Member><Member name=\"velocities_\">",
"<Sequence><Type name=\"::geometry_msgs::msg::dds_::Twist_\"/></Sequence></Member><Member name=\"accelerations_\">",
"<Sequence><Type name=\"::geometry_msgs::msg::dds_::Twist_\"/></Sequence></Member><Member name=\"time_from_start_\">",
"<Type name=\"::builtin_interfaces::msg::dds_::Duration_\"/></Member></Struct></Module></Module></Module>",
"<Module name=\"std_msgs\"><Module name=\"msg\"><Module name=\"dds_\"><Struct name=\"Header_\"><Member name=\"stamp_\">",
"<Type name=\"::builtin_interfaces::msg::dds_::Time_\"/></Member><Member name=\"frame_id_\"><String/></Member>",
"</Struct></Module></Module></Module><Module name=\"trajectory_msgs\"><Module name=\"msg\"><Module name=\"dds_\">",
"<Struct name=\"MultiDOFJointTrajectory_\"><Member name=\"header_\"><Type name=\"::std_msgs::msg::dds_::Header_\"/>",
"</Member><Member name=\"joint_names_\"><Sequence><String/></Sequence></Member><Member name=\"points_\">",
"<Sequence><Type name=\"MultiDOFJointTrajectoryPoint_\"/></Sequence></Member></Struct></Module></Module>",
"</Module></MetaData>"};

                public MultiDOFJointTrajectory_TypeSupport()
                    : base(typeof(MultiDOFJointTrajectory_), metaDescriptor, "trajectory_msgs::msg::dds_::MultiDOFJointTrajectory_", "", "")
                { }


                public override ReturnCode RegisterType(IDomainParticipant participant, string typeName)
                {
                    return RegisterType(participant, typeName, new __MultiDOFJointTrajectory_Marshaler());
                }

                public override DDS.OpenSplice.DataWriter CreateDataWriter(DatabaseMarshaler marshaler)
                {
                    return new MultiDOFJointTrajectory_DataWriter(marshaler);
                }

                public override DDS.OpenSplice.DataReader CreateDataReader(DatabaseMarshaler marshaler)
                {
                    return new MultiDOFJointTrajectory_DataReader(marshaler);
                }
            }
            #endregion

        }

    }

}

