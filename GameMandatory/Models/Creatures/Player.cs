using GameMandatory.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.Models.Creatures
{
    public class Player : Creature
    {
        public AttackItem? AttackItem { get; set; }
        public DefenceItem? DefenceItem { get; set; }
        
        public Player(string name, int hitPoints, int attack, int defence, Position position)
            :base(name, hitPoints, attack, defence, position)
        {

        }

    }
}
