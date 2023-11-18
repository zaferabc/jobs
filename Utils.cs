global using Rocket.API;
global using Rocket.API.Collections;
global using Rocket.API.Serialisation;
global using Rocket.Core;
global using Rocket.Core.Assets;
global using Rocket.Core.Logging;
global using Rocket.Core.Plugins;
global using Rocket.Unturned;
global using Rocket.Unturned.Chat;
global using Rocket.Unturned.Events;
global using Rocket.Unturned.Player;
global using SDG.Unturned;
global using Steamworks;
global using System;
global using System.Collections;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Reflection;
global using System.Text;
global using System.Text.RegularExpressions;
global using System.Threading;
global using System.Xml.Serialization;
global using UnityEngine;
global using static SK_Jobs.Utils;
global using IRP = Rocket.API.IRocketPlayer;
global using Logger = Rocket.Core.Logging.Logger;
global using UP = Rocket.Unturned.Player.UnturnedPlayer;
global using V = SDG.Unturned.InteractableVehicle;
global using P = SDG.Unturned.Player;
global using SP = SDG.Unturned.SteamPlayer;
global using Color = UnityEngine.Color;

namespace SK_Jobs
{
    public static partial class Utils
    {
        public static IEnumerable<UP> UPList => Provider.clients.Select(UP.FromSteamPlayer);
        public static SK_JobsMain inst => SK_JobsMain.Instance;
        public static SK_JobsConfig conf => inst.Configuration.Instance;
    }
}