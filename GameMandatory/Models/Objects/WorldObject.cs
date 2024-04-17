using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GameMandatory.Interfaces;
using GameMandatory.Models;
using GameMandatory.Models.World;

namespace GameMandatory
{
    public abstract class WorldObject : IWorldObject
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }
        public Position Position { get; set; }

        public WorldObject(string name, bool lootable, bool removeable, Position position)
        {
            Name = name;
            Lootable = lootable;
            Removeable = removeable;
            Position = position;
        }

    }
}
