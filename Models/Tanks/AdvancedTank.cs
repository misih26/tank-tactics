using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Tactics.Models.Enums;

namespace Tank_Tactics.Models.Tanks
{
    public class AdvancedTank : Tank
    {
        public double SecondaryAttack { get; set; }
        public double SecondaryAttackCooldown { get; set; }
        public AdvancedTank(string name, double shield, double attack, double attackCooldown, double speed, double secondaryAttack, double secondaryAttackCooldown, double positionTop, double positionLeft, Direction direction, string image)
            : base(name, shield, attack, attackCooldown, speed, positionTop, positionLeft, direction, image)
        {
            SecondaryAttack = secondaryAttack;
            SecondaryAttackCooldown = secondaryAttackCooldown;
        }
    }
}
