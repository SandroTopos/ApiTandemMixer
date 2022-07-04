using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class ErrorLog
    {
        /// <summary>
        /// [Identity]
        /// </summary>
        public long ErrorLogId { get; set; }
        /// <summary>
        /// [Cluster] Error Time
        /// </summary>
        public DateTimeOffset? ErrorTime { get; set; }
        /// <summary>
        /// SQL Error Number
        /// </summary>
        public int? ErrorNumber { get; set; }
        /// <summary>
        /// SQL Error Severity
        /// </summary>
        public int? ErrorSeverity { get; set; }
        /// <summary>
        /// SQL Error State
        /// </summary>
        public int? ErrorState { get; set; }
        /// <summary>
        /// Procedure that generated error
        /// </summary>
        public string? ErrorProcedure { get; set; }
        /// <summary>
        /// Error Line Number in Procedure
        /// </summary>
        public int? ErrorLineNumber { get; set; }
        /// <summary>
        /// SQL Error Message
        /// </summary>
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Extra Information Provided by Procedure
        /// </summary>
        public string? ErrorExtraInfo { get; set; }
    }
}
