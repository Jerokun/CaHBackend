namespace CahBackend.Lobby
{
    using System;

    public abstract class CustomUser
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public CustomUser()
        {
            Id = new Guid();
        }
    }
}
