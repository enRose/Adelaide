using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers.DigitalComms
{
    public class Michael : Handler
    {
        public Speaking speaking;

        public Michael()
        {
            handlerName = this.GetType().Name;

            intentsToHandle.Add("ASB-digital-comms-team-perf");

            intentsToHandle.Add("ASB-digital-comms-highlight");

            intentsToHandle.Add("ASB-digital-comms-squad-mvp");

            intentsToHandle.Add("ASB-digital-comms-my-perf");

            intentsToHandle.Add("ASB-digital-comms-be-serious");

            intentsToHandle.Add("ASB-digital-comms-enjoyed-most");

            intentsToHandle.Add("ASB-digital-comms-still-need-host-RCU");

            intentsToHandle.Add("ASB-digital-comms-existential-crisis");

            intentsToHandle.Add("ASB-digital-comms-emily-creation");

            intentsToHandle.Add("ASB-digital-comms-financial-climate");

            intentsToHandle.Add("ASB-digital-comms-terminator");

            intentsToHandle.Add("ASB-digital-comms-universe-muscles");

            speaking = new Speaking();
        }

        public override void Do(IntentRecognitionResult intent)
        {
            var soundFileName = "";
            switch (intent.IntentId)
            {
                case "ASB-digital-comms-team-perf":
                    soundFileName = "TeamPerf";
                    break;

                case "ASB-digital-comms-highlight":
                    soundFileName = "Highlight";
                    break;

                case "ASB-digital-comms-squad-mvp":
                    soundFileName = "SquadMvp";
                    break;

                case "ASB-digital-comms-my-perf":
                    soundFileName = "BuyMeDinner";
                    break;

                case "ASB-digital-comms-be-serious":
                    soundFileName = "BeSerious";
                    break;

                case "ASB-digital-comms-enjoyed-most":
                    soundFileName = "EnjoyedMost";
                    break;

                case "ASB-digital-comms-still-need-host-RCU":
                    soundFileName = "StillNeedHostRCU";
                    break;

                case "ASB-digital-comms-existential-crisis":
                    soundFileName = "ExistentialCrisis";
                    break;

                case "ASB-digital-comms-emily-creation":
                    soundFileName = "EmilyCreation";
                    break;

                case "ASB-digital-comms-financial-climate":
                    soundFileName = "MachineOverLords";
                    break;

                case "ASB-digital-comms-terminator":
                    soundFileName = "Terminator";
                    break;

                case "ASB-digital-comms-universe-muscles":
                    soundFileName = "MrUniverseMuscles";
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
