using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.DigitalComms
{
    public class Michael : Handler
    {
        public Speaking speaking;

        public Michael()
        {
            handlerName = this.GetType().Name;

            intentsToHandle.Add("team-perf");

            intentsToHandle.Add("highlight");

            intentsToHandle.Add("squad-mvp");

            intentsToHandle.Add("buy-me-dinner");

            intentsToHandle.Add("be-serious");

            intentsToHandle.Add("enjoyed-most");

            intentsToHandle.Add("still-need-Host-RCU");

            intentsToHandle.Add("existential-crisis");

            speaking = new Speaking();

        }

        public override void Do(IntentRecognitionResult intent)
        {
            var soundFileName = "";
            switch (intent.IntentId)
            {
                case "team-perf":
                    soundFileName = "TeamPerf";
                    break;

                case "highlight":
                    soundFileName = "Highlight";
                    break;

                case "squad-mvp":
                    soundFileName = "SquadMvp";
                    break;

                case "buy-me-dinner":
                    soundFileName = "BuyMeDinner";
                    break;

                case "be-serious":
                    soundFileName = "BeSerious";
                    break;

                case "enjoyed-most":
                    soundFileName = "EnjoyedMost";
                    break;

                case "still-need-Host-RCU":
                    soundFileName = "StillNeedHostRCU";
                    break;

                case "existential-crisis":
                    soundFileName = "ExistentialCrisis";
                    break;

                default:
                    break;
            }

            if (soundFileName == "")
            {
                return;
            }

            speaking.Speak(soundFileName, handlerName, belongsToSkill);

            base.Do(intent);
        }
    }
}
