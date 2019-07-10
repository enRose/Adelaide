using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers.DigitalComms.Opening
{
    public class Intro
    {
        public static string[] speeches = {
                "GetScriptReady",
                "LoadCommsSkills",
                "PrepareCommsScript"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            var playList = (path: @"IntentHandlers\DigitalComms\Intro", speeches);

            Utils.PlayOneFrom(playList);
        }
    }
}
