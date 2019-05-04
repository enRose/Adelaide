using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandler.CreditCardApply
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

            Utils.RandomlyPlay(speeches, "AgreeCreditCheck");
        }
    }
}
