using GameMandatory.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.Models.Creatures
{
    public class Monster : Creature
    {
        public Monster(string name, int hitPoints, int attack, int defence, Position position)
            : base(name, hitPoints, attack, defence, position)
        {

        }

        public override void Die()
        {
            base.Die();
        }
    }
}
