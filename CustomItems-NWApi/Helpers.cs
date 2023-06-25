using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CustomItems_NWApi.Factory;
using PluginAPI.Core;

namespace CustomItems_NWApi
{
    public static class Helpers
    {
        public static List<CiPlayer> Players => Player.GetPlayers<CiPlayer>();

        public static CiPlayer GetPlayer(string arg) => int.TryParse(arg, out int id)
            ? Player.Get<CiPlayer>(id)
            : Players.FirstOrDefault(p => p.Nickname.Contains(arg.ToLower()));
    }
}