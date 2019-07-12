using Adelaide.IntentHandlers.DigitalComms;
using Adelaide.IntentHandlers.Sleep;
using Adelaide.IntentHandlers.Wake;
using Microsoft.CognitiveServices.Speech.Intent;
using System.Collections.Generic;
using System.Linq;

namespace Adelaide.IntentHandlers
{
    public class SkillSet
    {
        public static string rootFolderName = "IntentHandlers";

        public List<Skill> skills = new List<Skill>();

        public SkillSet()
        {
            skills.Add(new WakeSkill());

            skills.Add(new SleepSkill());

            skills.Add(new DigitalCommsSkill());
        }

        public void Handle(IntentRecognitionResult intent)
        {
            List<Handler> handlers = new List<Handler>();

            skills.ForEach(skill =>
                handlers.AddRange(
                    skill.handlers.Where(handler => handler.CanHandle(intent))
                ));

            handlers?.ForEach(handler => handler.Do(intent));
        }
    }
}
