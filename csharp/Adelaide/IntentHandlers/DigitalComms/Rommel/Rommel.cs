using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.DigitalComms
{
    public class Rommel : Handler
    {
        public static string[] speeches = {
                "GoodJob"
            };

        public Speaking speaking;

        public Rommel()
        {
            handlerName = "Rommel";

            intentsToHandle.Add("Rommel");

            speaking = new Speaking(speeches);
        }

        public override void Do(IntentRecognitionResult intent)
        {
            speaking.Speak(handlerName, belongsToSkill);

            base.Do(intent);
        }
    }
}
