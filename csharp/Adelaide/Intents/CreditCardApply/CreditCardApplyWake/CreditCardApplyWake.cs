using Adelaide.CreditCardAppContext;
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
            if (CreditCardAppCxt.AppStatus == AppStatus.Paused)
            {
                Utils.Play("YesNoResumeExistingCCApp", "CreditCardApplyWake");

                return;
            }

            Utils.RandomlyPlay(speeches, "CreditCardApplyWake");
        }
    }
}
