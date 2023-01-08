namespace GMToolset.Presentation.Helpers.Managers
{
    public static class LanguageManager
    {
        public enum Language
        {
            pl, eng, unknown
        }

        public static Language GetContextLanguage(HttpContext context)
        {
            var currentCulture = context.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
            var language = currentCulture?.RequestCulture.Culture.Name;

            if (string.IsNullOrEmpty(language))
                return Language.unknown;

            switch (language)
            {
                case "pl":
                    return Language.pl;
                case "en":
                    return Language.eng;
                default:
                    return Language.unknown;
            }

        }
    }
}
