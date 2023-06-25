using System;
using CommandSystem;
using CustomItems_NWApi.Commands.Sub;
using CustomItems_NWApi.Factory;
using PluginAPI.Core;

namespace CustomItems_NWApi.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class CustomItemParent : ParentCommand
    {
        public override string Command { get; } = "customitems";

        public override string[] Aliases { get; } = new string[]
        {
            "ci"
        };

        public override string Description { get; } = "Literally all of the commands";

        public CustomItemParent() => LoadGeneratedCommands();

        public override void LoadGeneratedCommands()
        { 
            RegisterCommand(new Reload());
            RegisterCommand(new Give());
            RegisterCommand(new Drop());
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Please specify a subcommand, available subcommands: reload, give, drop";
            return false;
        }
    }
}