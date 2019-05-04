using Adelaide.CreditCardAppContext;
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
            CreditCardAppContext.CreditCardAppCxt.AppStatus = AppStatus.InProgress;

            CreditCardAppContext.CreditCardAppCxt.AgreeCreditCheck = true;

            CreditCardAppContext.CreditCardAppCxt.NextStep = AppStep.WhatIsCurrentAddress;

            Utils.RandomlyPlay(speeches, "AgreeCreditCheck");
        }
    }
}
