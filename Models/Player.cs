using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank_Tactics.Models
{
    public class Player
    {
        public string Name { get; }
        public int Points { get; set; }
        public Tank ChosenTank { get; set; }

        public Player(string name, Tank chosenTank)
        {
            Name = name;
            ChosenTank = chosenTank;
        }
    }
}
