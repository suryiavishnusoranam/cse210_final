using System.Diagnostics;
namespace FinalProject
{
    public class TypingSpeedGame : Activity
    {
        public void StartSpeed()
        {
            Console.WriteLine("Type the following sentence as fast as you can:");
            string _vsSentence = "You are doing amazing today!";
            Console.WriteLine(_vsSentence);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string _vsInput = Console.ReadLine();
            stopwatch.Stop();

            if (_vsInput == _vsSentence)
            {
                Console.WriteLine("Congratulations, you typed the sentence correctly in " +
                                  stopwatch.Elapsed.TotalSeconds + " seconds!");
            }
            else
            {
                Console.WriteLine("Sorry, you made a mistake. Please try again.");
            }
        }
    }
}