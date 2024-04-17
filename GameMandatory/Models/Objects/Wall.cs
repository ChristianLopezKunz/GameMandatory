using GameMandatory.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMandatory.Models.Objects
{
    public class Wall : WorldObject
    {
        public Wall(string name, bool lootable, bool removeable, Position position)
            : base(name, lootable, removeable, position)
        {

        }
    }
}
