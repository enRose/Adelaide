using System;
using System.Collections.Generic;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Intents
{
    public class Actor
    {
        public void Do(IntentRecognitionResult intent)
        {
            if (ConversationContext.Sleep == true && intent.IntentId != "Wake")
            {
                return;
            }

            if (ActionMap.TryGetValue(intent.IntentId, 
                out Action<IntentRecognitionResult> act))
            {
                act(intent);
            }
            else
            {
                NoMatch.Act(intent);
            }
        }

        public Dictionary<string, Action<IntentRecognitionResult>> ActionMap =>

        new Dictionary<string, Action<IntentRecognitionResult>>
        {
            { "Wake", Wake.Act },

            { "Sleep", Sleep.Act },

            { "ApplyForCreditCard.Wake", CreditCardApplyWake.Act },

            { "ASBCreditCard.Start", ApplyASBStart.Act },

            { "AgreeCreditCheck", AgreeCreditCheck.Act }
        };
    }
}
