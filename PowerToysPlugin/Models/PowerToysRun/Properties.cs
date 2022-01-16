using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.PowerToysRun
{
    public class Properties
    {
        [JsonProperty("search_result_preference")]
        public string SearchResultPreference { get; set; }

        [JsonProperty("search_type_preference")]
        public string SearchTypePreference { get; set; }

        [JsonProperty("maximum_number_of_results")]
        public int MaximumNumberOfResults { get; set; }

        [JsonProperty("open_powerlauncher")]
        public OpenPowerlauncher OpenPowerlauncher { get; set; }

        [JsonProperty("open_file_location")]
        public OpenFileLocation OpenFileLocation { get; set; }

        [JsonProperty("copy_path_location")]
        public CopyPathLocation CopyPathLocation { get; set; }

        [JsonProperty("open_console")]
        public OpenConsole OpenConsole { get; set; }

        [JsonProperty("override_win_r_key")]
        public bool OverrideWinRKey { get; set; }

        [JsonProperty("override_win_s_key")]
        public bool OverrideWinSKey { get; set; }

        [JsonProperty("ignore_hotkeys_in_fullscreen")]
        public bool IgnoreHotkeysInFullscreen { get; set; }

        [JsonProperty("clear_input_on_launch")]
        public bool ClearInputOnLaunch { get; set; }

        [JsonProperty("theme")]
        public int Theme { get; set; }

        [JsonProperty("startupPosition")]
        public int StartupPosition { get; set; }

        [JsonProperty("use_centralized_keyboard_hook")]
        public bool UseCentralizedKeyboardHook { get; set; }
    }
}