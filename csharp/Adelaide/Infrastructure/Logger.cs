using System;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Infrastructure
{
    public static class Logger
    {
        public static void OnIntentRecognised(IntentRecognitionResult intent)
        {
            var json = intent.Properties.GetProperty(
                                PropertyId.LanguageUnderstandingServiceResponse_JsonResult);

            Console.WriteLine($"RECOGNIZED: Text={intent.Text}");

            Console.WriteLine($"    Intent Id: {intent.IntentId}.");

            Console.WriteLine($"    Language Understanding JSON: {json}.");
        }

        public static void OnSpeechRecognised(IntentRecognitionResult result)
        {
            Console.WriteLine($"RECOGNIZED: Text={result.Text}");
            Console.WriteLine($"    Intent not recognized.");
        }

        public static void OnSpeechUnrecognised()
        {
            Console.WriteLine($"NOMATCH: Speech could not be recognized.");
        }

        public static void OnCancel(IntentRecognitionCanceledEventArgs e)
        {
            Console.WriteLine($"CANCELED: Reason={e.Reason}");

            if (e.Reason == CancellationReason.Error)
            {
                Console.WriteLine($"CANCELED: ErrorCode={e.ErrorCode}");
                Console.WriteLine($"CANCELED: ErrorDetails={e.ErrorDetails}");
                Console.WriteLine($"CANCELED: Did you update the subscription info?");
            }
        }

        public static void OnSessionStoped(SessionEventArgs e)
        {
            Console.WriteLine("\n    Session stopped event.");
            Console.WriteLine("\nStop recognition.");
        }
    }
}
