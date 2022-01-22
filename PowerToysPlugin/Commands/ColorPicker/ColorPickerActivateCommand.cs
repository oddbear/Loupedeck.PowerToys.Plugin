﻿using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.ColorPicker;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.ColorPicker
{
    class ColorPickerActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private ColorPickerService _service;
        private ColorPickerSettings _currentSettings;

        public ColorPickerActivateCommand()
            : base("Activate ColorPicker",
                "Presses the assigned keyboard shortcuts to activate.",
                "ColorPicker")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.ColorPickerService;
            if (_service is null)
                return false;

            _currentSettings = _service.GetSettings();

            return true;
        }
        
        protected override void RunCommand(string actionParameter)
        {
            _service.Activate();
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = "Loupedeck.PowerToysPlugin.Resources.Modules.ColorPicker.icon-80.png";

                var background = ResourceHelper.GetBackgroundImage(path);
                bitmapBuilder.SetBackgroundImage(background);

                bitmapBuilder.Translate(0, 20);
                var text = GetCommandDisplayName(actionParameter, imageSize);
                bitmapBuilder.DrawText(text, BitmapColor.White, 10);

                return bitmapBuilder.ToImage();
            }
        }

        protected override string GetCommandDisplayName(string actionParameter, PluginImageSize imageSize)
        {
            return "Color Picker";
        }
    }
}
