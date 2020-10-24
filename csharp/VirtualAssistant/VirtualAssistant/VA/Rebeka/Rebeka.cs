using System;
using Microsoft.CognitiveServices.Speech.Intent;

namespace VirtualAssistant.VA.Rebeka
{
    public class Rebeka : Persona
    {
        public Rebeka()
        {
            skills.Add("WhoIsRebeka", WhoIsRebeka);
        }

        public override void Handle(IntentRecognitionResult result)
        {
            if (skills.TryGetValue(result.IntentId,
                 out Action<IntentRecognitionResult> skill
             ))
            {
                LogSkillExecuteBegins(result);

                skill(result);

                return;
            }

            HandleSkillNotFound(result);
        }

        public void WhoIsRebeka(IntentRecognitionResult result)
        {
            var replies = new string[] {
                "Hi everyone, I am a spokewoman that does comms for my team.",

                "Hi, I'm Rebeka. I am a Zing bot.",

                "Hi, I'm Rebeka, I am a bot and that's all I can say. " +
                "If you want to know more about me, please ask Cards Y.",

                "Ha ha, I am funny, I am curious, and I am constantly improving!",
            };

            textToSpeech.Speak(OneOf(replies)).Wait();
        }

        public void Zing(IntentRecognitionResult result)
        {
            var replies = new string[] {
                "Hi everyone, I am a spokewoman that does comms for my team.",

                "Hi, I'm Rebeka. I am a Zing bot.",

                "Hi, I'm Rebeka, I am a bot and that's all I can say. " +
                "If you want to know more about me, please ask Cards Y.",

                "Ha ha, I am funny, I am curious, and I am constantly improving!",
            };

            textToSpeech.Speak(OneOf(replies)).Wait();
        }
    }
}
