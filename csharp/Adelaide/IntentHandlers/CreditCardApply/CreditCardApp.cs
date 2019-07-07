
using System.Collections.Generic;


namespace Adelaide.CreditCardAppContext
{
    public static class CreditCardApp
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

        WhatIsMainSourceOfIncome,

        HowMuchIsMainIncome,

        VerifyPayslip
    }

    public static class IntentIdLocator
    {
        public static Dictionary<AppStep, string>
            Map =>

            new Dictionary<AppStep, string> {
                {AppStep.AgreeCreditCheck, "AgreeCreditCheck"},

                {AppStep.WhatIsCurrentAddress, "WhatIsCurrentAddress"},

                {AppStep.WhoIsNextOfKin, "WhoIsNextOfKin"},

                {AppStep.WhatIsNextOfKinAddress, "WhatIsNextOfKinAddress"},

                {AppStep.WhatIsMainSourceOfIncome, "WhatIsMainSourceOfIncome"},

                {AppStep.HowMuchIsMainIncome, "HowMuchIsMainIncome"}
            };
    }
    
}
