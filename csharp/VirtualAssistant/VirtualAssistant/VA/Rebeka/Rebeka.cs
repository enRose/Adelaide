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
            if (skills.TryGetValue(
                 result.IntentId,
                 out Action<IntentRecognitionResult> skill
             ))
            {
                skill(result);
                return;
            }

            HandleSkillNotFound(result);
        }

        public void WhoIsRebeka(IntentRecognitionResult result)
        {
            Console.WriteLine($"Rebeka handling intent {result.IntentId}");

            var replies = new string[] {
                "Hi everyone, I am a spokewoman that does comms for my team.",

                "Hi, I'm Rebeka. I am a Zing bot.",

                "Hi, I'm Rebeka, I am a bot and that's all I can say. " +
                "If you want to know more about me, please ask Cards Y."
            };

            var rnd = new Random();
            int indx = rnd.Next(0, replies.Length-1);

            textToSpeech.Speak(replies[indx]).Wait();
        }
    }
}
