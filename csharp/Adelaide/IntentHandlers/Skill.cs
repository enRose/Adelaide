using System.Collections.Generic;

namespace Adelaide.IntentHandlers
{
    public class Skill
    {
        public string skillName;

        public List<Handler> handlers = new List<Handler>();
    }

    public static class SkillExtentions
    {
        public static void BelongTo(this List<Handler> handlers, string skillName)
        {
            handlers?.ForEach(handler => handler.belongsToSkill = skillName);
        }
    }
}
