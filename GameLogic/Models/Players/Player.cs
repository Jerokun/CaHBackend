using GameLogic.Models.Cards;
using System.Collections.Generic;

namespace GameLogic.Models
{
    public class Player : CustomUser
    {
        public bool IsLeader { get; set; }
        private bool IsHost { get; set; }
        public bool IsDone { get; set; }
        public int Score { get; set; }
        public IEnumerable<BlackCard> HistoryBlackCards { get; set; }
        public IEnumerable<WhiteCard> HistoryWhiteCards { get; set; }
        public IEnumerable<BlackCard> BlackCards { get; set; }
        public IEnumerable<WhiteCard> WhiteCards { get; set; }

        public Player(string name) : base(name)
        {
            Score = 0;
        }

        public void IsHostAsync()
        {
            IsHost = true;
        }

    }
}
