using System;
using System.Collections.Generic;

namespace Adelaide.IntentHandlers.DigitalComms
{
    public class DigitalCommsSkill : Skill
    {
        public DigitalCommsSkill()
        {
            skillName = "DigitalComms";

            handlers.Add(new Rommel());

            handlers.BelongTo(skillName);
        }
    }
}
