#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("TestInternalGrainInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace UnitTests.GrainInterfaces
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject))]
    internal class OrleansCodeGenClientAddressableTestClientObjectReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject
    {
        protected @OrleansCodeGenClientAddressableTestClientObjectReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientAddressableTestClientObjectReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -413437530;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -413437530;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -413437530:
                    switch (@methodId)
                    {
                        case 1001930530:
                            return "OnHappyPath";
                        case 1740088762:
                            return "OnSadPath";
                        case -1140724741:
                            return "OnSerialStress";
                        case -252098785:
                            return "OnParallelStress";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -413437530 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @OnHappyPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.String>(1001930530, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @OnSadPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1740088762, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @OnSerialStress(global::System.Int32 @n)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1140724741, new global::System.Object[]{@n});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @OnParallelStress(global::System.Int32 @n)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-252098785, new global::System.Object[]{@n});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject", -413437530, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestClientObjectMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -413437530:
                        switch (methodId)
                        {
                            case 1001930530:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnHappyPath((global::System.String)arguments[0]).@Box();
                            case 1740088762:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnSadPath((global::System.String)arguments[0]).@Box();
                            case -1140724741:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnSerialStress((global::System.Int32)arguments[0]).@Box();
                            case -252098785:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnParallelStress((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -413437530 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -413437530;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestGrain))]
    internal class OrleansCodeGenClientAddressableTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestGrain
    {
        protected @OrleansCodeGenClientAddressableTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientAddressableTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1146001751;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1146001751;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1146001751:
                    switch (@methodId)
                    {
                        case 1054570258:
                            return "SetTarget";
                        case -921057028:
                            return "HappyPath";
                        case -1261808465:
                            return "SadPath";
                        case 265614114:
                            return "MicroSerialStressTest";
                        case 107468207:
                            return "MicroParallelStressTest";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1146001751 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetTarget(global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject @target)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1054570258, new global::System.Object[]{@target is global::Orleans.Grain ? @target.@AsReference<global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject>() : @target});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @HappyPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.String>(-921057028, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @SadPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1261808465, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @MicroSerialStressTest(global::System.Int32 @iterationCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(265614114, new global::System.Object[]{@iterationCount});
        }

        public global::System.Threading.Tasks.Task @MicroParallelStressTest(global::System.Int32 @iterationCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(107468207, new global::System.Object[]{@iterationCount});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestGrain", 1146001751, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1146001751:
                        switch (methodId)
                        {
                            case 1054570258:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@SetTarget((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)arguments[0]).@Box();
                            case -921057028:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@HappyPath((global::System.String)arguments[0]).@Box();
                            case -1261808465:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@SadPath((global::System.String)arguments[0]).@Box();
                            case 265614114:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@MicroSerialStressTest((global::System.Int32)arguments[0]).@Box();
                            case 107468207:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@MicroParallelStressTest((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1146001751 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1146001751;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestProducer))]
    internal class OrleansCodeGenClientAddressableTestProducerReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestProducer
    {
        protected @OrleansCodeGenClientAddressableTestProducerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientAddressableTestProducerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 924523153;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestProducer";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 924523153;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 924523153:
                    switch (@methodId)
                    {
                        case -439075721:
                            return "Poll";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 924523153 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @Poll()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-439075721, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestProducer", 924523153, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestProducer)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestProducerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 924523153:
                        switch (methodId)
                        {
                            case -439075721:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestProducer)@grain).@Poll().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 924523153 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 924523153;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain))]
    internal class OrleansCodeGenClientAddressableTestRendezvousGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain
    {
        protected @OrleansCodeGenClientAddressableTestRendezvousGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientAddressableTestRendezvousGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1879648219;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1879648219;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1879648219:
                    switch (@methodId)
                    {
                        case 500328066:
                            return "GetProducer";
                        case -1738589351:
                            return "SetProducer";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1879648219 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IClientAddressableTestProducer> @GetProducer()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IClientAddressableTestProducer>(500328066, null);
        }

        public global::System.Threading.Tasks.Task @SetProducer(global::UnitTests.GrainInterfaces.IClientAddressableTestProducer @producer)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1738589351, new global::System.Object[]{@producer is global::Orleans.Grain ? @producer.@AsReference<global::UnitTests.GrainInterfaces.IClientAddressableTestProducer>() : @producer});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain", 1879648219, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestRendezvousGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1879648219:
                        switch (methodId)
                        {
                            case 500328066:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain)@grain).@GetProducer().@Box();
                            case -1738589351:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain)@grain).@SetProducer((global::UnitTests.GrainInterfaces.IClientAddressableTestProducer)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1879648219 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1879648219;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain))]
    internal class OrleansCodeGenMultifacetFactoryTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain
    {
        protected @OrleansCodeGenMultifacetFactoryTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMultifacetFactoryTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1185322135;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1185322135;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1185322135:
                    switch (@methodId)
                    {
                        case 1321973978:
                            return "GetReader";
                        case 872009969:
                            return "GetReader";
                        case -2056720036:
                            return "GetWriter";
                        case 105514979:
                            return "GetWriter";
                        case -281962391:
                            return "SetReader";
                        case -843412927:
                            return "SetWriter";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1185322135 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetReader> @GetReader(global::UnitTests.GrainInterfaces.IMultifacetTestGrain @grain)
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetReader>(1321973978, new global::System.Object[]{@grain is global::Orleans.Grain ? @grain.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetTestGrain>() : @grain});
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetReader> @GetReader()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetReader>(872009969, null);
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetWriter> @GetWriter(global::UnitTests.GrainInterfaces.IMultifacetTestGrain @grain)
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetWriter>(-2056720036, new global::System.Object[]{@grain is global::Orleans.Grain ? @grain.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetTestGrain>() : @grain});
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetWriter> @GetWriter()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetWriter>(105514979, null);
        }

        public global::System.Threading.Tasks.Task @SetReader(global::UnitTests.GrainInterfaces.IMultifacetReader @reader)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-281962391, new global::System.Object[]{@reader is global::Orleans.Grain ? @reader.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetReader>() : @reader});
        }

        public global::System.Threading.Tasks.Task @SetWriter(global::UnitTests.GrainInterfaces.IMultifacetWriter @writer)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-843412927, new global::System.Object[]{@writer is global::Orleans.Grain ? @writer.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetWriter>() : @writer});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain", 1185322135, typeof (global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMultifacetFactoryTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1185322135:
                        switch (methodId)
                        {
                            case 1321973978:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetReader((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)arguments[0]).@Box();
                            case 872009969:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetReader().@Box();
                            case -2056720036:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetWriter((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)arguments[0]).@Box();
                            case 105514979:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetWriter().@Box();
                            case -281962391:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@SetReader((global::UnitTests.GrainInterfaces.IMultifacetReader)arguments[0]).@Box();
                            case -843412927:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@SetWriter((global::UnitTests.GrainInterfaces.IMultifacetWriter)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1185322135 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1185322135;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IMultifacetTestGrain))]
    internal class OrleansCodeGenMultifacetTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IMultifacetTestGrain
    {
        protected @OrleansCodeGenMultifacetTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenMultifacetTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -498812991;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IMultifacetTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -498812991 || @interfaceId == -1899485304 || @interfaceId == -1574751914;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -498812991:
                    switch (@methodId)
                    {
                        case 637921746:
                            return "GetValue";
                        case -317315461:
                            return "SetValue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -498812991 + ",methodId=" + @methodId);
                    }

                case -1899485304:
                    switch (@methodId)
                    {
                        case 637921746:
                            return "GetValue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1899485304 + ",methodId=" + @methodId);
                    }

                case -1574751914:
                    switch (@methodId)
                    {
                        case -317315461:
                            return "SetValue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1574751914 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetValue()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(637921746, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Int32 @x)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-317315461, new global::System.Object[]{@x});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IMultifacetTestGrain", -498812991, typeof (global::UnitTests.GrainInterfaces.IMultifacetTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMultifacetTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -498812991:
                        switch (methodId)
                        {
                            case 637921746:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@GetValue().@Box();
                            case -317315461:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@SetValue((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -498812991 + ",methodId=" + methodId);
                        }

                    case -1899485304:
                        switch (methodId)
                        {
                            case 637921746:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@GetValue().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1899485304 + ",methodId=" + methodId);
                        }

                    case -1574751914:
                        switch (methodId)
                        {
                            case -317315461:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@SetValue((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1574751914 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -498812991;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IStressTestGrain))]
    internal class OrleansCodeGenStressTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IStressTestGrain
    {
        protected @OrleansCodeGenStressTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStressTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1803695362;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IStressTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1803695362;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1803695362:
                    switch (@methodId)
                    {
                        case 815427771:
                            return "GetLabel";
                        case 137111425:
                            return "SetLabel";
                        case -2120489211:
                            return "PingOthers";
                        case 1178934261:
                            return "LookUpMany";
                        case 1040966585:
                            return "Send";
                        case -608678522:
                            return "Echo";
                        case -2068079123:
                            return "Ping";
                        case -105598243:
                            return "PingWithDelay";
                        case 2018329561:
                            return "GetGrainReference";
                        case 543404287:
                            return "DeactivateSelf";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1803695362 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetLabel()
        {
            return base.@InvokeMethodAsync<global::System.String>(815427771, null);
        }

        public global::System.Threading.Tasks.Task @SetLabel(global::System.String @label)
        {
            return base.@InvokeMethodAsync<global::System.Object>(137111425, new global::System.Object[]{@label});
        }

        public global::System.Threading.Tasks.Task @PingOthers(global::System.Int64[] @others)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2120489211, new global::System.Object[]{@others});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ActivationId>>>>> @LookUpMany(global::Orleans.Runtime.SiloAddress @destination, global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>> @grainAndETagList, global::System.Int32 @retries)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ActivationId>>>>>(1178934261, new global::System.Object[]{@destination, @grainAndETagList, @retries});
        }

        public global::System.Threading.Tasks.Task @Send(global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1040966585, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task<global::System.Byte[]> @Echo(global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Byte[]>(-608678522, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task @Ping(global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2068079123, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task @PingWithDelay(global::System.Byte[] @data, global::System.TimeSpan @delay)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-105598243, new global::System.Object[]{@data, @delay});
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IStressTestGrain> @GetGrainReference()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IStressTestGrain>(2018329561, null);
        }

        public global::System.Threading.Tasks.Task @DeactivateSelf()
        {
            return base.@InvokeMethodAsync<global::System.Object>(543404287, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.2.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IStressTestGrain", -1803695362, typeof (global::UnitTests.GrainInterfaces.IStressTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStressTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1803695362:
                        switch (methodId)
                        {
                            case 815427771:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@GetLabel().@Box();
                            case 137111425:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@SetLabel((global::System.String)arguments[0]).@Box();
                            case -2120489211:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@PingOthers((global::System.Int64[])arguments[0]).@Box();
                            case 1178934261:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@LookUpMany((global::Orleans.Runtime.SiloAddress)arguments[0], (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>>)arguments[1], (global::System.Int32)arguments[2]).@Box();
                            case 1040966585:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@Send((global::System.Byte[])arguments[0]).@Box();
                            case -608678522:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@Echo((global::System.Byte[])arguments[0]).@Box();
                            case -2068079123:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@Ping((global::System.Byte[])arguments[0]).@Box();
                            case -105598243:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@PingWithDelay((global::System.Byte[])arguments[0], (global::System.TimeSpan)arguments[1]).@Box();
                            case 2018329561:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@GetGrainReference().@Box();
                            case 543404287:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@DeactivateSelf().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1803695362 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1803695362;
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
