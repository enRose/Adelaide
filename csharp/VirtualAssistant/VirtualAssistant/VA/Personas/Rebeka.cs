using System;
using Microsoft.CognitiveServices.Speech.Intent;

namespace VirtualAssistant.VA.Personas
{
    public class Rebeka : Persona
    {
        public Rebeka()
        {
            intentsToHandle.Add("WhoIsRebeka");
        }

        public override void Handle(IntentRecognitionResult result)
        {
            Console.WriteLine("Rebeka handling intent...");
        }
    }
}
