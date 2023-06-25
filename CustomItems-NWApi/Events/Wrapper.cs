using InventorySystem.Items.Pickups;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;
using Scp914;

namespace CustomItems_NWApi.Events
{
    public class Wrapper
    {
        [PluginEvent(ServerEventType.PlayerUsedItem)]
        void PlayerUsedItem(PlayerUsedItemEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                //Coinflips and keycards don't count towards item used
                Log.Info($"Player {ev.Player.Nickname} ({ev.Player.PlayerId} as {ev.Player.RoleName}) used item {ev.Item.name}" );
            
        }
        
        [PluginEvent(ServerEventType.PlayerUseItem)]
        void PlayerUseItem(PlayerUseItemEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Player {ev.Player.Nickname} ({ev.Player.PlayerId} as {ev.Player.RoleName}) is using item {ev.Item.name}" );
            
        }

        [PluginEvent(ServerEventType.PlayerJoined)]
        void PlayerJoin(PlayerJoinedEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info("A player has joined the server");
        }

        [PluginEvent(ServerEventType.Scp914UpgradePickup)]
        void Scp914UpgradePickup(Scp914UpgradePickupEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Item {ev.Item.name} has been dropped through 914");
        }

        [PluginEvent(ServerEventType.Scp914InventoryItemUpgraded)]
        void Scp914InventoryItemUpgraded(Scp914InventoryItemUpgradedEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Item {ev.Item.name} has been upgraded in inventory");
        }
    }
}