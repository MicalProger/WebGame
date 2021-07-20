using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebGameClient;

namespace WebGameServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController: ControllerBase
    {
        private List<Player> players;

        public PlayersController()
        {
            players = new List<Player>();
            
        }

        [HttpGet]
        public List<Player> Get()
        {
            return players;
        }

        [HttpPost]
        public void Post(Player player)
        {
            players.Add(player);
        }

        [HttpDelete]
        public void Delete(Player player)
        {
            players.Remove(player);
        }
    }
}