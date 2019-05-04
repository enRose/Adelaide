using Adelaide.Infrastructure;

namespace Adelaide.Unexpected
{
    public static class UnrecognisedSpeechHandler
    {
        private static int unrecognisedSpeechCount = 0;

        private const string thisFolderName = "SpeechUnrecognisedHandler";

        public static string[] speeches = {
                "BegPardon",
                "IDontUnderstand",
                "RepeatAgain"
            };

        public static void Act()
        {
            unrecognisedSpeechCount += 1;

            if (unrecognisedSpeechCount > 5)
            {
                Utils.Play("DoYouWantSpeakToHuman", thisFolderName);
                return;
            }

            Utils.RandomlyPlay(speeches, thisFolderName);
        }
    }
}
