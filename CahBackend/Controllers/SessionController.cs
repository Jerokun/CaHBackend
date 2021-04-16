using GameLogic.Models;
using GameLogic.Models.Lobby;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CahBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Lobby> CreateSessionPost([FromBody] Boolean IsPrivate, string UserName, string[] PackNames)
        {
            return Unauthorized();
        }

        [HttpGet]
        public ActionResult JoinSessionGet([FromBody] Object obj)
        {
/*            {
                return null;
            }
*/
            return Unauthorized();
        }
    }
}