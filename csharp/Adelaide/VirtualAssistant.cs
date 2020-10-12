using Adelaide.IntentHandlers;
using Adelaide.Unexpected;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Intent;
using Newtonsoft.Json;

namespace Adelaide
{
    public class VirtualAssistant
    {
        private readonly SkillSet skills = new SkillSet();

        public void OnIntentRecognised(IntentRecognitionResult intent)
        { 
            if (Memory.Sleep == true && intent.IntentId != "wake")
            {
                return;
            }

            if (IsHighEnoughCcore(intent))
            {
                skills.Handle(intent);
            }
        }

        public bool IsHighEnoughCcore(IntentRecognitionResult intent)
        {
            var json = intent.Properties.GetProperty(
                PropertyId.LanguageUnderstandingServiceResponse_JsonResult);

            var intentJsonModel = JsonConvert.DeserializeObject<IntentJsonModel>(json);

            if (intentJsonModel.TopScoringIntent != null)
            {
                return intentJsonModel.TopScoringIntent.Score > 0.75;
            }

            return false;
        }

        public void OnSpeechUnrecognised()
        {
            if (Memory.Sleep == true)
            {
                return;
            }

            UnrecognisedSpeechHandler.Act();
        }
    }
}
