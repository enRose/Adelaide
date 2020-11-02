using System;
using System.Collections.Generic;
using Microsoft.CognitiveServices.Speech.Intent;
using VirtualAssistant.Utility;
using VirtualAssistant.VA.Luis;

namespace VirtualAssistant.VA
{
    public abstract class Persona
    {
        public Luis.Luis luis;
        public TextToSpeech textToSpeech;
        public Dictionary<string, Action<IntentRecognitionResult>> skills;

        public Persona()
        {
            luis = new Luis.Luis();
            textToSpeech = new TextToSpeech();
            skills = new Dictionary<string, Action<IntentRecognitionResult>>();
        }

        public void AddSkill(Action<IntentRecognitionResult> skill)
        {
            skills.Add(nameof(skill), skill);
        }

        public abstract void Handle(IntentRecognitionResult result);

        public virtual void Run() => luis.RecogniseIntent(Handle);

        public virtual void AskUserToRepeatQuestion(IntentRecognitionResult result)
        {
            Console.WriteLine($"{GetType().Name} does not have the skill to" +
                $"intent: {luis.Deserialize<IntentResultModel>(result)}");

            var replies = new string[] {
                "Sorry, I didn't understand what you mean by that.",

                "Sorry, could you please say that again?",

                "Sorry, I didn't quite get what you say. " +
                "Could you please repeat the question again?",

                "Sorry, could you please repeat that again?",
            };

            Speak(replies.OneOf());
        }

        public void Speak(string txt) => textToSpeech.Speak(txt).Wait();
        
        public virtual void LogSkillExecuteBegins(IntentRecognitionResult result)
        => Console.WriteLine($"{GetType().Name} handling intent {result.IntentId}");
    }
}