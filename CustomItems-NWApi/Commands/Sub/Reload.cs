using System;
using CommandSystem;

namespace CustomItems_NWApi.Commands.Sub
{

    public class Reload : ICommand
    {
        public string Command { get; } = "reload";

        public string[] Aliases { get; } = null;

        public string Description { get; } = "Triggers a config reload";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "wa";
            return true;
        }
    }
}