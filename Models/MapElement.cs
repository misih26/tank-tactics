﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank_Tactics.Models
{
    public abstract class MapElement
    {
        public string Image { get; set; }
        public double PositionTop { get; }
        public double PositionLeft { get; }
        public double Width { get; }
        public double Height { get; }

        protected MapElement(string image, double positionTop, double positionLeft, double width, double height)
        {
            Image = image;
            PositionTop = positionTop;
            PositionLeft = positionLeft;
            Width = width;
            Height = height;
        }
        public bool IsTouching(Tank tank) => false;
        public abstract void HandleTouch(Tank tank);
    }
}
