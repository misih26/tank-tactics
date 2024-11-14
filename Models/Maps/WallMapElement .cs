using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Tanks;


namespace Tank_Tactics.Models.Maps
{
    public class WallMapElement : MapElement
    {
        public WallMapElement(string image, double positionTop, double positionLeft, double width, double height)
            : base(image, positionTop, positionLeft, width, height)
        { }

        public override void HandleTouch(Tank tank)
        {
            tank.Blocked = true;
        }
    }
}

