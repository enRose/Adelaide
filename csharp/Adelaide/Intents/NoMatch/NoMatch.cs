using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.Intents
{
    public static class NoMatch
    {
        private static int noMatchCount = 0;

        private const string thisFolderName = "NoMatch";

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

            Utils.RandomlyPlay(speeches, thisFolderName);
        }
    }
}
