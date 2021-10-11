using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DDS;
using DDS.OpenSplice;
using DDS.OpenSplice.CustomMarshalers;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            #region MultiDOFJointState_DataReader
            public class MultiDOFJointState_DataReader : DDS.OpenSplice.FooDataReader<MultiDOFJointState_, __MultiDOFJointState_Marshaler>, 
                                                 IMultiDOFJointState_DataReader
            {
                public MultiDOFJointState_DataReader(DatabaseMarshaler marshaler)
                    : base(marshaler) { }

                public ReturnCode Read(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos)
                {
                    return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
                }

                public ReturnCode Read(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples)
                {
                    return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                        ViewStateKind.Any, InstanceStateKind.Any);
                }

                public ReturnCode Read(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates)
                {
                    return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                        viewStates, instanceStates);
                }

                public override ReturnCode Read(
                        ref MultiDOFJointState_[] dataValues,
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
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos)
                {
                    return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
                }

                public ReturnCode Take(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples)
                {
                    return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                        ViewStateKind.Any, InstanceStateKind.Any);
                }

                public ReturnCode Take(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates)
                {
                    return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                        viewStates, instanceStates);
                }

                public override ReturnCode Take(
                        ref MultiDOFJointState_[] dataValues,
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
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition)
                {
                    return ReadWithCondition(ref dataValues, ref sampleInfos,
                        Length.Unlimited, readCondition);
                }

                public override ReturnCode ReadWithCondition(
                        ref MultiDOFJointState_[] dataValues,
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
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition)
                {
                    return TakeWithCondition(ref dataValues, ref sampleInfos,
                        Length.Unlimited, readCondition);
                }

                public override ReturnCode TakeWithCondition(
                        ref MultiDOFJointState_[] dataValues,
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
                        ref MultiDOFJointState_ dataValue,
                        ref SampleInfo sampleInfo)
                {
                    ReturnCode result =
                        base.ReadNextSample(
                                ref dataValue,
                                ref sampleInfo);
                    return result;
                }

                public override ReturnCode TakeNextSample(
                        ref MultiDOFJointState_ dataValue,
                        ref SampleInfo sampleInfo)
                {
                    ReturnCode result =
                        base.TakeNextSample(
                                ref dataValue,
                                ref sampleInfo);
                    return result;
                }

                public ReturnCode ReadInstance(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode ReadInstance(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode ReadInstance(
                        ref MultiDOFJointState_[] dataValues,
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
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode TakeInstance(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode TakeInstance(
                        ref MultiDOFJointState_[] dataValues,
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
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode ReadNextInstance(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode ReadNextInstance(
                        ref MultiDOFJointState_[] dataValues,
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
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode TakeNextInstance(
                    ref MultiDOFJointState_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode TakeNextInstance(
                        ref MultiDOFJointState_[] dataValues,
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
                        ref MultiDOFJointState_[] dataValues,
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
                        ref MultiDOFJointState_[] dataValues,
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
                        ref MultiDOFJointState_[] dataValues,
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
                        ref MultiDOFJointState_[] dataValues,
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
                        ref MultiDOFJointState_[] dataValues,
                        ref SampleInfo[] sampleInfos)
                {
                    ReturnCode result =
                        base.ReturnLoan(
                                ref dataValues,
                                ref sampleInfos);

                    return result;
                }

                public override ReturnCode GetKeyValue(
                        ref MultiDOFJointState_ key,
                        InstanceHandle handle)
                {
                    ReturnCode result = base.GetKeyValue(
                                ref key,
                                handle);
                    return result;
                }

                public override InstanceHandle LookupInstance(
                        MultiDOFJointState_ instance)
                {
                    return
                        base.LookupInstance(
                                instance);
                }

            }
            #endregion
            
            #region MultiDOFJointState_DataWriter
            public class MultiDOFJointState_DataWriter : DDS.OpenSplice.FooDataWriter<MultiDOFJointState_, __MultiDOFJointState_Marshaler>, 
                                                 IMultiDOFJointState_DataWriter
            {
                public MultiDOFJointState_DataWriter(DatabaseMarshaler marshaler)
                    : base(marshaler) { }

                public InstanceHandle RegisterInstance(
                        MultiDOFJointState_ instanceData)
                {
                    return base.RegisterInstance(
                            instanceData,
                            Time.Current);
                }

                public InstanceHandle RegisterInstanceWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.RegisterInstance(
                            instanceData,
                            sourceTimestamp);
                }

                public ReturnCode UnregisterInstance(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.UnregisterInstance(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode UnregisterInstanceWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.UnregisterInstance(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode Write(MultiDOFJointState_ instanceData)
                {
                    return base.Write(
                            instanceData,
                            InstanceHandle.Nil,
                            Time.Current);
                }

                public ReturnCode Write(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.Write(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode WriteWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.Write(
                            instanceData,
                            InstanceHandle.Nil,
                            sourceTimestamp);
                }

                public ReturnCode WriteWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.Write(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode Dispose(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.Dispose(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode DisposeWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.Dispose(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode WriteDispose(
                        MultiDOFJointState_ instanceData)
                {
                    return base.WriteDispose(
                            instanceData,
                            InstanceHandle.Nil,
                            Time.Current);
                }

                public ReturnCode WriteDispose(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.WriteDispose(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode WriteDisposeWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.WriteDispose(
                            instanceData,
                            InstanceHandle.Nil,
                            sourceTimestamp);
                }

                public ReturnCode WriteDisposeWithTimestamp(
                        MultiDOFJointState_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.WriteDispose(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public override ReturnCode GetKeyValue(
                        ref MultiDOFJointState_ key,
                        InstanceHandle instanceHandle)
                {
                    return base.GetKeyValue(ref key, instanceHandle);
                }

                public override InstanceHandle LookupInstance(
                    MultiDOFJointState_ instanceData)
                {
                    return base.LookupInstance(instanceData);
                }
            }
            #endregion

            #region MultiDOFJointState_TypeSupport
            public class MultiDOFJointState_TypeSupport : DDS.OpenSplice.TypeSupport
            {
                private static readonly string[] metaDescriptor = {"<MetaData version=\"1.0.0\"><Module name=\"geometry_msgs\"><Module name=\"msg\"><Module name=\"dds_\">",
"<Struct name=\"Vector3_\"><Member name=\"x_\"><Double/></Member><Member name=\"y_\"><Double/></Member>",
"<Member name=\"z_\"><Double/></Member></Struct><Struct name=\"Quaternion_\"><Member name=\"x_\"><Double/>",
"</Member><Member name=\"y_\"><Double/></Member><Member name=\"z_\"><Double/></Member><Member name=\"w_\">",
"<Double/></Member></Struct><Struct name=\"Wrench_\"><Member name=\"force_\"><Type name=\"Vector3_\"/>",
"</Member><Member name=\"torque_\"><Type name=\"Vector3_\"/></Member></Struct><Struct name=\"Twist_\">",
"<Member name=\"linear_\"><Type name=\"Vector3_\"/></Member><Member name=\"angular_\"><Type name=\"Vector3_\"/>",
"</Member></Struct><Struct name=\"Transform_\"><Member name=\"translation_\"><Type name=\"Vector3_\"/>",
"</Member><Member name=\"rotation_\"><Type name=\"Quaternion_\"/></Member></Struct></Module></Module></Module>",
"<Module name=\"builtin_interfaces\"><Module name=\"msg\"><Module name=\"dds_\"><Struct name=\"Time_\">",
"<Member name=\"sec_\"><Long/></Member><Member name=\"nanosec_\"><ULong/></Member></Struct></Module></Module>",
"</Module><Module name=\"std_msgs\"><Module name=\"msg\"><Module name=\"dds_\"><Struct name=\"Header_\">",
"<Member name=\"stamp_\"><Type name=\"::builtin_interfaces::msg::dds_::Time_\"/></Member><Member name=\"frame_id_\">",
"<String/></Member></Struct></Module></Module></Module><Module name=\"sensor_msgs\"><Module name=\"msg\">",
"<Module name=\"dds_\"><Struct name=\"MultiDOFJointState_\"><Member name=\"header_\"><Type name=\"::std_msgs::msg::dds_::Header_\"/>",
"</Member><Member name=\"joint_names_\"><Sequence><String/></Sequence></Member><Member name=\"transforms_\">",
"<Sequence><Type name=\"::geometry_msgs::msg::dds_::Transform_\"/></Sequence></Member><Member name=\"twist_\">",
"<Sequence><Type name=\"::geometry_msgs::msg::dds_::Twist_\"/></Sequence></Member><Member name=\"wrench_\">",
"<Sequence><Type name=\"::geometry_msgs::msg::dds_::Wrench_\"/></Sequence></Member></Struct></Module></Module>",
"</Module></MetaData>"};

                public MultiDOFJointState_TypeSupport()
                    : base(typeof(MultiDOFJointState_), metaDescriptor, "sensor_msgs::msg::dds_::MultiDOFJointState_", "", "")
                { }


                public override ReturnCode RegisterType(IDomainParticipant participant, string typeName)
                {
                    return RegisterType(participant, typeName, new __MultiDOFJointState_Marshaler());
                }

                public override DDS.OpenSplice.DataWriter CreateDataWriter(DatabaseMarshaler marshaler)
                {
                    return new MultiDOFJointState_DataWriter(marshaler);
                }

                public override DDS.OpenSplice.DataReader CreateDataReader(DatabaseMarshaler marshaler)
                {
                    return new MultiDOFJointState_DataReader(marshaler);
                }
            }
            #endregion

        }

    }

}

