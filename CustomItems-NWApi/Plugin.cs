using System;
using PluginAPI.Core.Items;

namespace CustomItems_NWApi
{
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using Configs;
    
    public class Plugin
    {

        public const string Name = "CustomItems";

        public const string Version = "0.0.1-alpha";
        
        public static Plugin Singleton { get; private set; }

        [PluginConfig] public Config Config;

        [PluginEntryPoint(Name, Version, "Custom Items API for NW Plugin System", "Deepfried-Chips, SwiftKraft")]
        private void Load()
        {
            Singleton = this;
            Log.Info("Hello from Custom Items", Name);
            
        }
        
        
    }
}