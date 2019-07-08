using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers
{
    public static class NoMatch
    {
        private static int noMatchCount = 0;

        private const string thisFolderName = "IntentHandlers\\NoMatch";

        public static string[] speeches = {
                "CannotHelp",
                "DoNotKnowHowTo",
                "NoSkillsToHandle"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            noMatchCount += 1;
             
            if (noMatchCount > 3)
            {
                Utils.Play("DoYouWantSpeakToHuman", thisFolderName);
                return;
            }

            Utils.PlayOneOf(speeches, thisFolderName);
        }
    }
}
