using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers.CreditCardApply
{
    public static class CreditCardApplyWake
    {
        private const string thisFolderName = "IntentHandlers\\CreditCardApply\\CreditCardApplyWake";

        public static string[] speeches = {
                "ASBHasTheBestProducts",
                "InGoodHandsOfMyCreator",
                "WouldYouLikeToGoWithASB"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            if (CreditCardApp.AppStatus == AppStatus.Paused)
            {
                Utils.Play("DoYouWantResumeExistingCCApp", thisFolderName);

                return;
            }

            Utils.PlayOneOf(speeches, thisFolderName);
        }
    }
}
