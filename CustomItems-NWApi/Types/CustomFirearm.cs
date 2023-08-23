using PlayerStatsSystem;
using PluginAPI.Core;

namespace CustomItems_NWApi.Types
{
    public abstract class CustomFirearm : CustomItem
    {

        public uint Attachments;

        public byte MaxAmmo;

        public float RunSpeed;

        public abstract void OnShot(Player player, InventorySystem.Items.Firearms.Firearm firearm);

        public abstract void OnDamage(Player victim, Player attacker, DamageHandlerBase dmg);

        public abstract void OnAim(Player player, InventorySystem.Items.Firearms.Firearm firearm, bool aiming);

        public abstract void OnUnload(Player player, InventorySystem.Items.Firearms.Firearm firearm);

        public abstract void OnReload(Player player, InventorySystem.Items.Firearms.Firearm firearm);

        protected CustomFirearm(string id, string name, string desc, ItemType item, uint attachments, byte ammo, float speed)
        {
            Item = item;

            ID = id.ToLower();
            Name = name;
            Description = desc;

            Attachments = attachments;
            MaxAmmo = ammo;

            RunSpeed = speed;
        }
    }
}