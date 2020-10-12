using System;
using VirtualAssistant.VA;

namespace VirtualAssistant
{
    public class Program
    {
        static void Main(string[] args)
        {
            var luis = new Luis();

            Console.WriteLine("Virtual assistant started...");

            luis.RecognitionWithMicrophoneAsync().Wait();

            //do
            //{
            //    luis.RecognitionWithMicrophoneAsync();
            //}
            //while (true);
        }
    }
}
