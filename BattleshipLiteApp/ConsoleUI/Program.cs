using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                Console.Clear();
                Console.WriteLine(activePlayer.UserName);
                //Display grid from activePlayer on where they fired
                DisplayShotGrid(activePlayer);

                RecordPlayerShot(activePlayer, opponent);

                //Determine if the game should continue
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                //If iver, set activePlayer as the winner
                //else, swap positions (activePlayer to opponent)
                if (doesGameContinue == true)
                {
                    /*
                    //swap using a temp variable
                    PlayerInfoModel tempHolder = opponent;
                    opponent = activePlayer;
                    activePlayer = tempHolder;
                    */

                    //Use Tuple to swap position
                    (activePlayer, opponent) = (opponent, activePlayer); //activePlayer is opposite of opponent and viceversa
                } else
                {
                    winner = activePlayer;
                }
                
            } while (winner == null);

            IdentifyWinner(winner);

            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to {winner.UserName} for winning!");
            Console.WriteLine($"{winner.UserName} took {GameLogic.GetShotCount(winner)} shots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                //Asks for a shot (we ask for "B2")
                string shot = AskForShot();
                //Determine what row and column that is - split it apart
                (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);         
                //Determine if that is a valid shot
                 isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                //Go back to the beginning if not a valid shot
                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid Shot Location. Please try again.");
                }
            } while (!isValidShot);  //isValidShot == false


            //Determine shot results
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            //Record results
            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
        }

        private static string AskForShot()
        {
            Console.Write("\nPlease enter your shot selection: ");
             string output = Console.ReadLine();

            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid) 
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

               
                if (gridSpot.Status == Enums.GridSpotStatus.Empty)
                {
                    Console.Write($"{gridSpot.SpotLetter}{gridSpot.SpotNumber}");
                }
                else if (gridSpot.Status == Enums.GridSpotStatus.Hit)
                {
                    Console.Write("X ");
                }
                else if (gridSpot.Status == Enums.GridSpotStatus.Miss)
                {
                    Console.Write("O ");
                }
                else
                {
                    Console.Write("? ");
                }
            }
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Udaya Rai");
            Console.WriteLine();
        } 

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();   //instantiate a new version of class, which is an object

            Console.WriteLine($"Player information for { playerTitle }");
            
            //Ask the user for their name
            output.UserName = AskForUsersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements
            PlaceShip(output);

            //Clear
            Console.Clear();

            return output;
        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShip(PlayerInfoModel model)
        {
            //Console.WriteLine($"Initial count: {model.ShipLocations.Count}"); //
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again: ");
                }
            } while (model.ShipLocations.Count < 5);
        }
        
    }
}
