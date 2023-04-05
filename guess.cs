namespace FinalProject
{
    public class GuessingGame : Activity
        {
                private int _vsGuess = 0;
                private int _vsGuessAmount = 0;
                
                public void StartGuess()
                {
                    Random random = new Random();
                    int _vsGuessThisNumber = random.Next(1, 51);
                    while (_vsGuess != _vsGuessThisNumber)
                    {
                        Console.Write("Enter your guess: ");
                        _vsGuess = Convert.ToInt32(Console.ReadLine());

                    if (_vsGuess < _vsGuessThisNumber)
                    {
                        Console.WriteLine("Too low! Guess again.");
                    }
                    else if (_vsGuess > _vsGuessThisNumber)
                    {
                        Console.WriteLine("Too high! Guess again.");
                    }

                    _vsGuessAmount++; }
                    
                    Console.WriteLine("Congratulations! You guessed the secret number in " + _vsGuessAmount + " guesses.");
                    Console.ReadLine();
            }
        }
    }