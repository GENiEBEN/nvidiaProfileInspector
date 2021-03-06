﻿using nspector.Native.NVAPI2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nspector.Common.Meta
{
    internal class SettingMeta
    {
        public NVDRS_SETTING_TYPE? SettingType { get; set; }

        public string GroupName { get; set; }

        public string SettingName { get; set; }

        public string DefaultStringValue { get; set; }

        public uint DefaultDwordValue { get; set; }

        public List<SettingValue<string>> StringValues { get; set; }

        public List<SettingValue<uint>> DwordValues { get; set; }
    }
}
