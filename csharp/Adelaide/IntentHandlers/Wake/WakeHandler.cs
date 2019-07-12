using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.Wake
{
    public class WakeHandler: Handler
    {
        public static string[] speeches = {
                "AtYourService",
                "HowCanIHelpYou",
                "IsThereAnythingICanHelpYouWith",
                "YesIamHere"
            };

        public WakeHandler()
        {
            intentsToHandle.Add("wake");
        }

        public override void Do(IntentRecognitionResult intent)
        {
            Memory.Sleep = false;

            Utils.PlayOneOf(speeches, "IntentHandlers\\Wake");

            base.Do(intent);
        }
    }
}
