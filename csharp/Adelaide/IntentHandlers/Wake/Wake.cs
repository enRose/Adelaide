using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandler
{
    public static class Wake
    {
        public static string[] speeches = {
                "AtYourServiceSir",
                "IsThereAnythingICanHelpYouWithSir",
                "YesIamHere",
                "YesSir"           
            };

        public static void Act(IntentRecognitionResult intent)
        {
            ConversationContext.Sleep = false;

            Utils.RandomlyPlay(speeches, "Wake");
        }
    }
}