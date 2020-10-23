using System;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;
using VirtualAssistant.Utilities;

namespace VirtualAssistant.VA
{
    public class Luis
    {
        private readonly IntentRecognizer recognizer;
        private SpeechConfig speechConfig;
        
        public Luis()
        {
            speechConfig = SpeechConfig.FromSubscription(
                Secret.LuisPredictionKey, Secret.Region);

            var model = LanguageUnderstandingModel.FromAppId(Secret.LuisAppId);

            recognizer = new IntentRecognizer(speechConfig);

            recognizer.AddAllIntents(model);
        }

        public void RecogniseIntent(Action<IntentRecognitionResult> handler)
        {
            var result = recognizer.RecognizeOnceAsync().Result;
            
            switch (result.Reason)
            {
                case ResultReason.RecognizedIntent:

                    Logger.OnIntentRecognised(result);

                    handler(result);

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
    }
}
