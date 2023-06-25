﻿using System;
using CommandSystem;
using CustomItems_NWApi.Factory;
using PluginAPI.Core;

namespace CustomItems_NWApi.Commands.Sub
{
    public class Drop : ICommand
    {
        public string Command { get; } = "drop";

        public string[] Aliases { get; } = null;

        public string Description { get; } = "Attempts to drop item, if it exists";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count < 2)
            {
                response = "Usage: <player> <item>";
                return false;
            }

            Player ply = Helpers.GetPlayer(arguments.At(0));
            if (ply == null)
            {
                response = "Couldn't find player!";
                return false;
            }
            
            response = Description;
            return true;
        }
    }
}