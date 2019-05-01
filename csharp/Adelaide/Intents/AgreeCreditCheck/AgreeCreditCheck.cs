using Adelaide.CreditCardApp;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Intents
{
    public static class AgreeCreditCheck
    {
        public static string[] speeches = {
                "MayIHaveYourAddress",
                "NeedAddressToFile",
                "WhatIsLivingAddress"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            App.AppStatus = AppStatus.InProgress;

            App.AgreeCreditCheck = true;

            App.NextStep = AppStep.WhatIsCurrentAddress;

            Utils.PlayOneOf(speeches, "AgreeCreditCheck");
        }
    }
}
