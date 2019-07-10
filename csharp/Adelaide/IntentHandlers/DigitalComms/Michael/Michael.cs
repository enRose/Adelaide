using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.DigitalComms.Michael
{
    public class Michael
    {
        private static string folderPath = @"DigitalComms\Michael";

        public static void TeamPerf(IntentRecognitionResult intent)
        {
            Utils.Play("TeamPerf", folderPath);
        }

        public static void SquadMvp(IntentRecognitionResult intent)
        {
            Utils.Play("SquadMvp", folderPath);
        }

        public static void BuyMeDinner(IntentRecognitionResult intent)
        {
            Utils.Play("BuyMeDinner", folderPath);
        }
    }
}
