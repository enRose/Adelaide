
namespace Adelaide.IntentHandlers.Wake
{
    public class WakeSkill : Skill
    {
        public WakeSkill()
        {
            skillName = "Wake";

            handlers.Add(new WakeHandler());
        }
    }
}
