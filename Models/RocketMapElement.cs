﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank_Tactics.Models
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
