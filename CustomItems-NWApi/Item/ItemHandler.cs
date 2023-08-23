using System.Collections.Generic;
using CustomItems_NWApi.Types;

namespace CustomItems_NWApi.Item
{
    public class ItemHandler
    {
        public static Dictionary<string, CustomItem> Registered = new Dictionary<string, CustomItem>();

        public static Dictionary<ushort, string> Spawned = new Dictionary<ushort, string>();

        public static bool RegisterItem(CustomItem item)
        {
            if (item == null)
                return false;

            Registered.Add(item.ID.ToLower(), item);
            
            return true;
        }
    }
}