using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.Intents
{
    public static class NoMatch
    {
        public static string[] speeches = {
                "BegPardon",
                "IDontUnderstand",
                "RepeatAgain"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            Utils.PlayOneOf(speeches, "NoMatch");
        }
    }
}
