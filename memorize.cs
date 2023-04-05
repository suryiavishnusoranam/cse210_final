using System.Collections.Generic;
namespace FinalProject
{
    public class MemorizeGame : Activity
    {
        public void StartMemorize()
        {
            // Define the list of items to memorize
            List<string> _vsItems = new List<string> { "Dog", "Cat", "Deer", "Bear"};

            // Shuffle the items
            Shuffle(_vsItems );
            // Show the items to the player
            Console.WriteLine("Memorize the following items:");
            foreach (string item in _vsItems )
            {
                Console.WriteLine(item);
            }

            // Wait for the player to press a key
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            // Clear the screen
            Console.Clear();

            // Ask the player to enter the items in the correct order
            Console.WriteLine("Enter the items in the order that you saw them:");
            foreach (string item in _vsItems )
            {
                string input = Console.ReadLine();
                if (input != item)
                {
                    Console.WriteLine("Sorry, that is incorrect.");
                    StartMemorize();
                }
            }

            Console.WriteLine("Congratulations, you won!");
        }
        static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();
            int _vsNumber = list.Count;
            while (_vsNumber > 1)
            {
                _vsNumber--;
                int _vsNextNumber =  random.Next(_vsNumber + 1); 
                T value = list[_vsNextNumber]; 
                list[_vsNextNumber] = list[_vsNumber];
                list[_vsNumber] = value;
            }
        }
    }
}