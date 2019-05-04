using System;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Intents
{
    public static class CreditCardApplyContinue
    {
        public static string[] speeches = {
                "ContinueExistingCCApp",

            };

        public static void Act(IntentRecognitionResult intent)
        {
            Utils.Play("ContinueExistingCCApp", "CreditCardApplyContinue");
        }
    }
}
