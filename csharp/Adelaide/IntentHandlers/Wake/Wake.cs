using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers
{
    public static class Wake
    {
        public static string[] speeches = {
                "AtYourService",
                "HowCanIHelpYou",
                "IsThereAnythingICanHelpYouWith",
                "YesIamHere"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            ConversationContext.Sleep = false;

            Utils.PlayOneOf(speeches, "IntentHandlers\\Wake");
        }
    }
}
