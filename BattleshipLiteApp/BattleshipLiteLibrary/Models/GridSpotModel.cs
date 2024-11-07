using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleshipLiteLibrary.Models.Enums;

namespace BattleshipLiteLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter {  get; set; }
        public int SpotNumber { get; set; }
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty; //by default we want every spot to be empty
    }
}

/*
 For code re-useability we need to use class library
If we need to change UI then we can use class library
Class library creates a dll and pdb (helps with debugging)
 Library cannot be directly run as it does not have a UI
 */
