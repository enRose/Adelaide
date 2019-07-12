using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers
{
    public class Handler
    {
        public string belongsToSkill;

        public string handlerName;

        public string intentToHandle;

        public virtual bool CanHandle(IntentRecognitionResult intent)
        {
            return intent.IntentId == intentToHandle;
        }

        public virtual void Do(IntentRecognitionResult intent)
        {
            // TODO: maybe generic clean up tasks here?
            return;
        }
    }
}
