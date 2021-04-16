using GameLogic.Models;
using GameLogic.Models.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.Interfaces
{
    interface IPackRepository<PackRepository>
    {
        public Dictionary<string, Pack> LoadCardCollection();
    }
}
