using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class Properties
    {
        [JsonProperty("fancyzones_shiftDrag")]
        public FancyzonesShiftDrag FancyzonesShiftDrag { get; set; }

        [JsonProperty("fancyzones_mouseSwitch")]
        public FancyzonesMouseSwitch FancyzonesMouseSwitch { get; set; }

        [JsonProperty("fancyzones_overrideSnapHotkeys")]
        public FancyzonesOverrideSnapHotkeys FancyzonesOverrideSnapHotkeys { get; set; }

        [JsonProperty("fancyzones_moveWindowAcrossMonitors")]
        public FancyzonesMoveWindowAcrossMonitors FancyzonesMoveWindowAcrossMonitors { get; set; }

        [JsonProperty("fancyzones_moveWindowsBasedOnPosition")]
        public FancyzonesMoveWindowsBasedOnPosition FancyzonesMoveWindowsBasedOnPosition { get; set; }

        [JsonProperty("fancyzones_overlappingZonesAlgorithm")]
        public FancyzonesOverlappingZonesAlgorithm FancyzonesOverlappingZonesAlgorithm { get; set; }

        [JsonProperty("fancyzones_displayChange_moveWindows")]
        public FancyzonesDisplayChangeMoveWindows FancyzonesDisplayChangeMoveWindows { get; set; }

        [JsonProperty("fancyzones_zoneSetChange_moveWindows")]
        public FancyzonesZoneSetChangeMoveWindows FancyzonesZoneSetChangeMoveWindows { get; set; }

        [JsonProperty("fancyzones_appLastZone_moveWindows")]
        public FancyzonesAppLastZoneMoveWindows FancyzonesAppLastZoneMoveWindows { get; set; }

        [JsonProperty("fancyzones_openWindowOnActiveMonitor")]
        public FancyzonesOpenWindowOnActiveMonitor FancyzonesOpenWindowOnActiveMonitor { get; set; }

        [JsonProperty("fancyzones_restoreSize")]
        public FancyzonesRestoreSize FancyzonesRestoreSize { get; set; }

        [JsonProperty("fancyzones_quickLayoutSwitch")]
        public FancyzonesQuickLayoutSwitch FancyzonesQuickLayoutSwitch { get; set; }

        [JsonProperty("fancyzones_flashZonesOnQuickSwitch")]
        public FancyzonesFlashZonesOnQuickSwitch FancyzonesFlashZonesOnQuickSwitch { get; set; }

        [JsonProperty("use_cursorpos_editor_startupscreen")]
        public UseCursorposEditorStartupscreen UseCursorposEditorStartupscreen { get; set; }

        [JsonProperty("fancyzones_show_on_all_monitors")]
        public FancyzonesShowOnAllMonitors FancyzonesShowOnAllMonitors { get; set; }

        [JsonProperty("fancyzones_span_zones_across_monitors")]
        public FancyzonesSpanZonesAcrossMonitors FancyzonesSpanZonesAcrossMonitors { get; set; }

        [JsonProperty("fancyzones_makeDraggedWindowTransparent")]
        public FancyzonesMakeDraggedWindowTransparent FancyzonesMakeDraggedWindowTransparent { get; set; }

        [JsonProperty("fancyzones_zoneHighlightColor")]
        public FancyzonesZoneHighlightColor FancyzonesZoneHighlightColor { get; set; }

        [JsonProperty("fancyzones_highlight_opacity")]
        public FancyzonesHighlightOpacity FancyzonesHighlightOpacity { get; set; }

        [JsonProperty("fancyzones_editor_hotkey")]
        public FancyzonesEditorHotkey FancyzonesEditorHotkey { get; set; }

        [JsonProperty("fancyzones_windowSwitching")]
        public FancyzonesWindowSwitching FancyzonesWindowSwitching { get; set; }

        [JsonProperty("fancyzones_nextTab_hotkey")]
        public FancyzonesNextTabHotkey FancyzonesNextTabHotkey { get; set; }

        [JsonProperty("fancyzones_prevTab_hotkey")]
        public FancyzonesPrevTabHotkey FancyzonesPrevTabHotkey { get; set; }

        [JsonProperty("fancyzones_excluded_apps")]
        public FancyzonesExcludedApps FancyzonesExcludedApps { get; set; }

        [JsonProperty("fancyzones_zoneBorderColor")]
        public FancyzonesZoneBorderColor FancyzonesZoneBorderColor { get; set; }

        [JsonProperty("fancyzones_zoneColor")]
        public FancyzonesZoneColor FancyzonesZoneColor { get; set; }

        [JsonProperty("fancyzones_zoneNumberColor")]
        public FancyzonesZoneNumberColor FancyzonesZoneNumberColor { get; set; }

        [JsonProperty("fancyzones_systemTheme")]
        public FancyzonesSystemTheme FancyzonesSystemTheme { get; set; }

        [JsonProperty("fancyzones_showZoneNumber")]
        public FancyzonesShowZoneNumber FancyzonesShowZoneNumber { get; set; }
    }
}