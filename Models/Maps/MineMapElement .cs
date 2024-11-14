using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Tanks;


namespace Tank_Tactics.Models.Maps
{
    public class MineMapElement : MapElement
    {
        public double Damage { get; }

        public MineMapElement(string image, double positionTop, double positionLeft, double width, double height, double damage)
            : base(image, positionTop, positionLeft, width, height)
        {
            Damage = damage;
        }

        public override void HandleTouch(Tank tank)
        {
            tank.Shield -= Damage;
        }
    }
}
