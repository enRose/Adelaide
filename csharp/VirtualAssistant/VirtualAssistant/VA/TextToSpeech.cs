using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using VirtualAssistant.Utility;

namespace VirtualAssistant.VA
{
    public class TextToSpeech
    {
        private readonly SpeechConfig config;

        public TextToSpeech()
        {
            config = SpeechConfig.FromSubscription(
                Secret.TextToSpeechSubKey, Secret.Region);
        }

        public async Task Speak(string txt)
        {
            using var synthesizer = new SpeechSynthesizer(config);

            var result = await synthesizer.SpeakTextAsync(txt);

            Logger.OnTextToSpeechFinished(result, txt);
        }
    }
}
