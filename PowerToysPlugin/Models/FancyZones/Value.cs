﻿using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class Value : IKeyboardShortcut
    {
        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("ctrl")]
        public bool Ctrl { get; set; }

        [JsonProperty("alt")]
        public bool Alt { get; set; }

        [JsonProperty("shift")]
        public bool Shift { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}