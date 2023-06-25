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
        
        public abstract bool OnUse(params object[] args);

        public abstract void OnUpgradePickup(params object[] args);

        public abstract void OnUpgradeInventory(params object[] args);

        public abstract void OnUpgradeAll(params object[] args);
        
        #endregion
    }
}