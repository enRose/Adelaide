
using System.Collections.Generic;
using Adelaide.IntentHandlers;

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
        public static Dictionary<AppStep, IntentId>
            Map =>

            new Dictionary<AppStep, IntentId> {
                {AppStep.AgreeCreditCheck, IntentId.AgreeCreditCheck},

                {AppStep.WhatIsCurrentAddress, IntentId.WhatIsCurrentAddress},

                {AppStep.WhoIsNextOfKin, IntentId.WhoIsNextOfKin},

                {AppStep.WhatIsNextOfKinAddress, IntentId.WhatIsNextOfKinAddress},

                {AppStep.WhatIsMainSourceOfIncome, IntentId.WhatIsMainSourceOfIncome},

                {AppStep.HowMuchIsMainIncome, IntentId.HowMuchIsMainIncome}
            };
    }
    
}
