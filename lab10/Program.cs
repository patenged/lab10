using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie genra list");
            GetCategory();
        }

        public static List<Movie> MakeList()
        {
            Movie movie1 = new Movie("Titanic (1997)", "Drama");
            Movie movie2 = new Movie("Good Will Hunting (1997)", "Drama");
            Movie movie3 = new Movie("Tinker Tailor Soldier Spy (2011)", "Drama");
            Movie movie4 = new Movie("Apollo 13 (1995)", "Drama");
            Movie movie5 = new Movie("The Shawshank Redemption (1994)", "Drama");
            Movie movie6 = new Movie("Schindler's List (1993)", "Drama");
            Movie movie7 = new Movie("Forrest Gump (1994)", "Drama");
            Movie movie8 = new Movie("A Few Good Men (1992)", "Drama");
            Movie movie9 = new Movie("Rain Man (1988)", "Drama");
            Movie movie10 = new Movie("Taxi Driver (1976)", "Drama");
            Movie movie11 = new Movie("Rocky (1976)", "Drama");
            Movie movie12 = new Movie("One Flew Over the Cuckoo's Nest (1975)", "Drama");
            Movie movie13 = new Movie("To Kill a Mockingbird (1962)", "Drama");
            Movie movie14 = new Movie("Malcolm X (1992)", "Drama");
            Movie movie15 = new Movie("The People vs. Larry Flynt (1996)", "Drama");
            Movie movie16 = new Movie("The Texas Chainsaw Massacre (1974)", "Horror");
            Movie movie17 = new Movie("Carrie (1976)", "Horror");
            Movie movie18 = new Movie("Dawn of the Dead (1978)", "Horror");
            Movie movie19 = new Movie("Halloween (1978)", "Horror");
            Movie movie20 = new Movie("Alien (1979)", "Horror");
            Movie movie21 = new Movie("The Amityville Horror (1979)", "Horror");
            Movie movie22 = new Movie("The Thing (1982)", "Horror");
            Movie movie23 = new Movie("A Nightmare on Elm Street (1984)", "Horror");
            Movie movie24 = new Movie("The Fly (1986)", "Horror");
            Movie movie25 = new Movie("Misery (1990)", "Horror");
            Movie movie26 = new Movie("Scream (1996)", "Horror");
            Movie movie27 = new Movie("The Ring (2002)", "Horror");
            Movie movie28 = new Movie("Saw (2004)", "Horror");
            Movie movie29 = new Movie("Final Destination (2000)", "Horror");
            Movie movie30 = new Movie("The Blair Witch Project (1999)", "Horror");
            Movie movie31 = new Movie("Zootopia (2016)", "Animated");
            Movie movie32 = new Movie("Frozen (2013)", "Animated");
            Movie movie33 = new Movie("Wall-E (2008)", "Animated");
            Movie movie34 = new Movie("The Incredibles (2004)", "Animated");
            Movie movie35 = new Movie("Spirited Away (2001)", "Animated");
            Movie movie36 = new Movie("Shrek (2001) ", "Animated");
            Movie movie37 = new Movie("Osmosis Jones (2001)", "Animated");
            Movie movie38 = new Movie("Monsters, Inc. (2001)", "Animated");
            Movie movie39 = new Movie("The Iron Giant (1999)", "Animated");
            Movie movie40 = new Movie("The Prince of Egypt (1998)", "Animated");
            Movie movie41 = new Movie("Aladdin (1992)", "Animated");
            Movie movie42 = new Movie("The Nightmare Before Christmas (1993)", "Animated");
            Movie movie43 = new Movie("The Lion King (1994)", "Animated");
            Movie movie44 = new Movie("Tarzan (1999)", "Animated");
            Movie movie45 = new Movie("Toy Story (1995)", "Animated");
            Movie movie46 = new Movie("District 9 (2009)", "Sci-Fi");
            Movie movie47 = new Movie("Primer (2004)", "Sci-Fi");
            Movie movie48 = new Movie("X-Men (2000)", "Sci-Fi");
            Movie movie49 = new Movie("The Matrix (1999)", "Sci-Fi");
            Movie movie50 = new Movie("Men in Black (1997)", "Sci-Fi");
            Movie movie51 = new Movie("Gattaca (1997)", "Sci-Fi");
            Movie movie52 = new Movie("Waterworld (1995)", "Sci-Fi");
            Movie movie53 = new Movie("Total Recall (1990)", "Sci-Fi");
            Movie movie54 = new Movie("Predator (1987)", "Sci-Fi");
            Movie movie55 = new Movie("RoboCop (1987)", "Sci-Fi");
            Movie movie56 = new Movie("Tron (1982)", "Sci-Fi");
            Movie movie57 = new Movie("Flash Gordon (1980)", "Sci-Fi");
            Movie movie58 = new Movie("Close Encounters of the Third Kind (1977)", "Sci-Fi");
            Movie movie59 = new Movie("Star Wars (1977)", "Sci-Fi");
            Movie movie60 = new Movie("2001: A Space Odyssey (1968)", "Sci-Fi");

            List<Movie> movies = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10,
               movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19 ,movie20, movie21, movie22, movie23,
               movie24, movie25, movie26, movie27, movie28, movie29, movie30, movie31, movie32, movie33, movie34, movie35, movie36,
               movie37, movie38, movie39, movie40, movie41, movie42, movie43, movie44, movie45, movie46, movie47, movie48, movie49,
               movie50, movie51, movie52, movie53, movie54, movie55, movie56, movie57, movie58, movie59, movie60};

            return movies;
        }

        public static void GetCategory()
        {
            string input;
            int inputInt;
            List<string> categories = new List<string>() { "Animated", "Drama", "Horror", "Sci-Fi" };
            Console.WriteLine("Enter the number of the genre below to see movies of that style:\n0 Animated\n1 Drama\n2 Horror\n3 Sci-fi");
            input = Console.ReadLine();
            if (int.TryParse(input, out inputInt))
            {
                Console.WriteLine(categories[inputInt]);
                PrintList(categories[inputInt]);
            }
            else
            {
                GetCategory();
            }
        }

        public static void PrintList(string category)
        {
            List<Movie> movieList = MakeList();
            List<string> movieMatch = new List<string>();
            foreach (Movie m in movieList)
            {
                if (m.GetCategory() == category)
                {
                    movieMatch.Add(m.GetTitle());
                }
            }
            movieMatch.Sort();
            foreach (string movie in movieMatch)
            {
                Console.WriteLine(movie);
            }
            Again();
        }

        public static void Again()
        {
            string input;
            Console.WriteLine("Would you like to continue? (Y/N)");
            input = Console.ReadLine().ToLower();

            if (input == 'y'.ToString())
            {
                GetCategory();
            }
            else if (input == 'n'.ToString())
            {
                Console.WriteLine("Good Bye");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Again();
            }
        }

    }
}
