using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Intents
{
    public static class CreditCardApplySleep
    {
        public static string[] speeches = {
                "NoProblem",
                "NotAProblem",
                "Ok",
                "CloseNow"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            Utils.PlayOneOf(speeches, "CreditCardApply.Sleep");
        }
    }
}
