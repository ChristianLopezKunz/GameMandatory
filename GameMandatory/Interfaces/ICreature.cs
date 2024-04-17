using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.Models
{
    public interface ICreature
    {
        string Name { get; set; }
        int HitPoints { get; set; }
        int Attack {  get; set; }
        int Defence { get; set; }
        bool Dead { get; set; }
        

        void Damage(Creature creature);
        void ReceiveDamage(int hit);
        void Die();
    }
}
