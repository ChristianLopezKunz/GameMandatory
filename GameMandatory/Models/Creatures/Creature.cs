using GameMandatory.Models.World;
using System;
using Microsoft.VisualBasic;
using GameMandatory.TraceLogger;

namespace GameMandatory.Models
{
    /// <summary>
    /// Creature klassen kan ikke direkte instantieres, men kan blive brugt som en skabelon til andre subklasser
    /// Metoder: Damage(),ReceiveDamage() og Die()
    /// </summary>
    public abstract class Creature : ICreature
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public bool Dead { get; set; } = false;

        public Position position { get; set; }
        public List<AttackItem>? AttackItem { get; set; }
        public List<DefenceItem>? DefenceItem { get; set; }

        public Creature(string name, int hitPoints, int attack, int defence, Position position)
        {
            Name = name;
            HitPoints = hitPoints;
            CurrentHitPoints = hitPoints;
            Attack = attack;
            Defence = defence;
        }

        /// <summary>
        /// Finder ud af hvor meget en modstander skal have i skade og logger angrebet
        /// Metoden tjekker også om person har et våben inden den giver skade
        /// </summary>
        /// <param name="enemy"></param>
        public virtual void Damage(Creature enemy)
        {
            Random random = new Random();
            int damage = Attack;
            string msg = $"{Name} attacked {enemy.Name} for {damage}";

            //Tjekker om creature har nogen våben
            if (AttackItem != null && AttackItem.Count > 0)
            {
                foreach (var item in AttackItem)
                {
                    //Hvis creature har et specifik våben, skader den mere
                    if (item != null)
                    {
                        damage += item.Damage;
                        msg += $" + {item.Damage} with a {AttackItem}";
                    }
                }
            }

            //Sikker at skaden mindste er 0
            damage = Math.Max(0, damage);

            Logger.Log(msg);
            enemy.ReceiveDamage(damage);
        }

        /// <summary>
        /// Finder ud af hvor meget en modstander reducere skaden og logger mængden
        /// Metoden tjekker også om person har armor på inden skaden er givet
        /// Den tjekker tilsidst om person dør
        /// </summary>
        /// <param name="dmg"></param>
        public virtual void ReceiveDamage(int dmg)
        {
            //Tjekker om modstanderen har noget armor på
            if (DefenceItem != null && DefenceItem.Count > 0)
            {
                foreach (var item in DefenceItem)
                {
                    //Hvis modstanderen har et specifik armor på, bliver damage reduceret
                    if (item != null)
                    {
                        dmg -= item.ReduceHitPoint;
                    }
                }
            }

            dmg -= Defence;
            //Sikrer mig at damage ikke kan være mindre end 0
            if(dmg < 0)
            {
                dmg = 0;
            }

            CurrentHitPoints -= dmg;
            Logger.Log($"{Name} received {dmg}");
            //Tjekker om spilleren har mere liv tilbage, hvis ikke dør spilleren
            if(CurrentHitPoints <= 0)
            {
                Logger.Log($"{Name} has died");
                Die();
            }
        }

        /// <summary>
        /// Logger at person er dø og ændre dead til true
        /// </summary>
        public virtual void Die()
        {
            Logger.Log($"{Name} has died");
            Dead = true;
        }

        public virtual void Loot(WorldObject item)
        {
            //Todo: Find på et eller andet
            throw new NotImplementedException();
        }

        //public int DistanceTo(Creature creature)
        //{
        //    int xDistance = Math.Abs(this.World.MaxX / 2 - creature.World.MaxX);
        //    int yDistance = Math.Abs(this.World.MaxY / 2 - creature.World.MaxY);    
        //    return (int)Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));
        //}

    }
}