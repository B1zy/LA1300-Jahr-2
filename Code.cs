using System;

namespace Number_Guessing_game
{
    class Program
    {
        
        public static void Main(string[] args)
        {
           

        start:

            Console.Clear(); // Clear the console at the beginning of each loop iteration

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int Guesses = 0;
            int playerGuess;
            bool Restartbool = true;
            string youWonText = @"
_____.___.               __      __              
\__  |   | ____  __ __  /  \    /  \____   ____  
 /   |   |/  _ \|  |  \ \   \/\/   /  _ \ /    \ 
 \____   (  <_> )  |  /  \        (  <_> )   |  \
 / ______|\____/|____/    \__/\  / \____/|___|  /
 \/                            \/             \/ 
";

            Random rnd = new Random();
            int generatedNum = rnd.Next(1, 100);
            Console.WriteLine("Geben sie Ihre Name ein");
            string playerName = Console.ReadLine();
            Console.WriteLine("Ihre Name ist" + " "+playerName);

            Console.WriteLine("Eine zufällige Zahl zwischen 1-100 wurde Generiert");
            Console.WriteLine("Probieren Sie es zu erraten");

            while (Restartbool == true) // Use an infinite loop instead of a do-while loop
            {
                

                Console.ForegroundColor = ConsoleColor.Yellow;
                string strplayerGuess = Console.ReadLine();

                if (int.TryParse(strplayerGuess, out playerGuess)) 

                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    if (playerGuess > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Bitte geben Sie eine Zahl ZWISCHEN 1-100");
                    }
                    else if (playerGuess < generatedNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Probieren sie höcher ↑");
                        Console.Beep(4000, 1000);
                        Guesses++;
                    }
                    else if (playerGuess > generatedNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Probieren sie tiefer ↓");
                        Console.Beep(3000, 1000);

                        Guesses++;
                    }
                    else if (playerGuess == generatedNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gut gemacht, Sie haben es geschafft");
                        Console.WriteLine("Sie haben " + Guesses + " Versuche gebraucht");
                        Console.WriteLine(youWonText);
                        Console.Beep(1000, 1000);


                        Console.WriteLine("Möchten Sie nochmal spielen?[Ja|Nein]");

                        string restartAnswer = Console.ReadLine();


                        if (restartAnswer.Equals("ja", StringComparison.OrdinalIgnoreCase))
                        {
                            Restartbool = true;

                            goto start;
                        }
                        else if (restartAnswer.Equals("nein", StringComparison.OrdinalIgnoreCase))
                        {
                            Restartbool = false;
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Falsche Eingabe");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                }
            }
        }
    }
}
