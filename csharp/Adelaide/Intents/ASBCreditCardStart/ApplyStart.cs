using Adelaide.CreditCardApp;
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
            App.AppStatus = AppStatus.New;

            App.NextStep = AppStep.AgreeCreditCheck;

            var inFolder = "ASBCreditCardStart";

            Utils.PlayOneOf(speeches, inFolder);
        }
    }
}
