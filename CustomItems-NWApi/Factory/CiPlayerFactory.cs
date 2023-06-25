using PluginAPI.Core.Factories;
using System;
using PluginAPI.Core.Interfaces;

namespace CustomItems_NWApi.Factory
{
    public class CiPlayerFactory : PlayerFactory
    {
        public override Type BaseType { get; } = typeof(CiPlayer);
        
        public override IPlayer Create(IGameComponent component) => new CiPlayer(component);
    }
}