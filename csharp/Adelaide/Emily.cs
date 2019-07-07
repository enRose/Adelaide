using System;
using Adelaide.IntentHandlers;
using Adelaide.Unexpected;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide
{
    public class Emily
    {
        public void OnIntentRecognised(IntentRecognitionResult intent)
        {
            if (ConversationContext.Sleep == true && intent.IntentId != "Wake")
            {
                return;
            }

            if (IntentHandlerLocator.Map.TryGetValue(intent.IntentId, out Action<IntentRecognitionResult> actOn))
            {
                actOn(intent);
            }
        }

        public void OnSpeechUnrecognised()
        {
            if (ConversationContext.Sleep == true)
            {
                return;
            }

            UnrecognisedSpeechHandler.Act();
        }
    }
}
