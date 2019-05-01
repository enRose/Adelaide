using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Infrastructure
{
    public class IntentRegonisor
    {
        private readonly IntentRecognizer recognizer;

        public IntentRegonisor()
        {
            var config = SpeechConfig.FromSubscription(Config.LuisKey, Config.Region);

            var model = LanguageUnderstandingModel.FromAppId(Config.LuisAppId);

            recognizer = new IntentRecognizer(config);

            recognizer.AddAllIntents(model);
        }

        public IntentRecognitionResult RecognizeOnce()
        {
            return recognizer.RecognizeOnceAsync().Result;
        }
    }
}
