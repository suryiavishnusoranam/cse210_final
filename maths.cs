namespace FinalProject
{
    public class MathsGame : Activity
    {
        public void StartMaths()
        {
            Random random = new Random();

            int _vsNo1, _vsNo2, _vsAnswer, _vsUserAnswer;
            int ActualCount = 0;
            int TotalCount = 0;

            while (true)
            {
                _vsNo1 = random.Next(1,51);
                _vsNo2 = random.Next(1, 51);
                _vsAnswer = _vsNo1 + _vsNo2;

                Console.Write($"{_vsNo1} + {_vsNo2} = ");
                _vsUserAnswer = int.Parse(Console.ReadLine());

                if (_vsUserAnswer == _vsAnswer)
                {
                    Console.WriteLine("Congratulations! You got the right answer.");
                    ActualCount++;
                }
                else
                {
                    Console.WriteLine($"Unfortunately you did not get the answer right. The right answer is {_vsAnswer}");
                }
                TotalCount++;

                Console.WriteLine($"You have answered {ActualCount} out of {TotalCount} correctly.");

                Console.WriteLine("Press Enter to continue or Q to quit.");
                if (Console.ReadLine().Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.Clear();
            }

            Console.WriteLine($"Thanks for playing! You answered {ActualCount} out of {TotalCount} correctly.");
        }
    }
}