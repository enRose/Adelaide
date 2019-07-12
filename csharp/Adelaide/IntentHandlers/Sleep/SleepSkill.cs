
namespace Adelaide.IntentHandlers.Sleep
{
    public class SleepSkill : Skill
    {
        public SleepSkill()
        {
            skillName = "Sleep";

            handlers.Add(new SleepHandler());
        }  
    }
}
