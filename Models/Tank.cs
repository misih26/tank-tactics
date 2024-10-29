using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank_Tactics.Models
{
    public class Tank
    {
        public string Name { get; set; }
        public double Shield { get; set; }
        public double Attack { get; set; }
        public double AttackCooldown { get; set; }
        public double Speed { get; set; }
        public double PositionTop { get; set; }
        public double PositionLeft { get; set; }
        public Direction Direction { get; set; }
        public bool Blocked { get; set; }
    }
}
