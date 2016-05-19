#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("TestGrains, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.SqlUtils.StorageProvider.GrainClasses
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_SqlUtils_StorageProvider_GrainClasses_CustomerStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState input = ((global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState)original);
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState result = new global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState();
            result.@AvatarUrl = input.@AvatarUrl;
            result.@BirthDate = input.@BirthDate;
            result.@Country = input.@Country;
            result.@CustomerId = input.@CustomerId;
            result.@Devices = (global::System.Collections.Generic.List<global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.IDeviceGrain>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Devices);
            result.@FirstName = input.@FirstName;
            result.@Gender = input.@Gender;
            result.@KudoPoints = input.@KudoPoints;
            result.@LastLogin = input.@LastLogin;
            result.@LastName = input.@LastName;
            result.@NickName = input.@NickName;
            result.@Status = input.@Status;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState input = (global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AvatarUrl, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@BirthDate, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Country, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CustomerId, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Devices, stream, typeof (global::System.Collections.Generic.List<global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.IDeviceGrain>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FirstName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Gender, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@KudoPoints, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LastLogin, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LastName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NickName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState result = new global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@AvatarUrl = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@BirthDate = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@Country = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@CustomerId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Devices = (global::System.Collections.Generic.List<global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.IDeviceGrain>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.IDeviceGrain>), stream);
            result.@FirstName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Gender = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@KudoPoints = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@LastLogin = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@LastName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@NickName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Status = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.SqlUtils.StorageProvider.GrainClasses.CustomerState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_SqlUtils_StorageProvider_GrainClasses_CustomerStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_SqlUtils_StorageProvider_GrainClasses_DeviceStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState input = ((global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState)original);
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState result = new global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState();
            result.@AllLampsOnTime = input.@AllLampsOnTime;
            result.@Altitude = input.@Altitude;
            result.@AmberLampCount = input.@AmberLampCount;
            result.@AmberLampTime = input.@AmberLampTime;
            result.@AmberWarningLampOn = input.@AmberWarningLampOn;
            result.@CompanyId = input.@CompanyId;
            result.@ConversionMethod = input.@ConversionMethod;
            result.@CurrentBusUtilization = input.@CurrentBusUtilization;
            result.@CustomerId = input.@CustomerId;
            result.@DateKey = input.@DateKey;
            result.@EngineFamilyId = input.@EngineFamilyId;
            result.@EngineStartAmbient = input.@EngineStartAmbient;
            result.@EngineStartCoolant = input.@EngineStartCoolant;
            result.@EventId = input.@EventId;
            result.@EventTypeId = input.@EventTypeId;
            result.@FaultId = input.@FaultId;
            result.@FlashAmberWarningLampOn = input.@FlashAmberWarningLampOn;
            result.@FlashMalfunctionIndicatorLampOn = input.@FlashMalfunctionIndicatorLampOn;
            result.@FlashProtectLampOn = input.@FlashProtectLampOn;
            result.@FlashRedStopLampOn = input.@FlashRedStopLampOn;
            result.@Heading = input.@Heading;
            result.@LampId = input.@LampId;
            result.@Latitude = input.@Latitude;
            result.@LifeCycleId = input.@LifeCycleId;
            result.@LocationId = input.@LocationId;
            result.@Longitude = input.@Longitude;
            result.@MalfunctionIndicatorLampOn = input.@MalfunctionIndicatorLampOn;
            result.@MessageId = input.@MessageId;
            result.@MilLampCount = input.@MilLampCount;
            result.@MilLampTime = input.@MilLampTime;
            result.@MillisecondKey = input.@MillisecondKey;
            result.@OccurrenceCount = input.@OccurrenceCount;
            result.@Owner = (global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.ICustomerGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Owner);
            result.@PeakBusUtilization = input.@PeakBusUtilization;
            result.@PostTriggerSamples = input.@PostTriggerSamples;
            result.@PreTriggerSamples = input.@PreTriggerSamples;
            result.@ProtectLampOn = input.@ProtectLampOn;
            result.@RedLampCount = input.@RedLampCount;
            result.@RedLampTime = input.@RedLampTime;
            result.@RedStopLampOn = input.@RedStopLampOn;
            result.@SerialNumber = input.@SerialNumber;
            result.@SoftwareId = input.@SoftwareId;
            result.@StatusId = input.@StatusId;
            result.@SystemId = input.@SystemId;
            result.@TimeKey = input.@TimeKey;
            result.@TotalDistance = input.@TotalDistance;
            result.@TotalEngineHours = input.@TotalEngineHours;
            result.@TotalFuel = input.@TotalFuel;
            result.@TotalIdleFuel = input.@TotalIdleFuel;
            result.@TotalIdleHours = input.@TotalIdleHours;
            result.@TotalPtoFuel = input.@TotalPtoFuel;
            result.@TotalSnapshots = input.@TotalSnapshots;
            result.@TransactionId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@TransactionId);
            result.@TriggerTime = input.@TriggerTime;
            result.@TripId = input.@TripId;
            result.@VehicleId = input.@VehicleId;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState input = (global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AllLampsOnTime, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Altitude, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AmberLampCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AmberLampTime, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AmberWarningLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CompanyId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ConversionMethod, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CurrentBusUtilization, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CustomerId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DateKey, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EngineFamilyId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EngineStartAmbient, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EngineStartCoolant, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventId, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventTypeId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FaultId, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FlashAmberWarningLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FlashMalfunctionIndicatorLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FlashProtectLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FlashRedStopLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Heading, stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LampId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Latitude, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LifeCycleId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LocationId, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Longitude, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MalfunctionIndicatorLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MessageId, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MilLampCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MilLampTime, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MillisecondKey, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@OccurrenceCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Owner, stream, typeof (global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.ICustomerGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PeakBusUtilization, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PostTriggerSamples, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PreTriggerSamples, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProtectLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RedLampCount, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RedLampTime, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RedStopLampOn, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SerialNumber, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SoftwareId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StatusId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SystemId, stream, typeof (global::System.Int16));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TimeKey, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalDistance, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalEngineHours, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalFuel, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalIdleFuel, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalIdleHours, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalPtoFuel, stream, typeof (global::System.Double));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TotalSnapshots, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TransactionId, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TriggerTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TripId, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@VehicleId, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState result = new global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@AllLampsOnTime = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@Altitude = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@AmberLampCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@AmberLampTime = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@AmberWarningLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@CompanyId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@ConversionMethod = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@CurrentBusUtilization = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@CustomerId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@DateKey = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@EngineFamilyId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@EngineStartAmbient = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@EngineStartCoolant = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@EventId = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@EventTypeId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@FaultId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@FlashAmberWarningLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@FlashMalfunctionIndicatorLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@FlashProtectLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@FlashRedStopLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@Heading = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            result.@LampId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@Latitude = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@LifeCycleId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@LocationId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Longitude = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@MalfunctionIndicatorLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@MessageId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@MilLampCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@MilLampTime = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@MillisecondKey = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@OccurrenceCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Owner = (global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.ICustomerGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.SqlUtils.StorageProvider.GrainInterfaces.ICustomerGrain), stream);
            result.@PeakBusUtilization = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@PostTriggerSamples = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@PreTriggerSamples = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@ProtectLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@RedLampCount = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@RedLampTime = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@RedStopLampOn = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@SerialNumber = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SoftwareId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@StatusId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@SystemId = (global::System.Int16)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int16), stream);
            result.@TimeKey = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@TotalDistance = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@TotalEngineHours = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@TotalFuel = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@TotalIdleFuel = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@TotalIdleHours = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@TotalPtoFuel = (global::System.Double)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Double), stream);
            result.@TotalSnapshots = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@TransactionId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@TriggerTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@TripId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@VehicleId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.SqlUtils.StorageProvider.GrainClasses.DeviceState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_SqlUtils_StorageProvider_GrainClasses_DeviceStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::TestGrainInterfaces.CircularStateTestState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenTestGrainInterfaces_CircularStateTestStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::TestGrainInterfaces.CircularStateTestState input = ((global::TestGrainInterfaces.CircularStateTestState)original);
            global::TestGrainInterfaces.CircularStateTestState result = new global::TestGrainInterfaces.CircularStateTestState();
            result.@CircularTest1 = (global::TestGrainInterfaces.CircularTest1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@CircularTest1);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::TestGrainInterfaces.CircularStateTestState input = (global::TestGrainInterfaces.CircularStateTestState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CircularTest1, stream, typeof (global::TestGrainInterfaces.CircularTest1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::TestGrainInterfaces.CircularStateTestState result = new global::TestGrainInterfaces.CircularStateTestState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@CircularTest1 = (global::TestGrainInterfaces.CircularTest1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::TestGrainInterfaces.CircularTest1), stream);
            return (global::TestGrainInterfaces.CircularStateTestState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::TestGrainInterfaces.CircularStateTestState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenTestGrainInterfaces_CircularStateTestStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::TestGrainInterfaces.CircularTest1)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenTestGrainInterfaces_CircularTest1Serializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::TestGrainInterfaces.CircularTest1 input = ((global::TestGrainInterfaces.CircularTest1)original);
            global::TestGrainInterfaces.CircularTest1 result = new global::TestGrainInterfaces.CircularTest1();
            result.@CircularTest2 = (global::TestGrainInterfaces.CircularTest2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@CircularTest2);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::TestGrainInterfaces.CircularTest1 input = (global::TestGrainInterfaces.CircularTest1)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CircularTest2, stream, typeof (global::TestGrainInterfaces.CircularTest2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::TestGrainInterfaces.CircularTest1 result = new global::TestGrainInterfaces.CircularTest1();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@CircularTest2 = (global::TestGrainInterfaces.CircularTest2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::TestGrainInterfaces.CircularTest2), stream);
            return (global::TestGrainInterfaces.CircularTest1)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::TestGrainInterfaces.CircularTest1), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenTestGrainInterfaces_CircularTest1Serializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::TestGrainInterfaces.CircularTest2)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenTestGrainInterfaces_CircularTest2Serializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::TestGrainInterfaces.CircularTest2 input = ((global::TestGrainInterfaces.CircularTest2)original);
            global::TestGrainInterfaces.CircularTest2 result = new global::TestGrainInterfaces.CircularTest2();
            result.@CircularTest1List = (global::System.Collections.Generic.List<global::TestGrainInterfaces.CircularTest1>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@CircularTest1List);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::TestGrainInterfaces.CircularTest2 input = (global::TestGrainInterfaces.CircularTest2)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@CircularTest1List, stream, typeof (global::System.Collections.Generic.List<global::TestGrainInterfaces.CircularTest1>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::TestGrainInterfaces.CircularTest2 result = new global::TestGrainInterfaces.CircularTest2();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@CircularTest1List = (global::System.Collections.Generic.List<global::TestGrainInterfaces.CircularTest1>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::TestGrainInterfaces.CircularTest1>), stream);
            return (global::TestGrainInterfaces.CircularTest2)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::TestGrainInterfaces.CircularTest2), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenTestGrainInterfaces_CircularTest2Serializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::TestGrains.StreamCheckpoint<>))]
    internal class OrleansCodeGenTestGrains_StreamCheckpointSerializer<TState>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::TestGrains.StreamCheckpoint<TState> input = ((global::TestGrains.StreamCheckpoint<TState>)original);
            global::TestGrains.StreamCheckpoint<TState> result = new global::TestGrains.StreamCheckpoint<TState>();
            result.@Accumulator = (TState)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Accumulator);
            result.@LastProcessedToken = (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@LastProcessedToken);
            result.@StartToken = (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@StartToken);
            result.@StreamGuid = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@StreamGuid);
            result.@StreamNamespace = input.@StreamNamespace;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::TestGrains.StreamCheckpoint<TState> input = (global::TestGrains.StreamCheckpoint<TState>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Accumulator, stream, typeof (TState));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LastProcessedToken, stream, typeof (global::Orleans.Streams.StreamSequenceToken));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartToken, stream, typeof (global::Orleans.Streams.StreamSequenceToken));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamGuid, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::TestGrains.StreamCheckpoint<TState> result = new global::TestGrains.StreamCheckpoint<TState>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Accumulator = (TState)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TState), stream);
            result.@LastProcessedToken = (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), stream);
            result.@StartToken = (global::Orleans.Streams.StreamSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.StreamSequenceToken), stream);
            result.@StreamGuid = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            result.@StreamNamespace = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::TestGrains.StreamCheckpoint<TState>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenTestGrains_StreamCheckpointSerializer_TState_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::TestGrains.StreamCheckpoint<>), typeof (OrleansCodeGenTestGrains_StreamCheckpointSerializer<>));
        }

        static OrleansCodeGenTestGrains_StreamCheckpointSerializer_TState_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::TestGrains.SerializationGenerationGrain.MyState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenTestGrains_SerializationGenerationGrainSerializer_MyStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::TestGrains.SerializationGenerationGrain.MyState input = ((global::TestGrains.SerializationGenerationGrain.MyState)original);
            global::TestGrains.SerializationGenerationGrain.MyState result = new global::TestGrains.SerializationGenerationGrain.MyState();
            result.@Classes = (global::System.Collections.Generic.IList<global::UnitTests.GrainInterfaces.SomeAbstractClass>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Classes);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::TestGrains.SerializationGenerationGrain.MyState input = (global::TestGrains.SerializationGenerationGrain.MyState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Classes, stream, typeof (global::System.Collections.Generic.IList<global::UnitTests.GrainInterfaces.SomeAbstractClass>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::TestGrains.SerializationGenerationGrain.MyState result = new global::TestGrains.SerializationGenerationGrain.MyState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Classes = (global::System.Collections.Generic.IList<global::UnitTests.GrainInterfaces.SomeAbstractClass>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::UnitTests.GrainInterfaces.SomeAbstractClass>), stream);
            return (global::TestGrains.SerializationGenerationGrain.MyState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::TestGrains.SerializationGenerationGrain.MyState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenTestGrains_SerializationGenerationGrainSerializer_MyStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<>))]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_MyObserverSubscriptionManagerSerializer<T>
        where T : global::Orleans.IGrainObserver
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.ObserverSubscriptionManager<T>).@GetTypeInfo().@GetField("observers", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> getField1 = (global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> setField1 = (global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T> input = ((global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>)original);
            global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T> result = new global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>();
            result.@Foo = input.@Foo;
            setField1(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T> input = (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Foo, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Collections.Generic.HashSet<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T> result = new global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Foo = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField1(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<T>), stream));
            return (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_MyObserverSubscriptionManagerSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<>), typeof (OrleansCodeGenUnitTests_GrainInterfaces_MyObserverSubscriptionManagerSerializer<>));
        }

        static OrleansCodeGenUnitTests_GrainInterfaces_MyObserverSubscriptionManagerSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.GrainInterfaces.MyState<>))]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_MyStateSerializer<T>
        where T : global::Orleans.IGrainObserver
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.GrainInterfaces.MyState<T> input = ((global::UnitTests.GrainInterfaces.MyState<T>)original);
            global::UnitTests.GrainInterfaces.MyState<T> result = new global::UnitTests.GrainInterfaces.MyState<T>();
            result.@Subscription = (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Subscription);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.GrainInterfaces.MyState<T> input = (global::UnitTests.GrainInterfaces.MyState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Subscription, stream, typeof (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.GrainInterfaces.MyState<T> result = new global::UnitTests.GrainInterfaces.MyState<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Subscription = (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::UnitTests.GrainInterfaces.MyObserverSubscriptionManager<T>), stream);
            return (global::UnitTests.GrainInterfaces.MyState<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_MyStateSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.GrainInterfaces.MyState<>), typeof (OrleansCodeGenUnitTests_GrainInterfaces_MyStateSerializer<>));
        }

        static OrleansCodeGenUnitTests_GrainInterfaces_MyStateSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.ChainedGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_ChainedGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.ChainedGrainState input = ((global::UnitTests.Grains.ChainedGrainState)original);
            global::UnitTests.Grains.ChainedGrainState result = new global::UnitTests.Grains.ChainedGrainState();
            result.@Id = input.@Id;
            result.@Next = (global::UnitTests.GrainInterfaces.IChainedGrain)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Next);
            result.@X = input.@X;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.ChainedGrainState input = (global::UnitTests.Grains.ChainedGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Id, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Next, stream, typeof (global::UnitTests.GrainInterfaces.IChainedGrain));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@X, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.ChainedGrainState result = new global::UnitTests.Grains.ChainedGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Id = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Next = (global::UnitTests.GrainInterfaces.IChainedGrain)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::UnitTests.GrainInterfaces.IChainedGrain), stream);
            result.@X = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::UnitTests.Grains.ChainedGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.ChainedGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_ChainedGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.SimpleGenericGrainState<>))]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGenericGrainStateSerializer<T>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.SimpleGenericGrainState<T> input = ((global::UnitTests.Grains.SimpleGenericGrainState<T>)original);
            global::UnitTests.Grains.SimpleGenericGrainState<T> result = new global::UnitTests.Grains.SimpleGenericGrainState<T>();
            result.@A = (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@A);
            result.@B = (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.SimpleGenericGrainState<T> input = (global::UnitTests.Grains.SimpleGenericGrainState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (T));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.SimpleGenericGrainState<T> result = new global::UnitTests.Grains.SimpleGenericGrainState<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@A = (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream);
            result.@B = (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream);
            return (global::UnitTests.Grains.SimpleGenericGrainState<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGenericGrainStateSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.SimpleGenericGrainState<>), typeof (OrleansCodeGenUnitTests_Grains_SimpleGenericGrainStateSerializer<>));
        }

        static OrleansCodeGenUnitTests_Grains_SimpleGenericGrainStateSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.SimpleGenericGrainUState<>))]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGenericGrainUStateSerializer<U>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.SimpleGenericGrainUState<U> input = ((global::UnitTests.Grains.SimpleGenericGrainUState<U>)original);
            global::UnitTests.Grains.SimpleGenericGrainUState<U> result = new global::UnitTests.Grains.SimpleGenericGrainUState<U>();
            result.@A = (U)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@A);
            result.@B = (U)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.SimpleGenericGrainUState<U> input = (global::UnitTests.Grains.SimpleGenericGrainUState<U>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (U));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (U));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.SimpleGenericGrainUState<U> result = new global::UnitTests.Grains.SimpleGenericGrainUState<U>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@A = (U)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (U), stream);
            result.@B = (U)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (U), stream);
            return (global::UnitTests.Grains.SimpleGenericGrainUState<U>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGenericGrainUStateSerializer_U_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.SimpleGenericGrainUState<>), typeof (OrleansCodeGenUnitTests_Grains_SimpleGenericGrainUStateSerializer<>));
        }

        static OrleansCodeGenUnitTests_Grains_SimpleGenericGrainUStateSerializer_U_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.SimpleGenericGrain2State<, >))]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGenericGrain2StateSerializer<T, U>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.SimpleGenericGrain2State<T, U> input = ((global::UnitTests.Grains.SimpleGenericGrain2State<T, U>)original);
            global::UnitTests.Grains.SimpleGenericGrain2State<T, U> result = new global::UnitTests.Grains.SimpleGenericGrain2State<T, U>();
            result.@A = (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@A);
            result.@B = (U)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.SimpleGenericGrain2State<T, U> input = (global::UnitTests.Grains.SimpleGenericGrain2State<T, U>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (T));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (U));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.SimpleGenericGrain2State<T, U> result = new global::UnitTests.Grains.SimpleGenericGrain2State<T, U>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@A = (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream);
            result.@B = (U)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (U), stream);
            return (global::UnitTests.Grains.SimpleGenericGrain2State<T, U>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGenericGrain2StateSerializer_T_U_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.SimpleGenericGrain2State<, >), typeof (OrleansCodeGenUnitTests_Grains_SimpleGenericGrain2StateSerializer<, >));
        }

        static OrleansCodeGenUnitTests_Grains_SimpleGenericGrain2StateSerializer_T_U_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.IGrainWithListFieldsState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_IGrainWithListFieldsStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.IGrainWithListFieldsState input = ((global::UnitTests.Grains.IGrainWithListFieldsState)original);
            global::UnitTests.Grains.IGrainWithListFieldsState result = new global::UnitTests.Grains.IGrainWithListFieldsState();
            result.@Items = (global::System.Collections.Generic.IList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Items);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.IGrainWithListFieldsState input = (global::UnitTests.Grains.IGrainWithListFieldsState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Items, stream, typeof (global::System.Collections.Generic.IList<global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.IGrainWithListFieldsState result = new global::UnitTests.Grains.IGrainWithListFieldsState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Items = (global::System.Collections.Generic.IList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<global::System.String>), stream);
            return (global::UnitTests.Grains.IGrainWithListFieldsState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.IGrainWithListFieldsState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_IGrainWithListFieldsStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.GenericGrainWithListFieldsState<>))]
    internal class OrleansCodeGenUnitTests_Grains_GenericGrainWithListFieldsStateSerializer<T>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.GenericGrainWithListFieldsState<T> input = ((global::UnitTests.Grains.GenericGrainWithListFieldsState<T>)original);
            global::UnitTests.Grains.GenericGrainWithListFieldsState<T> result = new global::UnitTests.Grains.GenericGrainWithListFieldsState<T>();
            result.@Items = (global::System.Collections.Generic.IList<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Items);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.GenericGrainWithListFieldsState<T> input = (global::UnitTests.Grains.GenericGrainWithListFieldsState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Items, stream, typeof (global::System.Collections.Generic.IList<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.GenericGrainWithListFieldsState<T> result = new global::UnitTests.Grains.GenericGrainWithListFieldsState<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Items = (global::System.Collections.Generic.IList<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IList<T>), stream);
            return (global::UnitTests.Grains.GenericGrainWithListFieldsState<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_GenericGrainWithListFieldsStateSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.GenericGrainWithListFieldsState<>), typeof (OrleansCodeGenUnitTests_Grains_GenericGrainWithListFieldsStateSerializer<>));
        }

        static OrleansCodeGenUnitTests_Grains_GenericGrainWithListFieldsStateSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.GenericReaderWriterState<>))]
    internal class OrleansCodeGenUnitTests_Grains_GenericReaderWriterStateSerializer<T>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.GenericReaderWriterState<T> input = ((global::UnitTests.Grains.GenericReaderWriterState<T>)original);
            global::UnitTests.Grains.GenericReaderWriterState<T> result = new global::UnitTests.Grains.GenericReaderWriterState<T>();
            result.@Value = (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.GenericReaderWriterState<T> input = (global::UnitTests.Grains.GenericReaderWriterState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value, stream, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.GenericReaderWriterState<T> result = new global::UnitTests.Grains.GenericReaderWriterState<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Value = (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream);
            return (global::UnitTests.Grains.GenericReaderWriterState<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_GenericReaderWriterStateSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.GenericReaderWriterState<>), typeof (OrleansCodeGenUnitTests_Grains_GenericReaderWriterStateSerializer<>));
        }

        static OrleansCodeGenUnitTests_Grains_GenericReaderWriterStateSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.GenericReader2State<, >))]
    internal class OrleansCodeGenUnitTests_Grains_GenericReader2StateSerializer<TOne, TTwo>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.GenericReader2State<TOne, TTwo> input = ((global::UnitTests.Grains.GenericReader2State<TOne, TTwo>)original);
            global::UnitTests.Grains.GenericReader2State<TOne, TTwo> result = new global::UnitTests.Grains.GenericReader2State<TOne, TTwo>();
            result.@Value1 = (TOne)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value1);
            result.@Value2 = (TTwo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value2);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.GenericReader2State<TOne, TTwo> input = (global::UnitTests.Grains.GenericReader2State<TOne, TTwo>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value1, stream, typeof (TOne));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value2, stream, typeof (TTwo));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.GenericReader2State<TOne, TTwo> result = new global::UnitTests.Grains.GenericReader2State<TOne, TTwo>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Value1 = (TOne)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TOne), stream);
            result.@Value2 = (TTwo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TTwo), stream);
            return (global::UnitTests.Grains.GenericReader2State<TOne, TTwo>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_GenericReader2StateSerializer_TOne_TTwo_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.GenericReader2State<, >), typeof (OrleansCodeGenUnitTests_Grains_GenericReader2StateSerializer<, >));
        }

        static OrleansCodeGenUnitTests_Grains_GenericReader2StateSerializer_TOne_TTwo_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.GenericReaderWriterGrain2State<, >))]
    internal class OrleansCodeGenUnitTests_Grains_GenericReaderWriterGrain2StateSerializer<TOne, TTwo>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo> input = ((global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo>)original);
            global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo> result = new global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo>();
            result.@Value1 = (TOne)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value1);
            result.@Value2 = (TTwo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value2);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo> input = (global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value1, stream, typeof (TOne));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value2, stream, typeof (TTwo));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo> result = new global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Value1 = (TOne)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TOne), stream);
            result.@Value2 = (TTwo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TTwo), stream);
            return (global::UnitTests.Grains.GenericReaderWriterGrain2State<TOne, TTwo>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_GenericReaderWriterGrain2StateSerializer_TOne_TTwo_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.GenericReaderWriterGrain2State<, >), typeof (OrleansCodeGenUnitTests_Grains_GenericReaderWriterGrain2StateSerializer<, >));
        }

        static OrleansCodeGenUnitTests_Grains_GenericReaderWriterGrain2StateSerializer_TOne_TTwo_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.GenericReader3State<,, >))]
    internal class OrleansCodeGenUnitTests_Grains_GenericReader3StateSerializer<TOne, TTwo, TThree>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree> input = ((global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree>)original);
            global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree> result = new global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree>();
            result.@Value1 = (TOne)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value1);
            result.@Value2 = (TTwo)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value2);
            result.@Value3 = (TThree)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Value3);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree> input = (global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value1, stream, typeof (TOne));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value2, stream, typeof (TTwo));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value3, stream, typeof (TThree));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree> result = new global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Value1 = (TOne)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TOne), stream);
            result.@Value2 = (TTwo)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TTwo), stream);
            result.@Value3 = (TThree)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (TThree), stream);
            return (global::UnitTests.Grains.GenericReader3State<TOne, TTwo, TThree>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_GenericReader3StateSerializer_TOne_TTwo_TThree_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.GenericReader3State<,, >), typeof (OrleansCodeGenUnitTests_Grains_GenericReader3StateSerializer<,, >));
        }

        static OrleansCodeGenUnitTests_Grains_GenericReader3StateSerializer_TOne_TTwo_TThree_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.Initialized_State)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_Initialized_StateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.Initialized_State input = ((global::UnitTests.Grains.Initialized_State)original);
            global::UnitTests.Grains.Initialized_State result = new global::UnitTests.Grains.Initialized_State();
            result.@Names = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Names);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.Initialized_State input = (global::UnitTests.Grains.Initialized_State)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Names, stream, typeof (global::System.Collections.Generic.List<global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.Initialized_State result = new global::UnitTests.Grains.Initialized_State();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Names = (global::System.Collections.Generic.List<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.String>), stream);
            return (global::UnitTests.Grains.Initialized_State)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.Initialized_State), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_Initialized_StateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.SimpleGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_SimpleGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.SimpleGrainState input = ((global::UnitTests.Grains.SimpleGrainState)original);
            global::UnitTests.Grains.SimpleGrainState result = new global::UnitTests.Grains.SimpleGrainState();
            result.@A = input.@A;
            result.@EventDelay = input.@EventDelay;
            result.@Observers = (global::Orleans.ObserverSubscriptionManager<global::UnitTests.GrainInterfaces.ISimpleGrainObserver>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Observers);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.SimpleGrainState input = (global::UnitTests.Grains.SimpleGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventDelay, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Observers, stream, typeof (global::Orleans.ObserverSubscriptionManager<global::UnitTests.GrainInterfaces.ISimpleGrainObserver>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.SimpleGrainState result = new global::UnitTests.Grains.SimpleGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@A = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@EventDelay = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Observers = (global::Orleans.ObserverSubscriptionManager<global::UnitTests.GrainInterfaces.ISimpleGrainObserver>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.ObserverSubscriptionManager<global::UnitTests.GrainInterfaces.ISimpleGrainObserver>), stream);
            return (global::UnitTests.Grains.SimpleGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.SimpleGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_SimpleGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ObserverSubscriptionManager<>))]
    internal class OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer<T>
        where T : global::Orleans.IGrainObserver
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.ObserverSubscriptionManager<T>).@GetTypeInfo().@GetField("observers", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> getField0 = (global::System.Func<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>> setField0 = (global::System.Action<global::Orleans.ObserverSubscriptionManager<T>, global::System.Collections.Generic.HashSet<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.ObserverSubscriptionManager<T> input = ((global::Orleans.ObserverSubscriptionManager<T>)original);
            global::Orleans.ObserverSubscriptionManager<T> result = new global::Orleans.ObserverSubscriptionManager<T>();
            setField0(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.ObserverSubscriptionManager<T> input = (global::Orleans.ObserverSubscriptionManager<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.HashSet<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.ObserverSubscriptionManager<T> result = new global::Orleans.ObserverSubscriptionManager<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.HashSet<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<T>), stream));
            return (global::Orleans.ObserverSubscriptionManager<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.ObserverSubscriptionManager<>), typeof (OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer<>));
        }

        static OrleansCodeGenOrleans_ObserverSubscriptionManagerSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.SimplePersistentGrain_State)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_SimplePersistentGrain_StateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.SimplePersistentGrain_State input = ((global::UnitTests.Grains.SimplePersistentGrain_State)original);
            global::UnitTests.Grains.SimplePersistentGrain_State result = new global::UnitTests.Grains.SimplePersistentGrain_State();
            result.@A = input.@A;
            result.@B = input.@B;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.SimplePersistentGrain_State input = (global::UnitTests.Grains.SimplePersistentGrain_State)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.SimplePersistentGrain_State result = new global::UnitTests.Grains.SimplePersistentGrain_State();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@A = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@B = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::UnitTests.Grains.SimplePersistentGrain_State)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.SimplePersistentGrain_State), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_SimplePersistentGrain_StateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.ValueTypeTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_ValueTypeTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.ValueTypeTestGrainState input = ((global::UnitTests.Grains.ValueTypeTestGrainState)original);
            global::UnitTests.Grains.ValueTypeTestGrainState result = new global::UnitTests.Grains.ValueTypeTestGrainState();
            result.@StateData = input.@StateData;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.ValueTypeTestGrainState input = (global::UnitTests.Grains.ValueTypeTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StateData, stream, typeof (global::UnitTests.GrainInterfaces.ValueTypeTestData));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.ValueTypeTestGrainState result = new global::UnitTests.Grains.ValueTypeTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@StateData = (global::UnitTests.GrainInterfaces.ValueTypeTestData)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::UnitTests.GrainInterfaces.ValueTypeTestData), stream);
            return (global::UnitTests.Grains.ValueTypeTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.ValueTypeTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_ValueTypeTestGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.GrainInterfaces.ValueTypeTestData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_ValueTypeTestDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.GrainInterfaces.ValueTypeTestData).@GetTypeInfo().@GetField("intValue", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.GrainInterfaces.ValueTypeTestData, global::System.Int32> getField0 = (global::System.Func<global::UnitTests.GrainInterfaces.ValueTypeTestData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::UnitTests.GrainInterfaces.ValueTypeTestData, global::System.Int32> setField0 = (global::Orleans.Serialization.SerializationManager.ValueTypeSetter<global::UnitTests.GrainInterfaces.ValueTypeTestData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetValueSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.GrainInterfaces.ValueTypeTestData input = ((global::UnitTests.GrainInterfaces.ValueTypeTestData)original);
            global::UnitTests.GrainInterfaces.ValueTypeTestData result = default (global::UnitTests.GrainInterfaces.ValueTypeTestData);
            setField0(ref result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.GrainInterfaces.ValueTypeTestData input = (global::UnitTests.GrainInterfaces.ValueTypeTestData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.GrainInterfaces.ValueTypeTestData result = default (global::UnitTests.GrainInterfaces.ValueTypeTestData);
            setField0(ref result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.GrainInterfaces.ValueTypeTestData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.GrainInterfaces.ValueTypeTestData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_GrainInterfaces_ValueTypeTestDataSerializer()
        {
            Register();
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
