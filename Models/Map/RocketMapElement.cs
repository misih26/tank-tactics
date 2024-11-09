using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Tanks;


namespace Tank_Tactics.Models.Map
{
    public class RocketMapElement : MapElement
    {
        public Tank SourceTank { get; }

        public RocketMapElement(string image, double positionTop, double positionLeft, double width, double height, Tank sourceTank)
            : base(image, positionTop, positionLeft, width, height)
        {
            SourceTank = sourceTank;
        }

        public override void HandleTouch(Tank tank)
        {
            tank.Shield -= SourceTank.Attack;
        }
    }
}
