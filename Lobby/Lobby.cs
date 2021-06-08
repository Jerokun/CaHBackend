using GameLogic.Models;
using System;
using System.Collections.Generic;

namespace CahBackend.Lobby
{
    public class Lobby
    {
        public Guid Id { get; set; }
        public string RoomCode { get; set; }
        public List<CustomUser> Users { get; set; }
        public IEnumerable<string> PackNames { get; set; }
        public bool IsPrivate { get; set; }
    }
}
