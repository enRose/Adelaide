using System.Collections.Generic;

namespace Adelaide
{
    public class IntentJsonModel
    {
        public string Query { get; set; }

        public IntentModel TopScoringIntent { get; set; }

        public IEnumerable<IntentModel> Intents { get; set; }

        public IEnumerable<EntityModel> Entities { get; set; }
    }

    public class IntentModel
    {
        public string Intent { get; set; }
        public double Score { get; set; }
    }

    public class EntityModel
    {
        public string Entity { get; set; }
        public string Role { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public double Score { get; set; }
    }
}
