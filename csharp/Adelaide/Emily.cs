using System;
using Adelaide.IntentHandlers;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide
{
    public class Emily
    {
        public void Do(IntentRecognitionResult intent)
        {
            if (ConversationContext.Sleep == true && intent.IntentId != "Wake")
            {
                return;
            }

            if (IntentHandlerLocator.Map.TryGetValue(intent.IntentId, out Action<IntentRecognitionResult> actOn))
            {
                actOn(intent);

                return;
            }

            NoMatch.Act(intent);
        }
    }
}
