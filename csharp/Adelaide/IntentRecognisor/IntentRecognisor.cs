using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.Infrastructure
{
    public class IntentRegonisor
    {
        private readonly IntentRecognizer recognizer;

        public IntentRegonisor()
        {
            var config = SpeechConfig.FromSubscription(
                Secret.LuisPredictionKey, Secret.Region);

            var model = LanguageUnderstandingModel.FromAppId(Secret.LuisAppId);

            recognizer = new IntentRecognizer(config);

            recognizer.AddAllIntents(model);
        }

        public IntentRecognitionResult RecognizeOnce()
        {
            return recognizer.RecognizeOnceAsync().Result;
        }
    }
}
