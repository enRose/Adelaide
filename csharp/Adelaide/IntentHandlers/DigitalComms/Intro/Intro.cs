using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.DigitalComms
{
    public class Intro : Handler
    {
        public static string[] speeches = {
                "GetScriptReady",
                "LoadCommsSkills",
                "PrepareCommsScript"
            };

        public Speaking speaking;

        public Intro()
        {
            handlerName = "Intro";

            intentsToHandle.Add("ASB-Digital-comms-opening");

            speaking = new Speaking(speeches);
        }

        public override void Do(IntentRecognitionResult intent)
        {
            speaking.Speak(handlerName, belongsToSkill);

            base.Do(intent);
        }
    }
}
