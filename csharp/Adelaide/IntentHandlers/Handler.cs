using Microsoft.CognitiveServices.Speech.Intent;
using System.Collections.Generic;

namespace Adelaide.IntentHandlers
{
    public class Handler
    {
        public string belongsToSkill;

        public string handlerName;

        public List<string> intentsToHandle = new List<string>();

        public virtual bool CanHandle(IntentRecognitionResult intent)
        {
            return intentsToHandle.Contains(intent.IntentId);
        }

        public virtual void Do(IntentRecognitionResult intent)
        {
            // TODO: maybe generic clean up tasks here?
            return;
        }
    }
}
