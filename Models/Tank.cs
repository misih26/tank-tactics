using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tank_Tactics.Models
{
    public class Tank
    {
        private const int WIDTH = 20;
        private const int HEIGHT = 20;
        public string Name { get; set; }
        public double Shield { get; set; }
        public double Attack { get; set; }
        public double AttackCooldown { get; set; }
        public double Speed { get; set; }
        public double PositionTop { get; set; }
        public double PositionLeft { get; set; }
        public Direction Direction { get; set; }
        public bool Blocked { get; set; }
        public string Image { get; }

        public Tank(string name, double shield, double attack, double attackCooldown, double speed, double positionTop, double positionLeft, Direction direction, string image)
        {
            Name = name;
            Shield = shield;
            Attack = attack;
            AttackCooldown = attackCooldown;
            Speed = speed;
            PositionTop = positionTop;
            PositionLeft = positionLeft;
            Direction = direction;
            Blocked = false;
            Image = image;
        }

        public void MoveUp() 
        {
            PositionTop -= Speed;
            Direction = Direction.UP;
        }
        public void MoveDown() 
        {
            PositionTop += Speed;
            Direction = Direction.DOWN;
        }
        public void MoveLeft() 
        {
            PositionLeft -= Speed;
            Direction = Direction.LEFT;
        }
        public void MoveRight() 
        {
            PositionLeft += Speed;
            Direction = Direction.RIGHT;
        }
        public int Height
        {
            get { return HEIGHT; }
        }
        public int Width
        {
            get { return WIDTH; }
        }
    }
}
