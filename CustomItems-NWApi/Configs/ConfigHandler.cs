namespace CustomItems_NWApi.Configs
{
    public class ConfigHandler
    {
        public static void ReloadConfig()
        {
            Plugin.Singleton.Handler.LoadConfig(Plugin.Singleton, nameof(Plugin.Config));
        }
    }
}