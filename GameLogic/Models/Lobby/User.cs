using System;

namespace GameLogic.Models.Lobby
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public User()
        {
            Id = new Guid();
        }
    }
}