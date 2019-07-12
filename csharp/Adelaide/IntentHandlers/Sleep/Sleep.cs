using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers
{
    public static class Sleep
    {
        public static string[] speeches = {
                "GoInStandByMode",
                "NeedAnythingLetMeKnow",
                "SignOut"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            Memory.Sleep = true;

            Utils.PlayOneOf(speeches, "IntentHandlers\\Sleep");
        }
    }
}
