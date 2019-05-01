
namespace Adelaide.CreditCardApp
{
    public static class App
    {
        public static AppStatus AppStatus { get; set; }

        public static AppStep NextStep { get; set; }

        public static bool? AgreeCreditCheck { get; set; }
    }

    public enum AppStatus
    {
        New,
        InProgress,
        Submitted,
        InEvalution,
        Finalised
    }

    public enum AppStep
    {
        AgreeCreditCheck,

        WhatIsCurrentAddress,

        WhoIsNextOfKin,

        WhatIsNextOfKinAddress,

        WhatIsMainIncome,

        HowMuchIsMainIncome
    }
    
}
