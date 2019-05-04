using Adelaide.CreditCardAppContext;
using Adelaide.Infrastructure;
using Adelaide.IntentHandler;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.CreditCardApply
{
    public static class CreditCardApplyResume
    {
        private const string thisFoldeName = "CreditCardApplyResume";

        public static void Act(IntentRecognitionResult intent)
        {
            if (CreditCardApp.AppStatus != AppStatus.Paused)
            {
                Utils.Play("DoYouWantANewApp", thisFoldeName);
                return;
            }

            Utils.Play("ResumingAppNow", thisFoldeName);

            var intentId = IntentIdLocator.Map[CreditCardApp.NextStep];

            var intentHandler = IntentHandlerLocator.Map[intentId];

            intentHandler(intent);
        }
    }
}
