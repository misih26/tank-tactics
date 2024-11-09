using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Enums;
using Tank_Tactics.Models.Players; 
using Tank_Tactics.Models.Tanks; 



namespace Tank_Tactics.Models.Map
{
    public class Map
    {
        public string Name { get; }
        public Player[] Players { get; }
        public string Background { get; }
        public List<MapElement> Elements { get; }

        public Map(string name, Player[] players, string? background, List<MapElement> elements)
        {
            Name = name;
            Players = players;
            Background = background;
            Elements = elements;
        }

        public void MoveTank(double leftChange, double topChange, int tankIndex)
        {

        }

        public void Attack(Tank attacker, Tank defender, AttackTypes attackType)
        {

        }
    }
}
