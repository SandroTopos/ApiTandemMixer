using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ServerHeartbeat
    {
        public int ServerHeartbeatId { get; set; }
        public long? TransactionNumber { get; set; }
        public int? PlcMixerStatus { get; set; }
        public int? PlcEventBufferPosition { get; set; }
        public int? PlcEventBufferPositionMax { get; set; }
        public DateTime? PlcEventBufferPositionMaxUpdateTime { get; set; }
        public DateTime? PlcEventBufferPositionMaxResetTime { get; set; }
        public DateTime? PlcCurrentTime { get; set; }
        public DateTimeOffset? SqlCurrentTime { get; set; }
        public DateTime? DxcCurrentTime { get; set; }
        public DateTime? RslinxCurrentTime { get; set; }
        public int? RslinxIsPresent { get; set; }
        public string? RslinxStatus { get; set; }
        public string? RslinxMode { get; set; }
    }
}
