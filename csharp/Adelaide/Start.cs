using System;
using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech;

namespace Adelaide
{
    public class Start
    {
        public static void Main()
        {
            var recognizer = new IntentRegonisor();

            var persona = new VirtualAssistant();

            Console.WriteLine("Say something...");

            do
            {
                Recognise(recognizer, persona);
            }
            while (true);
        }

        public static void Recognise(
            IntentRegonisor recognizer, VirtualAssistant persona)
        {
            var result = recognizer.RecognizeOnce();

            switch (result.Reason)
            {
                case ResultReason.RecognizedIntent:

                    Logger.OnIntentRecognised(result);

                    persona.OnIntentRecognised(result);

                    break;

                case ResultReason.RecognizedSpeech:

                    Logger.OnSpeechRecognised(result);

                    break;

                default:
                    Logger.OnSpeechUnrecognised();

                    break;
            }
        }
    }
}
