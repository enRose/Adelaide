﻿using System;
using Microsoft.CognitiveServices.Speech.Intent;
using VirtualAssistant.Utility;

namespace VirtualAssistant.VA.Rebeka
{
    public class Rebeka : Persona
    {
        public Rebeka()
        {
            AddSkill(WhoIsRebeka);
            AddSkill(Zing);
        }

        public override void Handle(IntentRecognitionResult result)
        {
            if (luis.IsHighEnoughScore(result, 0.8) &&

                skills.TryGetValue(result.IntentId,
                 out Action<IntentRecognitionResult> skill
             ))
            {
                LogSkillExecuteBegins(result);

                skill(result);

                return;
            }

            if (luis.IsHighEnoughScore(result, 0.6))
            {
                AskUserToRepeatQuestion(result);
            }
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

            Speak(replies.OneOf());
        }

        public void Zing(IntentRecognitionResult result)
        {
            var replies = new string[] {
                "Everyone is working hard this week, especially me.",

                "UM is about to be finished, Rommel started on Bento Box this sprint," +
                "James is making good progress on Instant Issuance, whle Trevor busy" +
                "attending a ton of meetings Yini and Mike are busy on personal loan and " +
                "production faults",
            };

            Speak(replies.OneOf());
        }
    }
}
