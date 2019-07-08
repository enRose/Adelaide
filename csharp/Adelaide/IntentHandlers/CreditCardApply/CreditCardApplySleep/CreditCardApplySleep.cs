using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.CreditCardApply
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
            CreditCardApp.AppStatus = AppStatus.Paused;

            Utils.PlayOneOf(speeches, "IntentHandlers\\CreditCardApply\\CreditCardApplySleep");
        }
    }
}
