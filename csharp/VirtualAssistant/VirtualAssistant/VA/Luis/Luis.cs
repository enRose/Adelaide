using System;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;
using Newtonsoft.Json;
using VirtualAssistant.Utility;

namespace VirtualAssistant.VA.Luis
{
    public class Luis
    {
        private readonly IntentRecognizer recognizer;
        private readonly SpeechConfig speechConfig;
        
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

        public bool IsHighEnoughScore(
            IntentRecognitionResult intent,
            double threshold = 0.75)
        {
            var intentModel = Deserialize<IntentResultModel>(intent);

            if (intentModel.TopScoringIntent != null)
            {
                return intentModel.TopScoringIntent.Score > threshold;
            }

            return false;
        }

        public T Deserialize<T>(IntentRecognitionResult intent)
        {
            var json = intent.Properties.GetProperty(
                PropertyId.LanguageUnderstandingServiceResponse_JsonResult);

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
