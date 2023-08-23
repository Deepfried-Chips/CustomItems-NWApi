namespace CustomItems_NWApi.Types
{
    public abstract class CustomItem
    {
        public string ID;
        public ItemType Item;
        
        #region Language stuff
        
        public string Name;

        public string Description;

        #endregion
        
        #region Wrappers
        
        public abstract void OnUsed(params object[] args);
        
        public abstract void OnUse(params object[] args);

        public abstract void OnUpgradePickup(params object[] args);

        public abstract void OnUpgradeInventory(params object[] args);

        ///You should probably check if you get an ItemPickupBase or an ItemBase
        public abstract void OnUpgradeAll(params object[] args);
        
        public abstract void OnDropItem(params object[] args);

        public abstract void OnDroppedItem(params object[] args);
        
        public abstract void OnPickupItem(params object[] args);
        
        public abstract void OnPickedUpItem(params object[] args);

        #endregion
    }
}