using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class Enums
    {
        // 0 = empty, 1 = ship, 2 = miss, 3 = hit, 4 = sunk
        public enum GridSpotStatus
        {
            Empty,    //we can overwrite but for the most part we do not change
            Ship,
            Miss,
            Hit,
            Sunk
        }
    }
}
