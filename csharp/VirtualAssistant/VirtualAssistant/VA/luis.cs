using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;
using VirtualAssistant.Utilities;
using VirtualAssistant.VA.Personas;

namespace VirtualAssistant.VA
{
    public class Luis
    {
        private readonly IntentRecognizer recognizer;
        private Persona persona;

        private SpeechConfig speechConfig;

        public Luis()
        {
            speechConfig = SpeechConfig.FromSubscription(
                Secret.LuisPredictionKey, Secret.Region);

            var model = LanguageUnderstandingModel.FromAppId(Secret.LuisAppId);

            recognizer = new IntentRecognizer(speechConfig);

            recognizer.AddAllIntents(model);
        }

        public void SetPersona(Persona p)
        {
            persona = p;
        }

        public void Run()
        {
            var result = recognizer.RecognizeOnceAsync().Result;
            
            switch (result.Reason)
            {
                case ResultReason.RecognizedIntent:

                    Logger.OnIntentRecognised(result);

                    persona.Handle(result);

                    break;

                case ResultReason.RecognizedSpeech:

                    Logger.OnSpeechRecognised(result);

                    break;

                case ResultReason.NoMatch:
                    Logger.OnSpeechUnrecognised();

                    var d = NoMatchDetails.FromResult(result);

                    Console.WriteLine(d.Reason);

                    break;

                default:
                    Logger.OnSpeechUnrecognised();

                    break;
            }
        }

        //https://github.com/Azure-Samples/cognitive-services-speech-sdk/blob/master/samples/csharp/sharedcontent/console/speech_recognition_samples.cs
        public async Task RecognitionWithMicrophoneAsync()
        {
            // <recognitionWithMicrophone>
            // Creates an instance of a speech config with specified subscription key and service region.
            // Replace with your own subscription key and service region (e.g., "westus").
            // The default language is "en-us".
            var config = SpeechConfig.FromSubscription(
                "", "");

            // Creates a speech recognizer using microphone as audio input.
            using (var recognizer = new SpeechRecognizer(config))
            {
                // Starts recognizing.
                Console.WriteLine("Say something...");

                // Starts speech recognition, and returns after a single utterance is recognized. The end of a
                // single utterance is determined by listening for silence at the end or until a maximum of 15
                // seconds of audio is processed.  The task returns the recognition text as result.
                // Note: Since RecognizeOnceAsync() returns only a single utterance, it is suitable only for single
                // shot recognition like command or query.
                // For long-running multi-utterance recognition, use StartContinuousRecognitionAsync() instead.
                var result = await recognizer.RecognizeOnceAsync().ConfigureAwait(false);

                // Checks result.
                if (result.Reason == ResultReason.RecognizedSpeech)
                {
                    Console.WriteLine($"RECOGNIZED: Text={result.Text}");
                }
                else if (result.Reason == ResultReason.NoMatch)
                {
                    Console.WriteLine($"NOMATCH: Speech could not be recognized.");
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = CancellationDetails.FromResult(result);
                    Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                    if (cancellation.Reason == CancellationReason.Error)
                    {
                        Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                        Console.WriteLine($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                        Console.WriteLine($"CANCELED: Did you update the subscription info?");
                    }
                }
            }
            // </recognitionWithMicrophone>
        }
    }
}
