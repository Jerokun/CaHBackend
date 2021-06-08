namespace GameLogic.Models
{
    using System;

    public abstract class CustomUser
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public CustomUser(string name)
        {
            Id = new Guid();
            Name = name;
        }
    }
}
