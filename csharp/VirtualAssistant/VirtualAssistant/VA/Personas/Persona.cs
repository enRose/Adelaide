using System.Collections.Generic;
using Microsoft.CognitiveServices.Speech.Intent;

namespace VirtualAssistant.VA.Personas
{
    public abstract class Persona
    {
        public List<string> intentsToHandle = new List<string>();

        public Persona()
        {
        }

        public abstract void Handle(IntentRecognitionResult result);
    }
}
