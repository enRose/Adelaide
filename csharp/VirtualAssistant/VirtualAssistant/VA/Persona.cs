using System;
using System.Collections.Generic;
using Microsoft.CognitiveServices.Speech.Intent;

namespace VirtualAssistant.VA
{
    public abstract class Persona
    {
        public Luis luis;
        public TextToSpeech textToSpeech;
        public Dictionary<string, Action<IntentRecognitionResult>> skills;

        public Persona()
        {
            luis = new Luis();
            textToSpeech = new TextToSpeech();
            skills = new Dictionary<string, Action<IntentRecognitionResult>>();
        }

        public abstract void Handle(IntentRecognitionResult result);

        public virtual void Run() => luis.RecogniseIntent(Handle);

        public virtual void HandleSkillNotFound(IntentRecognitionResult result)
        {
            Console.WriteLine($"{this.GetType().Name} does not have the skill to" +
                $" handle intent {result.IntentId}");
        }

        public virtual string OneOf(string[] replies) =>           
           replies[new Random().Next(0, replies.Length - 1)];
    }
}