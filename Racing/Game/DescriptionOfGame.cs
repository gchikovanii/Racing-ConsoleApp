using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Racing
{
    public class DescriptionOfGame
    {
        public static void PrintInformationAboutGame()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Description about Game!");
            WriteLine(new string('-', 30));
            WriteLine("You can buy and improve Cars!");
            WriteLine("Participate in races");
            WriteLine("Take Part in lottery to win a car!");
            WriteLine(new string('-', 30));
            ForegroundColor = ConsoleColor.Blue;
        }

        public static void Actions()
        {
            WriteLine(new string('-', 30));
            WriteLine("Actions:");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("1 - Information about driver\n" +
                "2 - Information about car\n" +
                "3 - Information about garage\n" +
                "4 - Information about balance\n" +
                "5 - Start the race\n" +
                "6 - Display info about improvments of car\n" +
                "7 - Improve Car\n" +
                "8 - Buy a car\n" +
                "9 - Display info about the prizes in lottery\n" +
                "10 - Play lottery\n" +
                "11 - Exit");
            ForegroundColor = ConsoleColor.White;

        }

    }
}
