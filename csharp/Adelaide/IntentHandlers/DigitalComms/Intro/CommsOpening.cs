using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers.DigitalComms.Opening
{
    public class CommsOpening
    {
        public static string[] speeches = {
                "OkGettingScriptsReady",
                "LoadingDigitalCommsSkills",
                "YesPreparingCommsSkills"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            ConversationContext.Sleep = false;

            Utils.RandomlyPlay(speeches, "DigitalComms\\Intro");
        }
    }
}
