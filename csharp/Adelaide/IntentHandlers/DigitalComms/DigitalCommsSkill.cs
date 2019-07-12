using System;
using System.Collections.Generic;

namespace Adelaide.IntentHandlers.DigitalComms
{
    public class DigitalCommsSkill : Skill
    {
        public DigitalCommsSkill()
        {
            skillName = "DigitalComms";

            handlers.Add(new Intro());

            handlers.Add(new Rommel());

            handlers.Add(new Michael());

            handlers.BelongTo(skillName);
        }
    }
}
