global using static SK_Jobs.Translations;

namespace SK_Jobs
{

    public static partial class Translations
    {
        #region Base
        public static char[] TranslationKeyTrimCharacters = new[] { '_' };
        public static TranslationList DefaultTranslationList
        {
            get
            {
                var translations = new TranslationList();
                translations.AddRange(
                typeof(Translations).GetFields(BindingFlags.Static | BindingFlags.Public)
                .Where(x => (x.IsStatic && x.IsInitOnly) || x.IsLiteral)
                .Select(x =>
                    new TranslationListEntry(x.Name.Trim(TranslationKeyTrimCharacters), (x.IsLiteral ? x.GetRawConstantValue() : x.GetValue(null)).ToString())
                ));
                return translations;
            }
        }
        public static string Translate(string translationKey, params object[] arguments) => inst.Translate(translationKey, arguments);
        #endregion
        public const string
            Format = "Members of {0}",
            FormatAll = "Jobs",
            JobFormat = "{0}・{1} players",
            MemberFormat = "{0}・ {1} - {2}";
    }
}