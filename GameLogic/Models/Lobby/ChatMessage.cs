namespace GameLogic.Models.Lobby
{
    using System;

    public class ChatMessage
    {
        public ChatMessage(string userName, string message)
        {
            UserName = userName;
            Message = message;
            Date = new DateTime();
        }

        public string UserName { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
