using GameMandatory.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory
{
    public class DefenceItem : WorldObject
    {
        public int ReduceHitPoint { get; set; }

        public static List<DefenceItem> defenceItems = new List<DefenceItem>()
        {
            new DefenceItem("Helm", true, false, new Position(0, 0)) { ReduceHitPoint = 2 },
            new DefenceItem("Chestplate", true, false, new Position(1, 1)) { ReduceHitPoint = 5 },
            new DefenceItem("Armorlegs", true, false, new Position(2, 2)) { ReduceHitPoint = 3 },
            new DefenceItem("Shield", true, false, new Position(3, 3)) { ReduceHitPoint = 3 },
            new DefenceItem("Boots", true, false, new Position(4, 4)) { ReduceHitPoint = 1 }
        };

        public DefenceItem(string name, bool lootable, bool removeable, Position position)
            : base(name, lootable, removeable, position)
        {

        }

        /// <summary>
        /// Denne metode finder summen af alt armor der er i listen
        /// </summary>
        /// <param name="defenceItems"></param>
        /// <returns></returns>
        public int TotalDefence(List<DefenceItem> defenceItems)
        {
            return defenceItems.Sum(item => item.ReduceHitPoint);
        }
    }
}
