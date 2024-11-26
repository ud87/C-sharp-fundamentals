﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models      //has added Models folder in namespace
{
    public  class PlayerInfoModel
    {
        public string UserName { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();
        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
        public int ShotCount { get; set; }
    }
    

}
