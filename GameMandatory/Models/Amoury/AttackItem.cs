using GameMandatory.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.Models
{
    public class AttackItem : WorldObject
    {
        public int Range { get; set; }
        public int Damage { get; set; }

        public static List<AttackItem> attackItems = new List<AttackItem>()
        {
            new AttackItem("Dagger", true, false, new Position(0, 0)) { Range = 1, Damage = 2 },
            new AttackItem("Sword", true, false, new Position(0, 0)) { Range = 1, Damage = 4 },
            new AttackItem("Bow", true, false, new Position(0, 0)) { Range = 3, Damage = 3 },
            new AttackItem("Staff", true, false, new Position(0, 0)) { Range = 2, Damage = 3 }
        };

        public AttackItem(string name, bool lootable, bool removeable, Position position)
            : base(name, lootable, removeable, position)
        {

        }
        /// <summary>
        /// Denne metode finder den samlede damage fra alle våben i listen
        /// </summary>
        /// <param name="attackItems"></param>
        /// <returns></returns>
        public static int TotalAttackDamage(List<AttackItem> attackItems)
        {
            return attackItems.Sum(item => item.Damage);
        }

        /// <summary>
        /// Denne metode finder den mest krafteste våben i listen
        /// </summary>
        /// <param name="attackItems"></param>
        /// <returns></returns>
        public static int FindMostPowerfulWeapon(List<AttackItem> attackItems)
        {
            return attackItems.Max(item => item.Damage);
        }

    }
}
