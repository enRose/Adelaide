using Adelaide.IntentHandlers;
using Adelaide.Unexpected;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide
{
    public class Emily
    {
        private readonly SkillSet skills = new SkillSet();

        public void OnIntentRecognised(IntentRecognitionResult intent)
        { 
            if (Memory.Sleep == true && intent.IntentId != "Wake")
            {
                return;
            }

            skills.Handle(intent);
        }

        public void OnSpeechUnrecognised()
        {
            if (Memory.Sleep == true)
            {
                return;
            }

            UnrecognisedSpeechHandler.Act();
        }
    }
}
