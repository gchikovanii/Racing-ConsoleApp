using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Description Of Game
            DescriptionOfGame.PrintInformationAboutGame();
          
            //Display info about the game
            DescriptionOfGame.PrintInformationAboutGame();
            //Registration of participant
            Participant participant = new Participant();
            participant.RegisterParticipant();
            Game game = new Game();
            CarDealership carDealership = new CarDealership();
            UpgradeCar upgradeCar = new UpgradeCar();
            Lottery lottery = new Lottery();

           


            while (true)
            {
                DescriptionOfGame.Actions();
                WriteLine("Please select number of action");
                WriteLine(new string('-', 30));
                string action = ReadLine();

                if(action == "1")
                {
                    participant.PrintInfoAboutParticipant();
                }
                else if(action == "2")
                {
                    game.PrintAllCars();
                }
                else if (action == "3")
                {
                    participant.PrintGarage();
                }
                else if (action == "4")
                {
                    participant.PrintBalance();
                }
                else if (action == "5")
                {
                    game.StartRace();
                }
                else if (action == "6")
                {
                    UpgradeCar.PrintInfoAboutSpareParts();
                }
                else if (action == "7")
                {
                    upgradeCar.AddCarParts();
                }
                else if (action == "8")
                {
                    carDealership.BuyCar();
                }
                else if (action == "9")
                {
                    Lottery.PrintLotteryPrize();
                }
                else if (action == "10")
                {
                    lottery.ParticipateInLottery();
                }
                else if (action == "11")
                {
                    break;
                }
                else
                {
                    WriteLine("Incorect Number!");
                }
                
            }           
        }
    }
}
