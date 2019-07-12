using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.Sleep
{
    public class SleepHandler : Handler
    {
        public static string[] speeches = {
                "GoInStandByMode",
                "NeedAnythingLetMeKnow",
                "SignOut"
            };

        public SleepHandler()
        {
            intentsToHandle.Add("sleep");
        }

        public override void Do(IntentRecognitionResult intent)
        {
            Memory.Sleep = true;

            Utils.PlayOneOf(speeches, "IntentHandlers\\Sleep");

            base.Do(intent);
        }
    }
}
