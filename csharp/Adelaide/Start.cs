using System;
using Adelaide.IntentHandlers;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech;
using Adelaide.Unexpected;

namespace Adelaide
{
    public class Start
    {
        public static void Main(string[] args)
        {
            var recognizer = new IntentRegonisor();

            var emily = new Emily();

            Console.WriteLine("Say something...");

            do
            {
                Recognise(recognizer, emily);
            }
            while (true);
        }

        public static void Recognise(IntentRegonisor recognizer, Emily emily)
        {
            var result = recognizer.RecognizeOnce();

            switch (result.Reason)
            {
                case ResultReason.RecognizedIntent:

                    Logger.OnIntentRecognised(result);

                    emily.Do(result);

                    break;

                case ResultReason.RecognizedSpeech:

                    Logger.OnSpeechRecognised(result);

                    break;

                case ResultReason.NoMatch:

                    Logger.OnSpeechUnrecognised();

                    UnrecognisedSpeechHandler.Act();

                    break;
            }
        }
    }
}
