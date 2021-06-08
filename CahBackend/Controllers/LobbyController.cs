namespace CahBackend.Controllers
{ 
    using Microsoft.AspNetCore.Mvc;
    using CahBackend.Lobby;
    using System;
    using Newtonsoft.Json;
    using GameLogic.Models;

    [AllowAnoymous]
    [ApiController]
    [Route("api/[controller]")]
    public class LobbyController : Controller
    {
        [Route("getDecks")]
        [HttpGet]
        public string Index()
        {
            var rawr = "Rawr";
            return rawr;
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<string> Create(string userName, string[] packSelection, bool isPrivate)
        {
            // TODO fakeplayers;
            var player = new Player(userName);
            var lobby = new Lobby();

            lobby.Id = new Guid();
            lobby.IsPrivate = isPrivate;
            lobby.PackNames = packSelection;

            var response = new
            {
            lobbyId = lobby.Id,
            isPrivate = true,
            roomCode = lobby.RoomCode,
                player = new
                {
                    id = player.Id,
                    name = player.Name
                }
            };

            return JsonConvert.SerializeObject(response);
        }
    }
}
