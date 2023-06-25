namespace CustomItems_NWApi.Factory
{
    using PluginAPI.Core.Interfaces;
    using PluginAPI.Core;
    
    public class CiPlayer : Player
    {
        public CiPlayer(IGameComponent component) : base(component)
        {
        }
    }
}