﻿using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;


namespace Adelaide.IntentHandlers.DigitalComms.Rommel
{
    public class Rommel
    {
        public static string[] speeches = {
                "GoodJob"
            };

        public static void Act(IntentRecognitionResult intent)
        {
            Utils.PlayOneOf(speeches, @"IntentHandlers\DigitalComms\Rommel");
        }
    }
}
 