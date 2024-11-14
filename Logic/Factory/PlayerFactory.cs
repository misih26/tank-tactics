using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Tanks;
using Tank_Tactics.Models.Players;

namespace Tank_Tactics.Logic.Factory
{
    public class PlayerFactory
    {
        public int PlayerIndex { get; set; }
        public string PlayerName { get; set; }
        public Tank tank { get; set; }
        public TankFactory TankFactory { get; }
        public PlayerFactory(TankFactory tankFactory)
        {
            TankFactory = tankFactory;
        }
        public Player BuildPlayer()
        {
            Player player = new Player(PlayerName, tank);
            ResetFactory();
            return player;
        }

        private void ResetFactory()
        {
            PlayerName = "";
            tank = null;
        }
    }
}
