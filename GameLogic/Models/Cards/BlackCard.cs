using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.Models.Cards
{
    public class BlackCard : Card
    {
        public int Pick { get; set; }

        public static implicit operator BlackCard(string v)
        {
            throw new NotImplementedException();
        }
    }
}
