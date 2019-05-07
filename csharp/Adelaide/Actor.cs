using System;
using Adelaide.IntentHandlers;
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

            if (IntentHandlerLocator.Map.TryGetValue(intentId, out Action<IntentRecognitionResult> actOn))
            {
                actOn(intent);
            }
            else
            {
                NoMatch.Act(intent);
            }
        }
    }
}
