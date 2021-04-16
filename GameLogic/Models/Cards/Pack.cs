using System;
using System.Collections.Generic;
using GameLogic.Models;

namespace GameLogic.Models.Cards
{
    public class Pack
    {
        public string Name { get; set; }
        public IEnumerable<BlackCard> BlackCards { get; set; }
        public IEnumerable<WhiteCard> WhiteCards { get; set; }
    }
}
