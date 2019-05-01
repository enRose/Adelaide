using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.Intents
{
    public static class CreditCardApplyWake
    {
        public static string[] speeches = {
                "ASBHasTheBestProducts",
                "InGoodHandsOfMyCreator",
                "WouldYouLikeToGoWithASB"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            Utils.PlayOneOf(speeches, "CreditCardApply.Wake");
        }
    }
}
