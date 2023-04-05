namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the Simple Games Gallery! Here are the menu Options:");
                Console.WriteLine("1. Start Guessing Game ");
                Console.WriteLine("2. Start Spinner Game");
                Console.WriteLine("3. Start Rock Paper Scissors Game");
                Console.WriteLine("4. Start Memorising Game");
                Console.WriteLine("5. Start Typing Speed Game");
                Console.WriteLine("6. Start Maths Game");
                Console.WriteLine("7. Quit");

                Console.WriteLine("What would you like to do? (1-6)");
                string _vsSelection = Console.ReadLine();

                // Activities
                Activity activity1 = new Activity();
                activity1.SetActivityName("Guessing Game");
                activity1.SetDescription("This game will allow you to guess a number until you get it right");

                Activity activity2 = new Activity();
                activity2.SetActivityName("Spinner Game");
                activity2.SetDescription("This game will allow you to play spinner game with the computer!");

                Activity activity3 = new Activity();
                activity3.SetActivityName("Rock Paper Scissors Game");
                activity3.SetDescription("This game will allow you to play rock paper scissors game with the computer!");
                
                Activity activity4 = new Activity();
                activity4.SetActivityName("Memorising Game");
                activity4.SetDescription("This game will allow you to play memorising game");
                
                Activity activity5 = new Activity();
                activity5.SetActivityName("Typing Speed Game");
                activity5.SetDescription("This game will allow you to test your typing speed!");
                
                Activity activity6 = new Activity();
                activity6.SetActivityName("Maths Game");
                activity6.SetDescription("This game will allow you to test your maths!");
                

                Activity activity = new Activity();
                if (_vsSelection == "1")
                {
                    Console.WriteLine(activity1.StartMessage());
                    GuessingGame guess = new GuessingGame();
                    guess.StartGuess();
                    Console.WriteLine(activity1.EndMessage());
                }
                
                if (_vsSelection == "2")
                {
                    Console.WriteLine(activity2.StartMessage());
                    SpinnerGame spin = new SpinnerGame();
                    spin.StartSpinner();
                    Console.WriteLine(activity2.EndMessage());
                }
                
                else if (_vsSelection == "3")
                {                
                    {
                        Console.WriteLine(activity3.StartMessage());
                        Rps choose = new Rps();
                        choose.StartRps();
                        Console.WriteLine(activity3.EndMessage());
                    }
                }
                else if (_vsSelection == "4")
                {                
                    {
                        Console.WriteLine(activity4.StartMessage());
                        MemorizeGame memorize = new MemorizeGame();
                        memorize.StartMemorize();
                        Console.WriteLine(activity3.EndMessage());
                    }
                }
                else if (_vsSelection == "5")
                {                
                    {
                        Console.WriteLine(activity5.StartMessage());
                        TypingSpeedGame type = new TypingSpeedGame();
                        type.StartSpeed();
                        Console.WriteLine(activity5.EndMessage());
                    }
                }
                else if (_vsSelection == "6")
                {                
                    {
                        Console.WriteLine(activity6.StartMessage());
                        MathsGame math = new MathsGame();
                        math.StartMaths();
                        Console.WriteLine(activity6.EndMessage());
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for using the Simple Games Gallery!");
                }
        }
        }
    }