using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Models.Cards
{
    public class Deck
    {

        public IEnumerable<BlackCard> BlackCards { get; set; }
        public IEnumerable<WhiteCard> WhiteCards { get; set; }

        public Deck()
        {
        }
    }
}
