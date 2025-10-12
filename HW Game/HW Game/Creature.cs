using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Game
{
    internal abstract class Creature
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; } = 100;
        protected int BaseDamage = 10;
        protected int BaseArmor = 10;

        protected Creature (string name, int healthPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
        }
    }

    internal class Character : Creature
    {

    }

    internal class Enemy : Creature
    {

    }
}
