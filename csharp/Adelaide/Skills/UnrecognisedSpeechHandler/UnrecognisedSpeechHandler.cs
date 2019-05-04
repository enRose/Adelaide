using Adelaide.Infrastructure;

namespace Adelaide.Skills
{
    public static class UnrecognisedSpeechHandler
    {
        public static string[] speeches = {
                "BegPardon",
                "IDontUnderstand",
                "RepeatAgain"
            };

        public static void Act()
        {
            Utils.RandomlyPlay(speeches, "SpeechUnrecognisedHandler");
        }
    }
}
