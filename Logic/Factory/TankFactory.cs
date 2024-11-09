using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Enums;
using Tank_Tactics.Models.Tanks;
using Tank_Tactics.Models.Enums;  //


namespace Tank_Tactics.Logic.Factory
{
    public class TankFactory
    {
        public Tank BuildTank(Tanks tankType)
        {
            if (tankType == Tanks.Tiger)
            {
                // Alap tank (Tank típus)
                return new Tank("Tiger", 150, 50, 2, 10, 0, 0, Direction.UP, "");
            }
            else if (tankType == Tanks.Leopard)
            {
                // Alap tank (Tank típus)
                return new Tank("Leopard", 130, 45, 1.5, 12, 0, 0, Direction.UP, "");
            }
            else if (tankType == Tanks.Panther)
            {
                // Fejlett tank (AdvancedTank típus)
                return new AdvancedTank("Panther", 140, 55, 1.8, 11, 25, 3, 0, 0, Direction.UP, "");
            }
            else if (tankType == Tanks.Sheridan)
            {
                // Fejlett tank (AdvancedTank típus)
                return new AdvancedTank("Sheridan", 120, 40, 1.2, 13, 30, 2.5, 0, 0, Direction.UP, "");
            }
            else
            {
                throw new ArgumentException("Invalid tank type");
            }
        }
    }
}
