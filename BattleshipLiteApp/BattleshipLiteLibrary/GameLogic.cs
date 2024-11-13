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

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
             throw new NotImplementedException();
        }

        public static bool PlayerStillActive(PlayerInfoModel opponent)
        {
            throw new NotImplementedException();
        }

        public static int GetShotCount(PlayerInfoModel winner)
        {
            throw new NotImplementedException();
        }
    }
}
   