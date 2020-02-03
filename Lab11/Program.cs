using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie frozen = new Movie("Frozen", "horror");
            Movie shining = new Movie("The Shining", "horror");
            Movie it = new Movie("IT", "horror");
            Movie panda = new Movie("Kung Fu Panda", "animation");
            Movie shrek = new Movie("Shrek", "animation");
            Movie toy = new Movie("Toy Story", "animation");
            Movie gravity = new Movie("Gravity", "drama");
            Movie logan = new Movie("Logan", "drama");
            Movie glass = new Movie("Glass", "drama");
            Movie endgame = new Movie("Avengers: Endgame", "scifi");
            Movie sw3 = new Movie("Star Wars Episode III: Revenge of the Sith", "scifi");
            Movie jurassic = new Movie("Jurassic Park", "scifi");


            List<Movie> title = new List<Movie> { frozen, shining, it, panda, shrek, toy, gravity, logan, glass, endgame, sw3, jurassic };
            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Which genre are you interested in? Choose horror, animation, drama, or scifi.");
                string input = Console.ReadLine().ToLower();

                Console.WriteLine("Here are the suggested movies:");

                for (int i = 0; i < title.Count; i++)
                {
                    Movie m = title[i];
                    if (m.Category == input)
                    {
                        Console.WriteLine(m.Title);
                    }

                }

                Console.WriteLine("Would you like to continue? y/n");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Thank you for using the Movie List Application! Have a nice day!");
                    loop = false;
                }
            }
        }
    }
}