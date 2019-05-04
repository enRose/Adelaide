using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.Intents
{
    public static class ApplyASBStart
    {
        public static string[] speeches = {
                "AreYouFineWithCreditCheck",
                "AreYouOkWithCreditCheck"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            CreditCardAppContext.CreditCardAppCxt.AppStatus = AppStatus.New;

            CreditCardAppContext.CreditCardAppCxt.NextStep = AppStep.AgreeCreditCheck;

            Utils.RandomlyPlay(speeches, "ASBCreditCardStart");
        }
    }
}
