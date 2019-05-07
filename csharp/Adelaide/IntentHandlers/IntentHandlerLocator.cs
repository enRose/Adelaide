using System;
using System.Collections.Generic;
using Adelaide.IntentHandlers.CreditCardApply;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers
{
    public enum IntentId
    {
        Wake,

        Sleep,

        ApplyForCreditCardWake,

        ApplyForCreditCardSleep,

        CreditCardApplyResume,

        ASBCreditCardStart,

        AgreeCreditCheck,

        WhatIsCurrentAddress,

        WhoIsNextOfKin,

        WhatIsNextOfKinAddress,

        WhatIsMainSourceOfIncome,

        HowMuchIsMainIncome,

        None
    }

    public static class IntentHandlerLocator
    {
        public static Dictionary<IntentId, Action<IntentRecognitionResult>> 
        Map =>

        new Dictionary<IntentId, Action<IntentRecognitionResult>>
        {
            { IntentId.Wake, Wake.Act },

            { IntentId.Sleep, Sleep.Act },

            { IntentId.ApplyForCreditCardWake, CreditCardApplyWake.Act },

            { IntentId.ApplyForCreditCardSleep, CreditCardApplyWake.Act },

            { IntentId.CreditCardApplyResume, CreditCardApplyResume.Act},

            { IntentId.ASBCreditCardStart, ApplyASBStart.Act },

            { IntentId.AgreeCreditCheck, AgreeCreditCheck.Act }
        };
    }
}
