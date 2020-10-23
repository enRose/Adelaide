using VirtualAssistant.VA.Rebeka;

namespace VirtualAssistant
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rebeka = new Rebeka();

            do
            {
                rebeka.Run();
            }
            while (true);
        }
    }
}
