namespace FinalProject
{
    public class Rps : Activity
    {
        int _vsUserScore = 0;
        int _vsOpponentScore = 0;

        public void StartRps()
        {
            Random random = new Random();
            while (_vsUserScore != 3 && _vsOpponentScore != 3)
            {
                Console.WriteLine("Player score - " + _vsUserScore + ". Enemy score - " + _vsOpponentScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors.");
                string UserChoice = Console.ReadLine();
                int OpponentChoice = random.Next(0, 3);

                if (OpponentChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");

                    switch (UserChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round!");
                            _vsUserScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round!");
                            _vsOpponentScore++;
                            break;
                    }
                }
                else if (OpponentChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");

                    switch (UserChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round!");
                            _vsOpponentScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player wins this round!");
                            _vsUserScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissors.");

                    switch (UserChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round!");
                            _vsUserScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins this round!");
                            _vsOpponentScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }
            if (_vsUserScore == 3)
            {
                Console.WriteLine("You Win!");
            }

            else
            {
                Console.WriteLine("You lost!");
            }
        }
    }
}