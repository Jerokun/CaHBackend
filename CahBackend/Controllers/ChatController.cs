using CahBackend.Hubs;
using GameLogic.Models.Lobby;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CahBackend.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public ChatController(IHubContext<ChatHub, IHubClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("receive")]
        [HttpGet]
        public async Task<ActionResult<ChatMessage>> ReceiveRequest([FromBody] string userName)
        {
            ChatMessage message = new(
                userName is not null && userName is not "" ? userName : "NO_NAME_ERROR", 
                "Hoi" + userName + "! Van receive"
                );

            await _hubContext.Clients.All.SendAsync(message);
            return Ok();
        }

        [Route("send")]
        [HttpPost]
        public async Task<ActionResult<ChatMessage>> SendRequest([FromBody] ChatMessage msg)
        {
            ChatMessage message = new(msg.UserName, "Hoi Mark! Van send" + msg.Message);

            await _hubContext.Clients.All.SendAsync(message);
            return Ok();
        }
    }
}