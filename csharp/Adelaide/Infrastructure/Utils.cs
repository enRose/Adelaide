using System;
using System.IO;

namespace Adelaide.Infrastructure
{
    public static class Utils
    {
        public static Random rnd = new Random();

        public static Func<int, int> Randomise =
            (int num) => rnd.Next(num);

        public static string AbsolutePathOf(string fileName, string folderPath)
        {
            var path = folderPath + "\\Speeches\\" + fileName + ".wav";

            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            var absolutePath = projectDirectory + "\\" + path;

            return absolutePath;
        }

        public static void Play(string fileName, string folderPath)
        {
            var path = AbsolutePathOf(fileName, folderPath);

            Play(path);
        }

        public static void PlayOneOf(string[] speeches, string inFolder)
        {
            var index = Randomise(speeches.Length);

            var path = AbsolutePathOf(speeches[index], inFolder);

            Play(path);
        }

        public static void PlayOneFrom((string path, string[] speeches) playList)
        {
            var index = Randomise(playList.speeches.Length);

            var path = AbsolutePathOf(playList.speeches[index], playList.path);

            Play(path);
        }

        public static void Play(string path)
        {
            var player = new NetCoreAudio.Player();

            player.Play(path).Wait();

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
