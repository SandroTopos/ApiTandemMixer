using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class DownloadedCompoundHeaderReturned
    {
        public long Id { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public string? Operation { get; set; }
        public long? OperationInstance { get; set; }
        public string? Transfer { get; set; }
        public int? ServerIdbegin { get; set; }
        public int? ServerIdend { get; set; }
        public int? FormulaNumNumOfBatches { get; set; }
        public int? FormulaNumSampleFrequency { get; set; }
        public int? FormulaNumChuteLevel { get; set; }
        public int? FormulaNumProcessCounts { get; set; }
        public int? FormulaNumTopMixerTcuzone1Sp { get; set; }
        public int? FormulaNumTopMixerTcuzone2Sp { get; set; }
        public int? FormulaNumTopMixerTcuzone3Sp { get; set; }
        public int? FormulaNumBottomMixerTcuzone1Sp { get; set; }
        public int? FormulaNumBottomMixerTcuzone2Sp { get; set; }
        public int? FormulaNumBottomMixerTcuzone3Sp { get; set; }
        public int? FormulaNumTdetcuzone1Sp { get; set; }
        public int? FormulaNumTdetcuzone2Sp { get; set; }
        public int? FormulaNumTdetcuzone3Sp { get; set; }
        public int? FormulaNumTdetcuzone4Sp { get; set; }
        public string? FormulaNumCompoundName { get; set; }
        public string? FormulaNumVersionDate { get; set; }
        public float? BatchOffExtruderSpeed { get; set; }
        public float? BatchOffPullOffDrawPct { get; set; }
        public string? BatchOffSkidBarcode { get; set; }
    }
}
