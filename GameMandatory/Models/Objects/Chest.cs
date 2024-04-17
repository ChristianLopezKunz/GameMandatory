using GameMandatory.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.Models
{
    public class Chest : WorldObject
    {
        public Chest(string name, bool lootable, bool removeable, Position position)
            : base(name, lootable, removeable, position)
        {
        }
    }
}
