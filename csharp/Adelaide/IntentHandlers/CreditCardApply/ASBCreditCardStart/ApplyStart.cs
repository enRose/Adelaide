using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers.CreditCardApply
{
    public static class ApplyASBStart
    {
        public static string[] speeches = {
                "AreYouFineWithCreditCheck",
                "AreYouOkWithCreditCheck"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            CreditCardApp.AppStatus = AppStatus.New;

            CreditCardApp.NextStep = AppStep.AgreeCreditCheck;

            Utils.RandomlyPlay(speeches, "CreditCardApply/ASBCreditCardStart");
        }
    }
}
