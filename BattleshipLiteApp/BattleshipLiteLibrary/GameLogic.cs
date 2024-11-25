using BattleshipLiteLibrary.Models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary
{
    public static class GameLogic    //no need to store data only used as method hence static is used 
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string> //hard coding to simplify
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            List<string> lettersNumbers = new List<string>();

            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    AddGridSpot(model, letters[i], numbers[j]);
                }
            }
        }


        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)     //this is not for external use this is just internal use only and just for me
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = Enums.GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }

        private static void AddShipLocation(PlayerInfoModel model, string location)
        {
            GridSpotModel shipLocation = new GridSpotModel
            {
                ShipLocation = location
            };

            model.ShipLocations.Add(shipLocation);  //add location to ShipLocation
        }
         

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            //Convert to lower case
            location = location.ToLower();

            string letter = location[0].ToString(); //convert char to string
            int number = 0;
            if (location.Length > 1)  
            {
                bool isNumber = int.TryParse(location[1].ToString(), out number); //convert location[1]
            }
            

            List<bool> boolList = new List<bool>();

            //if location length > 2 or < 2 return false straight away
            if (location.Length != 2)
            {
                return false;
            }
            //else split location into letter and number
            else
            {
                foreach (var item in model.ShotGrid)
                {
                    //Console.WriteLine($"Spot Letter: {item.SpotLetter}");
                    //Console.WriteLine($"Spot Number: {item.SpotNumber}");
                    if (letter == item.SpotLetter.ToLower() && number == item.SpotNumber) //Compare if SpotLetter is equal to letter and SpotNumber is equal to number
                    {
                        AddShipLocation(model, location);
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool PlayerStillActive(PlayerInfoModel opponent)
        {
            //throw new NotImplementedException();
            if (opponent.ShipLocations.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public static int GetShotCount(PlayerInfoModel winner)
        {
            throw new NotImplementedException();
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            //split shot to row and column if length == 2 and second character is a digit
            if (shot.Length == 2 && char.IsDigit(shot[1])) 
            {
                return (shot[0].ToString(), int.Parse(shot[1].ToString()));
            }
            else
            {
                return (null, 0);  //if not in correct format return null and 0
            }
        }

        public static bool ValidateShot(PlayerInfoModel activePlayer, string row, int column)
        {
            foreach (var item in activePlayer.ShotGrid)
            {
                if (item.SpotLetter.ToLower() == row && item.SpotNumber == column)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            //throw new NotImplementedException();
            foreach (var item in opponent.ShipLocations)
            {
                string shotLocation = row + column.ToString();
                //Console.WriteLine($"Shot Location is {shotLocation}");
                if (item.ShipLocation == shotLocation)
                {
                    opponent.ShipLocations.Remove(item);   //if hit, then remove item
                    return true;
                }
            }
            return false;
        }

        public static void MarkShotResult(PlayerInfoModel activePlayer, string row, int column, bool isAHit)
        {
            //throw new NotImplementedException();

            foreach (var item in activePlayer.ShotGrid)
            {
                if (isAHit)
                {
                    if (item.SpotLetter.ToLower() == row && item.SpotNumber == column)
                    {
                        item.Status = Enums.GridSpotStatus.Hit;
                        Console.WriteLine("This is a hit"); 
                    }
                }
                else
                {
                    if (item.SpotLetter.ToLower() == row && item.SpotNumber == column)
                    {
                        item.Status = Enums.GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
   