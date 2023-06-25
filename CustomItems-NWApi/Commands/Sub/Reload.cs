using System;
using CommandSystem;
using NWAPIPermissionSystem;

namespace CustomItems_NWApi.Commands.Sub
{
    using Configs;

    public class Reload : ICommand
    {
        public string Command { get; } = "reload";

        public string[] Aliases { get; } = null;

        public string Description { get; } = "Triggers a config reload";

        public string Permission { get; } = "customitems.reload";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission(Permission))
            {
                response = $"You do not have the permissions required to run this command, permissions required: {Permission}";
                return false;
            }
            
            ConfigHandler.ReloadConfig();
            response = "Reloading configs";
            return true;
        }
    }
}