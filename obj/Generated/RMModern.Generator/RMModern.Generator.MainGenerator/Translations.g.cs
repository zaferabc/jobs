namespace SK_Jobs
{
    public static partial class Translations
    {
        /// <summary><c>"Members of {0}"</c></summary>
        public static string TranslateFormat(params object[] args) => Translate(nameof(Format), args);
        /// <summary><c>"Jobs"</c></summary>
        public static string TranslateFormatAll(params object[] args) => Translate(nameof(FormatAll), args);
        /// <summary><c>"{0}・{1} players"</c></summary>
        public static string TranslateJobFormat(params object[] args) => Translate(nameof(JobFormat), args);
        /// <summary><c>"{0}・ {1} - {2}"</c></summary>
        public static string TranslateMemberFormat(params object[] args) => Translate(nameof(MemberFormat), args);
    }
    
}

