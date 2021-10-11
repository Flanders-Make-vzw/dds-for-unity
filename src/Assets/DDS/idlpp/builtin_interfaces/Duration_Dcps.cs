using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DDS;
using DDS.OpenSplice;
using DDS.OpenSplice.CustomMarshalers;

namespace builtin_interfaces
{
    namespace msg
    {
        namespace dds_
        {
            #region Duration_DataReader
            public class Duration_DataReader : DDS.OpenSplice.FooDataReader<Duration_, __Duration_Marshaler>, 
                                                 IDuration_DataReader
            {
                public Duration_DataReader(DatabaseMarshaler marshaler)
                    : base(marshaler) { }

                public ReturnCode Read(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos)
                {
                    return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
                }

                public ReturnCode Read(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples)
                {
                    return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                        ViewStateKind.Any, InstanceStateKind.Any);
                }

                public ReturnCode Read(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates)
                {
                    return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                        viewStates, instanceStates);
                }

                public override ReturnCode Read(
                        ref Duration_[] dataValues,
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
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos)
                {
                    return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
                }

                public ReturnCode Take(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples)
                {
                    return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                        ViewStateKind.Any, InstanceStateKind.Any);
                }

                public ReturnCode Take(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    SampleStateKind sampleStates,
                    ViewStateKind viewStates,
                    InstanceStateKind instanceStates)
                {
                    return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                        viewStates, instanceStates);
                }

                public override ReturnCode Take(
                        ref Duration_[] dataValues,
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
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition)
                {
                    return ReadWithCondition(ref dataValues, ref sampleInfos,
                        Length.Unlimited, readCondition);
                }

                public override ReturnCode ReadWithCondition(
                        ref Duration_[] dataValues,
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
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    IReadCondition readCondition)
                {
                    return TakeWithCondition(ref dataValues, ref sampleInfos,
                        Length.Unlimited, readCondition);
                }

                public override ReturnCode TakeWithCondition(
                        ref Duration_[] dataValues,
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
                        ref Duration_ dataValue,
                        ref SampleInfo sampleInfo)
                {
                    ReturnCode result =
                        base.ReadNextSample(
                                ref dataValue,
                                ref sampleInfo);
                    return result;
                }

                public override ReturnCode TakeNextSample(
                        ref Duration_ dataValue,
                        ref SampleInfo sampleInfo)
                {
                    ReturnCode result =
                        base.TakeNextSample(
                                ref dataValue,
                                ref sampleInfo);
                    return result;
                }

                public ReturnCode ReadInstance(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode ReadInstance(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode ReadInstance(
                        ref Duration_[] dataValues,
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
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode TakeInstance(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode TakeInstance(
                        ref Duration_[] dataValues,
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
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode ReadNextInstance(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode ReadNextInstance(
                        ref Duration_[] dataValues,
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
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    InstanceHandle instanceHandle)
                {
                    return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
                }

                public ReturnCode TakeNextInstance(
                    ref Duration_[] dataValues,
                    ref SampleInfo[] sampleInfos,
                    int maxSamples,
                    InstanceHandle instanceHandle)
                {
                    return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                        SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
                }

                public override ReturnCode TakeNextInstance(
                        ref Duration_[] dataValues,
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
                        ref Duration_[] dataValues,
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
                        ref Duration_[] dataValues,
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
                        ref Duration_[] dataValues,
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
                        ref Duration_[] dataValues,
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
                        ref Duration_[] dataValues,
                        ref SampleInfo[] sampleInfos)
                {
                    ReturnCode result =
                        base.ReturnLoan(
                                ref dataValues,
                                ref sampleInfos);

                    return result;
                }

                public override ReturnCode GetKeyValue(
                        ref Duration_ key,
                        InstanceHandle handle)
                {
                    ReturnCode result = base.GetKeyValue(
                                ref key,
                                handle);
                    return result;
                }

                public override InstanceHandle LookupInstance(
                        Duration_ instance)
                {
                    return
                        base.LookupInstance(
                                instance);
                }

            }
            #endregion
            
            #region Duration_DataWriter
            public class Duration_DataWriter : DDS.OpenSplice.FooDataWriter<Duration_, __Duration_Marshaler>, 
                                                 IDuration_DataWriter
            {
                public Duration_DataWriter(DatabaseMarshaler marshaler)
                    : base(marshaler) { }

                public InstanceHandle RegisterInstance(
                        Duration_ instanceData)
                {
                    return base.RegisterInstance(
                            instanceData,
                            Time.Current);
                }

                public InstanceHandle RegisterInstanceWithTimestamp(
                        Duration_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.RegisterInstance(
                            instanceData,
                            sourceTimestamp);
                }

                public ReturnCode UnregisterInstance(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.UnregisterInstance(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode UnregisterInstanceWithTimestamp(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.UnregisterInstance(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode Write(Duration_ instanceData)
                {
                    return base.Write(
                            instanceData,
                            InstanceHandle.Nil,
                            Time.Current);
                }

                public ReturnCode Write(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.Write(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode WriteWithTimestamp(
                        Duration_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.Write(
                            instanceData,
                            InstanceHandle.Nil,
                            sourceTimestamp);
                }

                public ReturnCode WriteWithTimestamp(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.Write(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode Dispose(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.Dispose(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode DisposeWithTimestamp(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.Dispose(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public ReturnCode WriteDispose(
                        Duration_ instanceData)
                {
                    return base.WriteDispose(
                            instanceData,
                            InstanceHandle.Nil,
                            Time.Current);
                }

                public ReturnCode WriteDispose(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle)
                {
                    return base.WriteDispose(
                            instanceData,
                            instanceHandle,
                            Time.Current);
                }

                public ReturnCode WriteDisposeWithTimestamp(
                        Duration_ instanceData,
                        Time sourceTimestamp)
                {
                    return base.WriteDispose(
                            instanceData,
                            InstanceHandle.Nil,
                            sourceTimestamp);
                }

                public ReturnCode WriteDisposeWithTimestamp(
                        Duration_ instanceData,
                        InstanceHandle instanceHandle,
                        Time sourceTimestamp)
                {
                    return base.WriteDispose(
                            instanceData,
                            instanceHandle,
                            sourceTimestamp);
                }

                public override ReturnCode GetKeyValue(
                        ref Duration_ key,
                        InstanceHandle instanceHandle)
                {
                    return base.GetKeyValue(ref key, instanceHandle);
                }

                public override InstanceHandle LookupInstance(
                    Duration_ instanceData)
                {
                    return base.LookupInstance(instanceData);
                }
            }
            #endregion

            #region Duration_TypeSupport
            public class Duration_TypeSupport : DDS.OpenSplice.TypeSupport
            {
                private static readonly string[] metaDescriptor = {"<MetaData version=\"1.0.0\"><Module name=\"builtin_interfaces\"><Module name=\"msg\"><Module name=\"dds_\">",
"<Struct name=\"Duration_\"><Member name=\"sec_\"><Long/></Member><Member name=\"nanosec_\"><ULong/></Member>",
"</Struct></Module></Module></Module></MetaData>"};

                public Duration_TypeSupport()
                    : base(typeof(Duration_), metaDescriptor, "builtin_interfaces::msg::dds_::Duration_", "", "")
                { }


                public override ReturnCode RegisterType(IDomainParticipant participant, string typeName)
                {
                    return RegisterType(participant, typeName, new __Duration_Marshaler());
                }

                public override DDS.OpenSplice.DataWriter CreateDataWriter(DatabaseMarshaler marshaler)
                {
                    return new Duration_DataWriter(marshaler);
                }

                public override DDS.OpenSplice.DataReader CreateDataReader(DatabaseMarshaler marshaler)
                {
                    return new Duration_DataReader(marshaler);
                }
            }
            #endregion

        }

    }

}

