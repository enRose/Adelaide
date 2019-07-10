using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.DigitalComms.Michael
{
    public class Michael
    {
        private static string folderPath = @"IntentHandlers\DigitalComms\Michael";

        public static void TeamPerf(IntentRecognitionResult intent)
        {
            Utils.Play("TeamPerf", folderPath);
        }

        public static void Highlight(IntentRecognitionResult intent)
        {
            Utils.Play("Highlight", folderPath);
        }

        public static void SquadMvp(IntentRecognitionResult intent)
        {
            Utils.Play("SquadMvp", folderPath);
        }

        public static void BuyMeDinner(IntentRecognitionResult intent)
        {
            Utils.Play("BuyMeDinner", folderPath);
        }

        public static void BeSerious(IntentRecognitionResult intent)
        {
            Utils.Play("BeSerious", folderPath);
        }

        public static void EnjoyedMost(IntentRecognitionResult intent)
        {
            Utils.Play("EnjoyedMost", folderPath);
        }

        public static void StillNeedHostRCU(IntentRecognitionResult intent)
        {
            Utils.Play("StillNeedHostRCU", folderPath);
        }

        public static void ExistentialCrisis(IntentRecognitionResult intent)
        {
            Utils.Play("ExistentialCrisis", folderPath);
        }

    }
}
