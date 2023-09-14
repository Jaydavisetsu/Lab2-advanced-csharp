using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Globalization;
using System.Xml.Linq;



namespace Lab_2___Advanced_C_
{
    public class Program
    {
        static void Main(string[] args)
        {
                            ////////////// DICTIONARY PART /////////////////
                   ////THIS PROJECT WILL EXPLOIT THE USERS FREEDOM TO DO ANYTHING/////

            Dictionary<int, string> gameDictionary = new Dictionary<int, string>();  /////Dictionary created

            bool gameAdding = false;

            string rootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string filePath = $"{rootFolder}{Path.DirectorySeparatorChar}videogames.csv";

            Console.WriteLine("Welcome to your gaming library. Its been quite some time since you've been here");
            Console.WriteLine("This is a collection of games you've collected over a few decades. Safe to say theres a ton to look at.");
            Console.WriteLine("To start you off lets randomly pick a game from the library.");
            Console.WriteLine();

            Console.WriteLine("Please type a number through 1 and 16,000.");
            int userInput = Int32.Parse(Console.ReadLine());



            using (var sr = new StreamReader(filePath))
            {
                string[] fileReader = File.ReadAllLines(filePath);


                gameDictionary.Add(userInput, fileReader[userInput]);

                // Display the contents of dictionary
                foreach (var item in gameDictionary)
                {

                    if(item.Value != null)
                    {
                        Console.WriteLine(item.Value);

                        Console.WriteLine("Great choice. Does this bring any memories or nostalgia?");
                        Console.WriteLine("\n\n\n");
                    }

                }

            }
            Console.WriteLine("press Enter to continue the program.");
            Console.Read();





            /////////////// STACK PART ///////////////////

            Console.WriteLine("Alright now lets take a look at the stack of games in this library of yours...");
            Console.Read();

            Stack<string> gamesStack = new Stack<string>();

            // Read and push CSV data onto the stack
            using (var sr = new StreamReader(filePath))
            {
                // Skip the header line 
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {

                        gamesStack.Push (line);
                    }
                }
            }

            // Now you have CSV data stored in a stack
            foreach(var game in gamesStack)
            {
                Console.WriteLine(game);
            }
                  Console.WriteLine("\n\n\n");

                  Console.WriteLine("Oh thats.. a ton. Feel free to just take a look.");
                  Console.WriteLine("\n");

                  Console.WriteLine("What game did you want to search for?");
                  string gameSearch = Console.ReadLine();


                  bool found = false;

                  foreach (string game in gamesStack)
                  {
                      if (game.Contains(gameSearch, StringComparison.OrdinalIgnoreCase))
                      {
                          Console.WriteLine("\n\n");
                          Console.WriteLine($"Found: {game}");
                          Console.WriteLine("\n\n");
                    found = true;
                          break; // Exit the loop once we find the game
                      }
                  }

                  if (!found)
                  {
                      Console.WriteLine($"Game '{gameSearch}' not found in the stack.");
                  }


                  //////////////// QUEUE PART /////////////////

            Queue<string> gamesQueue = new Queue<string>();

            Console.WriteLine("Now that youve found a game did you want to add to this collection?");
            Console.WriteLine("You dont have a choice just press enter.");
            Console.ReadLine();

            Console.WriteLine("Whats the title of the game?");
            string userTitle = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("Whats the platoform(s) of the game?");
            string userPlatform = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("Whats the genre(s) of the game?");
            string userGenre = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("Whats the publisher of the game?");
            string userPublisher = Console.ReadLine();
            Console.WriteLine("\n\n");


            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into individual values (assuming CSV format).
                    string[] values = line.Split(',');

                    // Create an instance of your data type and populate it with values.
                    VideoGame data = new VideoGame
                    {
                        Name = userTitle,
                        Platform = userPlatform,
                        Genre = userGenre,
                        Publisher = userPublisher,

                    };
                    // Enqueue the data into the queue.
                    gamesQueue.Enqueue(line);


                    if(gamesQueue.Count > 0)
                    {
                        Console.WriteLine("Heres what I got:");

                        Console.WriteLine("\n");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine($"Title: {data.Name}");
                        Console.WriteLine($"Platform: {data.Platform}");
                        Console.WriteLine($"Genre: {data.Genre}");
                        Console.WriteLine($"Publisher: {data.Publisher}");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("\n\n");
                        break;
                    }

                }
             
            }


            Console.WriteLine("Alright, now that we've got some changes to this prehistoric game collection,");
            Console.WriteLine("lets take another look at this.");
            Console.ReadLine();

            gamesQueue.Clear();
            try
            {
                gamesQueue.Peek();
            }
            catch (Exception e)
            {
                Console.WriteLine("---------- PROGRAM ERROR -----------");
                Console.WriteLine("WOAH seems like you had a little mishap there and you knocked over your " +
                    " priceless collection of games.");
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Well dont worry yourself this can be easily fixed.");
            Console.WriteLine("Since the programmer didnt just want to copy paste the same code to here " +
                "we shall do something a bit different;");
            Console.WriteLine("hope you dont get lazy on me because you are gonna add the games yourself now.");
            Console.ReadLine();
            Console.WriteLine("\n\n\n");


            do 
            {


                Console.WriteLine("Whats the title of the game?");
                userTitle = Console.ReadLine();
                Console.WriteLine("\n\n");

                Console.WriteLine("Whats the platoform(s) of the game?");
                userPlatform = Console.ReadLine();
                Console.WriteLine("\n\n");

                Console.WriteLine("Whats the genre(s) of the game?");
                userGenre = Console.ReadLine();
                Console.WriteLine("\n\n");

                Console.WriteLine("Whats the publisher of the game?");
                userPublisher = Console.ReadLine();
                Console.WriteLine("\n\n");


                gamesQueue.Enqueue(userTitle);
                gamesQueue.Enqueue(userPlatform);
                gamesQueue.Enqueue(userGenre);
                gamesQueue.Enqueue(userPublisher);

                Console.WriteLine("Wanna add more? Y or N?");
                string answer = Console.ReadLine();



                if (answer == "Y" || answer == "y")
                {
                    Console.WriteLine("Too bad. The programmer couldnt figure it out in time so thats all you get.");
                    Console.ReadLine();
                    Console.WriteLine("Hey this may not be what you expected, but your on a roll so far.. just have to add about 15,999 more games!");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("But heres your collection so far:");
                    Console.WriteLine("\n\n");

                    Console.WriteLine($"Title: {userTitle}, \n Platform: {userPlatform}, \n Genre: {userGenre}, \n Publisher: {userPublisher}");
                    gameAdding = true;
                    break;
                }
                if (answer == "N" || answer == "n")
                {
                    Console.WriteLine("Alight cool lets take a look at this library now.");
                    Console.ReadLine();


                    // Display the contents of the queue using a loop.
                    /*    foreach (var game in gamesQueue)
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine($"Title: {userTitle}, Platform: {userPlatform}, Genre: {userGenre}, Publisher: {userPublisher}");
                            gameAdding = true;
                        }*/

                }

                Console.WriteLine($"Title: {userTitle}, \n Platform: {userPlatform}, \n Genre: {userGenre}, \n Publisher: {userPublisher}");
                gameAdding = true;

            } while(gameAdding == false);
          /*  while (gameAdding == true)
            {
                gamesQueue.Peek();
            }*/
            

        }

    }
}