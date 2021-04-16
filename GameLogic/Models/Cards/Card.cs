using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.Models.Cards
{
    public abstract class Card
    {
        public string Text { get; set; }
        public string PackName { get; set; }
        public Boolean IsHistory { get; set; }
    }
}
