using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Tanks;


namespace Tank_Tactics.Models.Map
{
    public abstract class MapElement
    {
        public string Image { get; set; }
        public double PositionTop { get; }
        public double PositionLeft { get; }
        public double Width { get; }
        public double Height { get; }

        public MapElement(string image, double positionTop, double positionLeft, double width, double height)
        {
            Image = image;
            PositionTop = positionTop;
            PositionLeft = positionLeft;
            Width = width;
            Height = height;
        }
        public bool IsTouching(Tank tank)
        {
            int[] tankTopLeft = { (int)tank.PositionLeft, (int)tank.PositionTop };
            int[] tankTopRight = { (int)(tank.PositionLeft + tank.Width), (int)tank.PositionTop };
            int[] tankBottomLeft = { (int)tank.PositionLeft, (int)(tank.PositionTop + tank.Height) };
            int[] tankBottomRight = { (int)(tank.PositionLeft + tank.Width), (int)(tank.PositionTop + tank.Height) };

            int[] elementTopLeft = { (int)PositionLeft, (int)PositionTop };
            int[] elementRightBottom = { (int)(PositionLeft + Width), (int)(PositionTop + Height) };

            return IsSelectedCornerTouched(tankTopLeft, elementTopLeft, elementRightBottom) ||
                   IsSelectedCornerTouched(tankTopRight, elementTopLeft, elementRightBottom) ||
                   IsSelectedCornerTouched(tankBottomLeft, elementTopLeft, elementRightBottom) ||
                   IsSelectedCornerTouched(tankBottomRight, elementTopLeft, elementRightBottom);
        }
        public abstract void HandleTouch(Tank tank);

        private bool IsSelectedCornerTouched(int[] tankCorner, int[] elementLeftTopConer, int[] elementRightBottomCorner)
        {
            int tankX = tankCorner[0];
            int tankY = tankCorner[1];

            int elementLeftX = elementLeftTopConer[0];
            int elementTopY = elementLeftTopConer[1];

            int elementRightX = elementRightBottomCorner[0];
            int elementBottomY = elementRightBottomCorner[1];

            if (tankX >= elementLeftX && tankX <= elementRightX &&
                tankY >= elementTopY && tankY <= elementBottomY)
            {
                return true;
            }
            return false;
        }
    }
}
