using System;
using System.Collections.Generic;
using Adelaide.Intents;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide
{
    public class Actor
    {
        public void Do(IntentRecognitionResult intent)
        {
            Enum.TryParse(intent.IntentId, out IntentId intentId);

            if (ConversationContext.Sleep == true && intentId != IntentId.Wake)
            {
                return;
            }

            if (ActionMap.TryGetValue(intentId, out Action<IntentRecognitionResult> act))
            {
                act(intent);
            }
            else
            {
                NoMatch.Act(intent);
            }
        }

        public Dictionary<IntentId, Action<IntentRecognitionResult>> ActionMap =>

        new Dictionary<IntentId, Action<IntentRecognitionResult>>
        {
            { IntentId.Wake, Wake.Act },

            { IntentId.Sleep, Sleep.Act },

            { IntentId.ApplyForCreditCardWake, CreditCardApplyWake.Act },

            { IntentId.ApplyForCreditCardSleep, CreditCardApplyWake.Act },

            { IntentId.ASBCreditCardStart, ApplyASBStart.Act },

            { IntentId.AgreeCreditCheck, AgreeCreditCheck.Act }
        };
    }
}
