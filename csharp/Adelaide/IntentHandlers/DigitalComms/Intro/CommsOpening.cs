using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers.DigitalComms.Opening
{
    public class CommsOpening
    {
        public static string[] speeches = {
                "OkGettingScriptsReady",
                "LoadingDigitalCommsSkills",
                "OkPreparingCommsSkills"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            var playList = (path: @"IntentHandlers\DigitalComms\Intro", speeches);

            Utils.PlayOneFrom(playList);
        }
    }
}
