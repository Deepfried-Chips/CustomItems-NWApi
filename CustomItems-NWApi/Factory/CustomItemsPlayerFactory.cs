using PluginAPI.Core.Factories;
using System;
using PluginAPI.Core.Interfaces;

namespace CustomItems_NWApi.Factory
{
    public class CustomItemsPlayerFactory : PlayerFactory
    {
        public override IPlayer Create(IGameComponent component) => new CustomItemsPlayer(component);
        
        public override Type BaseType { get; } = typeof(CustomItemsPlayer);
    }
}