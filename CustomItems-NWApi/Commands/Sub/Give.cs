using System;
using CommandSystem;
using CustomItems_NWApi.Factory;
using PluginAPI.Core;

namespace CustomItems_NWApi.Commands.Sub
{
    public class Give : ICommand
    {
        public string Command { get; } = "give";

        public string[] Aliases { get; } = null;

        public string Description { get; } = "Attempts to give item, if it exists";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Log.Info(arguments.At(0), Plugin.Name);
            if (arguments.Count < 2)
            {
                response = "Usage: <player> <item>";
                return false;
            }
            Player player = CustomItemsPlayer.Get(arguments.At(0));
            if (player == null)
            {
                response = "Couldn't find player!";
                return false;
            }
            
            response = Description;
            return true;
        }
    }
}