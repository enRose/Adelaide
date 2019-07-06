using System;
using System.IO;

namespace Adelaide.Infrastructure
{
    public static class Utils
    {
        public static Random rnd = new Random();

        public static Func<int, int> Randomise =
            (int num) => rnd.Next(num);

        public static string SoundPath(string fileName, string intentFolderName)
        {
            return "IntentHandlers\\" + intentFolderName + "\\Speeches\\" + fileName + ".wav";
        }

        public static void Play(string speechFileName, string intentFolderName)
        {
            var path = SoundPath(speechFileName, intentFolderName);

            Play(path);
        }

        public static void RandomlyPlay(string[] speeches, string inFolder)
        {
            var index = Randomise(speeches.Length);

            var path = SoundPath(speeches[index], inFolder);

            Play(path);
        }

        public static void Play(string path)
        {
            var player = new NetCoreAudio.Player();

            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            var dir = projectDirectory + "\\" + path;

            player.Play(dir).Wait();

            bool finished = false;

            player.PlaybackFinished += (sender, e) => {
                finished = true;
                Console.WriteLine("playing finished");
            };

            do
            {
            } while (finished == false);
        }
    }
}
