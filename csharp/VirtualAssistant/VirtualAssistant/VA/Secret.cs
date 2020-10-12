using System;
namespace VirtualAssistant.VA
{
    public class Secret
    {
        public static string LuisPredictionKey
        { get; internal set; }
        = "";

        public static string Region { get; internal set; }
        = "";

        public static string LuisAppId { get; internal set; }
        = "";

        public static string TTSAuthUrl { get; internal set; }

        public static string TTSKey { get; internal set; }
    }
}
