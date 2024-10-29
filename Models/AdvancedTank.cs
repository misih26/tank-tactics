﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank_Tactics.Models
{
    public class AdvancedTank : Tank
    {
        public double SecondaryAttack { get; set; }
        public double SecondaryAttackCooldown { get; set; }
        public AdvancedTank(string name, double shield, double attack, double attackCooldown, double speed, double secondaryAttack, double secondaryAttackCooldown)
            : base(name, shield, attack, attackCooldown, speed)
        {
            SecondaryAttack = secondaryAttack;
            SecondaryAttackCooldown = secondaryAttackCooldown;
        }
    }
}
