using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAPITandemMixer.Models;

namespace WebAPITandemMixer.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        // Verificar se isso consiste Action ou Models.Action Sandro
        public virtual DbSet<Models.Action> Actions { get; set; } = null!;
        public virtual DbSet<ActionClass> ActionClasses { get; set; } = null!;
        public virtual DbSet<ActionClassProperty> ActionClassProperties { get; set; } = null!;
        public virtual DbSet<ActionLog> ActionLogs { get; set; } = null!;
        public virtual DbSet<ActionParameter> ActionParameters { get; set; } = null!;
        public virtual DbSet<ActionParameterLog> ActionParameterLogs { get; set; } = null!;
        public virtual DbSet<ActionParameterType> ActionParameterTypes { get; set; } = null!;
        public virtual DbSet<ActionProperty> ActionProperties { get; set; } = null!;
        public virtual DbSet<ActionType> ActionTypes { get; set; } = null!;
        public virtual DbSet<Alarm> Alarms { get; set; } = null!;
        public virtual DbSet<AlarmType> AlarmTypes { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; } = null!;
        public virtual DbSet<CarbonSilo> CarbonSilos { get; set; } = null!;
        public virtual DbSet<Compound> Compounds { get; set; } = null!;
        public virtual DbSet<CompoundBatchesProduced> CompoundBatchesProduceds { get; set; } = null!;
        public virtual DbSet<CompoundStagePropertyType> CompoundStagePropertyTypes { get; set; } = null!;
        public virtual DbSet<CompoundVariableMapping> CompoundVariableMappings { get; set; } = null!;
        public virtual DbSet<CrewRotationCalendar> CrewRotationCalendars { get; set; } = null!;
        public virtual DbSet<DownloadResult> DownloadResults { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundHeader> DownloadedCompoundHeaders { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundHeaderReturned> DownloadedCompoundHeaderReturneds { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundHeaderReturnedError> DownloadedCompoundHeaderReturnedErrors { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundHeaderReturnedHistory> DownloadedCompoundHeaderReturnedHistories { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhase> DownloadedCompoundPhases { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesBottom> DownloadedCompoundPhasesBottoms { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesBottomReturned> DownloadedCompoundPhasesBottomReturneds { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesBottomReturnedError> DownloadedCompoundPhasesBottomReturnedErrors { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesBottomReturnedHistory> DownloadedCompoundPhasesBottomReturnedHistories { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTop> DownloadedCompoundPhasesTops { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopPreUdt20190916> DownloadedCompoundPhasesTopPreUdt20190916s { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopReturned> DownloadedCompoundPhasesTopReturneds { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopReturnedError> DownloadedCompoundPhasesTopReturnedErrors { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopReturnedErrorsPreUdt20190916> DownloadedCompoundPhasesTopReturnedErrorsPreUdt20190916s { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopReturnedHistory> DownloadedCompoundPhasesTopReturnedHistories { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopReturnedHistoryPreUdt20190916> DownloadedCompoundPhasesTopReturnedHistoryPreUdt20190916s { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundPhasesTopReturnedPreUdt20190916> DownloadedCompoundPhasesTopReturnedPreUdt20190916s { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundTemp> DownloadedCompoundTemps { get; set; } = null!;
        public virtual DbSet<DownloadedCompoundTrigger> DownloadedCompoundTriggers { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<EquipmentPhaseParameterType> EquipmentPhaseParameterTypes { get; set; } = null!;
        public virtual DbSet<EquipmentPhaseTransitionType> EquipmentPhaseTransitionTypes { get; set; } = null!;
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; } = null!;
        public virtual DbSet<EquipmentTypePhase> EquipmentTypePhases { get; set; } = null!;
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; } = null!;
        public virtual DbSet<EventArea> EventAreas { get; set; } = null!;
        public virtual DbSet<EventArea1> EventArea1s { get; set; } = null!;
        public virtual DbSet<EventAreaId> EventAreaIds { get; set; } = null!;
        public virtual DbSet<EventAreaId1> EventAreaId1s { get; set; } = null!;
        public virtual DbSet<EventBuffer> EventBuffers { get; set; } = null!;
        public virtual DbSet<EventLog> EventLogs { get; set; } = null!;
        public virtual DbSet<EventLogSeverity> EventLogSeverities { get; set; } = null!;
        public virtual DbSet<EventMixer> EventMixers { get; set; } = null!;
        public virtual DbSet<EventMixer1> EventMixer1s { get; set; } = null!;
        public virtual DbSet<GlobalSetting> GlobalSettings { get; set; } = null!;
        public virtual DbSet<Ingredient> Ingredients { get; set; } = null!;
        public virtual DbSet<IngredientLocation> IngredientLocations { get; set; } = null!;
        public virtual DbSet<IngredientLocationValid> IngredientLocationValids { get; set; } = null!;
        public virtual DbSet<IngredientParameter> IngredientParameters { get; set; } = null!;
        public virtual DbSet<IngredientTiming> IngredientTimings { get; set; } = null!;
        public virtual DbSet<IngredientType> IngredientTypes { get; set; } = null!;
        public virtual DbSet<IngredientTypeOld> IngredientTypeOlds { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<LocationOperation> LocationOperations { get; set; } = null!;
        public virtual DbSet<LotReport> LotReports { get; set; } = null!;
        public virtual DbSet<LotReportBatchDetail> LotReportBatchDetails { get; set; } = null!;
        public virtual DbSet<LotReportPhaseDetail> LotReportPhaseDetails { get; set; } = null!;
        public virtual DbSet<LotReportPhaseMaterialsDetail> LotReportPhaseMaterialsDetails { get; set; } = null!;
        public virtual DbSet<LotReportPowerChart> LotReportPowerCharts { get; set; } = null!;
        public virtual DbSet<MixSpeedType> MixSpeedTypes { get; set; } = null!;
        public virtual DbSet<MixTimingType> MixTimingTypes { get; set; } = null!;
        public virtual DbSet<MixerStatusBitMap> MixerStatusBitMaps { get; set; } = null!;
        public virtual DbSet<Number> Numbers { get; set; } = null!;
        public virtual DbSet<Operation> Operations { get; set; } = null!;
        public virtual DbSet<OperationResult> OperationResults { get; set; } = null!;
        public virtual DbSet<OperationScan> OperationScans { get; set; } = null!;
        public virtual DbSet<OperationScanResult> OperationScanResults { get; set; } = null!;
        public virtual DbSet<OperationScanValue> OperationScanValues { get; set; } = null!;
        public virtual DbSet<Option> Options { get; set; } = null!;
        public virtual DbSet<OptionAction> OptionActions { get; set; } = null!;
        public virtual DbSet<OptionClass> OptionClasses { get; set; } = null!;
        public virtual DbSet<Phase> Phases { get; set; } = null!;
        public virtual DbSet<PhaseCheck> PhaseChecks { get; set; } = null!;
        public virtual DbSet<PhaseCheckType> PhaseCheckTypes { get; set; } = null!;
        public virtual DbSet<PhaseHoldParameter> PhaseHoldParameters { get; set; } = null!;
        public virtual DbSet<PhaseIngredient> PhaseIngredients { get; set; } = null!;
        public virtual DbSet<PhaseMixSpeed> PhaseMixSpeeds { get; set; } = null!;
        public virtual DbSet<PhaseParameter> PhaseParameters { get; set; } = null!;
        public virtual DbSet<PhaseParameterType> PhaseParameterTypes { get; set; } = null!;
        public virtual DbSet<PhaseParameterUnit> PhaseParameterUnits { get; set; } = null!;
        public virtual DbSet<PhasePusher> PhasePushers { get; set; } = null!;
        public virtual DbSet<PhasePusherTimingType> PhasePusherTimingTypes { get; set; } = null!;
        public virtual DbSet<PhasePusherType> PhasePusherTypes { get; set; } = null!;
        public virtual DbSet<PhaseRamControl> PhaseRamControls { get; set; } = null!;
        public virtual DbSet<PhaseTransition> PhaseTransitions { get; set; } = null!;
        public virtual DbSet<PhaseType> PhaseTypes { get; set; } = null!;
        public virtual DbSet<PowerChartDatum> PowerChartData { get; set; } = null!;
        public virtual DbSet<Printing> Printings { get; set; } = null!;
        public virtual DbSet<PrintingDefault> PrintingDefaults { get; set; } = null!;
        public virtual DbSet<RamControlType> RamControlTypes { get; set; } = null!;
        public virtual DbSet<RamTimingType> RamTimingTypes { get; set; } = null!;
        public virtual DbSet<Scan> Scans { get; set; } = null!;
        public virtual DbSet<ScanAction> ScanActions { get; set; } = null!;
        public virtual DbSet<ScanClass> ScanClasses { get; set; } = null!;
        public virtual DbSet<ScanOption> ScanOptions { get; set; } = null!;
        public virtual DbSet<ScannedValue> ScannedValues { get; set; } = null!;
        public virtual DbSet<Scanner> Scanners { get; set; } = null!;
        public virtual DbSet<ScannerGroup> ScannerGroups { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<SecurityObject> SecurityObjects { get; set; } = null!;
        public virtual DbSet<SecurityObjectRole> SecurityObjectRoles { get; set; } = null!;
        public virtual DbSet<SecurityOperator> SecurityOperators { get; set; } = null!;
        public virtual DbSet<SecurityRole> SecurityRoles { get; set; } = null!;
        public virtual DbSet<ServerHeartbeat> ServerHeartbeats { get; set; } = null!;
        public virtual DbSet<Stage> Stages { get; set; } = null!;
        public virtual DbSet<SystemLog> SystemLogs { get; set; } = null!;
        public virtual DbSet<SystemLogEvent> SystemLogEvents { get; set; } = null!;
        public virtual DbSet<SystemLogLevel> SystemLogLevels { get; set; } = null!;
        public virtual DbSet<SystemLogName> SystemLogNames { get; set; } = null!;
        public virtual DbSet<SystemLogSource> SystemLogSources { get; set; } = null!;
        public virtual DbSet<SystemParameter> SystemParameters { get; set; } = null!;
        public virtual DbSet<SystemParameter1> SystemParameters1 { get; set; } = null!;
        public virtual DbSet<TandemRunLog> TandemRunLogs { get; set; } = null!;
        public virtual DbSet<TestTable> TestTables { get; set; } = null!;
        public virtual DbSet<TransitionType> TransitionTypes { get; set; } = null!;
        public virtual DbSet<Udtstructure> Udtstructures { get; set; } = null!;
        public virtual DbSet<Validate> Validates { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=ADMSQL01PCAM\ADM01;Initial Catalog=TandemMixer;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Models.Action>(entity =>
            {
                entity.ToTable("Action", "barcode");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_id");

                entity.Property(e => e.ActionClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_class_id");

                entity.Property(e => e.ActionDescription)
                    .IsUnicode(false)
                    .HasColumnName("action_description");

                entity.Property(e => e.ActionMessage)
                    .IsUnicode(false)
                    .HasColumnName("action_message");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("action_name");

                entity.Property(e => e.ActionTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_type_id");

                entity.HasOne(d => d.ActionClass)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.ActionClassId)
                    .HasConstraintName("FK_Action_ActionType");

                entity.HasOne(d => d.ActionType)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.ActionTypeId)
                    .HasConstraintName("FK_Action_ActionType1");
            });

            modelBuilder.Entity<ActionClass>(entity =>
            {
                entity.ToTable("ActionClass", "barcode");

                entity.Property(e => e.ActionClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_class_id");

                entity.Property(e => e.ActionClassDescription)
                    .IsUnicode(false)
                    .HasColumnName("action_class_description");

                entity.Property(e => e.ActionClassName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("action_class_name");
            });

            modelBuilder.Entity<ActionClassProperty>(entity =>
            {
                entity.HasKey(e => new { e.ActionClassId, e.ActionClassProperty1 })
                    .HasName("PK_ActionClassProperty");

                entity.ToTable("ActionClassProperties", "barcode");

                entity.Property(e => e.ActionClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_class_id");

                entity.Property(e => e.ActionClassProperty1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_class_property");

                entity.Property(e => e.ActionClassPropertyDescription)
                    .IsUnicode(false)
                    .HasColumnName("action_class_property_description");

                entity.HasOne(d => d.ActionClass)
                    .WithMany(p => p.ActionClassProperties)
                    .HasForeignKey(d => d.ActionClassId)
                    .HasConstraintName("FK_ActionClassProperty_ActionClass");
            });

            modelBuilder.Entity<ActionLog>(entity =>
            {
                entity.ToTable("ActionLog", "barcode");

                entity.Property(e => e.ActionLogId).HasColumnName("action_log_id");

                entity.Property(e => e.ActionError)
                    .IsUnicode(false)
                    .HasColumnName("action_error");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_id");

                entity.Property(e => e.ActionOrder).HasColumnName("action_order");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_status");

                entity.Property(e => e.ActionTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("action_timestamp");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.OperationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operation_id");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id");

                entity.Property(e => e.ScannedValue)
                    .IsUnicode(false)
                    .HasColumnName("scanned_value");

                entity.Property(e => e.ScannerId)
                    .HasMaxLength(128)
                    .HasColumnName("scanner_id");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoredProcedure)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionLogs)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_ActionLog_Action");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ActionLogs)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_ActionLog_Location");

                entity.HasOne(d => d.Scanner)
                    .WithMany(p => p.ActionLogs)
                    .HasForeignKey(d => d.ScannerId)
                    .HasConstraintName("FK_ActionLog_Scanner");
            });

            modelBuilder.Entity<ActionParameter>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.ParameterIndex })
                    .HasName("PK_ActionParameter");

                entity.ToTable("ActionParameters", "barcode");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_id");

                entity.Property(e => e.ParameterIndex).HasColumnName("parameter_index");

                entity.Property(e => e.ParameterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_id");

                entity.Property(e => e.ParameterValueKey)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value_key");

                entity.Property(e => e.ParameterValueType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value_type");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionParameters)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_ActionParameter_Action");

                entity.HasOne(d => d.ParameterValueTypeNavigation)
                    .WithMany(p => p.ActionParameters)
                    .HasForeignKey(d => d.ParameterValueType)
                    .HasConstraintName("FK_ActionParameter_ActionParameterType");
            });

            modelBuilder.Entity<ActionParameterLog>(entity =>
            {
                entity.HasKey(e => new { e.ActionLogId, e.ParameterIndex });

                entity.ToTable("ActionParameterLog", "barcode");

                entity.Property(e => e.ActionLogId).HasColumnName("action_log_id");

                entity.Property(e => e.ParameterIndex).HasColumnName("parameter_index");

                entity.Property(e => e.ParameterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_id");

                entity.Property(e => e.ParameterValue)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value");

                entity.Property(e => e.ParameterValueKey)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value_key");

                entity.Property(e => e.ParameterValueType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value_type");

                entity.HasOne(d => d.ActionLog)
                    .WithMany(p => p.ActionParameterLogs)
                    .HasForeignKey(d => d.ActionLogId)
                    .HasConstraintName("FK_ActionParameterLog_ActionLog");
            });

            modelBuilder.Entity<ActionParameterType>(entity =>
            {
                entity.HasKey(e => e.ParameterValueType);

                entity.ToTable("ActionParameterType", "barcode");

                entity.Property(e => e.ParameterValueType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value_type");

                entity.Property(e => e.ParameterValueTypeDescription)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value_type_description");
            });

            modelBuilder.Entity<ActionProperty>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.ActionProperty1 })
                    .HasName("PK_ActionProperty");

                entity.ToTable("ActionProperties", "barcode");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_id");

                entity.Property(e => e.ActionProperty1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_property");

                entity.Property(e => e.ActionPropertyValue)
                    .IsUnicode(false)
                    .HasColumnName("action_property_value");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionProperties)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_ActionProperty_Action");
            });

            modelBuilder.Entity<ActionType>(entity =>
            {
                entity.ToTable("ActionType", "barcode");

                entity.Property(e => e.ActionTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_type_id");

                entity.Property(e => e.ActionTypeDescription)
                    .IsUnicode(false)
                    .HasColumnName("action_type_description");

                entity.Property(e => e.ActionTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("action_type_name");
            });

            modelBuilder.Entity<Alarm>(entity =>
            {
                entity.Property(e => e.AlarmId).HasColumnName("Alarm_ID");

                entity.Property(e => e.AlarmBatchNumber).HasColumnName("Alarm_Batch_Number");

                entity.Property(e => e.AlarmDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Alarm_DateTime");

                entity.Property(e => e.AlarmDateTimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Alarm_DateTimeEnd");

                entity.Property(e => e.AlarmDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Alarm_Description");

                entity.Property(e => e.AlarmDuration)
                    .HasColumnName("Alarm_Duration")
                    .HasComputedColumnSql("(datediff(second,[Alarm_DateTime],isnull([Alarm_DateTimeEnd],getdate())))", false);

                entity.Property(e => e.AlarmEventArea).HasColumnName("Alarm_Event_Area");

                entity.Property(e => e.AlarmEventIdNumber).HasColumnName("Alarm_Event_ID_Number");

                entity.Property(e => e.AlarmLotNumber).HasColumnName("Alarm_Lot_Number");

                entity.Property(e => e.AlarmPhaseNumber).HasColumnName("Alarm_Phase_Number");

                entity.Property(e => e.AlarmState).HasColumnName("Alarm_State");

                entity.Property(e => e.AlarmTypeId).HasColumnName("Alarm_Type_ID");
            });

            modelBuilder.Entity<AlarmType>(entity =>
            {
                entity.Property(e => e.AlarmTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Alarm_Type_ID");

                entity.Property(e => e.AlarmTypeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Alarm_Type_Description");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(128);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);
            });

            modelBuilder.Entity<CarbonSilo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CarbonSilos", "WIL");

                entity.Property(e => e.Material)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Compound>(entity =>
            {
                entity.HasKey(e => e.CompoundName);

                entity.ToTable("Compound", "web");

                entity.Property(e => e.CompoundName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name");

                entity.Property(e => e.BatchSize)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("batch_size");

                entity.Property(e => e.BottomMixerBodyTcuz1)
                    .HasColumnName("BottomMixerBodyTCUZ1")
                    .HasDefaultValueSql("((140))");

                entity.Property(e => e.BottomMixerGateTcuz3)
                    .HasColumnName("BottomMixerGateTCUZ3")
                    .HasDefaultValueSql("((140))");

                entity.Property(e => e.BottomMixerRotorsTcuz2)
                    .HasColumnName("BottomMixerRotorsTCUZ2")
                    .HasDefaultValueSql("((140))");

                entity.Property(e => e.ChuteLevel)
                    .HasColumnName("Chute_Level")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompoundId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("compound_id");

                entity.Property(e => e.CompoundNotes)
                    .IsUnicode(false)
                    .HasColumnName("Compound_Notes");

                entity.Property(e => e.CompoundVersionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("compound_version_date");

                entity.Property(e => e.IsCompoundActive)
                    .IsRequired()
                    .HasColumnName("Is_Compound_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCompoundLocked).HasColumnName("Is_Compound_Locked");

                entity.Property(e => e.TopMixerBodyTcuz1)
                    .HasColumnName("TopMixerBodyTCUZ1")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.TopMixerGateTcuz3)
                    .HasColumnName("TopMixerGateTCUZ3")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.TopMixerRotorsTcuz2)
                    .HasColumnName("TopMixerRotorsTCUZ2")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.TsrbodyZ4)
                    .HasColumnName("TSRBodyZ4")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.TsrbottomRollZ2)
                    .HasColumnName("TSRBottomRollZ2")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.TsrscrewZ3)
                    .HasColumnName("TSRScrewZ3")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.TsrtopRollZ1)
                    .HasColumnName("TSRTopRollZ1")
                    .HasDefaultValueSql("((90))");
            });

            modelBuilder.Entity<CompoundBatchesProduced>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CompoundBatchesProduced", "WIL");

                entity.Property(e => e.Compound)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Processed).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompoundStagePropertyType>(entity =>
            {
                entity.HasKey(e => e.CompoundStagePropertyType1);

                entity.ToTable("CompoundStagePropertyType", "web");

                entity.Property(e => e.CompoundStagePropertyType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_stage_property_type");
            });

            modelBuilder.Entity<CompoundVariableMapping>(entity =>
            {
                entity.HasKey(e => e.CompoundVariableId);

                entity.ToTable("CompoundVariableMapping", "web");

                entity.Property(e => e.CompoundVariableId).HasColumnName("Compound_Variable_ID");

                entity.Property(e => e.CompoundVariableColumnName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Compound_Variable_Column_Name");

                entity.Property(e => e.CompoundVariableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Compound_Variable_Name");

                entity.Property(e => e.CompoundVariableOrder).HasColumnName("Compound_Variable_Order");

                entity.Property(e => e.GlobalSettingNameDefaultValue)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Name_Default_Value");

                entity.Property(e => e.GlobalSettingNameMaxLimit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Name_Max_Limit");

                entity.Property(e => e.GlobalSettingNameMinLimit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Name_Min_Limit");

                entity.Property(e => e.IsSetDefaultValue)
                    .IsRequired()
                    .HasColumnName("Is_Set_Default_Value")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsValidateLimitsEnabled)
                    .IsRequired()
                    .HasColumnName("Is_Validate_Limits_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVariableTypeDecimal).HasColumnName("Is_Variable_Type_Decimal");

                entity.Property(e => e.IsVariableTypeInt)
                    .IsRequired()
                    .HasColumnName("Is_Variable_Type_Int")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVariableTypeString).HasColumnName("Is_Variable_Type_String");
            });

            modelBuilder.Entity<CrewRotationCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CrewRotationCalendar");

                entity.HasIndex(e => e.Crew, "Idx_CrewRotationCalendar_Crew_caldate_shift");

                entity.HasIndex(e => new { e.Shift, e.Crew }, "Idx_CrewRotationCalendar_shift_crew_caldate");

                entity.Property(e => e.CaldDate).HasColumnType("datetime");

                entity.Property(e => e.Crew)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RotationGroup)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Shift)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShiftDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WeekDay)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DownloadResult>(entity =>
            {
                entity.HasKey(e => e.DownloadResultsId);

                entity.ToTable("DownloadResults", "plc");

                entity.Property(e => e.DownloadResultsId).HasColumnName("Download_Results_ID");

                entity.Property(e => e.CurrentDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Current_DateTime");

                entity.Property(e => e.ErrorCode).HasColumnName("Error_Code");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Error_Message");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");
            });

            modelBuilder.Entity<DownloadedCompoundHeader>(entity =>
            {
                entity.ToTable("DownloadedCompoundHeader", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchOffExtruderSpeed).HasColumnName("BatchOff.Extruder_Speed");

                entity.Property(e => e.BatchOffPullOffDrawPct).HasColumnName("BatchOff.PullOffDrawPCT");

                entity.Property(e => e.BatchOffSkidBarcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BatchOff.Skid_Barcode");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone1Sp).HasColumnName("FormulaNum.BottomMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone2Sp).HasColumnName("FormulaNum.BottomMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone3Sp).HasColumnName("FormulaNum.BottomMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumChuteLevel).HasColumnName("FormulaNum.ChuteLevel");

                entity.Property(e => e.FormulaNumCompoundName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.CompoundName");

                entity.Property(e => e.FormulaNumNumOfBatches).HasColumnName("FormulaNum.NumOfBatches");

                entity.Property(e => e.FormulaNumProcessCounts).HasColumnName("FormulaNum.ProcessCounts");

                entity.Property(e => e.FormulaNumSampleFrequency).HasColumnName("FormulaNum.SampleFrequency");

                entity.Property(e => e.FormulaNumTdetcuzone1Sp).HasColumnName("FormulaNum.TDETCUZone1SP");

                entity.Property(e => e.FormulaNumTdetcuzone2Sp).HasColumnName("FormulaNum.TDETCUZone2SP");

                entity.Property(e => e.FormulaNumTdetcuzone3Sp).HasColumnName("FormulaNum.TDETCUZone3SP");

                entity.Property(e => e.FormulaNumTdetcuzone4Sp).HasColumnName("FormulaNum.TDETCUZone4SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone1Sp).HasColumnName("FormulaNum.TopMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone2Sp).HasColumnName("FormulaNum.TopMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone3Sp).HasColumnName("FormulaNum.TopMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumVersionDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.VersionDate");

                entity.Property(e => e.ServerIdbegin).HasColumnName("ServerIDBegin");

                entity.Property(e => e.ServerIdend).HasColumnName("ServerIDEnd");
            });

            modelBuilder.Entity<DownloadedCompoundHeaderReturned>(entity =>
            {
                entity.ToTable("DownloadedCompoundHeaderReturned", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchOffExtruderSpeed).HasColumnName("BatchOff.Extruder_Speed");

                entity.Property(e => e.BatchOffPullOffDrawPct).HasColumnName("BatchOff.PullOffDrawPCT");

                entity.Property(e => e.BatchOffSkidBarcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BatchOff.Skid_Barcode");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone1Sp).HasColumnName("FormulaNum.BottomMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone2Sp).HasColumnName("FormulaNum.BottomMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone3Sp).HasColumnName("FormulaNum.BottomMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumChuteLevel).HasColumnName("FormulaNum.ChuteLevel");

                entity.Property(e => e.FormulaNumCompoundName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.CompoundName");

                entity.Property(e => e.FormulaNumNumOfBatches).HasColumnName("FormulaNum.NumOfBatches");

                entity.Property(e => e.FormulaNumProcessCounts).HasColumnName("FormulaNum.ProcessCounts");

                entity.Property(e => e.FormulaNumSampleFrequency).HasColumnName("FormulaNum.SampleFrequency");

                entity.Property(e => e.FormulaNumTdetcuzone1Sp).HasColumnName("FormulaNum.TDETCUZone1SP");

                entity.Property(e => e.FormulaNumTdetcuzone2Sp).HasColumnName("FormulaNum.TDETCUZone2SP");

                entity.Property(e => e.FormulaNumTdetcuzone3Sp).HasColumnName("FormulaNum.TDETCUZone3SP");

                entity.Property(e => e.FormulaNumTdetcuzone4Sp).HasColumnName("FormulaNum.TDETCUZone4SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone1Sp).HasColumnName("FormulaNum.TopMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone2Sp).HasColumnName("FormulaNum.TopMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone3Sp).HasColumnName("FormulaNum.TopMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumVersionDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.VersionDate");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIdbegin).HasColumnName("ServerIDBegin");

                entity.Property(e => e.ServerIdend).HasColumnName("ServerIDEnd");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundHeaderReturnedError>(entity =>
            {
                entity.ToTable("DownloadedCompoundHeaderReturnedErrors", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchOffExtruderSpeed).HasColumnName("BatchOff.Extruder_Speed");

                entity.Property(e => e.BatchOffPullOffDrawPct).HasColumnName("BatchOff.PullOffDrawPCT");

                entity.Property(e => e.BatchOffSkidBarcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BatchOff.Skid_Barcode");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone1Sp).HasColumnName("FormulaNum.BottomMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone2Sp).HasColumnName("FormulaNum.BottomMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone3Sp).HasColumnName("FormulaNum.BottomMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumChuteLevel).HasColumnName("FormulaNum.ChuteLevel");

                entity.Property(e => e.FormulaNumCompoundName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.CompoundName");

                entity.Property(e => e.FormulaNumNumOfBatches).HasColumnName("FormulaNum.NumOfBatches");

                entity.Property(e => e.FormulaNumProcessCounts).HasColumnName("FormulaNum.ProcessCounts");

                entity.Property(e => e.FormulaNumSampleFrequency).HasColumnName("FormulaNum.SampleFrequency");

                entity.Property(e => e.FormulaNumTdetcuzone1Sp).HasColumnName("FormulaNum.TDETCUZone1SP");

                entity.Property(e => e.FormulaNumTdetcuzone2Sp).HasColumnName("FormulaNum.TDETCUZone2SP");

                entity.Property(e => e.FormulaNumTdetcuzone3Sp).HasColumnName("FormulaNum.TDETCUZone3SP");

                entity.Property(e => e.FormulaNumTdetcuzone4Sp).HasColumnName("FormulaNum.TDETCUZone4SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone1Sp).HasColumnName("FormulaNum.TopMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone2Sp).HasColumnName("FormulaNum.TopMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone3Sp).HasColumnName("FormulaNum.TopMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumVersionDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.VersionDate");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIdbegin).HasColumnName("ServerIDBegin");

                entity.Property(e => e.ServerIdend).HasColumnName("ServerIDEnd");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundHeaderReturnedHistory>(entity =>
            {
                entity.ToTable("DownloadedCompoundHeaderReturnedHistory", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchOffExtruderSpeed).HasColumnName("BatchOff.Extruder_Speed");

                entity.Property(e => e.BatchOffPullOffDrawPct).HasColumnName("BatchOff.PullOffDrawPCT");

                entity.Property(e => e.BatchOffSkidBarcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BatchOff.Skid_Barcode");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone1Sp).HasColumnName("FormulaNum.BottomMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone2Sp).HasColumnName("FormulaNum.BottomMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumBottomMixerTcuzone3Sp).HasColumnName("FormulaNum.BottomMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumChuteLevel).HasColumnName("FormulaNum.ChuteLevel");

                entity.Property(e => e.FormulaNumCompoundName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.CompoundName");

                entity.Property(e => e.FormulaNumNumOfBatches).HasColumnName("FormulaNum.NumOfBatches");

                entity.Property(e => e.FormulaNumProcessCounts).HasColumnName("FormulaNum.ProcessCounts");

                entity.Property(e => e.FormulaNumSampleFrequency).HasColumnName("FormulaNum.SampleFrequency");

                entity.Property(e => e.FormulaNumTdetcuzone1Sp).HasColumnName("FormulaNum.TDETCUZone1SP");

                entity.Property(e => e.FormulaNumTdetcuzone2Sp).HasColumnName("FormulaNum.TDETCUZone2SP");

                entity.Property(e => e.FormulaNumTdetcuzone3Sp).HasColumnName("FormulaNum.TDETCUZone3SP");

                entity.Property(e => e.FormulaNumTdetcuzone4Sp).HasColumnName("FormulaNum.TDETCUZone4SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone1Sp).HasColumnName("FormulaNum.TopMixerTCUZone1SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone2Sp).HasColumnName("FormulaNum.TopMixerTCUZone2SP");

                entity.Property(e => e.FormulaNumTopMixerTcuzone3Sp).HasColumnName("FormulaNum.TopMixerTCUZone3SP");

                entity.Property(e => e.FormulaNumVersionDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormulaNum.VersionDate");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIdbegin).HasColumnName("ServerIDBegin");

                entity.Property(e => e.ServerIdend).HasColumnName("ServerIDEnd");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhaseBotMixerChuteMaterialBinSource).HasColumnName("Phase.BotMixer.Chute.MaterialBinSource");

                entity.Property(e => e.PhaseBotMixerChuteMaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.BotMixer.Chute.MaterialType");

                entity.Property(e => e.PhaseBotMixerChuteSkipStep).HasColumnName("Phase.BotMixer.Chute.SkipStep");

                entity.Property(e => e.PhaseBotMixerChuteTargetWeight).HasColumnName("Phase.BotMixer.Chute.TargetWeight");

                entity.Property(e => e.PhaseBotMixerChuteTimingType).HasColumnName("Phase.BotMixer.Chute.TimingType");

                entity.Property(e => e.PhaseBotMixerChuteTimingValue).HasColumnName("Phase.BotMixer.Chute.TimingValue");

                entity.Property(e => e.PhaseBotMixerChuteWeightMinusTol).HasColumnName("Phase.BotMixer.Chute.WeightMinusTol");

                entity.Property(e => e.PhaseBotMixerChuteWeightPlusTol).HasColumnName("Phase.BotMixer.Chute.WeightPlusTol");

                entity.Property(e => e.PhaseBotMixerGateDwell).HasColumnName("Phase.BotMixer.GateDwell");

                entity.Property(e => e.PhaseBotMixerMaxPhaseKwh).HasColumnName("Phase.BotMixer.MaxPhaseKWH");

                entity.Property(e => e.PhaseBotMixerMaxPhaseTemp).HasColumnName("Phase.BotMixer.MaxPhaseTemp");

                entity.Property(e => e.PhaseBotMixerMaxPhaseTime).HasColumnName("Phase.BotMixer.MaxPhaseTime");

                entity.Property(e => e.PhaseBotMixerMinPhaseTime).HasColumnName("Phase.BotMixer.MinPhaseTime");

                entity.Property(e => e.PhaseBotMixerMixerSpeed0MixerSpeed).HasColumnName("Phase.BotMixer.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.PhaseBotMixerMixerSpeed0TimingType).HasColumnName("Phase.BotMixer.MixerSpeed.0.TimingType");

                entity.Property(e => e.PhaseBotMixerMixerSpeed0TimingValue).HasColumnName("Phase.BotMixer.MixerSpeed.0.TimingValue");

                entity.Property(e => e.PhaseBotMixerMixerSpeed1MixerSpeed).HasColumnName("Phase.BotMixer.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.PhaseBotMixerMixerSpeed1TimingType).HasColumnName("Phase.BotMixer.MixerSpeed.1.TimingType");

                entity.Property(e => e.PhaseBotMixerMixerSpeed1TimingValue).HasColumnName("Phase.BotMixer.MixerSpeed.1.TimingValue");

                entity.Property(e => e.PhaseBotMixerMixerSpeed2MixerSpeed).HasColumnName("Phase.BotMixer.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.PhaseBotMixerMixerSpeed2TimingType).HasColumnName("Phase.BotMixer.MixerSpeed.2.TimingType");

                entity.Property(e => e.PhaseBotMixerMixerSpeed2TimingValue).HasColumnName("Phase.BotMixer.MixerSpeed.2.TimingValue");

                entity.Property(e => e.PhaseBotMixerMixerSpeed3MixerSpeed).HasColumnName("Phase.BotMixer.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.PhaseBotMixerMixerSpeed3TimingType).HasColumnName("Phase.BotMixer.MixerSpeed.3.TimingType");

                entity.Property(e => e.PhaseBotMixerMixerSpeed3TimingValue).HasColumnName("Phase.BotMixer.MixerSpeed.3.TimingValue");

                entity.Property(e => e.PhaseBotMixerMixerSpeed4MixerSpeed).HasColumnName("Phase.BotMixer.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.PhaseBotMixerMixerSpeed4TimingType).HasColumnName("Phase.BotMixer.MixerSpeed.4.TimingType");

                entity.Property(e => e.PhaseBotMixerMixerSpeed4TimingValue).HasColumnName("Phase.BotMixer.MixerSpeed.4.TimingValue");

                entity.Property(e => e.PhaseBotMixerPhaseCheck0CheckTime).HasColumnName("Phase.BotMixer.PhaseCheck.0.CheckTime");

                entity.Property(e => e.PhaseBotMixerPhaseCheck0Max).HasColumnName("Phase.BotMixer.PhaseCheck.0.Max");

                entity.Property(e => e.PhaseBotMixerPhaseCheck0Min).HasColumnName("Phase.BotMixer.PhaseCheck.0.Min");

                entity.Property(e => e.PhaseBotMixerPhaseCheck0Variable).HasColumnName("Phase.BotMixer.PhaseCheck.0.Variable");

                entity.Property(e => e.PhaseBotMixerPhaseCheck1CheckTime).HasColumnName("Phase.BotMixer.PhaseCheck.1.CheckTime");

                entity.Property(e => e.PhaseBotMixerPhaseCheck1Max).HasColumnName("Phase.BotMixer.PhaseCheck.1.Max");

                entity.Property(e => e.PhaseBotMixerPhaseCheck1Min).HasColumnName("Phase.BotMixer.PhaseCheck.1.Min");

                entity.Property(e => e.PhaseBotMixerPhaseCheck1Variable).HasColumnName("Phase.BotMixer.PhaseCheck.1.Variable");

                entity.Property(e => e.PhaseBotMixerPhaseCheck2CheckTime).HasColumnName("Phase.BotMixer.PhaseCheck.2.CheckTime");

                entity.Property(e => e.PhaseBotMixerPhaseCheck2Max).HasColumnName("Phase.BotMixer.PhaseCheck.2.Max");

                entity.Property(e => e.PhaseBotMixerPhaseCheck2Min).HasColumnName("Phase.BotMixer.PhaseCheck.2.Min");

                entity.Property(e => e.PhaseBotMixerPhaseCheck2Variable).HasColumnName("Phase.BotMixer.PhaseCheck.2.Variable");

                entity.Property(e => e.PhaseBotMixerPhaseDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.BotMixer.PhaseDescription");

                entity.Property(e => e.PhaseBotMixerPhaseTransition0Value).HasColumnName("Phase.BotMixer.PhaseTransition.0.Value");

                entity.Property(e => e.PhaseBotMixerPhaseTransition0Variable).HasColumnName("Phase.BotMixer.PhaseTransition.0.Variable");

                entity.Property(e => e.PhaseBotMixerPhaseTransition1Value).HasColumnName("Phase.BotMixer.PhaseTransition.1.Value");

                entity.Property(e => e.PhaseBotMixerPhaseTransition1Variable).HasColumnName("Phase.BotMixer.PhaseTransition.1.Variable");

                entity.Property(e => e.PhaseBotMixerPhaseTransition2Value).HasColumnName("Phase.BotMixer.PhaseTransition.2.Value");

                entity.Property(e => e.PhaseBotMixerPhaseTransition2Variable).HasColumnName("Phase.BotMixer.PhaseTransition.2.Variable");

                entity.Property(e => e.PhaseBotMixerPhaseType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.BotMixer.PhaseType");

                entity.Property(e => e.PhaseBotMixerPusherControl0TimingType).HasColumnName("Phase.BotMixer.PusherControl.0.TimingType");

                entity.Property(e => e.PhaseBotMixerPusherControl0TimingValue).HasColumnName("Phase.BotMixer.PusherControl.0.TimingValue");

                entity.Property(e => e.PhaseBotMixerPusherControl1TimingType).HasColumnName("Phase.BotMixer.PusherControl.1.TimingType");

                entity.Property(e => e.PhaseBotMixerPusherControl1TimingValue).HasColumnName("Phase.BotMixer.PusherControl.1.TimingValue");

                entity.Property(e => e.PhaseBotMixerPusherControl2TimingType).HasColumnName("Phase.BotMixer.PusherControl.2.TimingType");

                entity.Property(e => e.PhaseBotMixerPusherControl2TimingValue).HasColumnName("Phase.BotMixer.PusherControl.2.TimingValue");

                entity.Property(e => e.PhaseBotMixerPusherControl3TimingType).HasColumnName("Phase.BotMixer.PusherControl.3.TimingType");

                entity.Property(e => e.PhaseBotMixerPusherControl3TimingValue).HasColumnName("Phase.BotMixer.PusherControl.3.TimingValue");

                entity.Property(e => e.PhaseBotMixerPusherControl4TimingType).HasColumnName("Phase.BotMixer.PusherControl.4.TimingType");

                entity.Property(e => e.PhaseBotMixerPusherControl4TimingValue).HasColumnName("Phase.BotMixer.PusherControl.4.TimingValue");

                entity.Property(e => e.PhaseChargeBeltPitchPack1MaterialBinSource).HasColumnName("Phase.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.PhaseChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.PhaseChargeBeltPitchPack1SkipStep).HasColumnName("Phase.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.PhaseChargeBeltPitchPack1TargetWeight).HasColumnName("Phase.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.PhaseChargeBeltPitchPack1WeightMinusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack1WeightPlusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack2MaterialBinSource).HasColumnName("Phase.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.PhaseChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.PhaseChargeBeltPitchPack2SkipStep).HasColumnName("Phase.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.PhaseChargeBeltPitchPack2TargetWeight).HasColumnName("Phase.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.PhaseChargeBeltPitchPack2WeightMinusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack2WeightPlusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack3MaterialBinSource).HasColumnName("Phase.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.PhaseChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.PhaseChargeBeltPitchPack3SkipStep).HasColumnName("Phase.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.PhaseChargeBeltPitchPack3TargetWeight).HasColumnName("Phase.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.PhaseChargeBeltPitchPack3WeightMinusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack3WeightPlusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack4MaterialBinSource).HasColumnName("Phase.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.PhaseChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.PhaseChargeBeltPitchPack4SkipStep).HasColumnName("Phase.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.PhaseChargeBeltPitchPack4TargetWeight).HasColumnName("Phase.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.PhaseChargeBeltPitchPack4WeightMinusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack4WeightPlusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack5MaterialBinSource).HasColumnName("Phase.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.PhaseChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.PhaseChargeBeltPitchPack5SkipStep).HasColumnName("Phase.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.PhaseChargeBeltPitchPack5TargetWeight).HasColumnName("Phase.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.PhaseChargeBeltPitchPack5WeightMinusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.PhaseChargeBeltPitchPack5WeightPlusTol).HasColumnName("Phase.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCanDump0MaterialBinSource).HasColumnName("Phase.TopMixer.CanDump.0.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCanDump0MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CanDump.0.MaterialType");

                entity.Property(e => e.PhaseTopMixerCanDump0SkipStep).HasColumnName("Phase.TopMixer.CanDump.0.SkipStep");

                entity.Property(e => e.PhaseTopMixerCanDump0TargetWeight).HasColumnName("Phase.TopMixer.CanDump.0.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCanDump0TimingType).HasColumnName("Phase.TopMixer.CanDump.0.TimingType");

                entity.Property(e => e.PhaseTopMixerCanDump0TimingValue).HasColumnName("Phase.TopMixer.CanDump.0.TimingValue");

                entity.Property(e => e.PhaseTopMixerCanDump0WeightMinusTol).HasColumnName("Phase.TopMixer.CanDump.0.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCanDump0WeightPlusTol).HasColumnName("Phase.TopMixer.CanDump.0.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCanDump1MaterialBinSource).HasColumnName("Phase.TopMixer.CanDump.1.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCanDump1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CanDump.1.MaterialType");

                entity.Property(e => e.PhaseTopMixerCanDump1SkipStep).HasColumnName("Phase.TopMixer.CanDump.1.SkipStep");

                entity.Property(e => e.PhaseTopMixerCanDump1TargetWeight).HasColumnName("Phase.TopMixer.CanDump.1.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCanDump1TimingType).HasColumnName("Phase.TopMixer.CanDump.1.TimingType");

                entity.Property(e => e.PhaseTopMixerCanDump1TimingValue).HasColumnName("Phase.TopMixer.CanDump.1.TimingValue");

                entity.Property(e => e.PhaseTopMixerCanDump1WeightMinusTol).HasColumnName("Phase.TopMixer.CanDump.1.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCanDump1WeightPlusTol).HasColumnName("Phase.TopMixer.CanDump.1.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0MaterialBinSource).HasColumnName("Phase.TopMixer.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CarbonBlack.0.MaterialType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0SkipStep).HasColumnName("Phase.TopMixer.CarbonBlack.0.SkipStep");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0TargetWeight).HasColumnName("Phase.TopMixer.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0TimingType).HasColumnName("Phase.TopMixer.CarbonBlack.0.TimingType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0TimingValue).HasColumnName("Phase.TopMixer.CarbonBlack.0.TimingValue");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0WeightMinusTol).HasColumnName("Phase.TopMixer.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack0WeightPlusTol).HasColumnName("Phase.TopMixer.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1MaterialBinSource).HasColumnName("Phase.TopMixer.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CarbonBlack.1.MaterialType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1SkipStep).HasColumnName("Phase.TopMixer.CarbonBlack.1.SkipStep");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1TargetWeight).HasColumnName("Phase.TopMixer.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1TimingType).HasColumnName("Phase.TopMixer.CarbonBlack.1.TimingType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1TimingValue).HasColumnName("Phase.TopMixer.CarbonBlack.1.TimingValue");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1WeightMinusTol).HasColumnName("Phase.TopMixer.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack1WeightPlusTol).HasColumnName("Phase.TopMixer.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2MaterialBinSource).HasColumnName("Phase.TopMixer.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CarbonBlack.2.MaterialType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2SkipStep).HasColumnName("Phase.TopMixer.CarbonBlack.2.SkipStep");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2TargetWeight).HasColumnName("Phase.TopMixer.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2TimingType).HasColumnName("Phase.TopMixer.CarbonBlack.2.TimingType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2TimingValue).HasColumnName("Phase.TopMixer.CarbonBlack.2.TimingValue");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2WeightMinusTol).HasColumnName("Phase.TopMixer.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack2WeightPlusTol).HasColumnName("Phase.TopMixer.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3MaterialBinSource).HasColumnName("Phase.TopMixer.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CarbonBlack.3.MaterialType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3SkipStep).HasColumnName("Phase.TopMixer.CarbonBlack.3.SkipStep");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3TargetWeight).HasColumnName("Phase.TopMixer.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3TimingType).HasColumnName("Phase.TopMixer.CarbonBlack.3.TimingType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3TimingValue).HasColumnName("Phase.TopMixer.CarbonBlack.3.TimingValue");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3WeightMinusTol).HasColumnName("Phase.TopMixer.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack3WeightPlusTol).HasColumnName("Phase.TopMixer.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4MaterialBinSource).HasColumnName("Phase.TopMixer.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.CarbonBlack.4.MaterialType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4SkipStep).HasColumnName("Phase.TopMixer.CarbonBlack.4.SkipStep");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4TargetWeight).HasColumnName("Phase.TopMixer.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4TimingType).HasColumnName("Phase.TopMixer.CarbonBlack.4.TimingType");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4TimingValue).HasColumnName("Phase.TopMixer.CarbonBlack.4.TimingValue");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4WeightMinusTol).HasColumnName("Phase.TopMixer.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerCarbonBlack4WeightPlusTol).HasColumnName("Phase.TopMixer.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerGateDwell).HasColumnName("Phase.TopMixer.GateDwell");

                entity.Property(e => e.PhaseTopMixerMaxPhaseKwh).HasColumnName("Phase.TopMixer.MaxPhaseKWH");

                entity.Property(e => e.PhaseTopMixerMaxPhaseTemp).HasColumnName("Phase.TopMixer.MaxPhaseTemp");

                entity.Property(e => e.PhaseTopMixerMaxPhaseTime).HasColumnName("Phase.TopMixer.MaxPhaseTime");

                entity.Property(e => e.PhaseTopMixerMinPhaseTime).HasColumnName("Phase.TopMixer.MinPhaseTime");

                entity.Property(e => e.PhaseTopMixerMixerSpeed0MixerSpeed).HasColumnName("Phase.TopMixer.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.PhaseTopMixerMixerSpeed0TimingType).HasColumnName("Phase.TopMixer.MixerSpeed.0.TimingType");

                entity.Property(e => e.PhaseTopMixerMixerSpeed0TimingValue).HasColumnName("Phase.TopMixer.MixerSpeed.0.TimingValue");

                entity.Property(e => e.PhaseTopMixerMixerSpeed1MixerSpeed).HasColumnName("Phase.TopMixer.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.PhaseTopMixerMixerSpeed1TimingType).HasColumnName("Phase.TopMixer.MixerSpeed.1.TimingType");

                entity.Property(e => e.PhaseTopMixerMixerSpeed1TimingValue).HasColumnName("Phase.TopMixer.MixerSpeed.1.TimingValue");

                entity.Property(e => e.PhaseTopMixerMixerSpeed2MixerSpeed).HasColumnName("Phase.TopMixer.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.PhaseTopMixerMixerSpeed2TimingType).HasColumnName("Phase.TopMixer.MixerSpeed.2.TimingType");

                entity.Property(e => e.PhaseTopMixerMixerSpeed2TimingValue).HasColumnName("Phase.TopMixer.MixerSpeed.2.TimingValue");

                entity.Property(e => e.PhaseTopMixerMixerSpeed3MixerSpeed).HasColumnName("Phase.TopMixer.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.PhaseTopMixerMixerSpeed3TimingType).HasColumnName("Phase.TopMixer.MixerSpeed.3.TimingType");

                entity.Property(e => e.PhaseTopMixerMixerSpeed3TimingValue).HasColumnName("Phase.TopMixer.MixerSpeed.3.TimingValue");

                entity.Property(e => e.PhaseTopMixerMixerSpeed4MixerSpeed).HasColumnName("Phase.TopMixer.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.PhaseTopMixerMixerSpeed4TimingType).HasColumnName("Phase.TopMixer.MixerSpeed.4.TimingType");

                entity.Property(e => e.PhaseTopMixerMixerSpeed4TimingValue).HasColumnName("Phase.TopMixer.MixerSpeed.4.TimingValue");

                entity.Property(e => e.PhaseTopMixerOil0MaterialBinSource).HasColumnName("Phase.TopMixer.Oil.0.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerOil0MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Oil.0.MaterialType");

                entity.Property(e => e.PhaseTopMixerOil0SkipStep).HasColumnName("Phase.TopMixer.Oil.0.SkipStep");

                entity.Property(e => e.PhaseTopMixerOil0TargetWeight).HasColumnName("Phase.TopMixer.Oil.0.TargetWeight");

                entity.Property(e => e.PhaseTopMixerOil0TimingType).HasColumnName("Phase.TopMixer.Oil.0.TimingType");

                entity.Property(e => e.PhaseTopMixerOil0TimingValue).HasColumnName("Phase.TopMixer.Oil.0.TimingValue");

                entity.Property(e => e.PhaseTopMixerOil0WeightMinusTol).HasColumnName("Phase.TopMixer.Oil.0.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerOil0WeightPlusTol).HasColumnName("Phase.TopMixer.Oil.0.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerOil1MaterialBinSource).HasColumnName("Phase.TopMixer.Oil.1.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerOil1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Oil.1.MaterialType");

                entity.Property(e => e.PhaseTopMixerOil1SkipStep).HasColumnName("Phase.TopMixer.Oil.1.SkipStep");

                entity.Property(e => e.PhaseTopMixerOil1TargetWeight).HasColumnName("Phase.TopMixer.Oil.1.TargetWeight");

                entity.Property(e => e.PhaseTopMixerOil1TimingType).HasColumnName("Phase.TopMixer.Oil.1.TimingType");

                entity.Property(e => e.PhaseTopMixerOil1TimingValue).HasColumnName("Phase.TopMixer.Oil.1.TimingValue");

                entity.Property(e => e.PhaseTopMixerOil1WeightMinusTol).HasColumnName("Phase.TopMixer.Oil.1.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerOil1WeightPlusTol).HasColumnName("Phase.TopMixer.Oil.1.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerOil2MaterialBinSource).HasColumnName("Phase.TopMixer.Oil.2.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerOil2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Oil.2.MaterialType");

                entity.Property(e => e.PhaseTopMixerOil2SkipStep).HasColumnName("Phase.TopMixer.Oil.2.SkipStep");

                entity.Property(e => e.PhaseTopMixerOil2TargetWeight).HasColumnName("Phase.TopMixer.Oil.2.TargetWeight");

                entity.Property(e => e.PhaseTopMixerOil2TimingType).HasColumnName("Phase.TopMixer.Oil.2.TimingType");

                entity.Property(e => e.PhaseTopMixerOil2TimingValue).HasColumnName("Phase.TopMixer.Oil.2.TimingValue");

                entity.Property(e => e.PhaseTopMixerOil2WeightMinusTol).HasColumnName("Phase.TopMixer.Oil.2.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerOil2WeightPlusTol).HasColumnName("Phase.TopMixer.Oil.2.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerOil3MaterialBinSource).HasColumnName("Phase.TopMixer.Oil.3.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerOil3MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Oil.3.MaterialType");

                entity.Property(e => e.PhaseTopMixerOil3SkipStep).HasColumnName("Phase.TopMixer.Oil.3.SkipStep");

                entity.Property(e => e.PhaseTopMixerOil3TargetWeight).HasColumnName("Phase.TopMixer.Oil.3.TargetWeight");

                entity.Property(e => e.PhaseTopMixerOil3TimingType).HasColumnName("Phase.TopMixer.Oil.3.TimingType");

                entity.Property(e => e.PhaseTopMixerOil3TimingValue).HasColumnName("Phase.TopMixer.Oil.3.TimingValue");

                entity.Property(e => e.PhaseTopMixerOil3WeightMinusTol).HasColumnName("Phase.TopMixer.Oil.3.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerOil3WeightPlusTol).HasColumnName("Phase.TopMixer.Oil.3.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerOil4MaterialBinSource).HasColumnName("Phase.TopMixer.Oil.4.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerOil4MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Oil.4.MaterialType");

                entity.Property(e => e.PhaseTopMixerOil4SkipStep).HasColumnName("Phase.TopMixer.Oil.4.SkipStep");

                entity.Property(e => e.PhaseTopMixerOil4TargetWeight).HasColumnName("Phase.TopMixer.Oil.4.TargetWeight");

                entity.Property(e => e.PhaseTopMixerOil4TimingType).HasColumnName("Phase.TopMixer.Oil.4.TimingType");

                entity.Property(e => e.PhaseTopMixerOil4TimingValue).HasColumnName("Phase.TopMixer.Oil.4.TimingValue");

                entity.Property(e => e.PhaseTopMixerOil4WeightMinusTol).HasColumnName("Phase.TopMixer.Oil.4.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerOil4WeightPlusTol).HasColumnName("Phase.TopMixer.Oil.4.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerPhaseCheck0CheckTime).HasColumnName("Phase.TopMixer.PhaseCheck.0.CheckTime");

                entity.Property(e => e.PhaseTopMixerPhaseCheck0Max).HasColumnName("Phase.TopMixer.PhaseCheck.0.Max");

                entity.Property(e => e.PhaseTopMixerPhaseCheck0Min).HasColumnName("Phase.TopMixer.PhaseCheck.0.Min");

                entity.Property(e => e.PhaseTopMixerPhaseCheck0Variable).HasColumnName("Phase.TopMixer.PhaseCheck.0.Variable");

                entity.Property(e => e.PhaseTopMixerPhaseCheck1CheckTime).HasColumnName("Phase.TopMixer.PhaseCheck.1.CheckTime");

                entity.Property(e => e.PhaseTopMixerPhaseCheck1Max).HasColumnName("Phase.TopMixer.PhaseCheck.1.Max");

                entity.Property(e => e.PhaseTopMixerPhaseCheck1Min).HasColumnName("Phase.TopMixer.PhaseCheck.1.Min");

                entity.Property(e => e.PhaseTopMixerPhaseCheck1Variable).HasColumnName("Phase.TopMixer.PhaseCheck.1.Variable");

                entity.Property(e => e.PhaseTopMixerPhaseCheck2CheckTime).HasColumnName("Phase.TopMixer.PhaseCheck.2.CheckTime");

                entity.Property(e => e.PhaseTopMixerPhaseCheck2Max).HasColumnName("Phase.TopMixer.PhaseCheck.2.Max");

                entity.Property(e => e.PhaseTopMixerPhaseCheck2Min).HasColumnName("Phase.TopMixer.PhaseCheck.2.Min");

                entity.Property(e => e.PhaseTopMixerPhaseCheck2Variable).HasColumnName("Phase.TopMixer.PhaseCheck.2.Variable");

                entity.Property(e => e.PhaseTopMixerPhaseDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.PhaseDescription");

                entity.Property(e => e.PhaseTopMixerPhaseTransition0Value).HasColumnName("Phase.TopMixer.PhaseTransition.0.Value");

                entity.Property(e => e.PhaseTopMixerPhaseTransition0Variable).HasColumnName("Phase.TopMixer.PhaseTransition.0.Variable");

                entity.Property(e => e.PhaseTopMixerPhaseTransition1Value).HasColumnName("Phase.TopMixer.PhaseTransition.1.Value");

                entity.Property(e => e.PhaseTopMixerPhaseTransition1Variable).HasColumnName("Phase.TopMixer.PhaseTransition.1.Variable");

                entity.Property(e => e.PhaseTopMixerPhaseTransition2Value).HasColumnName("Phase.TopMixer.PhaseTransition.2.Value");

                entity.Property(e => e.PhaseTopMixerPhaseTransition2Variable).HasColumnName("Phase.TopMixer.PhaseTransition.2.Variable");

                entity.Property(e => e.PhaseTopMixerPhaseType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.PhaseType");

                entity.Property(e => e.PhaseTopMixerPigment0MaterialBinSource).HasColumnName("Phase.TopMixer.Pigment.0.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerPigment0MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Pigment.0.MaterialType");

                entity.Property(e => e.PhaseTopMixerPigment0SkipStep).HasColumnName("Phase.TopMixer.Pigment.0.SkipStep");

                entity.Property(e => e.PhaseTopMixerPigment0TargetWeight).HasColumnName("Phase.TopMixer.Pigment.0.TargetWeight");

                entity.Property(e => e.PhaseTopMixerPigment0TimingType).HasColumnName("Phase.TopMixer.Pigment.0.TimingType");

                entity.Property(e => e.PhaseTopMixerPigment0TimingValue).HasColumnName("Phase.TopMixer.Pigment.0.TimingValue");

                entity.Property(e => e.PhaseTopMixerPigment0WeightMinusTol).HasColumnName("Phase.TopMixer.Pigment.0.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerPigment0WeightPlusTol).HasColumnName("Phase.TopMixer.Pigment.0.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerPigment1MaterialBinSource).HasColumnName("Phase.TopMixer.Pigment.1.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerPigment1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Pigment.1.MaterialType");

                entity.Property(e => e.PhaseTopMixerPigment1SkipStep).HasColumnName("Phase.TopMixer.Pigment.1.SkipStep");

                entity.Property(e => e.PhaseTopMixerPigment1TargetWeight).HasColumnName("Phase.TopMixer.Pigment.1.TargetWeight");

                entity.Property(e => e.PhaseTopMixerPigment1TimingType).HasColumnName("Phase.TopMixer.Pigment.1.TimingType");

                entity.Property(e => e.PhaseTopMixerPigment1TimingValue).HasColumnName("Phase.TopMixer.Pigment.1.TimingValue");

                entity.Property(e => e.PhaseTopMixerPigment1WeightMinusTol).HasColumnName("Phase.TopMixer.Pigment.1.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerPigment1WeightPlusTol).HasColumnName("Phase.TopMixer.Pigment.1.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerPigment2MaterialBinSource).HasColumnName("Phase.TopMixer.Pigment.2.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerPigment2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Pigment.2.MaterialType");

                entity.Property(e => e.PhaseTopMixerPigment2SkipStep).HasColumnName("Phase.TopMixer.Pigment.2.SkipStep");

                entity.Property(e => e.PhaseTopMixerPigment2TargetWeight).HasColumnName("Phase.TopMixer.Pigment.2.TargetWeight");

                entity.Property(e => e.PhaseTopMixerPigment2TimingType).HasColumnName("Phase.TopMixer.Pigment.2.TimingType");

                entity.Property(e => e.PhaseTopMixerPigment2TimingValue).HasColumnName("Phase.TopMixer.Pigment.2.TimingValue");

                entity.Property(e => e.PhaseTopMixerPigment2WeightMinusTol).HasColumnName("Phase.TopMixer.Pigment.2.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerPigment2WeightPlusTol).HasColumnName("Phase.TopMixer.Pigment.2.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerPigment3MaterialBinSource).HasColumnName("Phase.TopMixer.Pigment.3.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerPigment3MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Pigment.3.MaterialType");

                entity.Property(e => e.PhaseTopMixerPigment3SkipStep).HasColumnName("Phase.TopMixer.Pigment.3.SkipStep");

                entity.Property(e => e.PhaseTopMixerPigment3TargetWeight).HasColumnName("Phase.TopMixer.Pigment.3.TargetWeight");

                entity.Property(e => e.PhaseTopMixerPigment3TimingType).HasColumnName("Phase.TopMixer.Pigment.3.TimingType");

                entity.Property(e => e.PhaseTopMixerPigment3TimingValue).HasColumnName("Phase.TopMixer.Pigment.3.TimingValue");

                entity.Property(e => e.PhaseTopMixerPigment3WeightMinusTol).HasColumnName("Phase.TopMixer.Pigment.3.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerPigment3WeightPlusTol).HasColumnName("Phase.TopMixer.Pigment.3.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerPigment4MaterialBinSource).HasColumnName("Phase.TopMixer.Pigment.4.MaterialBinSource");

                entity.Property(e => e.PhaseTopMixerPigment4MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.TopMixer.Pigment.4.MaterialType");

                entity.Property(e => e.PhaseTopMixerPigment4SkipStep).HasColumnName("Phase.TopMixer.Pigment.4.SkipStep");

                entity.Property(e => e.PhaseTopMixerPigment4TargetWeight).HasColumnName("Phase.TopMixer.Pigment.4.TargetWeight");

                entity.Property(e => e.PhaseTopMixerPigment4TimingType).HasColumnName("Phase.TopMixer.Pigment.4.TimingType");

                entity.Property(e => e.PhaseTopMixerPigment4TimingValue).HasColumnName("Phase.TopMixer.Pigment.4.TimingValue");

                entity.Property(e => e.PhaseTopMixerPigment4WeightMinusTol).HasColumnName("Phase.TopMixer.Pigment.4.WeightMinusTol");

                entity.Property(e => e.PhaseTopMixerPigment4WeightPlusTol).HasColumnName("Phase.TopMixer.Pigment.4.WeightPlusTol");

                entity.Property(e => e.PhaseTopMixerRamControl0RamPostion).HasColumnName("Phase.TopMixer.RamControl.0.RamPostion");

                entity.Property(e => e.PhaseTopMixerRamControl0RamPressure).HasColumnName("Phase.TopMixer.RamControl.0.RamPressure");

                entity.Property(e => e.PhaseTopMixerRamControl0TimingType).HasColumnName("Phase.TopMixer.RamControl.0.TimingType");

                entity.Property(e => e.PhaseTopMixerRamControl0TimingValue).HasColumnName("Phase.TopMixer.RamControl.0.TimingValue");

                entity.Property(e => e.PhaseTopMixerRamControl1RamPostion).HasColumnName("Phase.TopMixer.RamControl.1.RamPostion");

                entity.Property(e => e.PhaseTopMixerRamControl1RamPressure).HasColumnName("Phase.TopMixer.RamControl.1.RamPressure");

                entity.Property(e => e.PhaseTopMixerRamControl1TimingType).HasColumnName("Phase.TopMixer.RamControl.1.TimingType");

                entity.Property(e => e.PhaseTopMixerRamControl1TimingValue).HasColumnName("Phase.TopMixer.RamControl.1.TimingValue");

                entity.Property(e => e.PhaseTopMixerRamControl2RamPostion).HasColumnName("Phase.TopMixer.RamControl.2.RamPostion");

                entity.Property(e => e.PhaseTopMixerRamControl2RamPressure).HasColumnName("Phase.TopMixer.RamControl.2.RamPressure");

                entity.Property(e => e.PhaseTopMixerRamControl2TimingType).HasColumnName("Phase.TopMixer.RamControl.2.TimingType");

                entity.Property(e => e.PhaseTopMixerRamControl2TimingValue).HasColumnName("Phase.TopMixer.RamControl.2.TimingValue");

                entity.Property(e => e.PhaseTopMixerRamControl3RamPostion).HasColumnName("Phase.TopMixer.RamControl.3.RamPostion");

                entity.Property(e => e.PhaseTopMixerRamControl3RamPressure).HasColumnName("Phase.TopMixer.RamControl.3.RamPressure");

                entity.Property(e => e.PhaseTopMixerRamControl3TimingType).HasColumnName("Phase.TopMixer.RamControl.3.TimingType");

                entity.Property(e => e.PhaseTopMixerRamControl3TimingValue).HasColumnName("Phase.TopMixer.RamControl.3.TimingValue");

                entity.Property(e => e.PhaseTopMixerRamControl4RamPostion).HasColumnName("Phase.TopMixer.RamControl.4.RamPostion");

                entity.Property(e => e.PhaseTopMixerRamControl4RamPressure).HasColumnName("Phase.TopMixer.RamControl.4.RamPressure");

                entity.Property(e => e.PhaseTopMixerRamControl4TimingType).HasColumnName("Phase.TopMixer.RamControl.4.TimingType");

                entity.Property(e => e.PhaseTopMixerRamControl4TimingValue).HasColumnName("Phase.TopMixer.RamControl.4.TimingValue");

                entity.Property(e => e.PhaseWeighBeltBaleRubber1MaterialBinSource).HasColumnName("Phase.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.PhaseWeighBeltBaleRubber1SkipStep).HasColumnName("Phase.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.PhaseWeighBeltBaleRubber1TargetWeight).HasColumnName("Phase.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltBaleRubber1WeightMinusTol).HasColumnName("Phase.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber1WeightPlusTol).HasColumnName("Phase.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber2MaterialBinSource).HasColumnName("Phase.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.PhaseWeighBeltBaleRubber2SkipStep).HasColumnName("Phase.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.PhaseWeighBeltBaleRubber2TargetWeight).HasColumnName("Phase.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltBaleRubber2WeightMinusTol).HasColumnName("Phase.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber2WeightPlusTol).HasColumnName("Phase.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber3MaterialBinSource).HasColumnName("Phase.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.PhaseWeighBeltBaleRubber3SkipStep).HasColumnName("Phase.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.PhaseWeighBeltBaleRubber3TargetWeight).HasColumnName("Phase.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltBaleRubber3WeightMinusTol).HasColumnName("Phase.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber3WeightPlusTol).HasColumnName("Phase.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber4MaterialBinSource).HasColumnName("Phase.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.PhaseWeighBeltBaleRubber4SkipStep).HasColumnName("Phase.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.PhaseWeighBeltBaleRubber4TargetWeight).HasColumnName("Phase.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltBaleRubber4WeightMinusTol).HasColumnName("Phase.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltBaleRubber4WeightPlusTol).HasColumnName("Phase.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltPack1MaterialBinSource).HasColumnName("Phase.WeighBelt.Pack1.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltPack1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.Pack1.MaterialType");

                entity.Property(e => e.PhaseWeighBeltPack1SkipStep).HasColumnName("Phase.WeighBelt.Pack1.SkipStep");

                entity.Property(e => e.PhaseWeighBeltPack1TargetWeight).HasColumnName("Phase.WeighBelt.Pack1.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltPack1WeightMinusTol).HasColumnName("Phase.WeighBelt.Pack1.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltPack1WeightPlusTol).HasColumnName("Phase.WeighBelt.Pack1.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltPack2MaterialBinSource).HasColumnName("Phase.WeighBelt.Pack2.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltPack2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.Pack2.MaterialType");

                entity.Property(e => e.PhaseWeighBeltPack2SkipStep).HasColumnName("Phase.WeighBelt.Pack2.SkipStep");

                entity.Property(e => e.PhaseWeighBeltPack2TargetWeight).HasColumnName("Phase.WeighBelt.Pack2.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltPack2WeightMinusTol).HasColumnName("Phase.WeighBelt.Pack2.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltPack2WeightPlusTol).HasColumnName("Phase.WeighBelt.Pack2.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltPack3MaterialBinSource).HasColumnName("Phase.WeighBelt.Pack3.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltPack3MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.Pack3.MaterialType");

                entity.Property(e => e.PhaseWeighBeltPack3SkipStep).HasColumnName("Phase.WeighBelt.Pack3.SkipStep");

                entity.Property(e => e.PhaseWeighBeltPack3TargetWeight).HasColumnName("Phase.WeighBelt.Pack3.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltPack3WeightMinusTol).HasColumnName("Phase.WeighBelt.Pack3.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltPack3WeightPlusTol).HasColumnName("Phase.WeighBelt.Pack3.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltPitch1MaterialBinSource).HasColumnName("Phase.WeighBelt.Pitch1.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltPitch1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.Pitch1.MaterialType");

                entity.Property(e => e.PhaseWeighBeltPitch1SkipStep).HasColumnName("Phase.WeighBelt.Pitch1.SkipStep");

                entity.Property(e => e.PhaseWeighBeltPitch1TargetWeight).HasColumnName("Phase.WeighBelt.Pitch1.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltPitch1WeightMinusTol).HasColumnName("Phase.WeighBelt.Pitch1.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltPitch1WeightPlusTol).HasColumnName("Phase.WeighBelt.Pitch1.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltPitch2MaterialBinSource).HasColumnName("Phase.WeighBelt.Pitch2.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltPitch2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.Pitch2.MaterialType");

                entity.Property(e => e.PhaseWeighBeltPitch2SkipStep).HasColumnName("Phase.WeighBelt.Pitch2.SkipStep");

                entity.Property(e => e.PhaseWeighBeltPitch2TargetWeight).HasColumnName("Phase.WeighBelt.Pitch2.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltPitch2WeightMinusTol).HasColumnName("Phase.WeighBelt.Pitch2.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltPitch2WeightPlusTol).HasColumnName("Phase.WeighBelt.Pitch2.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltSlabRubber1MaterialBinSource).HasColumnName("Phase.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.PhaseWeighBeltSlabRubber1SkipStep).HasColumnName("Phase.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.PhaseWeighBeltSlabRubber1TargetWeight).HasColumnName("Phase.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltSlabRubber1WeightMinusTol).HasColumnName("Phase.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltSlabRubber1WeightPlusTol).HasColumnName("Phase.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltSlabRubber2MaterialBinSource).HasColumnName("Phase.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.PhaseWeighBeltSlabRubber2SkipStep).HasColumnName("Phase.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.PhaseWeighBeltSlabRubber2TargetWeight).HasColumnName("Phase.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltSlabRubber2WeightMinusTol).HasColumnName("Phase.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltSlabRubber2WeightPlusTol).HasColumnName("Phase.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.PhaseWeighBeltTmaMaterialBinSource).HasColumnName("Phase.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.PhaseWeighBeltTmaMaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phase.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.PhaseWeighBeltTmaSkipStep).HasColumnName("Phase.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.PhaseWeighBeltTmaTargetWeight).HasColumnName("Phase.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.PhaseWeighBeltTmaWeightMinusTol).HasColumnName("Phase.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.PhaseWeighBeltTmaWeightPlusTol).HasColumnName("Phase.WeighBelt.TMA.WeightPlusTol");
            });

            modelBuilder.Entity<DownloadedCompoundPhasesBottom>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PhaseNumber })
                    .HasName("PK_DownloadedCompoundPhasesBottom_TEST");

                entity.ToTable("DownloadedCompoundPhasesBottom", "plc");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialBinSource).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialBinSource");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteSkipStep).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.SkipStep");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTargetWeight).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TargetWeight");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingType).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingValue).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightMinusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightMinusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightPlusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightPlusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersGateDwell).HasColumnName("BottomMixerPhase.BottomMixParameters.GateDwell");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseKwh).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseKWH");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTemp).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTemp");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMinPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MinPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingValue");

                entity.Property(e => e.BottomMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.PhaseDescription");

                entity.Property(e => e.BottomMixerPhasePhaseType).HasColumnName("BottomMixerPhase.PhaseType");
            });

            modelBuilder.Entity<DownloadedCompoundPhasesBottomReturned>(entity =>
            {
                entity.ToTable("DownloadedCompoundPhasesBottomReturned", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialBinSource).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialBinSource");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteSkipStep).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.SkipStep");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTargetWeight).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TargetWeight");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingType).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingValue).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightMinusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightMinusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightPlusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightPlusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersGateDwell).HasColumnName("BottomMixerPhase.BottomMixParameters.GateDwell");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseKwh).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseKWH");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTemp).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTemp");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMinPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MinPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingValue");

                entity.Property(e => e.BottomMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.PhaseDescription");

                entity.Property(e => e.BottomMixerPhasePhaseType).HasColumnName("BottomMixerPhase.PhaseType");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesBottomReturnedError>(entity =>
            {
                entity.ToTable("DownloadedCompoundPhasesBottomReturnedErrors", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialBinSource).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialBinSource");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteSkipStep).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.SkipStep");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTargetWeight).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TargetWeight");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingType).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingValue).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightMinusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightMinusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightPlusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightPlusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersGateDwell).HasColumnName("BottomMixerPhase.BottomMixParameters.GateDwell");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseKwh).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseKWH");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTemp).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTemp");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMinPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MinPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingValue");

                entity.Property(e => e.BottomMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.PhaseDescription");

                entity.Property(e => e.BottomMixerPhasePhaseType).HasColumnName("BottomMixerPhase.PhaseType");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesBottomReturnedHistory>(entity =>
            {
                entity.ToTable("DownloadedCompoundPhasesBottomReturnedHistory", "plc");

                entity.HasIndex(e => new { e.OperationInstance, e.PhaseNumber }, "IX_DownloadedCompoundPhasesBottomReturnedHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialBinSource).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialBinSource");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.MaterialType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteSkipStep).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.SkipStep");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTargetWeight).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TargetWeight");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingType).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteTimingValue).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightMinusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightMinusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixIngredientsChuteWeightPlusTol).HasColumnName("BottomMixerPhase.BottomMixIngredients.Chute.WeightPlusTol");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtcspeedTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCSpeedTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMax).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMax");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempMin).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempMin");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersDtctempTarget).HasColumnName("BottomMixerPhase.BottomMixParameters.DTCTempTarget");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersGateDwell).HasColumnName("BottomMixerPhase.BottomMixParameters.GateDwell");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseKwh).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseKWH");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTemp).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTemp");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMaxPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MaxPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMinPhaseTime).HasColumnName("BottomMixerPhase.BottomMixParameters.MinPhaseTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4MixerSpeed).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersMixerSpeed4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck0Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck1Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Max).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Min).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2TriggerTime).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseCheck2Type).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition0Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition1Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Duration).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Value).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPhaseTransition2Variable).HasColumnName("BottomMixerPhase.BottomMixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl0TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.0.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl1TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.1.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl2TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.2.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl3TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.3.TimingValue");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingType).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingType");

                entity.Property(e => e.BottomMixerPhaseBottomMixParametersPusherControl4TimingValue).HasColumnName("BottomMixerPhase.BottomMixParameters.PusherControl.4.TimingValue");

                entity.Property(e => e.BottomMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BottomMixerPhase.PhaseDescription");

                entity.Property(e => e.BottomMixerPhasePhaseType).HasColumnName("BottomMixerPhase.PhaseType");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTop>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PhaseNumber })
                    .HasName("PK_DownloadedCompoundPhasesTop_TEST");

                entity.ToTable("DownloadedCompoundPhasesTop", "plc");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopPreUdt20190916>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DownloadedCompoundPhasesTop_PreUDT2019_09_16", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopReturned>(entity =>
            {
                entity.ToTable("DownloadedCompoundPhasesTopReturned", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopReturnedError>(entity =>
            {
                entity.ToTable("DownloadedCompoundPhasesTopReturnedErrors", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopReturnedErrorsPreUdt20190916>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DownloadedCompoundPhasesTopReturnedErrors_PreUDT2019_09_16", "plc");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopReturnedHistory>(entity =>
            {
                entity.ToTable("DownloadedCompoundPhasesTopReturnedHistory", "plc");

                entity.HasIndex(e => new { e.OperationInstance, e.PhaseNumber }, "IX_DownloadedCompoundPhasesTopReturnedHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack10WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack10.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack6WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack6.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack7WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack7.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack8WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack8.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitchPack9WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.PitchPack9.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopReturnedHistoryPreUdt20190916>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DownloadedCompoundPhasesTopReturnedHistory_PreUDT2019_09_16", "plc");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundPhasesTopReturnedPreUdt20190916>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DownloadedCompoundPhasesTopReturned_PreUDT2019_09_16", "plc");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCanDump1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CanDump.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingType).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsCarbonBlack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.CarbonBlack.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsChargeBeltPitchPack5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.ChargeBelt.Pitch_Pack5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Oil.5.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingType).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsOil5WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Oil.5.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment0WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.0.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingType).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4TimingValue).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsPigment4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.Pigment.4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltBaleRubber4WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.BaleRubber4.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPack3WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pack3.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltPitch2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.Pitch2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber1WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber1.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2SkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2TargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltSlabRubber2WeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.SlabRubber2.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialBinSource).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialBinSource");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaMaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.MaterialType");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaSkipStep).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.SkipStep");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaTargetWeight).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.TargetWeight");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightMinusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightMinusTol");

                entity.Property(e => e.TopMixerPhaseMixIngredientsWeighBeltTmaWeightPlusTol).HasColumnName("TopMixerPhase.MixIngredients.WeighBelt.TMA.WeightPlusTol");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMax).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedMin).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtcspeedTarget).HasColumnName("TopMixerPhase.MixParameters.DTCSpeedTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMax).HasColumnName("TopMixerPhase.MixParameters.DTCTempMax");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempMin).HasColumnName("TopMixerPhase.MixParameters.DTCTempMin");

                entity.Property(e => e.TopMixerPhaseMixParametersDtctempTarget).HasColumnName("TopMixerPhase.MixParameters.DTCTempTarget");

                entity.Property(e => e.TopMixerPhaseMixParametersGateDwell).HasColumnName("TopMixerPhase.MixParameters.GateDwell");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseKwh).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseKWH");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTemp).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTemp");

                entity.Property(e => e.TopMixerPhaseMixParametersMaxPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MaxPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMinPhaseTime).HasColumnName("TopMixerPhase.MixParameters.MinPhaseTime");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed0TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed1TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed2TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed3TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4MixerSpeed).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.MixerSpeed");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingType).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersMixerSpeed4TimingValue).HasColumnName("TopMixerPhase.MixParameters.MixerSpeed.4.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck0Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.0.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck1Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.1.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Max).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Max");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Min).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Min");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2TriggerTime).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.TriggerTime");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseCheck2Type).HasColumnName("TopMixerPhase.MixParameters.PhaseCheck.2.Type");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition0Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.0.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition1Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.1.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Duration).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Duration");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Value).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Value");

                entity.Property(e => e.TopMixerPhaseMixParametersPhaseTransition2Variable).HasColumnName("TopMixerPhase.MixParameters.PhaseTransition.2.Variable");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl0TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.0.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl1TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.1.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl2TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.2.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl3TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.3.TimingValue");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPostion).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPostion");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4RamPressure).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.RamPressure");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingType).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingType");

                entity.Property(e => e.TopMixerPhaseMixParametersRamControl4TimingValue).HasColumnName("TopMixerPhase.MixParameters.RamControl.4.TimingValue");

                entity.Property(e => e.TopMixerPhasePhaseDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TopMixerPhase.PhaseDescription");

                entity.Property(e => e.TopMixerPhasePhaseType).HasColumnName("TopMixerPhase.PhaseType");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadedCompoundTemp>(entity =>
            {
                entity.ToTable("DownloadedCompoundTemp", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DownloadedCompoundTrigger>(entity =>
            {
                entity.HasKey(e => e.DownloadId);

                entity.ToTable("DownloadedCompoundTrigger", "plc");

                entity.Property(e => e.DownloadId)
                    .ValueGeneratedNever()
                    .HasColumnName("download_id");

                entity.Property(e => e.CurrentDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("current_datetime");

                entity.Property(e => e.DownloadTransactionNumber).HasColumnName("download_transaction_number");

                entity.Property(e => e.LotNumber).HasColumnName("lot_number");

                entity.Property(e => e.OperationInstance).HasColumnName("operation_instance");

                entity.Property(e => e.ReceivedTransactionNumber).HasColumnName("received_transaction_number");

                entity.Property(e => e.TempTriggerForTimer).HasColumnName("temp_trigger_for_timer");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.EquipmentName);

                entity.ToTable("Equipment", "web");

                entity.Property(e => e.EquipmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_name");

                entity.Property(e => e.EquipmentCapacity)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("equipment_capacity");

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_type");

                entity.Property(e => e.EventMixerAbbr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventMixerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActiveMixer).HasColumnName("Is_Active_Mixer");

                entity.HasOne(d => d.EquipmentTypeNavigation)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentType)
                    .HasConstraintName("FK_Equipment_EquipmentType");
            });

            modelBuilder.Entity<EquipmentPhaseParameterType>(entity =>
            {
                entity.HasKey(e => new { e.EquipmentType, e.PhaseType, e.PhaseParameterType });

                entity.ToTable("EquipmentPhaseParameterType", "web");

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_type");

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_type");

                entity.Property(e => e.PhaseParameterType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_parameter_type");

                entity.HasOne(d => d.EquipmentTypeNavigation)
                    .WithMany(p => p.EquipmentPhaseParameterTypes)
                    .HasForeignKey(d => d.EquipmentType)
                    .HasConstraintName("FK_EquipmentPhaseParameterType_EquipmentType");

                entity.HasOne(d => d.PhaseParameterTypeNavigation)
                    .WithMany(p => p.EquipmentPhaseParameterTypes)
                    .HasForeignKey(d => d.PhaseParameterType)
                    .HasConstraintName("FK_EquipmentPhaseParameterType_PhaseParameterType");

                entity.HasOne(d => d.PhaseTypeNavigation)
                    .WithMany(p => p.EquipmentPhaseParameterTypes)
                    .HasForeignKey(d => d.PhaseType)
                    .HasConstraintName("FK_EquipmentPhaseParameterType_PhaseType");
            });

            modelBuilder.Entity<EquipmentPhaseTransitionType>(entity =>
            {
                entity.HasKey(e => new { e.EquipmentType, e.PhaseType, e.TransitionType });

                entity.ToTable("EquipmentPhaseTransitionType", "web");

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_type");

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_type");

                entity.Property(e => e.TransitionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transition_type");

                entity.HasOne(d => d.EquipmentTypeNavigation)
                    .WithMany(p => p.EquipmentPhaseTransitionTypes)
                    .HasForeignKey(d => d.EquipmentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquipmentPhaseTransitionType_EquipmentType");

                entity.HasOne(d => d.PhaseTypeNavigation)
                    .WithMany(p => p.EquipmentPhaseTransitionTypes)
                    .HasForeignKey(d => d.PhaseType)
                    .HasConstraintName("FK_EquipmentPhaseTransitionType_PhaseType");

                entity.HasOne(d => d.TransitionTypeNavigation)
                    .WithMany(p => p.EquipmentPhaseTransitionTypes)
                    .HasForeignKey(d => d.TransitionType)
                    .HasConstraintName("FK_EquipmentPhaseTransitionType_TransitionType");
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.HasKey(e => e.EquipmentType1);

                entity.ToTable("EquipmentType", "web");

                entity.Property(e => e.EquipmentType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_type");

                entity.HasMany(d => d.IngredientTypes)
                    .WithMany(p => p.EquipmentTypes)
                    .UsingEntity<Dictionary<string, object>>(
                        "EquipmentIngredient",
                        l => l.HasOne<IngredientType>().WithMany().HasForeignKey("IngredientType").HasConstraintName("FK_EquipmentIngredient_IngredientType"),
                        r => r.HasOne<EquipmentType>().WithMany().HasForeignKey("EquipmentType").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EquipmentIngredient_EquipmentType"),
                        j =>
                        {
                            j.HasKey("EquipmentType", "IngredientType");

                            j.ToTable("EquipmentIngredient", "web");

                            j.IndexerProperty<string>("EquipmentType").HasMaxLength(50).IsUnicode(false).HasColumnName("equipment_type");

                            j.IndexerProperty<string>("IngredientType").HasMaxLength(50).IsUnicode(false).HasColumnName("ingredient_type");
                        });
            });

            modelBuilder.Entity<EquipmentTypePhase>(entity =>
            {
                entity.HasKey(e => new { e.EquipmentType, e.PhaseType });

                entity.ToTable("EquipmentTypePhase", "web");

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_type");

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_type");

                entity.Property(e => e.IsHasPhaseCheck).HasColumnName("Is_Has_PhaseCheck");

                entity.Property(e => e.IsHasPhaseHoldParameter).HasColumnName("Is_Has_PhaseHoldParameter");

                entity.Property(e => e.IsHasPhaseIngredient).HasColumnName("Is_Has_PhaseIngredient");

                entity.Property(e => e.IsHasPhaseMixSpeed).HasColumnName("Is_Has_PhaseMixSpeed");

                entity.Property(e => e.IsHasPhaseParameter).HasColumnName("Is_Has_PhaseParameter");

                entity.Property(e => e.IsHasPhasePusher).HasColumnName("Is_Has_PhasePusher");

                entity.Property(e => e.IsHasPhaseRamControl).HasColumnName("Is_Has_PhaseRamControl");

                entity.Property(e => e.IsHasPhaseTransition).HasColumnName("Is_Has_PhaseTransition");

                entity.HasOne(d => d.EquipmentTypeNavigation)
                    .WithMany(p => p.EquipmentTypePhases)
                    .HasForeignKey(d => d.EquipmentType)
                    .HasConstraintName("FK_EquipmentTypePhase_EquipmentType");

                entity.HasOne(d => d.PhaseTypeNavigation)
                    .WithMany(p => p.EquipmentTypePhases)
                    .HasForeignKey(d => d.PhaseType)
                    .HasConstraintName("FK_EquipmentTypePhase_PhaseType");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorLogId)
                    .IsClustered(false);

                entity.ToTable("ErrorLog");

                entity.Property(e => e.ErrorLogId)
                    .HasColumnName("Error_Log_ID")
                    .HasComment("[Identity]");

                entity.Property(e => e.ErrorExtraInfo)
                    .IsUnicode(false)
                    .HasColumnName("Error_Extra_Info")
                    .HasComment("Extra Information Provided by Procedure");

                entity.Property(e => e.ErrorLineNumber)
                    .HasColumnName("Error_Line_Number")
                    .HasComment("Error Line Number in Procedure");

                entity.Property(e => e.ErrorMessage)
                    .IsUnicode(false)
                    .HasColumnName("Error_Message")
                    .HasComment("SQL Error Message");

                entity.Property(e => e.ErrorNumber)
                    .HasColumnName("Error_Number")
                    .HasComment("SQL Error Number");

                entity.Property(e => e.ErrorProcedure)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Error_Procedure")
                    .HasComment("Procedure that generated error");

                entity.Property(e => e.ErrorSeverity)
                    .HasColumnName("Error_Severity")
                    .HasComment("SQL Error Severity");

                entity.Property(e => e.ErrorState)
                    .HasColumnName("Error_State")
                    .HasComment("SQL Error State");

                entity.Property(e => e.ErrorTime)
                    .HasColumnName("Error_Time")
                    .HasComment("[Cluster] Error Time");
            });

            modelBuilder.Entity<EventArea>(entity =>
            {
                entity.HasKey(e => new { e.EventMixer, e.EventArea1 });

                entity.ToTable("EventArea", "plc");

                entity.Property(e => e.EventArea1).HasColumnName("EventArea");

                entity.Property(e => e.EventAreaName).HasDefaultValueSql("('UNKNOWN')");

                entity.HasOne(d => d.EventMixerNavigation)
                    .WithMany(p => p.EventAreas)
                    .HasForeignKey(d => d.EventMixer)
                    .HasConstraintName("FK_EventArea_EventMixer");
            });

            modelBuilder.Entity<EventArea1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EventArea1", "plc");

                entity.Property(e => e.EventAreaName).HasMaxLength(255);
            });

            modelBuilder.Entity<EventAreaId>(entity =>
            {
                entity.HasKey(e => new { e.EventMixer, e.EventArea, e.EventId });

                entity.ToTable("EventAreaId", "plc");

                entity.Property(e => e.AlarmTypeId).HasColumnName("Alarm_Type_ID");

                entity.Property(e => e.EventName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UNKNOWN')");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventAreaIds)
                    .HasForeignKey(d => new { d.EventMixer, d.EventArea })
                    .HasConstraintName("FK_EventAreaId_EventArea");
            });

            modelBuilder.Entity<EventAreaId1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EventAreaId1", "plc");

                entity.Property(e => e.EventAlarmTypeId).HasColumnName("Event_Alarm_Type_ID");

                entity.Property(e => e.EventName).HasMaxLength(255);
            });

            modelBuilder.Entity<EventBuffer>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("EventBuffer", "plc");

                entity.HasIndex(e => new { e.EventArea, e.EventIdnumber, e.EventProcessed, e.EventId }, "IX_EventBuffer");

                entity.HasIndex(e => new { e.EventProcessed, e.EventIdnumber, e.EventArea, e.EventId }, "IX_EventBuffer_1");

                entity.Property(e => e.EventId).HasColumnName("Event_ID");

                entity.Property(e => e.EventAlarmProcessed).HasDefaultValueSql("((0))");

                entity.Property(e => e.EventIdnumber).HasColumnName("EventIDNumber");

                entity.Property(e => e.EventProcessed).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlceventTime).HasColumnName("PLCEventTime");

                entity.Property(e => e.SqleventTime)
                    .HasColumnName("SQLEventTime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_event_log")
                    .IsClustered(false);

                entity.ToTable("EventLog");

                entity.Property(e => e.EventId).HasColumnName("Event_ID");

                entity.Property(e => e.EventArea).HasColumnName("Event_Area");

                entity.Property(e => e.EventBatchNumber).HasColumnName("Event_Batch_Number");

                entity.Property(e => e.EventClientComputerName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("Event_Client_Computer_Name");

                entity.Property(e => e.EventCompoundId).HasColumnName("Event_Compound_ID");

                entity.Property(e => e.EventCurrentOperation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Event_Current_Operation");

                entity.Property(e => e.EventDebugLevel).HasColumnName("Event_Debug_Level");

                entity.Property(e => e.EventDuration).HasColumnName("Event_Duration");

                entity.Property(e => e.EventInitialSource)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("Event_Initial_Source");

                entity.Property(e => e.EventLotNumber).HasColumnName("Event_Lot_Number");

                entity.Property(e => e.EventMsg)
                    .IsUnicode(false)
                    .HasColumnName("Event_Msg");

                entity.Property(e => e.EventOperatorId).HasColumnName("Event_Operator_ID");

                entity.Property(e => e.EventPhaseNumber).HasColumnName("Event_Phase_Number");

                entity.Property(e => e.EventProcedureHistory)
                    .IsUnicode(false)
                    .HasColumnName("Event_Procedure_History");

                entity.Property(e => e.EventReturnValue).HasColumnName("Event_Return_Value");

                entity.Property(e => e.EventRowCount).HasColumnName("Event_Row_Count");

                entity.Property(e => e.EventSequence).HasColumnName("Event_Sequence");

                entity.Property(e => e.EventSeverityId)
                    .HasColumnName("Event_Severity_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EventSource)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("Event_Source");

                entity.Property(e => e.EventStartTime).HasColumnName("Event_Start_Time");

                entity.Property(e => e.EventTime)
                    .HasColumnName("Event_Time")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.EventUserMsg)
                    .IsUnicode(false)
                    .HasColumnName("Event_User_Msg");

                entity.HasOne(d => d.EventSeverity)
                    .WithMany(p => p.EventLogs)
                    .HasForeignKey(d => d.EventSeverityId)
                    .HasConstraintName("FK_EventLog_EventLogSeverity");
            });

            modelBuilder.Entity<EventLogSeverity>(entity =>
            {
                entity.HasKey(e => e.SeverityId)
                    .HasName("PK_event_log_severity");

                entity.ToTable("EventLogSeverity");

                entity.Property(e => e.SeverityId)
                    .HasColumnName("Severity_ID")
                    .HasComment("Severity ID");

                entity.Property(e => e.SeverityDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Severity_Description")
                    .HasComment("Event Log Severity Description");

                entity.Property(e => e.SeverityName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Severity_Name")
                    .HasComment("Event Log Severity Name");
            });

            modelBuilder.Entity<EventMixer>(entity =>
            {
                entity.HasKey(e => e.EventMixer1);

                entity.ToTable("EventMixer", "plc");

                entity.Property(e => e.EventMixer1)
                    .ValueGeneratedNever()
                    .HasColumnName("EventMixer");

                entity.Property(e => e.EquipmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_name");
            });

            modelBuilder.Entity<EventMixer1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EventMixer1", "plc");

                entity.Property(e => e.EquipmentName)
                    .HasMaxLength(255)
                    .HasColumnName("equipment_name");

                entity.Property(e => e.EventMixerName).HasMaxLength(255);
            });

            modelBuilder.Entity<GlobalSetting>(entity =>
            {
                entity.HasKey(e => e.GlobalSettingName);

                entity.Property(e => e.GlobalSettingName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Name");

                entity.Property(e => e.GlobalSettingDataType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Data_Type")
                    .HasComment("STRING, INT, BIT");

                entity.Property(e => e.GlobalSettingUserDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_User_Description");

                entity.Property(e => e.GlobalSettingUserGroupId).HasColumnName("Global_Setting_User_Group_ID");

                entity.Property(e => e.GlobalSettingUserGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_User_Group_Name");

                entity.Property(e => e.GlobalSettingUserItemSort).HasColumnName("Global_Setting_User_Item_Sort");

                entity.Property(e => e.GlobalSettingValueBit).HasColumnName("Global_Setting_Value_Bit");

                entity.Property(e => e.GlobalSettingValueDefault)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Value_Default");

                entity.Property(e => e.GlobalSettingValueDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Value_Description");

                entity.Property(e => e.GlobalSettingValueInt).HasColumnName("Global_Setting_Value_Int");

                entity.Property(e => e.GlobalSettingValueIntMax)
                    .HasColumnName("Global_Setting_Value_Int_Max")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Max Value setting for Int");

                entity.Property(e => e.GlobalSettingValueIntMin)
                    .HasColumnName("Global_Setting_Value_Int_Min")
                    .HasComment("Min Value setting for Int");

                entity.Property(e => e.GlobalSettingValueString)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Global_Setting_Value_String");

                entity.Property(e => e.IsGlobalSettingApplicationSetting)
                    .HasColumnName("Is_Global_Setting_Application_Setting")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGlobalSettingUserEditEnabled)
                    .HasColumnName("Is_Global_Setting_User_Edit_Enabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGlobalSettingUserVisible).HasColumnName("Is_Global_Setting_User_Visible");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.HasKey(e => e.Ingredient1);

                entity.ToTable("Ingredient", "web");

                entity.Property(e => e.Ingredient1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient");

                entity.Property(e => e.IngredientType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_type");

                entity.HasOne(d => d.IngredientTypeNavigation)
                    .WithMany(p => p.Ingredients)
                    .HasForeignKey(d => d.IngredientType)
                    .HasConstraintName("FK_Ingredient_IngredientType");
            });

            modelBuilder.Entity<IngredientLocation>(entity =>
            {
                entity.ToTable("IngredientLocation", "web");

                entity.HasIndex(e => e.IngredientLocation1, "IX_IngredientLocation")
                    .IsUnique();

                entity.Property(e => e.IngredientLocationId).HasColumnName("ingredient_location_id");

                entity.Property(e => e.IngredientLocation1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_location");

                entity.Property(e => e.IngredientLocationIndex).HasColumnName("ingredient_location_index");
            });

            modelBuilder.Entity<IngredientLocationValid>(entity =>
            {
                entity.HasKey(e => new { e.Ingredient, e.IngredientLocation });

                entity.ToTable("IngredientLocationValid", "web");

                entity.Property(e => e.Ingredient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient");

                entity.Property(e => e.IngredientLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_location");

                entity.Property(e => e.IngredientLevel).HasColumnName("ingredient_level");

                entity.HasOne(d => d.IngredientNavigation)
                    .WithMany(p => p.IngredientLocationValids)
                    .HasForeignKey(d => d.Ingredient)
                    .HasConstraintName("FK_IngredientLocationValid_Ingredient");

                entity.HasOne(d => d.IngredientLocationNavigation)
                    .WithMany(p => p.IngredientLocationValids)
                    .HasPrincipalKey(p => p.IngredientLocation1)
                    .HasForeignKey(d => d.IngredientLocation)
                    .HasConstraintName("FK_IngredientLocationValid_IngredientLocation");
            });

            modelBuilder.Entity<IngredientParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterName);

                entity.ToTable("IngredientParameters", "web");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_name");

                entity.Property(e => e.ParameterValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value");
            });

            modelBuilder.Entity<IngredientTiming>(entity =>
            {
                entity.HasKey(e => e.IngredientTimingType);

                entity.ToTable("IngredientTiming", "web");

                entity.Property(e => e.IngredientTimingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_timing_type");

                entity.Property(e => e.IngredientTimingTypeId).HasColumnName("ingredient_timing_type_id");
            });

            modelBuilder.Entity<IngredientType>(entity =>
            {
                entity.HasKey(e => e.IngredientType1);

                entity.ToTable("IngredientType", "web");

                entity.Property(e => e.IngredientType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_type");

                entity.Property(e => e.HighToleranceAbsLbs)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("high_tolerance_abs_lbs");

                entity.Property(e => e.HighTolerancePercent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("high_tolerance_percent");

                entity.Property(e => e.IngredientSortOrder).HasColumnName("ingredient_sort_order");

                entity.Property(e => e.LowToleranceAbsLbs)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("low_tolerance_abs_lbs");

                entity.Property(e => e.LowTolerancePercent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("low_tolerance_percent");

                entity.Property(e => e.LowToleranceRange)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("low_tolerance_range");

                entity.Property(e => e.MidToleranceAbsLbs)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mid_tolerance_abs_lbs");

                entity.Property(e => e.MidTolerancePercent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mid_tolerance_percent");

                entity.Property(e => e.MidToleranceRange)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mid_tolerance_range");
            });

            modelBuilder.Entity<IngredientTypeOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IngredientType_OLD", "web");

                entity.Property(e => e.IngredientSortOrder).HasColumnName("ingredient_sort_order");

                entity.Property(e => e.IngredientType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_type");

                entity.Property(e => e.LowerTolerance)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("lower_tolerance");

                entity.Property(e => e.UpperTolerance)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("upper_tolerance");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location", "barcode");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocationDescription)
                    .IsUnicode(false)
                    .HasColumnName("location_description");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location_name");

                entity.Property(e => e.ParentLocationId).HasColumnName("parent_location_id");

                entity.HasOne(d => d.ParentLocation)
                    .WithMany(p => p.InverseParentLocation)
                    .HasForeignKey(d => d.ParentLocationId)
                    .HasConstraintName("FK_Location_Location");
            });

            modelBuilder.Entity<LocationOperation>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.OperationId })
                    .HasName("PK_LocationScan");

                entity.ToTable("LocationOperations", "barcode");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.OperationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operation_id");

                entity.Property(e => e.OperationOrder).HasColumnName("operation_order");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationOperations)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_LocationScan_Location");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.LocationOperations)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_LocationOperations_Operation");
            });

            modelBuilder.Entity<LotReport>(entity =>
            {
                entity.HasKey(e => e.LotId)
                    .HasName("PK_Lots");

                entity.ToTable("LotReport");

                entity.HasIndex(e => e.LotNumber, "IX_LotReport");

                entity.Property(e => e.LotId).HasColumnName("Lot_ID");

                entity.Property(e => e.ChuteLevel).HasColumnName("Chute_Level");

                entity.Property(e => e.CompoundName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Compound_Name");

                entity.Property(e => e.CurrentBatchNumber).HasColumnName("Current_Batch_Number");

                entity.Property(e => e.DownloadTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Download_Time");

                entity.Property(e => e.LotEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Lot_EndTime");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");

                entity.Property(e => e.LotStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Lot_StartTime");

                entity.Property(e => e.NumBatches).HasColumnName("Num_Batches");

                entity.Property(e => e.SapProcess)
                    .HasColumnType("datetime")
                    .HasColumnName("SAP_Process");

                entity.Property(e => e.SkidBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Skid_Barcode");
            });

            modelBuilder.Entity<LotReportBatchDetail>(entity =>
            {
                entity.HasKey(e => e.BatchDetailsId);

                entity.HasIndex(e => new { e.LotNumber, e.BatchNumber, e.EventArea }, "IX_LotReportBatchDetails");

                entity.Property(e => e.BatchDetailsId).HasColumnName("BatchDetails_ID");

                entity.Property(e => e.BatchNumber).HasColumnName("Batch_Number");

                entity.Property(e => e.BwbStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("BWB_StartTime");

                entity.Property(e => e.ChargeStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Charge_StartTime");

                entity.Property(e => e.DischargeEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Discharge_EndTime");

                entity.Property(e => e.DischargeKWh).HasColumnName("Discharge_kWh");

                entity.Property(e => e.DischargeStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Discharge_StartTime");

                entity.Property(e => e.DischargeTemp).HasColumnName("Discharge_Temp");

                entity.Property(e => e.EventArea).HasColumnName("Event_Area");

                entity.Property(e => e.FIndex).HasColumnName("F_Index");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");

                entity.Property(e => e.Meq).HasColumnName("MEQ");

                entity.Property(e => e.MixStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Mix_StartTime");

                entity.Property(e => e.MixerEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Mixer_EndTime")
                    .HasComment("Batch End Time");

                entity.Property(e => e.MixerStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Mixer_StartTime")
                    .HasComment("Batch Start Time");
            });

            modelBuilder.Entity<LotReportPhaseDetail>(entity =>
            {
                entity.HasKey(e => e.PhaseDetailsId);

                entity.HasIndex(e => new { e.LotNumber, e.BatchNumber, e.PhaseNumber, e.EventArea }, "IX_LotReportPhaseDetails");

                entity.HasIndex(e => new { e.PhaseType, e.LotNumber, e.BatchNumber, e.PhaseNumber }, "IX_LotReportPhaseDetails_1");

                entity.Property(e => e.PhaseDetailsId).HasColumnName("PhaseDetails_ID");

                entity.Property(e => e.AverageRpm).HasColumnName("Average_RPM");

                entity.Property(e => e.AvgDriveSideTemp).HasColumnName("AVG_Drive_Side_Temp");

                entity.Property(e => e.AvgWaterSideTemp).HasColumnName("AVG_Water_Side_Temp");

                entity.Property(e => e.BatchNumber).HasColumnName("Batch_Number");

                entity.Property(e => e.EventArea).HasColumnName("Event_Area");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");

                entity.Property(e => e.PhaseCheckResults1).HasColumnName("Phase_Check_Results_1");

                entity.Property(e => e.PhaseCheckResults2).HasColumnName("Phase_Check_Results_2");

                entity.Property(e => e.PhaseCheckResults3).HasColumnName("Phase_Check_Results_3");

                entity.Property(e => e.PhaseEndKwh).HasColumnName("Phase_EndKWH");

                entity.Property(e => e.PhaseEndTemp).HasColumnName("Phase_EndTemp");

                entity.Property(e => e.PhaseEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Phase_EndTime");

                entity.Property(e => e.PhaseNumber).HasColumnName("Phase_Number");

                entity.Property(e => e.PhaseStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Phase_StartTime");

                entity.Property(e => e.PhaseType)
                    .HasColumnName("Phase_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RpmStd).HasColumnName("RPM_STD");

                entity.Property(e => e.StdDriveSideTemp).HasColumnName("STD_Drive_Side_Temp");

                entity.Property(e => e.StdTemperature).HasColumnName("STD_Temperature");

                entity.Property(e => e.StdWaterSideTemp).HasColumnName("STD_Water_Side_Temp");

                entity.Property(e => e.TargetTemperature).HasColumnName("Target_Temperature");
            });

            modelBuilder.Entity<LotReportPhaseMaterialsDetail>(entity =>
            {
                entity.HasKey(e => e.PhaseMaterialsDetailsId);

                entity.HasIndex(e => new { e.LotNumber, e.BatchNumber, e.PhaseNumber, e.EventArea }, "IX_LotReportPhaseMaterialsDetails");

                entity.Property(e => e.PhaseMaterialsDetailsId).HasColumnName("PhaseMaterialsDetails_ID");

                entity.Property(e => e.Bale1Weight).HasColumnName("Bale1_Weight");

                entity.Property(e => e.Bale2Weight).HasColumnName("Bale2_Weight");

                entity.Property(e => e.Bale3Weight).HasColumnName("Bale3_Weight");

                entity.Property(e => e.Bale4Weight).HasColumnName("Bale4_Weight");

                entity.Property(e => e.BatchNumber).HasColumnName("Batch_Number");

                entity.Property(e => e.CanDump1Weight).HasColumnName("CanDump1_Weight");

                entity.Property(e => e.Carbon1Weight).HasColumnName("Carbon1_Weight");

                entity.Property(e => e.Carbon2Weight).HasColumnName("Carbon2_Weight");

                entity.Property(e => e.Carbon3Weight).HasColumnName("Carbon3_Weight");

                entity.Property(e => e.Carbon4Weight).HasColumnName("Carbon4_Weight");

                entity.Property(e => e.Carbon5Weight).HasColumnName("Carbon5_Weight");

                entity.Property(e => e.EventArea).HasColumnName("Event_Area");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");

                entity.Property(e => e.Oil1Weight).HasColumnName("Oil1_Weight");

                entity.Property(e => e.Oil2Weight).HasColumnName("Oil2_Weight");

                entity.Property(e => e.Oil3Weight).HasColumnName("Oil3_Weight");

                entity.Property(e => e.Oil4Weight).HasColumnName("Oil4_Weight");

                entity.Property(e => e.Oil5Weight).HasColumnName("Oil5_Weight");

                entity.Property(e => e.Oil6Weight).HasColumnName("Oil6_Weight");

                entity.Property(e => e.PhaseNumber).HasColumnName("Phase_Number");

                entity.Property(e => e.PhaseType).HasColumnName("Phase_Type");

                entity.Property(e => e.Pigment1Weight).HasColumnName("Pigment1_Weight");

                entity.Property(e => e.Pigment2Weight).HasColumnName("Pigment2_Weight");

                entity.Property(e => e.Pigment3Weight).HasColumnName("Pigment3_Weight");

                entity.Property(e => e.Pigment4Weight).HasColumnName("Pigment4_Weight");

                entity.Property(e => e.Pigment5Weight).HasColumnName("Pigment5_Weight");

                entity.Property(e => e.PitchPack10Weight).HasColumnName("PitchPack10_Weight");

                entity.Property(e => e.PitchPack1Weight).HasColumnName("PitchPack1_Weight");

                entity.Property(e => e.PitchPack2Weight).HasColumnName("PitchPack2_Weight");

                entity.Property(e => e.PitchPack3Weight).HasColumnName("PitchPack3_Weight");

                entity.Property(e => e.PitchPack4Weight).HasColumnName("PitchPack4_Weight");

                entity.Property(e => e.PitchPack5Weight).HasColumnName("PitchPack5_Weight");

                entity.Property(e => e.PitchPack6Weight).HasColumnName("PitchPack6_Weight");

                entity.Property(e => e.PitchPack7Weight).HasColumnName("PitchPack7_Weight");

                entity.Property(e => e.PitchPack8Weight).HasColumnName("PitchPack8_Weight");

                entity.Property(e => e.PitchPack9Weight).HasColumnName("PitchPack9_Weight");

                entity.Property(e => e.Slab1Weight).HasColumnName("Slab1_Weight");

                entity.Property(e => e.Slab2Weight).HasColumnName("Slab2_Weight");

                entity.Property(e => e.TmaWeight).HasColumnName("TMA_Weight");
            });

            modelBuilder.Entity<LotReportPowerChart>(entity =>
            {
                entity.HasKey(e => e.PowerId);

                entity.ToTable("LotReportPowerChart");

                entity.HasIndex(e => new { e.LotNumber, e.BatchNumber, e.EventArea, e.PhaseNumber, e.EventId }, "IX_LotReportPowerChart");

                entity.Property(e => e.PowerId).HasColumnName("Power_ID");

                entity.Property(e => e.BatchNumber).HasColumnName("Batch_Number");

                entity.Property(e => e.DriveTemp).HasColumnName("Drive_Temp");

                entity.Property(e => e.EventArea).HasColumnName("Event_Area");

                entity.Property(e => e.EventId).HasColumnName("Event_ID");

                entity.Property(e => e.EventValue).HasColumnName("Event_Value");

                entity.Property(e => e.KWh).HasColumnName("kWh");

                entity.Property(e => e.Kw).HasColumnName("KW");

                entity.Property(e => e.LotNumber).HasColumnName("Lot_Number");

                entity.Property(e => e.MixTime).HasColumnName("Mix_Time");

                entity.Property(e => e.MixerSpeed).HasColumnName("Mixer_Speed");

                entity.Property(e => e.PhaseNumber).HasColumnName("Phase_Number");

                entity.Property(e => e.PhaseType).HasColumnName("Phase_Type");

                entity.Property(e => e.PlceventDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("PLCEventDateTime");

                entity.Property(e => e.PlceventTime).HasColumnName("PLCEventTime");

                entity.Property(e => e.RamPosition).HasColumnName("Ram_Position");

                entity.Property(e => e.RamPressure).HasColumnName("Ram_Pressure");

                entity.Property(e => e.SqldateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("SQLDateTime");

                entity.Property(e => e.WaterTemp).HasColumnName("Water_Temp");
            });

            modelBuilder.Entity<MixSpeedType>(entity =>
            {
                entity.HasKey(e => e.MixSpeedType1);

                entity.ToTable("MixSpeedType", "web");

                entity.Property(e => e.MixSpeedType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mix_speed_type");
            });

            modelBuilder.Entity<MixTimingType>(entity =>
            {
                entity.HasKey(e => e.TimingType);

                entity.ToTable("MixTimingType", "web");

                entity.Property(e => e.TimingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timing_type");

                entity.Property(e => e.TimingTypeId).HasColumnName("timing_type_id");
            });

            modelBuilder.Entity<MixerStatusBitMap>(entity =>
            {
                entity.HasKey(e => e.MixerStatusBitNumber);

                entity.ToTable("MixerStatusBitMap", "plc");

                entity.Property(e => e.MixerStatusBitNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("Mixer_Status_Bit_Number");

                entity.Property(e => e.IsMixerStatusEnabled).HasColumnName("Is_Mixer_Status_Enabled");

                entity.Property(e => e.MixerStatusBitValue).HasColumnName("Mixer_Status_Bit_Value");

                entity.Property(e => e.MixerStatusMessageOff)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Mixer_Status_Message_Off");

                entity.Property(e => e.MixerStatusMessageOn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Mixer_Status_Message_On");

                entity.Property(e => e.MixerStatusMessageText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Mixer_Status_Message_Text");
            });

            modelBuilder.Entity<Number>(entity =>
            {
                entity.HasKey(e => e.Number1);

                entity.Property(e => e.Number1)
                    .ValueGeneratedNever()
                    .HasColumnName("Number")
                    .HasComment("-100 to 10,000");
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.ToTable("Operation", "barcode");

                entity.Property(e => e.OperationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operation_id");

                entity.Property(e => e.OperationDescription)
                    .IsUnicode(false)
                    .HasColumnName("operation_description");

                entity.Property(e => e.OperationEnabled).HasColumnName("operation_enabled");

                entity.Property(e => e.OperationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("operation_name");

                entity.Property(e => e.ResultIdEnd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("result_id_end");

                entity.HasOne(d => d.ResultIdEndNavigation)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.ResultIdEnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operation_OperationScanResult");
            });

            modelBuilder.Entity<OperationResult>(entity =>
            {
                entity.ToTable("OperationResults", "plc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OperationStartTime).HasColumnType("datetime");

                entity.Property(e => e.ServerIdbegin).HasColumnName("ServerIDBegin");

                entity.Property(e => e.ServerIdend).HasColumnName("ServerIDEnd");

                entity.Property(e => e.Transfer)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationScan>(entity =>
            {
                entity.HasKey(e => new { e.OperationId, e.ScanId, e.ScanOrder });

                entity.ToTable("OperationScans", "barcode");

                entity.Property(e => e.OperationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operation_id");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id");

                entity.Property(e => e.ScanOrder).HasColumnName("scan_order");

                entity.Property(e => e.ResultIdFail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("result_id_fail");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.OperationScans)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_OperationScans_Operation");

                entity.HasOne(d => d.ResultIdFailNavigation)
                    .WithMany(p => p.OperationScans)
                    .HasForeignKey(d => d.ResultIdFail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperationScans_OperationScanResult1");

                entity.HasOne(d => d.Scan)
                    .WithMany(p => p.OperationScans)
                    .HasForeignKey(d => d.ScanId)
                    .HasConstraintName("FK_OperationScans_Scan");
            });

            modelBuilder.Entity<OperationScanResult>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("OperationScanResult", "barcode");

                entity.Property(e => e.ResultId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("result_id");

                entity.Property(e => e.ResultDescription)
                    .IsUnicode(false)
                    .HasColumnName("result_description");

                entity.Property(e => e.ResultName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("result_name");
            });

            modelBuilder.Entity<OperationScanValue>(entity =>
            {
                entity.HasKey(e => new { e.OperationId, e.ScanId, e.ScanOrder, e.ScanStatus, e.ResultIdValueOrder });

                entity.ToTable("OperationScanValues", "barcode");

                entity.Property(e => e.OperationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operation_id");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id");

                entity.Property(e => e.ScanOrder).HasColumnName("scan_order");

                entity.Property(e => e.ScanStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_status");

                entity.Property(e => e.ResultIdValueOrder).HasColumnName("result_id_value_order");

                entity.Property(e => e.ResultIdValue)
                    .IsUnicode(false)
                    .HasColumnName("result_id_value");

                entity.HasOne(d => d.OperationScan)
                    .WithMany(p => p.OperationScanValues)
                    .HasForeignKey(d => new { d.OperationId, d.ScanId, d.ScanOrder })
                    .HasConstraintName("FK_OperationScanValues_OperationScans");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("Option", "barcode");

                entity.Property(e => e.OptionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_id");

                entity.Property(e => e.OptionClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_class");

                entity.Property(e => e.OptionColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_color");

                entity.Property(e => e.OptionDescription)
                    .IsUnicode(false)
                    .HasColumnName("option_description");

                entity.Property(e => e.OptionEnabled).HasColumnName("option_enabled");

                entity.Property(e => e.OptionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("option_name");

                entity.HasOne(d => d.OptionClassNavigation)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.OptionClass)
                    .HasConstraintName("FK_Option_OptionClass");
            });

            modelBuilder.Entity<OptionAction>(entity =>
            {
                entity.HasKey(e => new { e.OptionId, e.ActionId, e.ActionOrder });

                entity.ToTable("OptionActions", "barcode");

                entity.Property(e => e.OptionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_id");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_id");

                entity.Property(e => e.ActionOrder).HasColumnName("action_order");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.OptionActions)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_OptionActions_Action");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.OptionActions)
                    .HasForeignKey(d => d.OptionId)
                    .HasConstraintName("FK_OptionActions_Option");
            });

            modelBuilder.Entity<OptionClass>(entity =>
            {
                entity.HasKey(e => e.OptionClass1);

                entity.ToTable("OptionClass", "barcode");

                entity.Property(e => e.OptionClass1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_class");

                entity.Property(e => e.OptionClassDescription)
                    .IsUnicode(false)
                    .HasColumnName("option_class_description");

                entity.Property(e => e.OptionClassName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("option_class_name");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.HasKey(e => e.PhaseId)
                    .IsClustered(false);

                entity.ToTable("Phase", "web");

                entity.HasIndex(e => new { e.CompoundName, e.Stage, e.Phase1 }, "IX_Phase")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PhaseId).HasColumnName("Phase_ID");

                entity.Property(e => e.CompoundName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name");

                entity.Property(e => e.Phase1).HasColumnName("phase");

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_type");

                entity.Property(e => e.Stage).HasColumnName("stage");

                entity.HasOne(d => d.PhaseTypeNavigation)
                    .WithMany(p => p.Phases)
                    .HasForeignKey(d => d.PhaseType)
                    .HasConstraintName("FK_Phase_PhaseType");
            });

            modelBuilder.Entity<PhaseCheck>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.Name, e.Type });

                entity.ToTable("PhaseCheck", "web");

                entity.HasIndex(e => e.PhaseCheckId, "IX_PhaseCheck")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.CheckTime).HasColumnName("check_time");

                entity.Property(e => e.Max)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("max");

                entity.Property(e => e.Min)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("min");

                entity.Property(e => e.PhaseCheckId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_check_ID");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhaseChecks)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseCheck_Phase");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.PhaseChecks)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseCheck_PhaseCheckType");
            });

            modelBuilder.Entity<PhaseCheckType>(entity =>
            {
                entity.HasKey(e => e.Type);

                entity.ToTable("PhaseCheckType", "web");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<PhaseHoldParameter>(entity =>
            {
                entity.HasKey(e => e.PhaseId);

                entity.ToTable("PhaseHoldParameters", "web");

                entity.HasIndex(e => e.PhaseHoldParameterId, "IX_PhaseHoldParameters")
                    .IsUnique();

                entity.Property(e => e.PhaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("phase_id");

                entity.Property(e => e.MixSpeedMaximum)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mix_speed_maximum");

                entity.Property(e => e.MixSpeedMinimum)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mix_speed_minimum");

                entity.Property(e => e.MixSpeedTarget)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mix_speed_target");

                entity.Property(e => e.MixTempMaximum)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mix_temp_maximum");

                entity.Property(e => e.MixTempMinimum)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mix_temp_minimum");

                entity.Property(e => e.MixTempTarget)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("mix_temp_target");

                entity.Property(e => e.PhaseHoldParameterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_hold_parameter_id");

                entity.HasOne(d => d.Phase)
                    .WithOne(p => p.PhaseHoldParameter)
                    .HasForeignKey<PhaseHoldParameter>(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseHoldParameters_Phase");
            });

            modelBuilder.Entity<PhaseIngredient>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.Ingredient })
                    .HasName("PK_PhaseIngredient_1");

                entity.ToTable("PhaseIngredient", "web");

                entity.HasIndex(e => e.PhaseIngredientId, "IX_PhaseIngredient")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.Ingredient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient");

                entity.Property(e => e.IngredientAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("ingredient_amount");

                entity.Property(e => e.IngredientLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_location");

                entity.Property(e => e.IngredientTimingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_timing_type");

                entity.Property(e => e.IngredientTimingValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("ingredient_timing_value");

                entity.Property(e => e.PhaseIngredientId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_ingredient_ID");

                entity.HasOne(d => d.IngredientNavigation)
                    .WithMany(p => p.PhaseIngredients)
                    .HasForeignKey(d => d.Ingredient)
                    .HasConstraintName("FK_PhaseIngredient_Ingredient");

                entity.HasOne(d => d.IngredientTimingTypeNavigation)
                    .WithMany(p => p.PhaseIngredients)
                    .HasForeignKey(d => d.IngredientTimingType)
                    .HasConstraintName("FK_PhaseIngredient_IngredientTiming");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhaseIngredients)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseIngredient_Phase");
            });

            modelBuilder.Entity<PhaseMixSpeed>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.MixSpeedIndex, e.MixSpeedType })
                    .HasName("PK_PhaseMixSpeed_1");

                entity.ToTable("PhaseMixSpeed", "web");

                entity.HasIndex(e => e.PhaseMixSpeedId, "IX_PhaseMixSpeed")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.MixSpeedIndex).HasColumnName("mix_speed_index");

                entity.Property(e => e.MixSpeedType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mix_speed_type");

                entity.Property(e => e.CompoundNameDeleteMe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name_DELETE_ME");

                entity.Property(e => e.MixSpeedValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mix_speed_value");

                entity.Property(e => e.PhaseDeleteMe).HasColumnName("phase_DELETE_ME");

                entity.Property(e => e.PhaseMixSpeedId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_mix_speed_ID");

                entity.Property(e => e.StageDeleteMe).HasColumnName("stage_DELETE_ME");

                entity.HasOne(d => d.MixSpeedTypeNavigation)
                    .WithMany(p => p.PhaseMixSpeeds)
                    .HasForeignKey(d => d.MixSpeedType)
                    .HasConstraintName("FK_PhaseMixSpeed_MixSpeedType");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhaseMixSpeeds)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseMixSpeed_Phase");
            });

            modelBuilder.Entity<PhaseParameter>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.PhaseParameterType });

                entity.ToTable("PhaseParameter", "web");

                entity.HasIndex(e => e.PhaseParameterId, "IX_PhaseParameter")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.PhaseParameterType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_parameter_type");

                entity.Property(e => e.CompoundNameDeleteMe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name_DELETE_ME");

                entity.Property(e => e.PhaseDeleteMe).HasColumnName("phase_DELETE_ME");

                entity.Property(e => e.PhaseParameterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_parameter_ID");

                entity.Property(e => e.PhaseParameterValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("phase_parameter_value");

                entity.Property(e => e.StageDeleteMe).HasColumnName("stage_DELETE_ME");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhaseParameters)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseParameter_Phase");

                entity.HasOne(d => d.PhaseParameterTypeNavigation)
                    .WithMany(p => p.PhaseParameters)
                    .HasForeignKey(d => d.PhaseParameterType)
                    .HasConstraintName("FK_PhaseParameter_PhaseParameterType");
            });

            modelBuilder.Entity<PhaseParameterType>(entity =>
            {
                entity.HasKey(e => e.PhaseParameterType1);

                entity.ToTable("PhaseParameterType", "web");

                entity.Property(e => e.PhaseParameterType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_parameter_type");

                entity.Property(e => e.PhaseParameterUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_parameter_unit");

                entity.HasOne(d => d.PhaseParameterUnitNavigation)
                    .WithMany(p => p.PhaseParameterTypes)
                    .HasForeignKey(d => d.PhaseParameterUnit)
                    .HasConstraintName("FK_PhaseParameterType_PhaseParameterUnit");
            });

            modelBuilder.Entity<PhaseParameterUnit>(entity =>
            {
                entity.HasKey(e => e.PhaseParameterUnit1);

                entity.ToTable("PhaseParameterUnit", "web");

                entity.Property(e => e.PhaseParameterUnit1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_parameter_unit");
            });

            modelBuilder.Entity<PhasePusher>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.PusherType, e.PusherIndex })
                    .HasName("PK_PhasePusher_1");

                entity.ToTable("PhasePusher", "web");

                entity.HasIndex(e => e.PhasePusherId, "IX_PhasePusher")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.PusherType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pusher_type");

                entity.Property(e => e.PusherIndex).HasColumnName("pusher_index");

                entity.Property(e => e.CompoundNameDeleteMe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name_DELETE_ME");

                entity.Property(e => e.PhaseDeleteMe).HasColumnName("phase_DELETE_ME");

                entity.Property(e => e.PhasePusherId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_pusher_ID");

                entity.Property(e => e.PusherValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pusher_value");

                entity.Property(e => e.StageDeleteMe).HasColumnName("stage_DELETE_ME");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhasePushers)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhasePusher_Phase");

                entity.HasOne(d => d.PusherTypeNavigation)
                    .WithMany(p => p.PhasePushers)
                    .HasPrincipalKey(p => p.PhasePusherTypeName)
                    .HasForeignKey(d => d.PusherType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhasePusher_PhasePusherType");
            });

            modelBuilder.Entity<PhasePusherTimingType>(entity =>
            {
                entity.HasKey(e => e.TimingType)
                    .HasName("PK_PhasePusheTimingType");

                entity.ToTable("PhasePusherTimingType", "web");

                entity.Property(e => e.TimingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timing_type")
                    .HasComment("Timing: 0=None, 1=Mix Time, 2=Temp, 3=KWH, 4=Phase Time");

                entity.Property(e => e.TimingTypeId).HasColumnName("timing_type_id");
            });

            modelBuilder.Entity<PhasePusherType>(entity =>
            {
                entity.ToTable("PhasePusherType", "web");

                entity.HasIndex(e => e.PhasePusherTypeName, "IX_PhasePusherType")
                    .IsUnique();

                entity.Property(e => e.PhasePusherTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Phase_Pusher_Type_ID");

                entity.Property(e => e.PhasePusherTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phase_Pusher_Type_Name");
            });

            modelBuilder.Entity<PhaseRamControl>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.RamControlIndex, e.RamControlType })
                    .HasName("PK_PhaseRamControl_1");

                entity.ToTable("PhaseRamControl", "web");

                entity.HasIndex(e => e.PhaseRamControlId, "IX_PhaseRamControl")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.RamControlIndex).HasColumnName("ram_control_index");

                entity.Property(e => e.RamControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ram_control_type");

                entity.Property(e => e.CompoundNameDeleteMe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name_DELETE_ME");

                entity.Property(e => e.PhaseDeleteMe).HasColumnName("phase_DELETE_ME");

                entity.Property(e => e.PhaseRamControlId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_ram_control_ID");

                entity.Property(e => e.RamControlValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ram_control_value");

                entity.Property(e => e.StageDeleteMe).HasColumnName("stage_DELETE_ME");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhaseRamControls)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseRamControl_Phase");

                entity.HasOne(d => d.RamControlTypeNavigation)
                    .WithMany(p => p.PhaseRamControls)
                    .HasForeignKey(d => d.RamControlType)
                    .HasConstraintName("FK_PhaseRamControl_RamControlType");
            });

            modelBuilder.Entity<PhaseTransition>(entity =>
            {
                entity.HasKey(e => new { e.PhaseId, e.Transition });

                entity.ToTable("PhaseTransition", "web");

                entity.HasIndex(e => e.PhaseTransitionId, "IX_PhaseTransition")
                    .IsUnique();

                entity.Property(e => e.PhaseId).HasColumnName("phase_id");

                entity.Property(e => e.Transition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transition");

                entity.Property(e => e.CompoundNameDeleteMe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name_DELETE_ME");

                entity.Property(e => e.PhaseDeleteMe).HasColumnName("phase_DELETE_ME");

                entity.Property(e => e.PhaseTransitionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("phase_transition_ID");

                entity.Property(e => e.StageDeleteMe).HasColumnName("stage_DELETE_ME");

                entity.Property(e => e.TransitionDuration).HasColumnName("transition_duration");

                entity.Property(e => e.TransitionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transition_type");

                entity.Property(e => e.TransitionValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("transition_value");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.PhaseTransitions)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhaseTransition_Phase");

                entity.HasOne(d => d.TransitionTypeNavigation)
                    .WithMany(p => p.PhaseTransitions)
                    .HasForeignKey(d => d.TransitionType)
                    .HasConstraintName("FK_PhaseTransition_TransitionType");
            });

            modelBuilder.Entity<PhaseType>(entity =>
            {
                entity.HasKey(e => e.PhaseType1);

                entity.ToTable("PhaseType", "web");

                entity.Property(e => e.PhaseType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phase_type");

                entity.Property(e => e.PhaseTypeId).HasColumnName("phase_type_id");
            });

            modelBuilder.Entity<PowerChartDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PowerChartData", "plc");

                entity.Property(e => e.PlcTime).HasColumnName("PLC_Time");

                entity.Property(e => e.TopMixerKwfromDrive).HasColumnName("TopMixerKWFromDrive");

                entity.Property(e => e.TopMixerKwh).HasColumnName("TopMixerKWH");
            });

            modelBuilder.Entity<Printing>(entity =>
            {
                entity.HasKey(e => e.LabelId)
                    .HasName("PK_MixerLabelPrinting");

                entity.ToTable("Printing", "label");

                entity.Property(e => e.LabelId).HasColumnName("label_id");

                entity.Property(e => e.AgeLimit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("age_limit");

                entity.Property(e => e.LabelPrinterId).HasColumnName("label_printer_id");

                entity.Property(e => e.LabelPrinterPrintedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("label_printer_printed_time");

                entity.Property(e => e.LabelPrinterSentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("label_printer_sent_time");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_number");

                entity.Property(e => e.ProductionDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("production_date");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quantity");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serial_number");

                entity.Property(e => e.WU)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("w_u");
            });

            modelBuilder.Entity<PrintingDefault>(entity =>
            {
                entity.HasKey(e => e.LabelPrinterId)
                    .HasName("PK_MixerLabelPrintingDefaults");

                entity.ToTable("PrintingDefaults", "label");

                entity.Property(e => e.LabelPrinterId)
                    .ValueGeneratedNever()
                    .HasColumnName("label_printer_id");

                entity.Property(e => e.LabelPrinterIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label_printer_ip");

                entity.Property(e => e.LabelPrinterLabelData)
                    .IsUnicode(false)
                    .HasColumnName("label_printer_label_data");

                entity.Property(e => e.LabelPrinterPort).HasColumnName("label_printer_port");
            });

            modelBuilder.Entity<RamControlType>(entity =>
            {
                entity.HasKey(e => e.RamControlType1);

                entity.ToTable("RamControlType", "web");

                entity.Property(e => e.RamControlType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ram_control_type");
            });

            modelBuilder.Entity<RamTimingType>(entity =>
            {
                entity.HasKey(e => e.TimingType);

                entity.ToTable("RamTimingType", "web");

                entity.HasIndex(e => e.TimingTypeId, "IX_RamTimingType")
                    .IsUnique();

                entity.Property(e => e.TimingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timing_type");

                entity.Property(e => e.TimingTypeId).HasColumnName("timing_type_id");
            });

            modelBuilder.Entity<Scan>(entity =>
            {
                entity.ToTable("Scan", "barcode");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id");

                entity.Property(e => e.ScanClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_class_id");

                entity.Property(e => e.ScanDescription)
                    .IsUnicode(false)
                    .HasColumnName("scan_description");

                entity.Property(e => e.ScanEnabled).HasColumnName("scan_enabled");

                entity.Property(e => e.ScanName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scan_name");

                entity.Property(e => e.ScanValueRelease).HasColumnName("scan_value_release");

                entity.Property(e => e.ScanValueRetention).HasColumnName("scan_value_retention");

                entity.HasOne(d => d.ScanClass)
                    .WithMany(p => p.Scans)
                    .HasForeignKey(d => d.ScanClassId)
                    .HasConstraintName("FK_Scan_ScanType");

                entity.HasMany(d => d.Validates)
                    .WithMany(p => p.Scans)
                    .UsingEntity<Dictionary<string, object>>(
                        "ScanValidate",
                        l => l.HasOne<Validate>().WithMany().HasForeignKey("ValidateId").HasConstraintName("FK_ScanValidate_Validate"),
                        r => r.HasOne<Scan>().WithMany().HasForeignKey("ScanId").HasConstraintName("FK_ScanValidate_Scan"),
                        j =>
                        {
                            j.HasKey("ScanId", "ValidateId");

                            j.ToTable("ScanValidate", "barcode");

                            j.IndexerProperty<string>("ScanId").HasMaxLength(50).IsUnicode(false).HasColumnName("scan_id");

                            j.IndexerProperty<string>("ValidateId").HasMaxLength(50).IsUnicode(false).HasColumnName("validate_id");
                        });
            });

            modelBuilder.Entity<ScanAction>(entity =>
            {
                entity.HasKey(e => new { e.ScanId, e.ActionId, e.ActionOrder })
                    .HasName("PK_ScanAction");

                entity.ToTable("ScanActions", "barcode");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_id");

                entity.Property(e => e.ActionOrder).HasColumnName("action_order");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ScanActions)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_ScanAction_Action");

                entity.HasOne(d => d.Scan)
                    .WithMany(p => p.ScanActions)
                    .HasForeignKey(d => d.ScanId)
                    .HasConstraintName("FK_ScanAction_Scan");
            });

            modelBuilder.Entity<ScanClass>(entity =>
            {
                entity.ToTable("ScanClass", "barcode");

                entity.Property(e => e.ScanClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_class_id");

                entity.Property(e => e.ScanClassDescription)
                    .IsUnicode(false)
                    .HasColumnName("scan_class_description");

                entity.Property(e => e.ScanClassName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scan_class_name");
            });

            modelBuilder.Entity<ScanOption>(entity =>
            {
                entity.HasKey(e => new { e.ScanId, e.OptionId, e.OptionOrder });

                entity.ToTable("ScanOptions", "barcode");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id");

                entity.Property(e => e.OptionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_id");

                entity.Property(e => e.OptionOrder).HasColumnName("option_order");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.ScanOptions)
                    .HasForeignKey(d => d.OptionId)
                    .HasConstraintName("FK_ScanOptions_Option");

                entity.HasOne(d => d.Scan)
                    .WithMany(p => p.ScanOptions)
                    .HasForeignKey(d => d.ScanId)
                    .HasConstraintName("FK_ScanOptions_Scan");
            });

            modelBuilder.Entity<ScannedValue>(entity =>
            {
                entity.ToTable("ScannedValues", "barcode");

                entity.HasComment("Logs all of the scans that occur in the system, including value and other properties that describe the actual (single) scan.");

                entity.Property(e => e.ScannedValueId)
                    .HasColumnName("scanned_value_id")
                    .HasComment("Identity integer used as PK for the table.");

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasComment("The Location ID from the Location table associated with the scanned value");

                entity.Property(e => e.OperationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operation_id")
                    .HasComment("The OPERATION ID that was being executed when the Scan collected the scanned value.");

                entity.Property(e => e.ScanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_id")
                    .HasComment("The SCAN ID of the Scan that collected the scanned value.");

                entity.Property(e => e.ScanStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scan_status")
                    .HasComment("The status of the scan (Pass or Fail)");

                entity.Property(e => e.ScanValueReleased)
                    .IsRequired()
                    .HasColumnName("scan_value_released")
                    .HasDefaultValueSql("((1))")
                    .HasComment("A true or false indicator to let us know if the value was programitcally released within the system.  It is used to drive the RELASE and CLEAR functionality of a pre-scan.");

                entity.Property(e => e.ScannedValue1)
                    .HasColumnName("scanned_value")
                    .HasComment("The actual value that was collected.");

                entity.Property(e => e.ScannedValueTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("scanned_value_timestamp")
                    .HasComment("The date and time (from web app) that the scanned value was collected.");

                entity.Property(e => e.ScannerId)
                    .HasMaxLength(128)
                    .HasColumnName("scanner_id")
                    .HasComment("The SCANNER ID from the Scanner table that indicates the Scanner used to collect the ScannedValue");

                entity.Property(e => e.StatusMessage)
                    .IsUnicode(false)
                    .HasColumnName("status_message")
                    .HasComment("Optional status message (for Fail only?) associated with the collection of the scanned value.");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ScannedValues)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Results_Location");

                entity.HasOne(d => d.Scan)
                    .WithMany(p => p.ScannedValues)
                    .HasForeignKey(d => d.ScanId)
                    .HasConstraintName("FK_Results_Scan");

                entity.HasOne(d => d.Scanner)
                    .WithMany(p => p.ScannedValues)
                    .HasForeignKey(d => d.ScannerId)
                    .HasConstraintName("FK_Results_Scanner");
            });

            modelBuilder.Entity<Scanner>(entity =>
            {
                entity.ToTable("Scanner", "barcode");

                entity.Property(e => e.ScannerId)
                    .HasMaxLength(128)
                    .HasColumnName("scanner_id");

                entity.Property(e => e.ScannerDescription)
                    .IsUnicode(false)
                    .HasColumnName("scanner_description");

                entity.Property(e => e.ScannerEnabled).HasColumnName("scanner_enabled");

                entity.Property(e => e.ScannerGroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scanner_group_id");

                entity.Property(e => e.ScannerHeartbeat)
                    .HasColumnType("datetime")
                    .HasColumnName("scanner_heartbeat");

                entity.Property(e => e.ScannerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scanner_name");

                entity.HasOne(d => d.ScannerGroup)
                    .WithMany(p => p.Scanners)
                    .HasForeignKey(d => d.ScannerGroupId)
                    .HasConstraintName("FK_Scanner_ScannerGroup");

                entity.HasMany(d => d.Locations)
                    .WithMany(p => p.Scanners)
                    .UsingEntity<Dictionary<string, object>>(
                        "ScannerLocation",
                        l => l.HasOne<Location>().WithMany().HasForeignKey("LocationId").HasConstraintName("FK_ScannerLocations_Location"),
                        r => r.HasOne<Scanner>().WithMany().HasForeignKey("ScannerId").HasConstraintName("FK_ScannerLocations_Scanner"),
                        j =>
                        {
                            j.HasKey("ScannerId", "LocationId");

                            j.ToTable("ScannerLocations", "barcode");

                            j.IndexerProperty<string>("ScannerId").HasMaxLength(128).HasColumnName("scanner_id");

                            j.IndexerProperty<int>("LocationId").HasColumnName("location_id");
                        });

                entity.HasMany(d => d.Operations)
                    .WithMany(p => p.Scanners)
                    .UsingEntity<Dictionary<string, object>>(
                        "ScannerOperation",
                        l => l.HasOne<Operation>().WithMany().HasForeignKey("OperationId").HasConstraintName("FK_ScannerOperations_Operation"),
                        r => r.HasOne<Scanner>().WithMany().HasForeignKey("ScannerId").HasConstraintName("FK_ScannerOperations_Scanner"),
                        j =>
                        {
                            j.HasKey("ScannerId", "OperationId");

                            j.ToTable("ScannerOperations", "barcode");

                            j.IndexerProperty<string>("ScannerId").HasMaxLength(128).HasColumnName("scanner_id");

                            j.IndexerProperty<string>("OperationId").HasMaxLength(50).IsUnicode(false).HasColumnName("operation_id");
                        });
            });

            modelBuilder.Entity<ScannerGroup>(entity =>
            {
                entity.ToTable("ScannerGroup", "barcode");

                entity.Property(e => e.ScannerGroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scanner_group_id");

                entity.Property(e => e.ScannerGroupDescription)
                    .IsUnicode(false)
                    .HasColumnName("scanner_group_description");

                entity.Property(e => e.ScannerGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("scanner_group_name");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule", "web");

                entity.Property(e => e.ScheduleId).HasColumnName("schedule_ID");

                entity.Property(e => e.ChuteLevel)
                    .HasColumnName("chute_level")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompoundName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name");

                entity.Property(e => e.ErrorFlag).HasColumnName("error_flag");

                entity.Property(e => e.IsManualRecipeDownload)
                    .HasColumnName("is_manual_recipe_download")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRecipeDownloadVerifiedOk).HasColumnName("is_recipe_download_verified_ok");

                entity.Property(e => e.LotNumber).HasColumnName("lot_number");

                entity.Property(e => e.LotStart)
                    .HasColumnType("datetime")
                    .HasColumnName("lot_start");

                entity.Property(e => e.LotStatus)
                    .HasColumnName("lot_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecipeDownloadStart).HasColumnName("recipe_download_start");

                entity.Property(e => e.RecipeDownloadVerified).HasColumnName("recipe_download_verified");

                entity.Property(e => e.ScheduleAssigned)
                    .HasColumnType("datetime")
                    .HasColumnName("schedule_assigned");

                entity.Property(e => e.ScheduleBatches).HasColumnName("schedule_batches");

                entity.Property(e => e.ScheduleErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("schedule_error_message");

                entity.Property(e => e.ScheduleNumber).HasColumnName("schedule_number");

                entity.Property(e => e.ScheduleNumberOriginal).HasColumnName("schedule_number_original");

                entity.Property(e => e.ScheduleSkid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("schedule_skid");

                entity.Property(e => e.ScheduleStart).HasColumnName("schedule_start");
            });

            modelBuilder.Entity<SecurityObject>(entity =>
            {
                entity.HasIndex(e => e.SecurityObjectName, "IX_SecurityObjects")
                    .IsUnique();

                entity.Property(e => e.SecurityObjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("Security_Object_ID");

                entity.Property(e => e.SecurityObjectDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Object_Description");

                entity.Property(e => e.SecurityObjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Security_Object_Name");
            });

            modelBuilder.Entity<SecurityObjectRole>(entity =>
            {
                entity.HasKey(e => e.SecurityObjectRoleId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.SecurityObjectId, e.SecurityRoleId }, "IX_SecurityObjectRoles")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.SecurityObjectRoleId).HasColumnName("Security_Object_Role_ID");

                entity.Property(e => e.IsEditEnabled).HasColumnName("Is_Edit_Enabled");

                entity.Property(e => e.IsViewable).HasColumnName("Is_Viewable");

                entity.Property(e => e.SecurityObjectId).HasColumnName("Security_Object_ID");

                entity.Property(e => e.SecurityRoleId).HasColumnName("Security_Role_ID");

                entity.HasOne(d => d.SecurityObject)
                    .WithMany(p => p.SecurityObjectRoles)
                    .HasForeignKey(d => d.SecurityObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecurityObjectRoles_SecurityObjects");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.SecurityObjectRoles)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecurityObjectRoles_SecurityRoles");
            });

            modelBuilder.Entity<SecurityOperator>(entity =>
            {
                entity.HasKey(e => e.OperatorId);

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.IsOperatorEnabled).HasColumnName("Is_Operator_Enabled");

                entity.Property(e => e.LastLoginTimeStamp).HasColumnName("Last_Login_Time_Stamp");

                entity.Property(e => e.NetworkUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Network_User_ID");

                entity.Property(e => e.OperatorLoginIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Operator_Login_Identifier");

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Operator_Name");

                entity.Property(e => e.OperatorPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Operator_Password");

                entity.Property(e => e.UpdatedTimeStamp)
                    .HasColumnName("Updated_Time_Stamp")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasMany(d => d.SecurityRoles)
                    .WithMany(p => p.Operators)
                    .UsingEntity<Dictionary<string, object>>(
                        "SecurityOperatorRole",
                        l => l.HasOne<SecurityRole>().WithMany().HasForeignKey("SecurityRoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SecurityOperatorRoles_SecurityRoles"),
                        r => r.HasOne<SecurityOperator>().WithMany().HasForeignKey("OperatorId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SecurityOperatorRoles_SecurityOperators"),
                        j =>
                        {
                            j.HasKey("OperatorId", "SecurityRoleId");

                            j.ToTable("SecurityOperatorRoles");

                            j.IndexerProperty<int>("OperatorId").HasColumnName("Operator_ID");

                            j.IndexerProperty<short>("SecurityRoleId").HasColumnName("Security_Role_ID");
                        });
            });

            modelBuilder.Entity<SecurityRole>(entity =>
            {
                entity.HasIndex(e => e.SecurityRoleName, "IX_SecurityRoles")
                    .IsUnique();

                entity.Property(e => e.SecurityRoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Security_Role_ID");

                entity.Property(e => e.IsControlComputerRole).HasColumnName("Is_Control_Computer_Role");

                entity.Property(e => e.IsMasterRole)
                    .HasColumnName("Is_Master_Role")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecurityRoleDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Security_Role_Description");

                entity.Property(e => e.SecurityRoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Security_Role_Name");
            });

            modelBuilder.Entity<ServerHeartbeat>(entity =>
            {
                entity.ToTable("ServerHeartbeat", "plc");

                entity.Property(e => e.ServerHeartbeatId)
                    .ValueGeneratedNever()
                    .HasColumnName("Server_Heartbeat_ID");

                entity.Property(e => e.DxcCurrentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DXC_Current_Time");

                entity.Property(e => e.PlcCurrentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("PLC_Current_Time");

                entity.Property(e => e.PlcEventBufferPosition).HasColumnName("PLC_Event_Buffer_Position");

                entity.Property(e => e.PlcEventBufferPositionMax).HasColumnName("PLC_Event_Buffer_Position_Max");

                entity.Property(e => e.PlcEventBufferPositionMaxResetTime)
                    .HasColumnType("datetime")
                    .HasColumnName("PLC_Event_Buffer_Position_Max_Reset_Time");

                entity.Property(e => e.PlcEventBufferPositionMaxUpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("PLC_Event_Buffer_Position_Max_Update_Time");

                entity.Property(e => e.PlcMixerStatus).HasColumnName("PLC_Mixer_Status");

                entity.Property(e => e.RslinxCurrentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("RSLinx_Current_Time");

                entity.Property(e => e.RslinxIsPresent).HasColumnName("RSLinx_IsPresent");

                entity.Property(e => e.RslinxMode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RSLinx_Mode");

                entity.Property(e => e.RslinxStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RSLinx_Status");

                entity.Property(e => e.SqlCurrentTime).HasColumnName("SQL_Current_Time");

                entity.Property(e => e.TransactionNumber).HasColumnName("Transaction_Number");
            });

            modelBuilder.Entity<Stage>(entity =>
            {
                entity.HasKey(e => new { e.CompoundName, e.Stage1 });

                entity.ToTable("Stage", "web");

                entity.Property(e => e.CompoundName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compound_name");

                entity.Property(e => e.Stage1).HasColumnName("stage");

                entity.Property(e => e.EquipmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipment_name");

                entity.Property(e => e.MaximumTime).HasColumnName("maximum_time");

                entity.Property(e => e.MinimumTime).HasColumnName("minimum_time");

                entity.HasOne(d => d.EquipmentNameNavigation)
                    .WithMany(p => p.Stages)
                    .HasForeignKey(d => d.EquipmentName)
                    .HasConstraintName("FK_Stage_Equipment");
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("SystemLog", "web");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogDevice)
                    .HasMaxLength(150)
                    .HasColumnName("log_device");

                entity.Property(e => e.LogEvent)
                    .HasMaxLength(50)
                    .HasColumnName("log_event");

                entity.Property(e => e.LogItem).HasColumnName("log_item");

                entity.Property(e => e.LogTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("log_timestamp");

                entity.HasOne(d => d.LogEventNavigation)
                    .WithMany(p => p.SystemLogs)
                    .HasForeignKey(d => d.LogEvent)
                    .HasConstraintName("FK_SystemLog_SystemLogEvent");
            });

            modelBuilder.Entity<SystemLogEvent>(entity =>
            {
                entity.HasKey(e => e.LogEvent);

                entity.ToTable("SystemLogEvent", "web");

                entity.Property(e => e.LogEvent)
                    .HasMaxLength(50)
                    .HasColumnName("log_event");

                entity.Property(e => e.LogEventDescription).HasColumnName("log_event_description");

                entity.Property(e => e.LogLevel)
                    .HasMaxLength(50)
                    .HasColumnName("log_level");

                entity.Property(e => e.LogSource)
                    .HasMaxLength(50)
                    .HasColumnName("log_source");

                entity.HasOne(d => d.LogLevelNavigation)
                    .WithMany(p => p.SystemLogEvents)
                    .HasForeignKey(d => d.LogLevel)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SystemLogEvent_SystemLogLevel");

                entity.HasOne(d => d.LogSourceNavigation)
                    .WithMany(p => p.SystemLogEvents)
                    .HasForeignKey(d => d.LogSource)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SystemLogEvent_SystemLogSource");
            });

            modelBuilder.Entity<SystemLogLevel>(entity =>
            {
                entity.HasKey(e => e.LogLevel);

                entity.ToTable("SystemLogLevel", "web");

                entity.Property(e => e.LogLevel)
                    .HasMaxLength(50)
                    .HasColumnName("log_level");
            });

            modelBuilder.Entity<SystemLogName>(entity =>
            {
                entity.HasKey(e => e.LogName);

                entity.ToTable("SystemLogName", "web");

                entity.Property(e => e.LogName)
                    .HasMaxLength(50)
                    .HasColumnName("log_name");
            });

            modelBuilder.Entity<SystemLogSource>(entity =>
            {
                entity.HasKey(e => e.LogSource);

                entity.ToTable("SystemLogSource", "web");

                entity.Property(e => e.LogSource)
                    .HasMaxLength(50)
                    .HasColumnName("log_source");

                entity.Property(e => e.LogName)
                    .HasMaxLength(50)
                    .HasColumnName("log_name");

                entity.HasOne(d => d.LogNameNavigation)
                    .WithMany(p => p.SystemLogSources)
                    .HasForeignKey(d => d.LogName)
                    .HasConstraintName("FK_SystemLogSource_SystemLogName");
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterName);

                entity.ToTable("SystemParameter", "barcode");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_name");

                entity.Property(e => e.ParameterChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("parameter_changed");

                entity.Property(e => e.ParameterValue)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value");
            });

            modelBuilder.Entity<SystemParameter1>(entity =>
            {
                entity.HasKey(e => e.ParameterName);

                entity.ToTable("SystemParameter", "web");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter_name");

                entity.Property(e => e.ParameterValue)
                    .IsUnicode(false)
                    .HasColumnName("parameter_value");
            });

            modelBuilder.Entity<TandemRunLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TandemRunLog", "WIL");

                entity.HasIndex(e => new { e.Mixer, e.StartTime, e.Ibmnumber }, "idx_Mixer_StartTime_RunId");

                entity.Property(e => e.Compound)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Ibmnumber).HasColumnName("IBMNumber");

                entity.Property(e => e.Mixer)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RunNumber)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sapusage)
                    .HasColumnType("datetime")
                    .HasColumnName("SAPUsage");

                entity.Property(e => e.SpecBatchWeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TagPrint).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasKey(e => new { e.Timestamp, e.ScannerId });

                entity.ToTable("TestTable");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.ScannerId)
                    .HasMaxLength(128)
                    .HasColumnName("scanner_id");

                entity.Property(e => e.TestValue)
                    .HasMaxLength(50)
                    .HasColumnName("test_value");
            });

            modelBuilder.Entity<TransitionType>(entity =>
            {
                entity.HasKey(e => e.TransitionType1);

                entity.ToTable("TransitionType", "web");

                entity.Property(e => e.TransitionType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transition_type");

                entity.Property(e => e.TransitionTypeId).HasColumnName("transition_type_id");
            });

            modelBuilder.Entity<Udtstructure>(entity =>
            {
                entity.HasKey(e => e.UdtSection);

                entity.ToTable("UDTStructure", "plc");

                entity.Property(e => e.UdtSection)
                    .HasMaxLength(50)
                    .HasColumnName("udt_section");

                entity.Property(e => e.UdtMaximum).HasColumnName("udt_maximum");

                entity.Property(e => e.UdtMinimum).HasColumnName("udt_minimum");
            });

            modelBuilder.Entity<Validate>(entity =>
            {
                entity.ToTable("Validate", "barcode");

                entity.Property(e => e.ValidateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validate_id");

                entity.Property(e => e.ValidateName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("validate_name");

                entity.Property(e => e.ValidateSproc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validate_sproc");
            });

            modelBuilder.HasSequence<int>("SequenceInitialSource", "plc")
                .HasMin(1)
                .HasMax(30000)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
