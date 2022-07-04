using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class DownloadedCompoundPhasesBottomReturnedError
    {
        public long Id { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public string? Operation { get; set; }
        public long? OperationInstance { get; set; }
        public string? Transfer { get; set; }
        public int PhaseNumber { get; set; }
        public short? BottomMixerPhasePhaseType { get; set; }
        public string? BottomMixerPhasePhaseDescription { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPhaseTransition0Variable { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseTransition0Value { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseTransition0Duration { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPhaseTransition1Variable { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseTransition1Value { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseTransition1Duration { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPhaseTransition2Variable { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseTransition2Value { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseTransition2Duration { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPhaseCheck0Type { get; set; }
        public int? BottomMixerPhaseBottomMixParametersPhaseCheck0TriggerTime { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseCheck0Min { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseCheck0Max { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPhaseCheck1Type { get; set; }
        public int? BottomMixerPhaseBottomMixParametersPhaseCheck1TriggerTime { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseCheck1Min { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseCheck1Max { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPhaseCheck2Type { get; set; }
        public int? BottomMixerPhaseBottomMixParametersPhaseCheck2TriggerTime { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseCheck2Min { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPhaseCheck2Max { get; set; }
        public int? BottomMixerPhaseBottomMixParametersGateDwell { get; set; }
        public int? BottomMixerPhaseBottomMixParametersMinPhaseTime { get; set; }
        public int? BottomMixerPhaseBottomMixParametersMaxPhaseTime { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMaxPhaseTemp { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMaxPhaseKwh { get; set; }
        public float? BottomMixerPhaseBottomMixParametersDtctempTarget { get; set; }
        public float? BottomMixerPhaseBottomMixParametersDtctempMin { get; set; }
        public float? BottomMixerPhaseBottomMixParametersDtctempMax { get; set; }
        public float? BottomMixerPhaseBottomMixParametersDtcspeedTarget { get; set; }
        public float? BottomMixerPhaseBottomMixParametersDtcspeedMin { get; set; }
        public float? BottomMixerPhaseBottomMixParametersDtcspeedMax { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPusherControl0TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPusherControl0TimingValue { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPusherControl1TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPusherControl1TimingValue { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPusherControl2TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPusherControl2TimingValue { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPusherControl3TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPusherControl3TimingValue { get; set; }
        public short? BottomMixerPhaseBottomMixParametersPusherControl4TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersPusherControl4TimingValue { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed0MixerSpeed { get; set; }
        public short? BottomMixerPhaseBottomMixParametersMixerSpeed0TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed0TimingValue { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed1MixerSpeed { get; set; }
        public short? BottomMixerPhaseBottomMixParametersMixerSpeed1TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed1TimingValue { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed2MixerSpeed { get; set; }
        public short? BottomMixerPhaseBottomMixParametersMixerSpeed2TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed2TimingValue { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed3MixerSpeed { get; set; }
        public short? BottomMixerPhaseBottomMixParametersMixerSpeed3TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed3TimingValue { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed4MixerSpeed { get; set; }
        public short? BottomMixerPhaseBottomMixParametersMixerSpeed4TimingType { get; set; }
        public float? BottomMixerPhaseBottomMixParametersMixerSpeed4TimingValue { get; set; }
        public bool? BottomMixerPhaseBottomMixIngredientsChuteSkipStep { get; set; }
        public int? BottomMixerPhaseBottomMixIngredientsChuteMaterialBinSource { get; set; }
        public float? BottomMixerPhaseBottomMixIngredientsChuteTargetWeight { get; set; }
        public float? BottomMixerPhaseBottomMixIngredientsChuteWeightPlusTol { get; set; }
        public float? BottomMixerPhaseBottomMixIngredientsChuteWeightMinusTol { get; set; }
        public short? BottomMixerPhaseBottomMixIngredientsChuteTimingType { get; set; }
        public float? BottomMixerPhaseBottomMixIngredientsChuteTimingValue { get; set; }
        public string? BottomMixerPhaseBottomMixIngredientsChuteMaterialType { get; set; }
    }
}
