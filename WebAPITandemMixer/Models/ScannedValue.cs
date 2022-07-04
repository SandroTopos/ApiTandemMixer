using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    /// <summary>
    /// Logs all of the scans that occur in the system, including value and other properties that describe the actual (single) scan.
    /// </summary>
    public partial class ScannedValue
    {
        /// <summary>
        /// Identity integer used as PK for the table.
        /// </summary>
        public long ScannedValueId { get; set; }
        /// <summary>
        /// The SCANNER ID from the Scanner table that indicates the Scanner used to collect the ScannedValue
        /// </summary>
        public string ScannerId { get; set; } = null!;
        /// <summary>
        /// The Location ID from the Location table associated with the scanned value
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// The OPERATION ID that was being executed when the Scan collected the scanned value.
        /// </summary>
        public string OperationId { get; set; } = null!;
        /// <summary>
        /// The SCAN ID of the Scan that collected the scanned value.
        /// </summary>
        public string ScanId { get; set; } = null!;
        /// <summary>
        /// The date and time (from web app) that the scanned value was collected.
        /// </summary>
        public DateTime ScannedValueTimestamp { get; set; }
        /// <summary>
        /// The actual value that was collected.
        /// </summary>
        public string ScannedValue1 { get; set; } = null!;
        /// <summary>
        /// The status of the scan (Pass or Fail)
        /// </summary>
        public string ScanStatus { get; set; } = null!;
        /// <summary>
        /// Optional status message (for Fail only?) associated with the collection of the scanned value.
        /// </summary>
        public string? StatusMessage { get; set; }
        /// <summary>
        /// A true or false indicator to let us know if the value was programitcally released within the system.  It is used to drive the RELASE and CLEAR functionality of a pre-scan.
        /// </summary>
        public bool? ScanValueReleased { get; set; }

        public virtual Location Location { get; set; } = null!;
        public virtual Scan Scan { get; set; } = null!;
        public virtual Scanner Scanner { get; set; } = null!;
    }
}
