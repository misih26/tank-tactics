using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Tanks;
using Tank_Tactics.Models.Player;

namespace Tank_Tactics.Logic.Factory
{
    public class PlayerFactory
    {
        int PlayerIndex { get; set; }
        string PlayerName { get; set; }
        Tank tank { get; set; }
        TankFactory TankFactory { get; }
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
