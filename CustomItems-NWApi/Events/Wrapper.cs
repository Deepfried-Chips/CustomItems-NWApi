using CustomItems_NWApi.Item;
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
            
            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnUsed(ev);
            }
        }
        
        [PluginEvent(ServerEventType.PlayerUseItem)]
        void PlayerUseItem(PlayerUseItemEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Player {ev.Player.Nickname} ({ev.Player.PlayerId} as {ev.Player.RoleName}) is using item {ev.Item.name}" );

            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnUse(ev);
            }
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
            
            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnUpgradePickup(ev);
                item.Value.OnUpgradeAll(ev);
            }
        }

        [PluginEvent(ServerEventType.Scp914InventoryItemUpgraded)]
        void Scp914InventoryItemUpgraded(Scp914InventoryItemUpgradedEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Item {ev.Item.name} has been upgraded in inventory");
            
            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnUpgradeInventory(ev);
                item.Value.OnUpgradeAll(ev);
            }
        }

        [PluginEvent(ServerEventType.PlayerDropItem)]
        void PlayerDropItem(PlayerDropItemEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Player {ev.Player.Nickname} has dropped Item {ev.Item.name}");

            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnDropItem(ev);
            }
        }
        
        [PluginEvent(ServerEventType.PlayerDropedpItem)]
        void PlayerDroppedItem(PlayerDroppedItemEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Player {ev.Player.Nickname} has dropped Item {ev.Item.name}");

            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnDroppedItem(ev);
            }
        }
        
        [PluginEvent(ServerEventType.PlayerSearchPickup)]
        void PlayerSearchPickup(PlayerSearchPickupEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Player {ev.Player.Nickname} has picked up Item {ev.Item.name}");

            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnPickupItem(ev);
            }
        }
        
        [PluginEvent(ServerEventType.PlayerSearchedPickup)]
        void PlayerSearchedPickup(PlayerSearchedPickupEvent ev)
        {
            if (Plugin.Singleton.PluginConfig.ExtendedDebug)
                Log.Info($"Player {ev.Player.Nickname} has picked up Item {ev.Item.name}");

            foreach (var item in ItemHandler.Registered)
            {
                item.Value.OnPickedUpItem(ev);
            }
        }
    }
}