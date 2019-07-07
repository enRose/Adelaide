using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.CreditCardApply
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
            CreditCardApp.AppStatus = AppStatus.InProgress;

            CreditCardApp.AgreeCreditCheck = true;

            CreditCardApp.NextStep = AppStep.WhatIsCurrentAddress;

            Utils.RandomlyPlay(speeches, "IntentHandlers\\CreditCardApply\\AgreeCreditCheck");
        }
    }
}
