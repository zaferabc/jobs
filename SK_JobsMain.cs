using System.Linq.Expressions;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Collections;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System.Net;
using Newtonsoft.Json;
namespace SK_Jobs
{
    public sealed class SK_JobsMain : RocketPlugin<SK_JobsConfig>
    {
        public static SK_JobsMain Instance { get; private set; }

        protected override void Load()
        {
            Instance = this;
            Rocket.Core.Logging.Logger.Log("SK_Jobs plugin active!");
            Rocket.Core.Logging.Logger.Log("Would you like more free plugins? Join now: https://discord.gg/y3rYs7ZXFs");
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("SK_Jobs plugin disabled!");
            Rocket.Core.Logging.Logger.Log("Would you like more free plugins? Join now: https://discord.gg/y3rYs7ZXFs");
        }

        #region Translations
        public override TranslationList DefaultTranslations => DefaultTranslationList;

        public new string Translate(string key, params object[] args) => base.Translate(key.Trim(TranslationKeyTrimCharacters), args);
        #endregion
    }
}