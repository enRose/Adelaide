using System;
using System.Collections.Generic;
using Adelaide.IntentHandlers.CreditCardApply;
using Adelaide.IntentHandlers.DigitalComms.Rommel;
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

            { "ApplyForCreditCardSleep", CreditCardApplySleep.Act },

            { "CreditCardApplyResume", CreditCardApplyResume.Act},

            { "ASBCreditCardStart", ApplyASBStart.Act },

            { "AgreeCreditCheck", AgreeCreditCheck.Act },


            { "Rommel", Rommel.Act}
        };
    }
}
