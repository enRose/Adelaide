using Adelaide.Infrastructure;
using Microsoft.CognitiveServices.Speech.Intent;

namespace Adelaide.IntentHandlers
{
    public class Speaking
    {
        public IntentRecognitionResult intent;
        public string[] speeches;

        public string rootFolderName = "IntentHandlers";
        public string skillName;
        public string handlerName;

        public Speaking(string[] speeches = default)
        {
            this.speeches = speeches;
        }

        public virtual bool Speak(string handlerName, string skillName)
        {
            var path = rootFolderName + "\\" + skillName + "\\" + handlerName;

            Utils.PlayOneOf(speeches, path);

            return true;
        }

        public virtual bool Speak(string soundFileName, string handlerName, string skillName)
        {
            var path = rootFolderName + "\\" + skillName + "\\" + handlerName;

            Utils.Play(soundFileName, path);

            return true;
        }
    }
}
