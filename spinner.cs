namespace FinalProject
{
    public class SpinnerGame : Activity
    {
        public void StartSpinner() 
        {
            Console.WriteLine("Press any key to spin the spinner...");
            Console.ReadKey(true);

            Random random = new Random();
            int _vsOutcome = random.Next(1, 11); 

            Console.WriteLine("You spun: " + _vsOutcome);
            Console.WriteLine("Guess if the next spin will be higher or lower (h/l):");

            char _vsGuess = Console.ReadKey(true).KeyChar;
            if (_vsGuess == 'h' || _vsGuess == 'H')
            {
                    int nextOutcome = random.Next(1, 11);
                    if (nextOutcome > _vsOutcome)
                    {
                        Console.WriteLine("You win! The next spin was: " + nextOutcome);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lose. The next spin was: " + nextOutcome);
                    }
            }
            else if (_vsGuess == 'l' || _vsGuess == 'L') 
            {
                    int _vsNextOutcome = random.Next(1, 11);
                    if (_vsNextOutcome < _vsOutcome)
                    {
                        Console.WriteLine("You win! The next spin was: " + _vsNextOutcome);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lose. The next spin was: " + _vsNextOutcome);
                    }
            }
            else
            {
                    Console.WriteLine("Invalid guess. Please enter h or l.");
            }
        }
        }
    }
