
namespace Adelaide.CreditCardAppContext
{
    public static class CreditCardAppCxt
    {
        public static AppStatus AppStatus { get; set; }

        public static AppStep NextStep { get; set; }

        public static bool? AgreeCreditCheck { get; set; }

        public static string CurrentAddress { get; set; }
    }

    public enum AppStatus
    {
        New,
        InProgress,
        Paused,
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
