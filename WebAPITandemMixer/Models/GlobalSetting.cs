using System;
using System.Collections.Generic;

namespace WebAPITandemMixer.Models
{
    public partial class GlobalSetting
    {
        public string GlobalSettingName { get; set; } = null!;
        /// <summary>
        /// STRING, INT, BIT
        /// </summary>
        public string GlobalSettingDataType { get; set; } = null!;
        public string? GlobalSettingValueString { get; set; }
        public int? GlobalSettingValueInt { get; set; }
        public bool? GlobalSettingValueBit { get; set; }
        public string? GlobalSettingValueDefault { get; set; }
        /// <summary>
        /// Min Value setting for Int
        /// </summary>
        public int? GlobalSettingValueIntMin { get; set; }
        /// <summary>
        /// Max Value setting for Int
        /// </summary>
        public int? GlobalSettingValueIntMax { get; set; }
        public bool? IsGlobalSettingUserVisible { get; set; }
        public bool? IsGlobalSettingUserEditEnabled { get; set; }
        public bool? IsGlobalSettingApplicationSetting { get; set; }
        public short? GlobalSettingUserGroupId { get; set; }
        public string? GlobalSettingUserGroupName { get; set; }
        public short? GlobalSettingUserItemSort { get; set; }
        public string? GlobalSettingUserDescription { get; set; }
        public string? GlobalSettingValueDescription { get; set; }
    }
}
