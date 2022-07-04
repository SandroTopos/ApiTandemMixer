using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public int ScheduleNumber { get; set; }
        public int? LotNumber { get; set; }
        public DateTime? ScheduleAssigned { get; set; }
        public int? ScheduleNumberOriginal { get; set; }
        public string CompoundName { get; set; } = null!;
        public short ScheduleBatches { get; set; }
        public DateTimeOffset? ScheduleStart { get; set; }
        public DateTimeOffset? RecipeDownloadStart { get; set; }
        public DateTimeOffset? RecipeDownloadVerified { get; set; }
        public bool? IsRecipeDownloadVerifiedOk { get; set; }
        public bool? IsManualRecipeDownload { get; set; }
        public DateTime? LotStart { get; set; }
        public string? ScheduleSkid { get; set; }
        public short? ErrorFlag { get; set; }
        public short? LotStatus { get; set; }
        public int? ChuteLevel { get; set; }
        public string? ScheduleErrorMessage { get; set; }
    }
}
