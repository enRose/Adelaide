using System;
using NetCoreAudio;

namespace Adelaide.Infrastructure
{
    public static class Utils
    {
        public static Random rnd = new Random();

        public static Func<int, int> Randomise =
        (int num) => rnd.Next(num);

        public static string Path(string fileName, string intentName)
        {
            return "Intents/" + intentName + "/Speeches/" + fileName + ".wav";
        }

        public static void PlayOneOf(string[] speeches, string inFolder)
        {
            var index = Randomise(speeches.Length);

            var path = Path(speeches[index], inFolder);

            var player = new Player();

            player.Play(path).Wait();

            bool finished = false;

            player.PlaybackFinished += (sender, e) => {
                finished = true;
                Console.WriteLine("playing finished");
            };

            do
            {
                Console.WriteLine("playing...");
            } while (finished == false);
        }
    }
}