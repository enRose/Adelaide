using System;
using System.Collections.Generic;
using Adelaide.IntentHandlers.CreditCardApply;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers
{
    public static class IntentHandlerLocator
    {
        public static Dictionary<string, Action<IntentRecognitionResult>> 
        Map =>

        new Dictionary<string, Action<IntentRecognitionResult>>
        {
            { "Wake", Wake.Act } ,

            { "Sleep", Sleep.Act },

            { "ApplyForCreditCardWake", CreditCardApplyWake.Act },

            { "ApplyForCreditCardSleep", CreditCardApplyWake.Act },

            { "CreditCardApplyResume", CreditCardApplyResume.Act},

            { "ASBCreditCardStart", ApplyASBStart.Act },

            { "AgreeCreditCheck", AgreeCreditCheck.Act }
        };
    }
}
